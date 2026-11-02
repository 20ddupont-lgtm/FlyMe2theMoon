Option Explicit On

Imports System.Data.OleDb

Module modDatabaseUtilities

    Public cboCustomerSelection As ComboBox
    Public intCurrentPassengerID As Integer
    Public intCurrentStateID As Integer
    Public intPassengerID As Integer
    Public intCurrentPilotID As Integer
    Public intCurrentPilotRoleID As Integer

    Public intCurrentCustomerUserID As Integer
    Public intCurrentPilotUserID As Integer
    Public intCurrentAttendantUserID As Integer

    Public intPilotID As Integer
    Public intCurrentAttendantID As Integer
    Public intAttendantID As Integer
    Public intCurrentAdminID As Integer
    Public dtmCurrentDate As DateTime = DateTime.Today

    ' PROPERTY - Connection Object

    ' m_conAdministrator is the connection VB uses to "talk" to the database.

    Public m_conAdministrator As OleDbConnection



    ' CONNECTION STRING

    ' Adjust Database/Server as needed for your setup.

    Public m_strDatabaseConnectionStringSQLServer As String = "Provider=SQLOLEDB;" &
                                                            "Server=DANIELDUPON106C\MSSQLSERVER01;" &
                                                            "Database=dbFlyMe2theMoon;" &
                                                            "Integrated Security=SSPI;"




    ' FUNCTION - OpenDatabaseConnectionSQLServer

    ' Opens and stores a SQL Server connection in m_conAdministrator.

    Public Function OpenDatabaseConnectionSQLServer() As Boolean

        Dim blnResult As Boolean ' Declare

        blnResult = False        ' Assign



        Try

            m_conAdministrator = New OleDbConnection(m_strDatabaseConnectionStringSQLServer)

            m_conAdministrator.Open()

            blnResult = True ' Success

        Catch excError As Exception

            MessageBox.Show(excError.Message)

        End Try

        Return blnResult

    End Function



    ' FUNCTION - CloseDatabaseConnection

    ' Closes connection if open and release memory.

    Public Function CloseDatabaseConnection() As Boolean

        Dim blnResult As Boolean ' Declare

        blnResult = False        ' Assign



        Try

            If m_conAdministrator IsNot Nothing Then

                If m_conAdministrator.State <> ConnectionState.Closed Then

                    m_conAdministrator.Close()

                End If

                m_conAdministrator.Dispose()

                m_conAdministrator = Nothing

            End If

            blnResult = True

        Catch excError As Exception

            MessageBox.Show(excError.Message)

        End Try

        Return blnResult

    End Function



End Module

