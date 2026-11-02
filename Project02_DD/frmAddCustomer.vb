Imports System.Text.RegularExpressions
Public Class frmAddCustomer
    Private Sub frmAddCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Dim strSelect As String = ""
            Dim cmdSelect As OleDb.OleDbCommand             ' this will be used for our Select statement
            Dim drSourceTable As OleDb.OleDbDataReader      ' this will be where our data is retrieved to
            Dim dts As DataTable = New DataTable            ' this is the table we will load from our reader for State

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

            'load the State result set into the combobox.  For VB, we do this by binding the data to the combobox

            cboState.ValueMember = "intStateID"
            cboState.DisplayMember = "strState"
            cboState.DataSource = dts

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
        Dim strInsert As String
        Dim strFirstName As String
        Dim strLastName As String
        Dim strAddress As String
        Dim strCity As String
        Dim strCityPattern As String = "^[a-zA-Z]+(\s[a-zA-Z]+)*$"
        Dim intState As Integer
        Dim strZip As String
        Dim strPhoneNumber As String
        Dim strEmail As String
        Dim strUserName As String
        Dim strPassword As String
        Dim strRole As String = "Customer"
        Dim blnValidated As Boolean = True

        Dim cmdSelect As OleDb.OleDbCommand ' select command object
        Dim cmdInsert As OleDb.OleDbCommand ' insert command object
        Dim cmdInsertUser As New OleDb.OleDbCommand()
        Dim drSourceTable As OleDb.OleDbDataReader ' data reader for pulling info
        Dim intNextPrimaryKey As Integer ' holds next highest PK value
        Dim intRowsAffected As Integer  ' how many rows were affected when sql executed


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
                ' put values into strings
                strFirstName = txtFirstName.Text
                strLastName = txtLastName.Text
                strAddress = txtAddress.Text
                strCity = txtCity.Text
                intState = cboState.SelectedValue
                strZip = txtZip.Text
                strPhoneNumber = txtPhoneNumber.Text
                strEmail = txtEmail.Text

                If OpenDatabaseConnectionSQLServer() = False Then

                    ' No, warn the user ...
                    MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                        "The application will now close.",
                                        Me.Text + " Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)

                    ' and close the form/application
                    Me.Close()

                End If

                strSelect = "SELECT MAX(intPassengerID) + 1 AS intNextPrimaryKey " &
                                " FROM TPassengers"

                'strPasswordSelect = "SELECT MAX(intUserLoginID) + 1 AS intNextPrimaryKey, MAX(intUserID) + 1 AS intNextUserID " &
                '                    " FROM TUserLogins"

                ' Execute command
                cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
                drSourceTable = cmdSelect.ExecuteReader

                ' Read result( highest ID )
                drSourceTable.Read()

                ' Null? (empty table)
                If drSourceTable.IsDBNull(0) = True Then

                    ' Yes, start numbering at 1
                    intNextPrimaryKey = 1

                Else

                    ' No, get the next highest ID
                    intNextPrimaryKey = CInt(drSourceTable("intNextPrimaryKey"))

                End If
                ' build insert statement (columns must match DB columns in name and the # of columns)

                strInsert = "INSERT INTO TPassengers (intPassengerID, strFirstName, strLastName, strAddress, strCity, intStateID, strZip, strPhoneNumber, strEmail)" &
                    " VALUES (" & intNextPrimaryKey & ",'" & strFirstName & "','" & strLastName & "','" & strAddress & "','" & strCity & "'," & intState & ",'" & strZip & "','" & strPhoneNumber & "','" & strEmail & "')"

                ' MessageBox.Show(strInsert)

                ' use insert command with sql string and connection object
                cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)

                ' execute query to insert data
                intRowsAffected = cmdInsert.ExecuteNonQuery()

                ' If not 0 insert successful
                If intRowsAffected > 0 Then

                End If

                CloseDatabaseConnection()       ' close connection if insert didn't work
                Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

        If Not String.IsNullOrWhiteSpace(txtUsername.Text) Then
        Else
            MessageBox.Show("Please Enter a Username")
            blnValidated = False
        End If

        If Not String.IsNullOrWhiteSpace(txtPassword.Text) Then
        Else
            MessageBox.Show("Please Enter a Password")
            blnValidated = False
        End If

        If blnValidated = False Then
            MessageBox.Show("Customer Add Failed.")
        Else
            Try
                ' put values into strings
                strUserName = txtUsername.Text
                strPassword = txtPassword.Text

                If OpenDatabaseConnectionSQLServer() = False Then

                    ' No, warn the user ...
                    MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                        "The application will now close.",
                                        Me.Text + " Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)

                    ' and close the form/application
                    Me.Close()

                End If

                cmdInsertUser.CommandText = "EXECUTE uspInsertUserLogin '" & intNextPrimaryKey & "','" & strUserName & "','" & strPassword & "','" & strRole & "','" & intCurrentCustomerUserID & "'"
                cmdInsertUser.CommandType = CommandType.StoredProcedure

                ' Call stored proc which will insert the record 
                cmdInsertUser = New OleDb.OleDbCommand(cmdInsertUser.CommandText, m_conAdministrator)

                ' this return is the # of rows affected
                intRowsAffected = cmdInsertUser.ExecuteNonQuery()

                ' close database connection
                CloseDatabaseConnection()

                ' have to let the user know what happened 
                If intRowsAffected > 0 Then
                    MessageBox.Show("Customer added successfully")

                Else

                End If

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

End Class