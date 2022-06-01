<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ClearBTN = New System.Windows.Forms.Button()
        Me.LoginBTN = New System.Windows.Forms.Button()
        Me.PasswordTB = New System.Windows.Forms.TextBox()
        Me.UserNameTB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel2.Location = New System.Drawing.Point(91, 91)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(253, 136)
        Me.Panel2.TabIndex = 15
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Location = New System.Drawing.Point(119, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(194, 61)
        Me.Panel1.TabIndex = 14
        '
        'ClearBTN
        '
        Me.ClearBTN.BackColor = System.Drawing.SystemColors.Control
        Me.ClearBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClearBTN.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearBTN.ForeColor = System.Drawing.Color.Black
        Me.ClearBTN.Location = New System.Drawing.Point(160, 395)
        Me.ClearBTN.Name = "ClearBTN"
        Me.ClearBTN.Size = New System.Drawing.Size(117, 35)
        Me.ClearBTN.TabIndex = 12
        Me.ClearBTN.Text = "Clear"
        Me.ClearBTN.UseVisualStyleBackColor = False
        '
        'LoginBTN
        '
        Me.LoginBTN.BackColor = System.Drawing.SystemColors.Control
        Me.LoginBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoginBTN.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginBTN.ForeColor = System.Drawing.Color.Black
        Me.LoginBTN.Location = New System.Drawing.Point(160, 356)
        Me.LoginBTN.Name = "LoginBTN"
        Me.LoginBTN.Size = New System.Drawing.Size(117, 33)
        Me.LoginBTN.TabIndex = 13
        Me.LoginBTN.Text = "Login"
        Me.LoginBTN.UseVisualStyleBackColor = False
        '
        'PasswordTB
        '
        Me.PasswordTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.PasswordTB.Location = New System.Drawing.Point(189, 295)
        Me.PasswordTB.Name = "PasswordTB"
        Me.PasswordTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTB.Size = New System.Drawing.Size(186, 29)
        Me.PasswordTB.TabIndex = 11
        Me.PasswordTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PasswordTB.UseSystemPasswordChar = True
        '
        'UserNameTB
        '
        Me.UserNameTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserNameTB.Location = New System.Drawing.Point(189, 247)
        Me.UserNameTB.Name = "UserNameTB"
        Me.UserNameTB.Size = New System.Drawing.Size(186, 29)
        Me.UserNameTB.TabIndex = 10
        Me.UserNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(58, 308)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 19)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(58, 260)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 19)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "User Name"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 459)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ClearBTN)
        Me.Controls.Add(Me.LoginBTN)
        Me.Controls.Add(Me.PasswordTB)
        Me.Controls.Add(Me.UserNameTB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ClearBTN As Button
    Friend WithEvents LoginBTN As Button
    Friend WithEvents PasswordTB As TextBox
    Friend WithEvents UserNameTB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
