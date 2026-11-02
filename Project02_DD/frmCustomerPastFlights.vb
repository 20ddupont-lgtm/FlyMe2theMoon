Public Class frmCustomerPastFlights
    Private Sub frmCustomerPastFlights_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Dim strSelect As String = ""
            Dim cmdSelect As OleDb.OleDbCommand            ' this will be used for our Select statement
            Dim drSourceTable As OleDb.OleDbDataReader     ' this will be where our result set will 
            Dim dt As DataTable = New DataTable            ' this is the table we will load from our reader
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

            ' Build the select statement
            strSelect = "SELECT TFlightPassengers.*, TFlights.*, TPassengers.* " &
                        "FROM TFlightPassengers JOIN TFlights " &
                        "ON TFlightPassengers.intFlightID = TFlights.intFlightID " &
                        "JOIN TPassengers " &
                        "ON TFlightPassengers.intPassengerID = TPassengers.intPassengerID " &
                        "WHERE TPassengers.intPassengerID = " & intCurrentPassengerID &
                        " AND dtmFlightDate < GETDATE() " &
                        "ORDER BY dtmFlightDate ASC"

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            'loop through result set and display in Listbox

            lstPastFlights.Items.Add("Past Flights for this Customer")
            lstPastFlights.Items.Add("  ")

            While drSourceTable.Read()

                lstPastFlights.Items.Add("=======================================")
                lstPastFlights.Items.Add("  ")

                lstPastFlights.Items.Add("Flight Date: " & vbTab & vbTab & drSourceTable("dtmFlightDate"))
                lstPastFlights.Items.Add("Flight Number: " & vbTab & vbTab & drSourceTable("strFlightNumber"))
                lstPastFlights.Items.Add("Time of Departure: " & vbTab & vbTab & drSourceTable("dtmTimeofDeparture"))
                lstPastFlights.Items.Add("Time of Landing: " & vbTab & vbTab & drSourceTable("dtmTimeofLanding"))
                lstPastFlights.Items.Add("From Airport: " & vbTab & vbTab & drSourceTable("intFromAirportID"))
                lstPastFlights.Items.Add("To Airport: " & vbTab & vbTab & drSourceTable("intToAirportID"))
                lstPastFlights.Items.Add("Miles Flown: " & vbTab & vbTab & drSourceTable("intMilesFlown"))
                lstPastFlights.Items.Add("Plane: " & vbTab & vbTab & vbTab & drSourceTable("intPlaneID"))

                lstPastFlights.Items.Add("  ")

            End While

            ' Clean up
            drSourceTable.Close()

            ' close the database connection
            CloseDatabaseConnection()

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

            cmdSelect = New OleDb.OleDbCommand("uspSelectCustomerPastMilesTotal", m_conAdministrator)
            cmdSelect.CommandType = CommandType.StoredProcedure

            objParam = cmdSelect.Parameters.Add("@passenger_id", OleDb.OleDbType.Integer)
            objParam.Direction = ParameterDirection.Input
            objParam.Value = intCurrentPassengerID

            drSourceTable = cmdSelect.ExecuteReader

            While drSourceTable.Read()

                lblMilesFlown.Text = If(IsDBNull(drSourceTable("MilesFlown")), "0", drSourceTable("MilesFlown").ToString())

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