Public Class frmCustomerMenu
    Private Sub btnUpdateProfile_Click(sender As Object, e As EventArgs) Handles btnUpdateProfile.Click
        ' Opens frmCustomerUpdateProfile

        frmCustomerUpdateProfile.Show()
    End Sub

    Private Sub btnBookFlight_Click(sender As Object, e As EventArgs) Handles btnBookFlight.Click
        ' Opens frmCustomerBookFlight

        frmCustomerBookFlight.Show()
    End Sub

    Private Sub btnPastFlights_Click(sender As Object, e As EventArgs) Handles btnPastFlights.Click
        ' Opens frmCustomerPastFlights

        frmCustomerPastFlights.Show()
    End Sub

    Private Sub btnFutureFlights_Click(sender As Object, e As EventArgs) Handles btnFutureFlights.Click
        ' Opens frmCustomerFutureFlights

        frmCustomerFutureFlights.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Closes the current form, and redirects the user back to frmMain

        Close()
        frmMain.Show()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Closes the enitre program

        Application.Exit()
    End Sub

    ' ==============================================================================================
    '   COSMETICS
    ' ==============================================================================================

    Private Sub btnClose_MouseEnter(sender As Object, e As EventArgs) Handles btnClose.MouseEnter
        ' Change the ForeColor when the mouse hovers over the button
        btnClose.ForeColor = System.Drawing.Color.White
    End Sub

    Private Sub btnClose_MouseLeave(sender As Object, e As EventArgs) Handles btnClose.MouseLeave
        ' Reset the ForeColor when the mouse leaves the button area
        btnClose.ForeColor = System.Drawing.Color.Black ' Or your original color
    End Sub
End Class