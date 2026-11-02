Imports System.Data.SqlClient
Imports System.Globalization
Public Class frmAddPilot

    Private Sub frmAddPilot_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Dim strSelect As String = ""
            Dim cmdSelect As OleDb.OleDbCommand             ' this will be used for our Select statement
            Dim drSourceTable As OleDb.OleDbDataReader      ' this will be where our data is retrieved to
            Dim dtr As DataTable = New DataTable            ' this is the table we will load from our reader for Pilot Roles

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
            strSelect = "SELECT intPilotRoleID, strPilotRole FROM TPilotRoles"

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader
            dtr.Load(drSourceTable)

            'load the State result set into the combobox.  For VB, we do this by binding the data to the combobox

            cboPilotRole.ValueMember = "intPilotRoleID"
            cboPilotRole.DisplayMember = "strPilotRole"
            cboPilotRole.DataSource = dtr

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

        Dim strFirstName As String
        Dim strLastName As String
        Dim strEmployeeID As String
        Dim dtmDateofHire As Date
        Dim dtmDateofTermination As Date
        Dim dtmDateofLicense As Date
        Dim dtmResultDate As DateTime
        Dim strFormat As String = "MM/dd/yyyy"
        Dim intPilotRoleID As Integer
        Dim intPKID As Integer
        Dim strUserName As String
        Dim strPassword As String
        Dim strRole As String = "Pilot"

        Dim blnValidated As Boolean = True

        Dim intNextPrimaryKey As Integer ' holds next highest PK value
        Dim cmdAddPilot As New OleDb.OleDbCommand()
        Dim cmdInsertUser As New OleDb.OleDbCommand()

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

        If String.IsNullOrWhiteSpace(txtEmployeeID.Text) Or Not IsNumeric(txtEmployeeID.Text) Or txtEmployeeID.Text.Length <> 5 Then
            MessageBox.Show("Please Enter a Valid Employee ID")
            blnValidated = False
        Else
        End If

        If Date.TryParse(txtDateofHire.Text, dtmDateofHire) Or Date.TryParse(txtTerminationDate.Text, dtmDateofTermination) Or Date.TryParse(txtLicensedDate.Text, dtmDateofLicense) Then
        Else
            MessageBox.Show("Please Enter a Valid Date")
            blnValidated = False
        End If

        If DateTime.TryParseExact(txtDateofHire.Text, strFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, dtmResultDate) Then
        Else
            MessageBox.Show("Please Enter a Valid Hire Date")
            blnValidated = False
        End If

        If DateTime.TryParseExact(txtTerminationDate.Text, strFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, dtmResultDate) Then
        Else
            MessageBox.Show("Please Enter a Valid Termination Date")
            blnValidated = False
        End If

        If DateTime.TryParseExact(txtLicensedDate.Text, strFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, dtmResultDate) Then
        Else
            MessageBox.Show("Please Enter a Valid License Date")
            blnValidated = False
        End If

        If blnValidated = False Then

        Else
            Try

                ' put values into strings
                strFirstName = txtFirstName.Text
                strLastName = txtLastName.Text
                strEmployeeID = txtEmployeeID.Text
                dtmDateofHire = txtDateofHire.Text
                dtmDateofTermination = txtTerminationDate.Text
                dtmDateofLicense = txtLicensedDate.Text
                intPilotRoleID = cboPilotRole.SelectedValue

                If OpenDatabaseConnectionSQLServer() = False Then

                    ' No, warn the user ...
                    MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                            "The application will now close.",
                                            Me.Text + " Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error)

                    ' and close the form/application
                    Me.Close()

                End If

                ' text to call stored proc
                cmdAddPilot.CommandText = "EXECUTE uspInsertPilot '" & intPKID & "','" & strFirstName & "','" & strLastName & "','" & strEmployeeID & "','" & dtmDateofHire & "','" & dtmDateofTermination & "','" & dtmDateofLicense & "','" & intPilotRoleID & "'"
                cmdAddPilot.CommandType = CommandType.StoredProcedure

                ' Call stored proc which will insert the record 
                cmdAddPilot = New OleDb.OleDbCommand(cmdAddPilot.CommandText, m_conAdministrator)

                ' this return is the # of rows affected
                intRowsAffected = cmdAddPilot.ExecuteNonQuery()

                ' close database connection
                CloseDatabaseConnection()

                ' have to let the user know what happened 
                If intRowsAffected > 0 Then
                    MessageBox.Show("Insert successful: Pilot " & strLastName & " has been added.")

                Else

                End If

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

                cmdInsertUser.CommandText = "EXECUTE uspInsertPilotLogin '" & intNextPrimaryKey & "','" & strUserName & "','" & strPassword & "','" & strRole & "','" & intCurrentPilotUserID & "'"
                cmdInsertUser.CommandType = CommandType.StoredProcedure

                ' Call stored proc which will insert the record 
                cmdInsertUser = New OleDb.OleDbCommand(cmdInsertUser.CommandText, m_conAdministrator)

                ' this return is the # of rows affected
                intRowsAffected = cmdInsertUser.ExecuteNonQuery()

                ' close database connection
                CloseDatabaseConnection()

                ' have to let the user know what happened 
                If intRowsAffected > 0 Then

                Else
                    MessageBox.Show("Pilot Add failed")

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
        btnSubmit.ForeColor = System.Drawing.Color.Black
    End Sub

    Private Sub btnSubmit_MouseLeave(sender As Object, e As EventArgs) Handles btnSubmit.MouseLeave
        ' Reset the ForeColor when the mouse leaves the button area
        btnSubmit.ForeColor = System.Drawing.Color.White ' Or your original color
    End Sub

    Private Sub btnBack_MouseEnter(sender As Object, e As EventArgs) Handles btnBack.MouseEnter
        ' Change the ForeColor when the mouse hovers over the button
        btnBack.ForeColor = System.Drawing.Color.Black
    End Sub

    Private Sub btnBack_MouseLeave(sender As Object, e As EventArgs) Handles btnBack.MouseLeave
        ' Reset the ForeColor when the mouse leaves the button area
        btnBack.ForeColor = System.Drawing.Color.White ' Or your original color
    End Sub

End Class