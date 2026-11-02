Public Class frmAdministrationMenu
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Closes the form

        Close()
        frmMain.Show()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Closes the entire program

        Application.Exit()
    End Sub

    Private Sub btnPilotMgmt_Click(sender As Object, e As EventArgs) Handles btnPilotMgmt.Click
        ' Opens frmAdminPilotMgmt

        frmAdminPilotMgmt.ShowDialog()
    End Sub

    Private Sub btnAttendantMgmt_Click(sender As Object, e As EventArgs) Handles btnAttendantMgmt.Click
        ' Opens frmAdminAttendantMgmt

        frmAdminAttendantMgmt.ShowDialog()
    End Sub

    Private Sub btnFlightMgmt_Click(sender As Object, e As EventArgs) Handles btnFlightMgmt.Click
        ' Opens frmAdminFlightMgmt

        frmAdminFlightMgmt.ShowDialog()
    End Sub

    Private Sub btnStatistics_Click(sender As Object, e As EventArgs) Handles btnStatistics.Click
        ' Opens frmAdminStatistics

        frmAdminStatistics.ShowDialog()
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