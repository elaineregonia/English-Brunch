Public Class frmLogin

    Dim drag As Boolean
    Dim SAPI
    Dim newpoint As New System.Drawing.Point

    Dim x, y As Integer

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtUsername.Select()

        With txtUsername

            .SelectionStart = .TextLength
            .SelectionLength = 0
            .SelectionStart = 0
            .ScrollToCaret()

        End With

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "cashier" And txtPass.Text = "1234" Then
            MsgBox("Login Successfully")
            'SAPI = CreateObject("SAPI.spvoice")
            'SAPI.speak("Login Successfully")
            frmLoad.Show()
            txtUsername.Clear()
            txtPass.Clear()
            txtUsername.Focus()
            With txtUsername

                .SelectionStart = .TextLength
                .SelectionLength = 0
                .SelectionStart = 0
                .ScrollToCaret()

            End With
            Me.Hide()
        ElseIf txtUsername.Text = "manager" And txtPass.Text = "1234" Then
            MsgBox("Login Successfully")
            'SAPI = CreateObject("SAPI.spvoice")
            'SAPI.speak("Login Successfully")
            frmVoid.Show()
            txtUsername.Clear()
            txtPass.Clear()
            txtUsername.Focus()
            With txtUsername

                .SelectionStart = .TextLength
                .SelectionLength = 0
                .SelectionStart = 0
                .ScrollToCaret()

            End With
            Me.Hide()
        ElseIf txtUsername.Text = "admin" And txtPass.Text = "1234" Then
            MsgBox("Login Successfully")
            'SAPI = CreateObject("SAPI.spvoice")
            'SAPI.speak("Login Successfully")
            frmAdmin.Show()
            txtUsername.Clear()
            txtPass.Clear()
            txtUsername.Focus()
            With txtUsername

                .SelectionStart = .TextLength
                .SelectionLength = 0
                .SelectionStart = 0
                .ScrollToCaret()

            End With
            Me.Hide()

        Else
            MsgBox("Access Denied!", vbCritical, "Login")
            'SAPI = CreateObject("SAPI.spvoice")
            'SAPI.speak("Access Denied! Try again!")
            txtUsername.Focus()
            txtUsername.Clear()
            txtPass.Clear()
            With txtUsername

                .SelectionStart = .TextLength
                .SelectionLength = 0
                .SelectionStart = 0
                .ScrollToCaret()

            End With
        End If
    End Sub

    Private Sub btExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Dim closing As DialogResult
        closing = MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If closing = DialogResult.No Then
            Me.Show()
        Else

            Me.Hide()
            txtUsername.Clear()
            txtPass.Clear()
            txtUsername.Focus()
            With txtUsername

                .SelectionStart = .TextLength
                .SelectionLength = 0
                .SelectionStart = 0
                .ScrollToCaret()

            End With

        End If

    End Sub

    Private Sub chkShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPass.CheckedChanged
        If chkShowPass.Checked = True Then
            txtPass.UseSystemPasswordChar = False
        Else
            txtPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown

        With txtUsername

            If .Text = "Username" And .ForeColor = Color.Gray Then
                If e.KeyCode = Keys.Right Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Or e.KeyCode = Keys.Home Or e.KeyCode = Keys.End Or e.KeyCode = Keys.Tab Then

                    e.Handled = True
                End If
            End If

        End With
    End Sub

    Private Sub txtUsername_MouseDown(sender As Object, e As MouseEventArgs) Handles txtUsername.MouseDown
        drag = True
        With txtUsername
            If .Text = "Username" And .ForeColor = Color.Gray Then
                .SelectionStart = .TextLength
                .SelectionLength = 0
                .SelectionStart = 0
                .ScrollToCaret()
            End If
        End With
    End Sub

    Private Sub txtUsername_MouseMove(sender As Object, e As MouseEventArgs) Handles txtUsername.MouseMove
        If drag Then
            With txtUsername
                If .Text = "Username" And .ForeColor = Color.Gray Then
                    txtUsername.Select(0, 0)
                End If
            End With
        End If
    End Sub

    Private Sub txtUsername_MouseUp(sender As Object, e As MouseEventArgs) Handles txtUsername.MouseUp
        drag = False
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

        With txtUsername

            If .Text = "" Then
                .Text = "Username"
                .ForeColor = Color.Gray
            End If

            If .Text = "Username" And .ForeColor = Color.Gray Then
                .ShortcutsEnabled = False
            Else
                .ShortcutsEnabled = True
            End If

            If .TextLength > 8 Then

                If StrReverse(StrReverse(.Text).Remove(8)) = "Username" Then

                    .Text = .Text.Remove(.TextLength - 8)
                    .ForeColor = Color.Black
                    .SelectionStart = .TextLength
                    .ScrollToCaret()
                End If
            End If

        End With
    End Sub

    Private Sub txtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPass.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnLogin_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True

        With txtPass

            If .Text = "Password" And .ForeColor = Color.Gray Then
                If e.KeyCode = Keys.Right Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Or e.KeyCode = Keys.Home Or e.KeyCode = Keys.End Or e.KeyCode = Keys.Tab Then
                    e.Handled = True
                End If
            End If

        End With


    End Sub

    Private Sub txtPass_MouseDown(sender As Object, e As MouseEventArgs) Handles txtPass.MouseDown
        drag = True
        With txtPass
            If .Text = "Password" And .ForeColor = Color.Gray Then
                .SelectionStart = .TextLength
                .SelectionLength = 0
                .SelectionStart = 0
                .ScrollToCaret()
            End If
        End With
    End Sub

    Private Sub txtPass_MouseMove(sender As Object, e As MouseEventArgs) Handles txtPass.MouseMove
        If drag Then
            With txtPass
                If .Text = "Password" And .ForeColor = Color.Gray Then
                    txtUsername.Select(0, 0)
                End If
            End With
        End If
    End Sub

    Private Sub txtPass_MouseUp(sender As Object, e As MouseEventArgs) Handles txtPass.MouseUp
        drag = False
    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged

        With txtPass

            If .Text = "" Then
                .Text = "Password"
                .ForeColor = Color.Gray
            End If

            If .Text = "Password" And .ForeColor = Color.Gray Then
                .ShortcutsEnabled = False
            Else
                .ShortcutsEnabled = True
            End If

            If .TextLength > 8 Then

                If StrReverse(StrReverse(.Text).Remove(8)) = "Password" Then

                    .Text = .Text.Remove(.TextLength - 8)
                    .ForeColor = Color.Black
                    .SelectionStart = .TextLength
                    .ScrollToCaret()
                End If
            End If

        End With
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
