' Programming 2
' Project 2
' Daniel Dupont
' 03/30/2026

Imports System.Data.OleDb

Public Class frmMain
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Try
            Dim strSQL As String
            Dim cmdSQL As OleDb.OleDbCommand             ' this will be used for our Select statement
            Dim drSourceTable As OleDb.OleDbDataReader      ' this will be where our data is retrieved to
            Dim dtu As DataTable = New DataTable            ' this is the table we will load from our reader

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
            strSQL = "SELECT * FROM TUserLogins " &
                 "WHERE strUserName = ? AND strPassword = ?"

            ' Retrieve all the records 
            cmdSQL = New OleDbCommand(strSQL, m_conAdministrator)

            cmdSQL.Parameters.AddWithValue("@Username", txtUsername.Text)
            cmdSQL.Parameters.AddWithValue("@Password", txtPassword.Text)

            drSourceTable = cmdSQL.ExecuteReader()

            If drSourceTable.Read() Then

                Dim strRole As String = drSourceTable("strRole").ToString()
                Dim intID As Integer = CInt(drSourceTable("intUserID"))

                If strRole = "Customer" Then
                    intCurrentPassengerID = intID
                    intCurrentStateID = intID
                    intCurrentCustomerUserID = intID
                    Dim frm As New frmCustomerMenu
                    frm.Show()

                ElseIf strRole = "Pilot" Then
                    intCurrentPilotID = intID
                    intCurrentPilotRoleID = intID
                    intCurrentPilotUserID = intID
                    Dim frm As New frmPilotMenu
                    frm.Show()

                ElseIf strRole = "Attendant" Then
                    intCurrentAttendantID = intID
                    intCurrentAttendantUserID = intID
                    Dim frm As New frmAttendantMenu
                    frm.Show()

                ElseIf strRole = "Admin" Then
                    intCurrentAdminID = intID
                    Dim frm As New frmAdministrationMenu
                    frm.Show()
                End If

                Me.Hide()

            Else
                MessageBox.Show("Invalid username or password")
            End If

            'load the Passenger Name result set into the combobox.  For VB, we do this by binding the data to the combobox


            ' Clean up
            drSourceTable.Close()

            ' close the database connection
            CloseDatabaseConnection()

        Catch ex As Exception

            ' Log and display error message
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub lblNewCustomer_Click(sender As Object, e As EventArgs) Handles lblNewCustomer.Click
        ' Opens frmAddCustomer

        frmAddCustomer.ShowDialog()
    End Sub

    ' ==============================================================================================
    '   COSMETICS
    ' ==============================================================================================

    Private Sub btnSubmit_MouseEnter(sender As Object, e As EventArgs) Handles btnLogin.MouseEnter
        ' Change the ForeColor when the mouse hovers over the button
        btnLogin.ForeColor = System.Drawing.Color.SteelBlue
    End Sub

    Private Sub btnSubmit_MouseLeave(sender As Object, e As EventArgs) Handles btnLogin.MouseLeave
        ' Reset the ForeColor when the mouse leaves the button area
        btnLogin.ForeColor = System.Drawing.Color.White ' Or your original color
    End Sub

    Private Sub lblNewCustomer_MouseEnter(sender As Object, e As EventArgs) Handles lblNewCustomer.MouseEnter
        ' Change the ForeColor when the mouse hovers over the button
        lblNewCustomer.ForeColor = System.Drawing.Color.RoyalBlue
    End Sub

    Private Sub lblNewCustomer_MouseDown(sender As Object, e As EventArgs) Handles lblNewCustomer.MouseDown
        ' Change the ForeColor when the mouse hovers over the button
        lblNewCustomer.ForeColor = System.Drawing.Color.CornflowerBlue
    End Sub

    Private Sub lblNewCustomer_MouseLeave(sender As Object, e As EventArgs) Handles lblNewCustomer.MouseLeave
        ' Reset the ForeColor when the mouse leaves the button area
        lblNewCustomer.ForeColor = System.Drawing.Color.Black ' Or your original color
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
