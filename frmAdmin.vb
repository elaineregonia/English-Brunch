Public Class frmAdmin

    Dim newpoint As New System.Drawing.Point

    Dim x, y As Integer

    Private Sub btnRestock_Click(sender As Object, e As EventArgs) Handles btnRestock.Click
        Me.Hide()
        frmRestock.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        frmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        Me.Hide()
        History.Show()
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= (x)
            newpoint.Y -= (y)
            Me.Location = newpoint

        End If
    End Sub

End Class