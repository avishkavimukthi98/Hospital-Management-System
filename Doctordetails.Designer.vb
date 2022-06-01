<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Doctordetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Doctordetails))
        Me.Search = New System.Windows.Forms.Label()
        Me.SearchTB = New System.Windows.Forms.TextBox()
        Me.AddressTB = New System.Windows.Forms.TextBox()
        Me.Address = New System.Windows.Forms.Label()
        Me.DocIDTb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DobDTPicker = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GenderCB = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ClearBTN = New System.Windows.Forms.Button()
        Me.SearchBTN = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UpdateBTN = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DocNameTB = New System.Windows.Forms.TextBox()
        Me.DeleteBTN = New System.Windows.Forms.Button()
        Me.AgeTB = New System.Windows.Forms.TextBox()
        Me.AddBTN = New System.Windows.Forms.Button()
        Me.DoctordetailsDataGridView = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        CType(Me.DoctordetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Search
        '
        Me.Search.AutoSize = True
        Me.Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(14, 36)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(94, 30)
        Me.Search.TabIndex = 12
        Me.Search.Text = "To Search ID," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "To Update ID" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'SearchTB
        '
        Me.SearchTB.Location = New System.Drawing.Point(115, 36)
        Me.SearchTB.Multiline = True
        Me.SearchTB.Name = "SearchTB"
        Me.SearchTB.Size = New System.Drawing.Size(198, 41)
        Me.SearchTB.TabIndex = 11
        '
        'AddressTB
        '
        Me.AddressTB.Location = New System.Drawing.Point(115, 164)
        Me.AddressTB.Multiline = True
        Me.AddressTB.Name = "AddressTB"
        Me.AddressTB.Size = New System.Drawing.Size(198, 47)
        Me.AddressTB.TabIndex = 10
        '
        'Address
        '
        Me.Address.AutoSize = True
        Me.Address.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address.Location = New System.Drawing.Point(14, 164)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(58, 15)
        Me.Address.TabIndex = 9
        Me.Address.Text = "Address"
        '
        'DocIDTb
        '
        Me.DocIDTb.Location = New System.Drawing.Point(115, 92)
        Me.DocIDTb.Name = "DocIDTb"
        Me.DocIDTb.Size = New System.Drawing.Size(198, 20)
        Me.DocIDTb.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DocName"
        '
        'DobDTPicker
        '
        Me.DobDTPicker.Location = New System.Drawing.Point(115, 301)
        Me.DobDTPicker.Name = "DobDTPicker"
        Me.DobDTPicker.Size = New System.Drawing.Size(198, 20)
        Me.DobDTPicker.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 227)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Age"
        '
        'GenderCB
        '
        Me.GenderCB.FormattingEnabled = True
        Me.GenderCB.Items.AddRange(New Object() {"Male", "Female"})
        Me.GenderCB.Location = New System.Drawing.Point(115, 264)
        Me.GenderCB.Name = "GenderCB"
        Me.GenderCB.Size = New System.Drawing.Size(198, 21)
        Me.GenderCB.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "DocID"
        '
        'ClearBTN
        '
        Me.ClearBTN.BackColor = System.Drawing.Color.Peru
        Me.ClearBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ClearBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearBTN.ForeColor = System.Drawing.Color.White
        Me.ClearBTN.Location = New System.Drawing.Point(238, 453)
        Me.ClearBTN.Name = "ClearBTN"
        Me.ClearBTN.Size = New System.Drawing.Size(75, 23)
        Me.ClearBTN.TabIndex = 6
        Me.ClearBTN.Text = "Clear"
        Me.ClearBTN.UseVisualStyleBackColor = False
        '
        'SearchBTN
        '
        Me.SearchBTN.BackColor = System.Drawing.Color.Peru
        Me.SearchBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SearchBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBTN.ForeColor = System.Drawing.Color.White
        Me.SearchBTN.Location = New System.Drawing.Point(26, 453)
        Me.SearchBTN.Name = "SearchBTN"
        Me.SearchBTN.Size = New System.Drawing.Size(75, 23)
        Me.SearchBTN.TabIndex = 6
        Me.SearchBTN.Text = "Search"
        Me.SearchBTN.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.Controls.Add(Me.Search)
        Me.Panel2.Controls.Add(Me.SearchTB)
        Me.Panel2.Controls.Add(Me.AddressTB)
        Me.Panel2.Controls.Add(Me.Address)
        Me.Panel2.Controls.Add(Me.DocIDTb)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.DobDTPicker)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.GenderCB)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.ClearBTN)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.UpdateBTN)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.SearchBTN)
        Me.Panel2.Controls.Add(Me.DocNameTB)
        Me.Panel2.Controls.Add(Me.DeleteBTN)
        Me.Panel2.Controls.Add(Me.AgeTB)
        Me.Panel2.Controls.Add(Me.AddBTN)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 59)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(329, 485)
        Me.Panel2.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 264)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Gender"
        '
        'UpdateBTN
        '
        Me.UpdateBTN.BackColor = System.Drawing.Color.Peru
        Me.UpdateBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.UpdateBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateBTN.ForeColor = System.Drawing.Color.White
        Me.UpdateBTN.Location = New System.Drawing.Point(26, 424)
        Me.UpdateBTN.Name = "UpdateBTN"
        Me.UpdateBTN.Size = New System.Drawing.Size(75, 23)
        Me.UpdateBTN.TabIndex = 6
        Me.UpdateBTN.Text = "Update"
        Me.UpdateBTN.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 301)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "DOB"
        '
        'DocNameTB
        '
        Me.DocNameTB.Location = New System.Drawing.Point(115, 128)
        Me.DocNameTB.Name = "DocNameTB"
        Me.DocNameTB.Size = New System.Drawing.Size(198, 20)
        Me.DocNameTB.TabIndex = 4
        '
        'DeleteBTN
        '
        Me.DeleteBTN.BackColor = System.Drawing.Color.Peru
        Me.DeleteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DeleteBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBTN.ForeColor = System.Drawing.Color.White
        Me.DeleteBTN.Location = New System.Drawing.Point(26, 395)
        Me.DeleteBTN.Name = "DeleteBTN"
        Me.DeleteBTN.Size = New System.Drawing.Size(75, 23)
        Me.DeleteBTN.TabIndex = 6
        Me.DeleteBTN.Text = "Delete"
        Me.DeleteBTN.UseVisualStyleBackColor = False
        '
        'AgeTB
        '
        Me.AgeTB.Location = New System.Drawing.Point(115, 227)
        Me.AgeTB.Name = "AgeTB"
        Me.AgeTB.Size = New System.Drawing.Size(198, 20)
        Me.AgeTB.TabIndex = 4
        '
        'AddBTN
        '
        Me.AddBTN.BackColor = System.Drawing.Color.Peru
        Me.AddBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AddBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBTN.ForeColor = System.Drawing.Color.White
        Me.AddBTN.Location = New System.Drawing.Point(26, 366)
        Me.AddBTN.Name = "AddBTN"
        Me.AddBTN.Size = New System.Drawing.Size(75, 23)
        Me.AddBTN.TabIndex = 6
        Me.AddBTN.Text = "Add "
        Me.AddBTN.UseVisualStyleBackColor = False
        '
        'DoctordetailsDataGridView
        '
        Me.DoctordetailsDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.DoctordetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DoctordetailsDataGridView.Dock = System.Windows.Forms.DockStyle.Right
        Me.DoctordetailsDataGridView.Location = New System.Drawing.Point(319, 59)
        Me.DoctordetailsDataGridView.Name = "DoctordetailsDataGridView"
        Me.DoctordetailsDataGridView.Size = New System.Drawing.Size(555, 485)
        Me.DoctordetailsDataGridView.TabIndex = 12
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel3.Location = New System.Drawing.Point(195, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(101, 56)
        Me.Panel3.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(301, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(234, 37)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Doctors Details"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(874, 59)
        Me.Panel1.TabIndex = 11
        '
        'Doctordetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 544)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DoctordetailsDataGridView)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Doctordetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Doctordetails"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DoctordetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Search As Label
    Friend WithEvents SearchTB As TextBox
    Friend WithEvents AddressTB As TextBox
    Friend WithEvents Address As Label
    Friend WithEvents DocIDTb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DobDTPicker As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents GenderCB As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ClearBTN As Button
    Friend WithEvents SearchBTN As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents UpdateBTN As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents DocNameTB As TextBox
    Friend WithEvents DeleteBTN As Button
    Friend WithEvents AgeTB As TextBox
    Friend WithEvents AddBTN As Button
    Friend WithEvents DoctordetailsDataGridView As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
End Class
