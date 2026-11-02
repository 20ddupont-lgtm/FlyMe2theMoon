Public Class frmPilotMenu


    Private Sub frmPilotMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim strSelect As String = ""
            Dim strSelectPilot As String = ""
            Dim cmdSelect As OleDb.OleDbCommand         ' this will be used for our Select statement
            Dim drSourceTable As OleDb.OleDbDataReader  ' this will be where our data is retrieved to
            'Dim dtc As DataTable = New DataTable       ' this is the table we will load from our reader for City
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
            strSelect = "SELECT intPilotID, strFirstName, strLastName " &
                        "FROM TPilots Where intPilotID = " & intCurrentPilotID

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader
            dts.Load(drSourceTable)

            ' Clean up
            drSourceTable.Close()

            ' close the database connection

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            drSourceTable.Read()

            ' populate the text boxes with the data
            lblFirstName.Text = drSourceTable("strFirstName")
            lblLastName.Text = drSourceTable("strLastName")

            CloseDatabaseConnection()

        Catch ex As Exception

            ' Log and display error message
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub btnUpdateProfile_Click(sender As Object, e As EventArgs) Handles btnUpdateProfile.Click
        ' Opens frmPilotUpdateProfile

        frmPilotUpdateProfile.Show()
    End Sub

    Private Sub btnPastFlights_Click(sender As Object, e As EventArgs) Handles btnPastFlights.Click
        ' Opens frmPilotPastFlights

        frmPilotPastFlights.Show()
    End Sub

    Private Sub btnFutureFlights_Click(sender As Object, e As EventArgs) Handles btnFutureFlights.Click
        ' Opens frmPilotFutureFlights

        frmPilotFutureFlights.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Exits the form

        Close()
        frmMain.Show()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Closes the entire program

        Application.Exit()
    End Sub

    ' ==============================================================================================
    '   COSMETICS
    ' ==============================================================================================

    Private Sub btnBack_MouseEnter(sender As Object, e As EventArgs) Handles btnBack.MouseEnter
        ' Change the ForeColor when the mouse hovers over the button
        btnBack.ForeColor = System.Drawing.Color.Black
    End Sub

    Private Sub btnBack_MouseLeave(sender As Object, e As EventArgs) Handles btnBack.MouseLeave
        ' Reset the ForeColor when the mouse leaves the button area
        btnBack.ForeColor = System.Drawing.Color.White ' Or your original color
    End Sub

End Class