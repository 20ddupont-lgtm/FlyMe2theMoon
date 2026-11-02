Imports System.Data.OleDb

Public Class frmAssignPilotFlight
    Private Sub frmAssignPilotFlight_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Dim strSelect As String = ""
            Dim cmdSelect As OleDb.OleDbCommand             ' this will be used for our Select statement
            Dim drSourceTable As OleDb.OleDbDataReader      ' this will be where our data is retrieved to
            Dim dtp As DataTable = New DataTable            ' this is the table we will load from our reader for Pilots
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
            strSelect = "SELECT intPilotID, (strFirstName + ', ' + strLastName) AS PilotName FROM TPilots"

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader
            dtp.Load(drSourceTable)

            'load the State result set into the combobox.  For VB, we do this by binding the data to the combobox

            cboPilots.ValueMember = "intPilotID"
            cboPilots.DisplayMember = "PilotName"
            cboPilots.DataSource = dtp

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

        Dim intFlightID As Integer
        Dim intPilotID As Integer
        Dim intPKID As Integer

        Dim cmdAddPilotFlight As New OleDb.OleDbCommand()

        Dim intRowsAffected As Integer  ' how many rows were affected when sql executed

        Try
            ' put values into strings
            intFlightID = cboFlights.SelectedValue
            intPilotID = cboPilots.SelectedValue

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
            cmdAddPilotFlight.CommandText = "EXECUTE uspInsertPilotFlightAssignment '" & intPKID & "','" & intPilotID & "','" & intFlightID & "'"
            cmdAddPilotFlight.CommandType = CommandType.StoredProcedure

            ' Call stored proc which will insert the record 
            cmdAddPilotFlight = New OleDb.OleDbCommand(cmdAddPilotFlight.CommandText, m_conAdministrator)

            ' this return is the # of rows affected
            intRowsAffected = cmdAddPilotFlight.ExecuteNonQuery()

            ' close database connection
            CloseDatabaseConnection()

            ' have to let the user know what happened 
            If intRowsAffected > 0 Then
                MessageBox.Show("Assignment successful")

            Else
                MessageBox.Show("Insert failed")

            End If

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