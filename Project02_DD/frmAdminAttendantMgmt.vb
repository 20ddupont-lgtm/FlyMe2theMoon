Public Class frmAdminAttendantMgmt

    Private Sub btnDeleteAttendant_Click(sender As Object, e As EventArgs) Handles btnDeleteAttendant.Click
        ' Opens frmDeleteAttendant

        frmDeleteAttendant.ShowDialog()
    End Sub

    Private Sub btnAddAttendant_Click(sender As Object, e As EventArgs) Handles btnAddAttendant.Click
        ' Opens frmAddAttendant

        frmAddAttendant.ShowDialog()
    End Sub

    Private Sub btnAssignFlight_Click(sender As Object, e As EventArgs) Handles btnAssignFlight.Click
        ' Opens frmAssignAttendantFlight

        frmAssignAttendantFlight.ShowDialog()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Closes the form

        Close()
    End Sub
End Class