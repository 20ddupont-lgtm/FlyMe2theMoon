Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmCustomerBookFlight
    Public Sub frmCustomerBookFlight_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'Dim departureTime As Date = CDate(selectedRow("dtmTimeofDeparture"))
        'Dim formattedTime As String = departureTime.ToString("HH:mm")

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
            lblState.Text = drSourceTable("intStateID")

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

            strSelect = "SELECT COUNT(intPassengerID) AS FlightAmount FROM TFlightPassengers" &
                        " WHERE intPassengerID = " & intCurrentPassengerID

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            drSourceTable.Read()

            ' populate the text boxes with the data
            lblFlightAmount.Text = drSourceTable("FlightAmount")

            ' Clean up
            drSourceTable.Close()

            ' close the database connection
            CloseDatabaseConnection()

        Catch ex As Exception
            ' Log and display error message
            MessageBox.Show(ex.Message)
        End Try

        Try
            Dim strSelect As String = ""
            Dim cmdSelect As OleDb.OleDbCommand         ' this will be used for our Select statement
            Dim drSourceTable As OleDb.OleDbDataReader  ' this will be where our data is retrieved to
            Dim dts As DataTable = New DataTable
            Dim dtf As DataTable = New DataTable        ' this is the table we will load from our reader
            Dim dtp As DataTable = New DataTable        ' this is the table we will load from our reader

            Dim dblBaseCost As Double = 250
            If OpenDatabaseConnectionSQLServer() = False Then

                ' No, warn the user ...
                MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                    "The application will now close.",
                                    Me.Text + " Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)

                ' and close the form/application
                Me.Close()

            End If

            strSelect = "SELECT intFlightID, dtmFlightDate, strFlightNumber,  dtmTimeofDeparture, dtmTimeOfLanding, intFromAirportID, intToAirportID, intMilesFlown, intPlaneID FROM TFlights"

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader
            dtf.Load(drSourceTable)

            Using conn As New OleDbConnection(m_strDatabaseConnectionStringSQLServer)
                Dim sql As String = "SELECT DISTINCT PT.*, P.*, A.*, PA.*, F.intFlightID, F.intMilesFlown, F.intPlaneID, intStateID, (FORMAT(dtmFlightDate, 'MM/dd/yyyy') + ' - ' + CAST(dtmTimeofDeparture AS VARCHAR(5)) + ' - ' + F.strFlightNumber + ' - ' + A.strAirportCity + ' - ' + AF.strAirportCity) AS FutureFlights " &
                                    " FROM TFlights F LEFT JOIN TFlightPassengers FP ON FP.intFlightID = F.intFlightID " &
                                    " AND FP.intPassengerID = " & intCurrentPassengerID &
                                    " LEFT JOIN TPassengers PA ON PA.intPassengerID = FP.intPassengerID " &
                                    " JOIN TAirports A ON A.intAirportID = F.intFromAirportID" &
                                    " JOIN TAirports AF ON AF.intAirportID = F.intToAirportID" &
                                    " JOIN TPlanes P ON P.intPlaneID = F.intPlaneID" &
                                    " JOIN TPlaneTypes PT ON PT.intPlaneTypeID = P.intPlaneTypeID" &
                                    " WHERE dtmFlightDate > GETDATE()" &
                                    " ORDER BY F.intFlightID"

                Using cmd As New OleDbCommand(sql, conn)

                    ' Add input parameter
                    cmd.Parameters.AddWithValue("p1", cboFutureFlights.Text)

                    ' Fill the DataTable
                    Dim dt As New DataTable()
                    Dim adapter As New OleDbDataAdapter(cmd)

                    adapter.Fill(dt)

                    ' Bind to the Control
                    cboFutureFlights.DataSource = dt
                    cboFutureFlights.ValueMember = "intFlightID"
                    cboFutureFlights.DisplayMember = "FutureFlights"
                End Using
            End Using


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

            strSelect = "Select COUNT(strSeat) AS ReservedSeats FROM TFlightPassengers" &
            " WHERE intFlightID = " & cboFutureFlights.SelectedValue &
            " AND strSeat = 'R'"


            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            drSourceTable.Read()

            ' populate the text boxes with the data
            lblReservedCount.Text = drSourceTable("ReservedSeats")

            ' Clean up
            drSourceTable.Close()

            ' close the database connection
            CloseDatabaseConnection()

        Catch excError As Exception
            ' Log and display error message
            MessageBox.Show(excError.Message)
        End Try
    End Sub

    Private Sub UpdateTotalPrice()
        Dim total As Decimal = 0
        Dim result As Double

        ' Get price from ComboBox
        If cboFutureFlights.SelectedItem IsNot Nothing Then
            Dim row As DataRowView = DirectCast(cboFutureFlights.SelectedItem, DataRowView)
            ' Assuming you have a price column in your TFlights table
            total += 250
            If CInt(row("intMilesFlown")) >= 750 Then
                total += 50
            End If

            If row("strPlaneType").ToString().Trim() = "Airbus A350" Then
                total += 35
            ElseIf row("strPlaneType").ToString().Trim() = "Boeing 747-8" Then
                total -= 25
            End If

            If row("strAirportCode").ToString().Trim() = "MIA" Then
                total += 15
            End If

            If lblState.Text = 1 Then
                total = total * 0.9
            ElseIf lblState.Text = 2 Then
                total = total * 0.95
            Else
                total = total
            End If

            If lblFlightAmount.Text >= 10 Then
                total = total * 0.8
            ElseIf lblFlightAmount.Text >= 5 And lblFlightAmount.Text < 10 Then
                total = total * 0.9
            Else
                total = total
            End If

            If Double.TryParse(lblReservedCount.Text, result) Then
                If lblReservedCount.Text < 4 Then
                    total = total - 50
                ElseIf lblReservedCount.Text >= 4 And lblReservedCount.Text <= 8 Then
                    total = total
                Else
                    total = total + 100
                End If
            Else result = 0
            End If
        End If

        ' Add logic for RadioButtons
        If radDesignatedSeat.Checked Then
            total += 0 ' Example surcharge
        ElseIf radReservedSeat.Checked Then
            total += 125
        End If


        ' Update the label
        lblTotalCost.Text = total.ToString("C2") ' C2 formats as Currency
    End Sub

    ' 2. Handle the ComboBox change
    Private Sub cboFlights_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFutureFlights.SelectedIndexChanged
        Try
            Dim strSelect As String = ""
            Dim cmdSelect As OleDb.OleDbCommand         ' this will be used for our Select statement
            Dim drSourceTable As OleDb.OleDbDataReader  ' this will be where our data is retrieved to
            Dim dtr As DataTable = New DataTable        ' this is the table we will load from our reader for Role
            Dim dtp As DataTable = New DataTable        ' this is the table we will load from our reader
            Dim objParam As OleDb.OleDbParameter           ' this will be used to add parameters needed for stored procedures
            If OpenDatabaseConnectionSQLServer() = False Then

                ' No, warn the user ...
                MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                    "The application will now close.",
                                    Me.Text + " Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)

                ' and close the form/application
                Me.Close()

            End If

            cmdSelect = New OleDb.OleDbCommand("uspGetFlightReservedCount", m_conAdministrator)
            cmdSelect.CommandType = CommandType.StoredProcedure

            objParam = cmdSelect.Parameters.Add("@flight_id", OleDb.OleDbType.Integer)
            objParam.Direction = ParameterDirection.Input

            If TypeOf cboFutureFlights.SelectedValue Is DataRowView Then
                Dim drv As DataRowView = DirectCast(cboFutureFlights.SelectedValue, DataRowView)
                objParam.Value = Convert.ToInt32(drv("intFlightID")) ' Use the actual ID column name here
            Else
                objParam.Value = Convert.ToInt32(cboFutureFlights.SelectedValue)
            End If

            drSourceTable = cmdSelect.ExecuteReader

            While drSourceTable.Read()

                lblReservedCount.Text = drSourceTable("ReservedSeats")

            End While

            drSourceTable.Close()

            CloseDatabaseConnection()

        Catch ex As Exception
            ' Log and display error message
            MessageBox.Show(ex.Message)
        End Try


        UpdateTotalPrice()
    End Sub

    ' 3. Handle the RadioButton changes
    Private Sub radDesignatedSeat_CheckedChanged(sender As Object, e As EventArgs) Handles radDesignatedSeat.CheckedChanged, radReservedSeat.CheckedChanged
        ' Note: You can list multiple buttons after the "Handles" keyword
        UpdateTotalPrice()
    End Sub


    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strSelect As String
        Dim strInsert As String
        Dim intFlightPassengerID As Integer
        Dim intFlightID As Integer = cboFutureFlights.SelectedValue
        Dim intPassengerID As Integer
        Dim strSeat As String

        Dim cmdSelect As OleDb.OleDbCommand ' select command object
        Dim cmdInsert As OleDb.OleDbCommand ' insert command object
        Dim drSourceTable As OleDb.OleDbDataReader ' data reader for pulling info
        Dim intNextPrimaryKey As Integer ' holds next highest PK value
        Dim intRowsAffected As Integer  ' how many rows were affected when sql executed
        Dim strResult As DialogResult = MessageBox.Show("Confirm Selected Flight", "Confirmation", MessageBoxButtons.YesNo)

        Try
            ' put values into strings

            If OpenDatabaseConnectionSQLServer() = False Then

                ' No, warn the user ...
                MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                    "The application will now close.",
                                    Me.Text + " Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)

                ' and close the form/application
                Me.Close()

            End If

            strSelect = "SELECT MAX(intFlightPassengerID) + 1 AS intNextPrimaryKey " &
                            " FROM TFlightPassengers"

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

            If radReservedSeat.Checked Then
                strSeat = "R"
            Else
                strSeat = "D"
            End If

            strInsert = "INSERT INTO TFlightPassengers (intFlightPassengerID, intFlightID, intPassengerID, strSeat)" &
                        " VALUES (" & intNextPrimaryKey & ",'" & intFlightID & "','" & intCurrentPassengerID & "','" & strSeat & "')"


            ' Check the result
            If strResult = DialogResult.Yes Then
                ' Code to run if Yes is clicked
            Else
                ' Code to run if No is clicked
                MessageBox.Show("Booking Canceled")
                Exit Sub
            End If

            ' use insert command with sql string and connection object
            cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)

            ' execute query to insert data
            intRowsAffected = cmdInsert.ExecuteNonQuery()

            ' If not 0 insert successful
            If intRowsAffected > 0 Then

                MessageBox.Show("Flight has been booked successfully")    ' let user know success
                ' close new player form
            End If

            CloseDatabaseConnection()       ' close connection if insert didn't work
            Close()
        Catch ex As Exception
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