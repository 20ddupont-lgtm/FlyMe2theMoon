Public Class frmPilotFutureFlights
    Private Sub frmPilotFutureFlights_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim strSelect As String = ""
            Dim cmdSelect As OleDb.OleDbCommand         ' this will be used for our Select statement
            Dim drSourceTable As OleDb.OleDbDataReader  ' this will be where our data is retrieved to
            Dim dtr As DataTable = New DataTable        ' this is the table we will load from our reader for Role
            Dim dtp As DataTable = New DataTable        ' this is the table we will load from our reader
            Dim objParam As OleDb.OleDbParameter           ' this will be used to add parameters needed for stored procedures

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

            cmdSelect = New OleDb.OleDbCommand("uspSelectPilotFutureFlights", m_conAdministrator)
            cmdSelect.CommandType = CommandType.StoredProcedure

            objParam = cmdSelect.Parameters.Add("@pilot_id", OleDb.OleDbType.Integer)
            objParam.Direction = ParameterDirection.Input
            objParam.Value = intCurrentPilotID

            drSourceTable = cmdSelect.ExecuteReader

            lstFutureFlights.Items.Add("Future Flights for this Pilot")
            lstFutureFlights.Items.Add("  ")

            While drSourceTable.Read()

                lstFutureFlights.Items.Add("=======================================")
                lstFutureFlights.Items.Add("  ")

                lstFutureFlights.Items.Add("Flight Date: " & vbTab & vbTab & drSourceTable("dtmFlightDate"))
                lstFutureFlights.Items.Add("Flight Number: " & vbTab & vbTab & drSourceTable("strFlightNumber"))
                lstFutureFlights.Items.Add("From Airport: " & vbTab & vbTab & drSourceTable("intFromAirportID"))
                lstFutureFlights.Items.Add("To Airport: " & vbTab & vbTab & drSourceTable("intToAirportID"))
                lstFutureFlights.Items.Add("Plane ID: " & vbTab & vbTab & vbTab & drSourceTable("intPlaneID"))

                lstFutureFlights.Items.Add("  ")

            End While

            drSourceTable.Close()

            CloseDatabaseConnection()

        Catch ex As Exception
            ' Log and display error message
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Closes the form

        Close()
    End Sub

    ' ==============================================================================================
    '   COSMETICS
    ' ==============================================================================================

    Private Sub btnBack_MouseEnter(sender As Object, e As EventArgs) Handles btnBack.MouseEnter
        ' Change the ForeColor when the mouse hovers over the button
        btnBack.ForeColor = System.Drawing.Color.SteelBlue
    End Sub

    Private Sub btnBack_MouseLeave(sender As Object, e As EventArgs) Handles btnBack.MouseLeave
        ' Reset the ForeColor when the mouse leaves the button area
        btnBack.ForeColor = System.Drawing.Color.White ' Or your original color
    End Sub
End Class