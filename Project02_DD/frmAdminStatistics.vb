Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class frmAdminStatistics
    Private Sub frmAdminStatistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PopulatePilotMiles()
        PopulateAttendantMiles()

        Try
            Dim strSelect As String = ""
            Dim strInsert As String = ""
            Dim cmdSelect As OleDb.OleDbCommand            ' this will be used for our Select statement
            Dim drSourceTable As OleDb.OleDbDataReader     ' this will be where our result set will 
            Dim dt As DataTable = New DataTable            ' this is the table we will load from our reader


            ' open the DB

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

            strSelect = "SELECT MAX(P.intPassengerID) AS TotalCustomers, MAX(F.intFlightID) AS TotalFlights, AVG(F.intMilesFlown) AS AverageMiles " &
                        " FROM TFlights F LEFT JOIN TFlightPassengers FP " &
                        " ON F.intFlightID = FP.intFlightID " &
                        " LEFT JOIN TPassengers P " &
                        " ON P.intPassengerID = FP.intPassengerID" &
                        " WHERE F.dtmFlightDate < GETDATE()"

            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)

            drSourceTable = cmdSelect.ExecuteReader

            While drSourceTable.Read()

                lblTotalCustomers.Text = drSourceTable("TotalCustomers")
                lblTotalFlights.Text = drSourceTable("TotalFlights")
                lblAverageMiles.Text = drSourceTable("AverageMiles")

            End While

            drSourceTable.Close()

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



        Catch ex As Exception
            ' Log and display error message
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub PopulatePilotMiles()
        Dim connectionString As String = "Server=DANIELDUPON106C\MSSQLSERVER01;" &
                                                            "Database=dbFlyMe2theMoon;" &
                                                            "Integrated Security=SSPI;"


        Dim query As String = "SELECT P.strFirstName + ' ' + P.strLastName + ':                 ' + " &
    "CAST(SUM(CASE WHEN F.dtmFlightDate < GETDATE() THEN ISNULL(F.intMilesFlown, 0) ELSE 0 END) AS VARCHAR) + ' miles' AS DisplayText " &
    "FROM TPilots P " &
    "LEFT JOIN TPilotFlights PF ON P.intPilotID = PF.intPilotID " &
    "LEFT JOIN TFlights F ON PF.intFlightID = F.intFlightID " &
    "GROUP BY P.intPilotID, P.strFirstName, P.strLastName"

        Using conn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand(query, conn)
            Dim dt As New DataTable()

            Try
                conn.Open()
                ' Load the data directly into the table
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    dt.Load(reader)
                End Using

                ' Bind to ListBox
                With lstPilotMiles
                    .DataSource = dt
                    .DisplayMember = "DisplayText"
                End With
            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End Using
    End Sub

    Public Sub PopulateAttendantMiles()
        Dim connectionString As String = "Server=DANIELDUPON106C\MSSQLSERVER01;" &
                                                            "Database=dbFlyMe2theMoon;" &
                                                            "Integrated Security=SSPI;"


        Dim query As String = "SELECT A.strFirstName + ' ' + A.strLastName + ':                 ' + " &
    "CAST(SUM(CASE WHEN F.dtmFlightDate < GETDATE() THEN ISNULL(F.intMilesFlown, 0) ELSE 0 END) AS VARCHAR) + ' miles' AS DisplayText " &
    "FROM TAttendants A " &
    "LEFT JOIN TAttendantFlights AF ON A.intAttendantID = AF.intAttendantID " &
    "LEFT JOIN TFlights F ON AF.intFlightID = F.intFlightID " &
    "GROUP BY A.intAttendantID, A.strFirstName, A.strLastName"

        Using conn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand(query, conn)
            Dim dt As New DataTable()

            Try
                conn.Open()
                ' Load the data directly into the table
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    dt.Load(reader)
                End Using

                ' Bind to ListBox
                With lstAttMiles
                    .DataSource = dt
                    .DisplayMember = "DisplayText"
                End With
            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Closes the form

        Close()
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