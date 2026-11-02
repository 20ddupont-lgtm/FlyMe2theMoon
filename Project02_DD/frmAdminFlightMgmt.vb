Public Class frmAdminFlightMgmt
    Private Sub btnCreateFlight_Click(sender As Object, e As EventArgs) Handles btnCreateFlight.Click
        ' Opens frmCreateFlight

        frmCreateFlight.ShowDialog()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Closes the form

        Close()
    End Sub
End Class