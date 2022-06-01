<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.HospitalMSTB3 = New System.Windows.Forms.TextBox()
        Me.HospitalMSTB2 = New System.Windows.Forms.TextBox()
        Me.HospitalMSTB1 = New System.Windows.Forms.TextBox()
        Me.HospitalMSTB = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'HospitalMSTB3
        '
        Me.HospitalMSTB3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HospitalMSTB3.ForeColor = System.Drawing.Color.ForestGreen
        Me.HospitalMSTB3.Location = New System.Drawing.Point(149, 373)
        Me.HospitalMSTB3.Multiline = True
        Me.HospitalMSTB3.Name = "HospitalMSTB3"
        Me.HospitalMSTB3.Size = New System.Drawing.Size(201, 69)
        Me.HospitalMSTB3.TabIndex = 11
        Me.HospitalMSTB3.Text = "Doctors Details" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Patient Details" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Receptionist & Workers Details" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'HospitalMSTB2
        '
        Me.HospitalMSTB2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HospitalMSTB2.Location = New System.Drawing.Point(62, 373)
        Me.HospitalMSTB2.Name = "HospitalMSTB2"
        Me.HospitalMSTB2.Size = New System.Drawing.Size(71, 22)
        Me.HospitalMSTB2.TabIndex = 10
        Me.HospitalMSTB2.Text = "Feature"
        '
        'HospitalMSTB1
        '
        Me.HospitalMSTB1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HospitalMSTB1.Location = New System.Drawing.Point(62, 253)
        Me.HospitalMSTB1.Name = "HospitalMSTB1"
        Me.HospitalMSTB1.Size = New System.Drawing.Size(71, 22)
        Me.HospitalMSTB1.TabIndex = 9
        Me.HospitalMSTB1.Text = "Objective:"
        '
        'HospitalMSTB
        '
        Me.HospitalMSTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HospitalMSTB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.HospitalMSTB.Location = New System.Drawing.Point(149, 253)
        Me.HospitalMSTB.Multiline = True
        Me.HospitalMSTB.Name = "HospitalMSTB"
        Me.HospitalMSTB.Size = New System.Drawing.Size(589, 88)
        Me.HospitalMSTB.TabIndex = 8
        Me.HospitalMSTB.Text = resources.GetString("HospitalMSTB.Text")
        Me.HospitalMSTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.Location = New System.Drawing.Point(260, 96)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(281, 151)
        Me.Panel2.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(260, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(281, 82)
        Me.Panel1.TabIndex = 6
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(833, 536)
        Me.Controls.Add(Me.HospitalMSTB3)
        Me.Controls.Add(Me.HospitalMSTB2)
        Me.Controls.Add(Me.HospitalMSTB1)
        Me.Controls.Add(Me.HospitalMSTB)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "About"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HospitalMSTB3 As TextBox
    Friend WithEvents HospitalMSTB2 As TextBox
    Friend WithEvents HospitalMSTB1 As TextBox
    Friend WithEvents HospitalMSTB As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
End Class
