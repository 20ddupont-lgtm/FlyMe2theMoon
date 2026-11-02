Public Class frmPilotUpdateProfile
    Private Sub frmPilotUpdateProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

            ' Build the select statement
            strSelect = "SELECT intPilotRoleID, strPilotRole FROM TPilotRoles"

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader
            dtr.Load(drSourceTable)

            cboPilotRole.ValueMember = "intPilotRoleID"
            cboPilotRole.DisplayMember = "strPilotRole"
            cboPilotRole.DataSource = dtr
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

            cmdSelect = New OleDb.OleDbCommand("uspSelectPilotByID", m_conAdministrator)
            cmdSelect.CommandType = CommandType.StoredProcedure

            objParam = cmdSelect.Parameters.Add("@pilot_id", OleDb.OleDbType.Integer)
            objParam.Direction = ParameterDirection.Input
            objParam.Value = intCurrentPilotID

            drSourceTable = cmdSelect.ExecuteReader

            While drSourceTable.Read()

                ' populate the text boxes with the data
                txtFirstName.Text = drSourceTable("strFirstName")
                txtLastName.Text = drSourceTable("strLastName")
                txtEmployeeID.Text = drSourceTable("strEmployeeID")
                txtDateofHire.Text = drSourceTable("dtmDateofHire")
                txtTerminationDate.Text = drSourceTable("dtmDateofTermination")
                txtLicensedDate.Text = drSourceTable("dtmDateofLicense")
                cboPilotRole.SelectedValue = drSourceTable("intPilotRoleID")

            End While

            drSourceTable.Close()

            CloseDatabaseConnection()

        Catch ex As Exception
            ' Log and display error message
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strSelect As String
        Dim strFirstName As String
        Dim strLastName As String
        Dim strEmployeeID As String
        Dim dtmDateofHire As Date
        Dim dtmDateofTermination As Date
        Dim dtmLicensedDate As Date
        Dim strPilotRole As String
        Dim intRowsAffected As Integer
        Dim blnValidated As Boolean = True

        ' thie will hold our Update statement
        Dim cmdUpdate As OleDb.OleDbCommand

        ' VALIDATE THE INPUTS
        If Not String.IsNullOrWhiteSpace(txtFirstName.Text) And txtFirstName.Text.All(AddressOf Char.IsLetter) Then
        Else
            MessageBox.Show("Please Enter a Valid First Name")
            blnValidated = False
        End If

        If Not String.IsNullOrWhiteSpace(txtLastName.Text) And txtLastName.Text.All(AddressOf Char.IsLetter) Then
        Else
            MessageBox.Show("Please Enter a Valid Last Name")
            blnValidated = False
        End If

        If String.IsNullOrWhiteSpace(txtEmployeeID.Text) Or Not IsNumeric(txtEmployeeID.Text) Or txtEmployeeID.Text.Length <> 5 Then
            MessageBox.Show("Please Enter a Valid Employee ID")
            blnValidated = False
        Else
        End If

        If Date.TryParse(txtDateofHire.Text, dtmDateofHire) Or Date.TryParse(txtTerminationDate.Text, dtmDateofTermination) Or Date.TryParse(txtLicensedDate.Text, dtmLicensedDate) Then
        Else
            MessageBox.Show("Please Enter a Valid Date")
            blnValidated = False
        End If

        If Date.TryParse(txtDateofHire.Text, dtmDateofHire) AndAlso Date.TryParse(txtTerminationDate.Text, dtmDateofTermination) AndAlso Date.TryParse(txtLicensedDate.Text, dtmLicensedDate) Then

            ' Perform the comparison
            If dtmDateofTermination <= dtmDateofHire Or dtmDateofTermination <= dtmLicensedDate Then
                MessageBox.Show("Termination Date must be after the Hire/Licensed Date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtTerminationDate.Focus()
                ' Exit the Sub if validation fails
                Return
            End If
        End If

        If blnValidated = False Then
            MessageBox.Show("Update Failed.")
        Else
            Try

                ' open database this is in module
                If OpenDatabaseConnectionSQLServer() = False Then

                    ' No, warn the user ...
                    MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                            "The application will now close.",
                                            Me.Text + " Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error)

                    ' and close the form/application
                    Me.Close()

                End If

                strFirstName = txtFirstName.Text
                strLastName = txtLastName.Text
                strEmployeeID = txtEmployeeID.Text
                dtmDateofHire = txtDateofHire.Text
                dtmDateofTermination = txtTerminationDate.Text
                dtmLicensedDate = txtLicensedDate.Text
                strPilotRole = cboPilotRole.SelectedValue

                ' Build the select statement using PK from name selected
                strSelect = "Update TPilots Set " &
                            "strFirstName = '" & strFirstName & "', " &
                            "strLastName = '" & strLastName & "', " &
                            "strEmployeeID = '" & strEmployeeID & "', " &
                            "dtmDateofHire = '" & dtmDateofHire & "', " &
                            "dtmDateofTermination = '" & dtmDateofTermination & "', " &
                            "dtmDateofLicense = '" & dtmLicensedDate & "', " &
                            "intPilotRoleID = '" & strPilotRole & "'" &
                            " WHERE intPilotID = " & intCurrentPilotID

                ' make the connection
                cmdUpdate = New OleDb.OleDbCommand(strSelect, m_conAdministrator)

                ' IUpdate the row with execute the statement
                intRowsAffected = cmdUpdate.ExecuteNonQuery()

                ' have to let the user know what happened 
                If intRowsAffected = 1 Then
                    MessageBox.Show("Update successful")
                Else
                    MessageBox.Show("Update failed")
                End If

                ' close the database connection
                CloseDatabaseConnection()

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

    Private Sub btnBack_MouseEnter(sender As Object, e As EventArgs) Handles btnBack.MouseEnter
        ' Change the ForeColor when the mouse hovers over the button
        btnBack.ForeColor = System.Drawing.Color.SteelBlue
    End Sub

    Private Sub btnBack_MouseLeave(sender As Object, e As EventArgs) Handles btnBack.MouseLeave
        ' Reset the ForeColor when the mouse leaves the button area
        btnBack.ForeColor = System.Drawing.Color.White ' Or your original color
    End Sub

    Private Sub btnSubmit_MouseEnter(sender As Object, e As EventArgs) Handles btnSubmit.MouseEnter
        ' Change the ForeColor when the mouse hovers over the button
        btnSubmit.ForeColor = System.Drawing.Color.SteelBlue
    End Sub

    Private Sub btnSubmit_MouseLeave(sender As Object, e As EventArgs) Handles btnSubmit.MouseLeave
        ' Reset the ForeColor when the mouse leaves the button area
        btnSubmit.ForeColor = System.Drawing.Color.White ' Or your original color
    End Sub
End Class