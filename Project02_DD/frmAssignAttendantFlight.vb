Imports System.Data.OleDb

Public Class frmAssignAttendantFlight
    Private Sub frmAssignAttendantFlight_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Dim strSelect As String = ""
            Dim cmdSelect As OleDb.OleDbCommand             ' this will be used for our Select statement
            Dim drSourceTable As OleDb.OleDbDataReader      ' this will be where our data is retrieved to
            Dim dta As DataTable = New DataTable            ' this is the table we will load from our reader for Pilots
            Dim dtf As DataTable = New DataTable            ' this is the table we will load from our reader for Flights

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
            strSelect = "SELECT intAttendantID, (strFirstName + ', ' + strLastName) AS AttendantName FROM TAttendants"

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader
            dta.Load(drSourceTable)

            'load the State result set into the combobox.  For VB, we do this by binding the data to the combobox

            cboAttendants.ValueMember = "intAttendantID"
            cboAttendants.DisplayMember = "AttendantName"
            cboAttendants.DataSource = dta

            ' Build the select statement
            Using conn As New OleDbConnection(m_strDatabaseConnectionStringSQLServer)
                Dim sql As String = "SELECT intFlightID, (strFlightNumber + ' - ' + FORMAT(dtmFlightDate, 'MM/dd/yyyy')) AS FutureFlights" &
                                    " FROM TFlights WHERE dtmFlightDate > GETDATE() " &
                                    " ORDER BY dtmFlightDate ASC"

                Using cmd As New OleDbCommand(sql, conn)

                    ' Add input parameter
                    cmd.Parameters.AddWithValue("p1", cboFlights.Text)

                    ' Fill the DataTable
                    Dim dt As New DataTable()
                    Dim adapter As New OleDbDataAdapter(cmd)
                    adapter.Fill(dt)

                    ' Bind to the Control
                    cboFlights.DataSource = dt
                    cboFlights.ValueMember = "intFlightID"
                    cboFlights.DisplayMember = "FutureFlights"
                End Using
            End Using
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
        Dim intFlightID As Integer = cboFlights.SelectedValue
        Dim intAttendantID As Integer = cboAttendants.SelectedValue

        Dim cmdSelect As OleDb.OleDbCommand ' select command object
        Dim cmdInsert As OleDb.OleDbCommand ' insert command object
        Dim drSourceTable As OleDb.OleDbDataReader ' data reader for pulling info
        Dim intNextPrimaryKey As Integer ' holds next highest PK value
        Dim intRowsAffected As Integer  ' how many rows were affected when sql executed
        Dim strResult As DialogResult = MessageBox.Show("Confirm Selected Assignment", "Confirmation", MessageBoxButtons.YesNo)

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

            strSelect = "SELECT MAX(intAttendantFlightID) + 1 AS intNextPrimaryKey " &
                            " FROM TAttendantFlights"

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

            strInsert = "INSERT INTO TAttendantFlights (intAttendantFlightID, intAttendantID, intFlightID)" &
                        " VALUES (" & intNextPrimaryKey & ",'" & intAttendantID & "','" & intFlightID & "')"


            ' Check the result
            If strResult = DialogResult.Yes Then
                ' Code to run if Yes is clicked
            Else
                ' Code to run if No is clicked
                MessageBox.Show("Flight assignment Canceled")
                Exit Sub
            End If

            ' use insert command with sql string and connection object
            cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)

            ' execute query to insert data
            intRowsAffected = cmdInsert.ExecuteNonQuery()

            ' If not 0 insert successful
            If intRowsAffected > 0 Then
                MessageBox.Show("Flight assignment successful")    ' let user know success
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