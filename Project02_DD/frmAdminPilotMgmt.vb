Public Class frmAdminPilotMgmt
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Closes the form

        Close()
    End Sub

    Private Sub btnAddPilot_Click(sender As Object, e As EventArgs) Handles btnAddPilot.Click
        ' Opens frmAddPilot

        frmAddPilot.ShowDialog()
    End Sub

    Private Sub btnAssignFlight_Click(sender As Object, e As EventArgs) Handles btnAssignFlight.Click
        ' Opens frmAssignPilotFlight

        frmAssignPilotFlight.ShowDialog()
    End Sub

    Private Sub btnDeletePilot_Click(sender As Object, e As EventArgs) Handles btnDeletePilot.Click
        ' Opens frmDeletePilot

        frmDeletePilot.ShowDialog()
    End Sub
End Class