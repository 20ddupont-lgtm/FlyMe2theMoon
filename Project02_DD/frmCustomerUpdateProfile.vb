Imports System.Text.RegularExpressions
Public Class frmCustomerUpdateProfile
    Private Sub frmCustomerUpdateProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim strSelect As String = ""
            Dim strSelectPassenger As String = ""
            Dim cmdSelect As OleDb.OleDbCommand         ' this will be used for our Select statement
            Dim drSourceTable As OleDb.OleDbDataReader  ' this will be where our data is retrieved to
            Dim dts As DataTable = New DataTable        ' this is the table we will load from our reader for State
            Dim dtp As DataTable = New DataTable        ' this is the table we will load from our reader

            ' open the DB
            If OpenDatabaseConnectionSQLServer() = False Then

                ' No, warn the user ...
                MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                    "The application will now close.",
                                    Me.Text + " Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)

                ' and close the form/application
                Me.Close()

            End If

            ' Build the select statement
            strSelect = "SELECT intStateID, strState FROM TStates"

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader
            dts.Load(drSourceTable)

            strSelect = "SELECT intPassengerID, strFirstName + ' ' + strLastName AS PassengerName, strAddress, strCity, intStateID, strZip, strPhoneNumber, strEmail FROM TPassengers"

            cboState.ValueMember = "intStateID"
            cboState.DisplayMember = "strState"
            cboState.DataSource = dts
            ' Clean up
            drSourceTable.Close()

            ' close the database connection
            CloseDatabaseConnection()

            If OpenDatabaseConnectionSQLServer() = False Then

                ' No, warn the user ...
                MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                    "The application will now close.",
                                    Me.Text + " Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)

                ' and close the form/application
                Me.Close()

            End If

            strSelect = "SELECT strFirstName, strLastName, strAddress, strCity, intStateID, strZip, strPhoneNumber, strEmail " &
            " FROM TPassengers Where intPassengerID = " & intCurrentPassengerID

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            drSourceTable.Read()

            ' populate the text boxes with the data
            txtFirstName.Text = drSourceTable("strFirstName")
            txtLastName.Text = drSourceTable("strLastName")
            txtAddress.Text = drSourceTable("strAddress")
            txtCity.Text = drSourceTable("strCity")
            cboState.SelectedValue = drSourceTable("intStateID")
            txtZip.Text = drSourceTable("strZip")
            txtPhoneNumber.Text = drSourceTable("strPhoneNumber")
            txtEmail.Text = drSourceTable("strEmail")

            ' Clean up
            drSourceTable.Close()

            ' close the database connection
            CloseDatabaseConnection()


        Catch ex As Exception
            ' Log and display error message
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strSelect As String
        Dim strFirstName As String
        Dim strLastName As String
        Dim strAddress As String
        Dim strCity As String
        Dim strCityPattern As String = "^[a-zA-Z]+(\s[a-zA-Z]+)*$"
        Dim intState As Integer
        Dim strZip As String
        Dim strPhoneNumber As String
        Dim strEmail As String
        Dim intRowsAffected As Integer
        Dim blnValidated As Boolean = True

        ' thie will hold our Update statement
        Dim cmdUpdate As OleDb.OleDbCommand

        ' VALIDATE THE INPUTS
        If Not String.IsNullOrWhiteSpace(txtFirstName.Text) And txtFirstName.Text.All(AddressOf Char.IsLetter) Then
        Else
            MessageBox.Show("Please Enter a Valid First Name")
            blnValidated = False
        End If

        If Not String.IsNullOrWhiteSpace(txtLastName.Text) And txtLastName.Text.All(AddressOf Char.IsLetter) Then
        Else
            MessageBox.Show("Please Enter a Valid Last Name")
            blnValidated = False
        End If

        If Not String.IsNullOrWhiteSpace(txtAddress.Text) Then
        Else
            MessageBox.Show("Please Enter an Address")
            blnValidated = False
        End If

        If String.IsNullOrEmpty(txtCity.Text) Then
            MessageBox.Show("City cannot be empty")
            blnValidated = False
        ElseIf Not Regex.IsMatch(txtCity.Text, strCityPattern) Then
            MessageBox.Show("Please enter a valid City")
            blnValidated = False
        End If

        If String.IsNullOrWhiteSpace(txtZip.Text) Or Not IsNumeric(txtZip.Text) Or txtZip.Text.Length <> 5 Then
            MessageBox.Show("Please Enter a Valid Zip Code")
            blnValidated = False
        Else
        End If

        If txtPhoneNumber.Text.Length = 10 Then
        Else
            MessageBox.Show("Phone Number must be exactly 10 characters")
            blnValidated = False
        End If

        If IsNumeric(txtPhoneNumber.Text) Then
        Else
            MessageBox.Show("Phone Number can only accept integers")
            blnValidated = False
        End If

        If Not txtEmail.Text.Contains("@") Then
            MessageBox.Show("The Email Must contain an @ symbol")
            txtEmail.Focus()
            blnValidated = False
        Else
        End If

        If blnValidated = False Then

        Else
            Try

                ' open database this is in module
                If OpenDatabaseConnectionSQLServer() = False Then

                    ' No, warn the user ...
                    MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                            "The application will now close.",
                                            Me.Text + " Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error)

                    ' and close the form/application
                    Me.Close()

                End If

                strFirstName = txtFirstName.Text
                strLastName = txtLastName.Text
                strAddress = txtAddress.Text
                strCity = txtCity.Text
                intState = cboState.SelectedValue
                strZip = txtZip.Text
                strPhoneNumber = txtPhoneNumber.Text
                strEmail = txtEmail.Text

                ' Build the select statement using PK from name selected
                strSelect = "Update TPassengers Set " &
                            "strFirstName = '" & strFirstName & "', " &
                            "strLastName = '" & strLastName & "', " &
                            "strAddress = '" & strAddress & "', " &
                            "strCity = '" & strCity & "', " &
                            "intStateID = " & intState & ", " &
                            "strZip = '" & strZip & "', " &
                            "strPhoneNumber = '" & strPhoneNumber & "', " &
                            "strEmail = '" & strEmail & "'" &
                            " WHERE intPassengerID = " & intCurrentPassengerID

                ' make the connection
                cmdUpdate = New OleDb.OleDbCommand(strSelect, m_conAdministrator)

                ' IUpdate the row with execute the statement
                intRowsAffected = cmdUpdate.ExecuteNonQuery()

                ' have to let the user know what happened 
                If intRowsAffected = 1 Then
                    MessageBox.Show("Update successful")
                Else
                    MessageBox.Show("Update failed")
                End If

                ' close the database connection
                CloseDatabaseConnection()

                Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Closes the form

        Close()
    End Sub

    ' ==============================================================================================
    '   COSMETICS
    ' ==============================================================================================

    Private Sub btnSubmit_MouseEnter(sender As Object, e As EventArgs) Handles btnSubmit.MouseEnter
        ' Change the ForeColor when the mouse hovers over the button
        btnSubmit.ForeColor = System.Drawing.Color.SteelBlue
    End Sub

    Private Sub btnSubmit_MouseLeave(sender As Object, e As EventArgs) Handles btnSubmit.MouseLeave
        ' Reset the ForeColor when the mouse leaves the button area
        btnSubmit.ForeColor = System.Drawing.Color.White ' Or your original color
    End Sub

    Private Sub btnBack_MouseEnter(sender As Object, e As EventArgs) Handles btnBack.MouseEnter
        ' Change the ForeColor when the mouse hovers over the button
        btnBack.ForeColor = System.Drawing.Color.SteelBlue
    End Sub

    Private Sub btnBack_MouseLeave(sender As Object, e As EventArgs) Handles btnBack.MouseLeave
        ' Reset the ForeColor when the mouse leaves the button area
        btnBack.ForeColor = System.Drawing.Color.White ' Or your original color
    End Sub

    Private Sub txtPhoneNumber_TextChanged(sender As Object, e As EventArgs) Handles txtPhoneNumber.TextChanged

    End Sub

    Private Sub cboState_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboState.SelectedIndexChanged

    End Sub
End Class