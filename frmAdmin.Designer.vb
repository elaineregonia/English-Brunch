<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnRestock = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(288, 30)
        Me.Panel1.TabIndex = 2
        '
        'btnRestock
        '
        Me.btnRestock.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange
        Me.btnRestock.FlatAppearance.BorderSize = 0
        Me.btnRestock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestock.Font = New System.Drawing.Font("Sitka Subheading", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestock.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRestock.Image = CType(resources.GetObject("btnRestock.Image"), System.Drawing.Image)
        Me.btnRestock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRestock.Location = New System.Drawing.Point(42, 169)
        Me.btnRestock.Name = "btnRestock"
        Me.btnRestock.Size = New System.Drawing.Size(187, 80)
        Me.btnRestock.TabIndex = 33
        Me.btnRestock.Text = "Restock"
        Me.btnRestock.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRestock.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.DarkOrange
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLogout.Location = New System.Drawing.Point(93, 362)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(110, 42)
        Me.btnLogout.TabIndex = 70
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnHistory
        '
        Me.btnHistory.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange
        Me.btnHistory.FlatAppearance.BorderSize = 0
        Me.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistory.Font = New System.Drawing.Font("Sitka Subheading", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistory.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnHistory.Image = CType(resources.GetObject("btnHistory.Image"), System.Drawing.Image)
        Me.btnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHistory.Location = New System.Drawing.Point(42, 266)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(190, 80)
        Me.btnHistory.TabIndex = 71
        Me.btnHistory.Text = "History"
        Me.btnHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHistory.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(264, 107)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 72
        Me.PictureBox1.TabStop = False
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(288, 432)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnRestock)
        Me.Controls.Add(Me.btnHistory)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAdmin"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnRestock As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnHistory As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
