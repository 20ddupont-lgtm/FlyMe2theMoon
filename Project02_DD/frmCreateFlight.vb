Public Class frmCreateFlight
    Private Sub frmCreateFlight_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Dim strFromSelect As String = ""
            Dim strToSelect As String = ""
            Dim strPlaneSelect As String = ""
            Dim cmdFromSelect As OleDb.OleDbCommand             ' this will be used for our Select statement
            Dim cmdToSelect As OleDb.OleDbCommand             ' this will be used for our Select statement
            Dim cmdPlaneSelect As OleDb.OleDbCommand             ' this will be used for our Select statement
            Dim drSourceTable As OleDb.OleDbDataReader      ' this will be where our data is retrieved to
            Dim dtfa As DataTable = New DataTable            ' this is the table we will load from our reader for FromAirports
            Dim dtta As DataTable = New DataTable            ' this is the table we will load from our reader for ToAirports
            Dim dtp As DataTable = New DataTable            ' this is the table we will load from our reader for Planes

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
            strFromSelect = "SELECT intAirportID, (strAirportCode + ' - ' + strAirportCity) AS Airport " &
                        " FROM TAirports"

            ' Retrieve all the records 
            cmdFromSelect = New OleDb.OleDbCommand(strFromSelect, m_conAdministrator)
            drSourceTable = cmdFromSelect.ExecuteReader
            dtfa.Load(drSourceTable)

            'load the State result set into the combobox.  For VB, we do this by binding the data to the combobox

            cboFromAirport.ValueMember = "intAirportID"
            cboFromAirport.DisplayMember = "Airport"
            cboFromAirport.DataSource = dtfa

            strToSelect = "SELECT intAirportID, (strAirportCode + ' - ' + strAirportCity) AS Airport " &
                        " FROM TAirports"

            ' Retrieve all the records 
            cmdToSelect = New OleDb.OleDbCommand(strToSelect, m_conAdministrator)
            drSourceTable = cmdToSelect.ExecuteReader
            dtta.Load(drSourceTable)

            'load the State result set into the combobox.  For VB, we do this by binding the data to the combobox

            cboToAirport.ValueMember = "intAirportID"
            cboToAirport.DisplayMember = "Airport"
            cboToAirport.DataSource = dtta

            ' Build the select statement

            strPlaneSelect = "SELECT intPlaneID" &
                             " FROM TPlanes"

            ' Retrieve all the records 
            cmdPlaneSelect = New OleDb.OleDbCommand(strPlaneSelect, m_conAdministrator)
            drSourceTable = cmdPlaneSelect.ExecuteReader
            dtp.Load(drSourceTable)

            cboPlaneID.ValueMember = "intPlaneID"
            cboPlaneID.DisplayMember = "intPlaneID"
            cboPlaneID.DataSource = dtp

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
        Dim dtmFlightDate As Date
        Dim strFlightNumber As String
        Dim dtmTimeofDeparture As DateTime
        Dim dtmTimeofLanding As DateTime
        Dim tsTimeSpan As TimeSpan
        Dim intFromAirportID As Integer
        Dim intToAirportID As Integer
        Dim intMilesFlown As Integer
        Dim intPlaneID As Integer
        Dim blnValidated As Boolean = True

        Dim cmdSelect As OleDb.OleDbCommand ' select command object
        Dim cmdInsert As OleDb.OleDbCommand ' insert command object
        Dim drSourceTable As OleDb.OleDbDataReader ' data reader for pulling info
        Dim intNextPrimaryKey As Integer ' holds next highest PK value
        Dim intRowsAffected As Integer  ' how many rows were affected when sql executed


        ' VALIDATE THE INPUTS
        If Date.TryParse(txtFlightDate.Text, dtmFlightDate) Then
            If dtmFlightDate.Date > Date.Today Then
            Else
                MessageBox.Show("Please Enter a Valid Future Date")
                blnValidated = False
            End If
        End If

        If DateTime.TryParse(txtDeparture.Text, dtmTimeofDeparture) Or DateTime.TryParse(txtLanding.Text, dtmTimeofLanding) Then
        Else
            MessageBox.Show("Please Enter a Valid Time (Use International Time: i.e 4:00PM = 16:00)")
            blnValidated = False
        End If

        If TimeSpan.TryParse(txtDeparture.Text, tsTimeSpan) Or TimeSpan.TryParse(txtLanding.Text, tsTimeSpan) Then
            ' Ensure it's a positive time and less than a full 24-hour day
            If tsTimeSpan.TotalHours >= 0 AndAlso tsTimeSpan.TotalHours < 24 Then
            End If
        Else
            MessageBox.Show("Please Enter a Valid Time (Use International Time: i.e 4:00PM = 16:00)")
            blnValidated = False
        End If

        If String.IsNullOrWhiteSpace(txtFlightNumber.Text) Or Not IsNumeric(txtFlightNumber.Text) Or txtFlightNumber.Text.Length <> 3 Then
            MessageBox.Show("Please Enter a Valid Flight Number")
            blnValidated = False
        Else
        End If

        If String.IsNullOrWhiteSpace(txtMilesFlown.Text) Then
            MessageBox.Show("Please Enter the amount of miles flown")
            blnValidated = False
        Else
        End If

        If Not IsNumeric(txtMilesFlown.Text) Or txtMilesFlown.Text.Length < 3 Or txtMilesFlown.Text.Length > 4 Then
            blnValidated = False
            MessageBox.Show("The amount of miles flown has to be numeric, and contain three or four characters.")
        ElseIf txtMilesFlown.Text < 100 Or txtMilesFlown.Text > 9999 Then
            blnValidated = False
            MessageBox.Show("The amount of miles must be between 100 and 9,999 miles.")
        Else
        End If

        If cboFromAirport.SelectedValue = cboToAirport.SelectedValue Then
            MessageBox.Show("The starting Airport and the landing Airport can not be the same")
            blnValidated = False
        End If

        If blnValidated = False Then
            MessageBox.Show("Flight Addition Failed.")
        Else
            Try
                ' put values into strings
                dtmFlightDate = txtFlightDate.Text
                strFlightNumber = txtFlightNumber.Text
                dtmTimeofDeparture = txtDeparture.Text
                dtmTimeofLanding = txtLanding.Text
                intFromAirportID = cboFromAirport.SelectedValue
                intToAirportID = cboToAirport.SelectedValue
                intMilesFlown = txtMilesFlown.Text
                intPlaneID = cboPlaneID.SelectedValue

                If OpenDatabaseConnectionSQLServer() = False Then

                    ' No, warn the user ...
                    MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                        "The application will now close.",
                                        Me.Text + " Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)

                    ' and close the form/application
                    Me.Close()

                End If

                strSelect = "SELECT MAX(intFlightID) + 1 AS intNextPrimaryKey " &
                                " FROM TFlights"

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

                strInsert = "INSERT INTO TFlights (intFlightID, dtmFlightDate, strFlightNumber, dtmTimeofDeparture, dtmTimeOfLanding, intFromAirportID, intToAirportID, intMilesFlown, intPlaneID)" &
                    " VALUES (" & intNextPrimaryKey & ",'" & dtmFlightDate & "','" & strFlightNumber & "','" & dtmTimeofDeparture & "','" & dtmTimeofLanding & "'," & intFromAirportID & ",'" & intToAirportID & "','" & intMilesFlown & "','" & intPlaneID & "')"

                ' MessageBox.Show(strInsert)

                ' use insert command with sql string and connection object
                cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)

                ' execute query to insert data
                intRowsAffected = cmdInsert.ExecuteNonQuery()

                ' If not 0 insert successful
                If intRowsAffected > 0 Then
                    MessageBox.Show("Flight added successfully")    ' let user know success
                    ' close new player form
                End If

                CloseDatabaseConnection()       ' close connection if insert didn't work
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