Public Class frmManageItems


    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        frmAdmin.Show()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim mozp As Integer

        mozp = txtPriceMoz.Text
        mainform.mozprice = mozp

        MsgBox("Updated Successfully!")
    End Sub
End Class