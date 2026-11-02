Imports System.Globalization

Public Class frmAddAttendant
    Private Sub frmAddAttendant_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Dim strSelect As String = ""
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
        Dim strEmployeeID As String
        Dim dtmDateofHire As Date
        Dim dtmDateofTermination As Date
        Dim dtmResultDate As DateTime
        Dim strFormat As String = "MM/dd/yyyy"
        Dim intRowsAffected As Integer
        Dim strUserName As String
        Dim strPassword As String
        Dim strRole As String = "Attendant"
        Dim blnValidated As Boolean = True

        Dim cmdSelect As OleDb.OleDbCommand ' select command object
        Dim cmdInsert As OleDb.OleDbCommand ' insert command object
        Dim drSourceTable As OleDb.OleDbDataReader ' data reader for pulling info
        Dim cmdAddAttendant As New OleDb.OleDbCommand()
        Dim cmdInsertUser As New OleDb.OleDbCommand()
        Dim intNextPrimaryKey As Integer ' holds next highest PK value

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

        If Date.TryParse(txtHireDate.Text, dtmDateofHire) Or Date.TryParse(txtTerminationDate.Text, dtmDateofTermination) Then
        Else
            MessageBox.Show("Please Enter a Valid Date")
            blnValidated = False
        End If

        If DateTime.TryParseExact(txtHireDate.Text, strFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, dtmResultDate) Then
        Else
            MessageBox.Show("Please Enter a Valid Hire Date")
            blnValidated = False
        End If

        If DateTime.TryParseExact(txtTerminationDate.Text, strFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, dtmResultDate) Then
        Else
            MessageBox.Show("Please Enter a Valid Termination Date")
            blnValidated = False
        End If

        If blnValidated = False Then

        Else
            Try
                ' put values into strings
                strFirstName = txtFirstName.Text
                strLastName = txtLastName.Text
                strEmployeeID = txtEmployeeID.Text
                dtmDateofHire = txtHireDate.Text
                dtmDateofTermination = txtTerminationDate.Text

                If OpenDatabaseConnectionSQLServer() = False Then

                    ' No, warn the user ...
                    MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                        "The application will now close.",
                                        Me.Text + " Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)

                    ' and close the form/application
                    Me.Close()

                End If

                strSelect = "SELECT MAX(intAttendantID) + 1 AS intNextPrimaryKey " &
                                " FROM TAttendants"

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

                strInsert = "INSERT INTO TAttendants (intAttendantID, strFirstName, strLastName, strEmployeeID, dtmDateofHire, dtmDateofTermination)" &
                    " VALUES (" & intNextPrimaryKey & ",'" & strFirstName & "','" & strLastName & "','" & strEmployeeID & "','" & dtmDateofHire & "','" & dtmDateofTermination & "')"

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
        If Not String.IsNullOrWhiteSpace(txtUserName.Text) Then
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
                strUserName = txtUserName.Text
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

                cmdInsertUser.CommandText = "EXECUTE uspInsertAttendantLogin '" & intNextPrimaryKey & "','" & strUserName & "','" & strPassword & "','" & strRole & "','" & intCurrentAttendantUserID & "'"
                cmdInsertUser.CommandType = CommandType.StoredProcedure

                ' Call stored proc which will insert the record 
                cmdInsertUser = New OleDb.OleDbCommand(cmdInsertUser.CommandText, m_conAdministrator)

                ' this return is the # of rows affected
                intRowsAffected = cmdInsertUser.ExecuteNonQuery()

                ' close database connection
                CloseDatabaseConnection()

                ' have to let the user know what happened 
                If intRowsAffected > 0 Then
                    MessageBox.Show("Attendant added successfully")

                Else
                    MessageBox.Show("Add Attendant failed")

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

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

End Class