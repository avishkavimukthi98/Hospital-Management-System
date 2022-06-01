<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patientdetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Patientdetails))
        Me.Search = New System.Windows.Forms.Label()
        Me.SearchTB = New System.Windows.Forms.TextBox()
        Me.AddressTB = New System.Windows.Forms.TextBox()
        Me.Address = New System.Windows.Forms.Label()
        Me.PatientIDTb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DobDTPicker = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GenderCB = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PatientNameTB = New System.Windows.Forms.TextBox()
        Me.AgeTB = New System.Windows.Forms.TextBox()
        Me.ClearBTN = New System.Windows.Forms.Button()
        Me.UpdateBTN = New System.Windows.Forms.Button()
        Me.SearchBTN = New System.Windows.Forms.Button()
        Me.DeleteBTN = New System.Windows.Forms.Button()
        Me.AddBTN = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PatientdetailsDataGridView = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PatientdetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Search
        '
        Me.Search.AutoSize = True
        Me.Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(7, 87)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(94, 30)
        Me.Search.TabIndex = 47
        Me.Search.Text = "To Search ID," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "To Update ID"
        '
        'SearchTB
        '
        Me.SearchTB.Location = New System.Drawing.Point(116, 87)
        Me.SearchTB.Multiline = True
        Me.SearchTB.Name = "SearchTB"
        Me.SearchTB.Size = New System.Drawing.Size(193, 30)
        Me.SearchTB.TabIndex = 46
        '
        'AddressTB
        '
        Me.AddressTB.Location = New System.Drawing.Point(99, 209)
        Me.AddressTB.Multiline = True
        Me.AddressTB.Name = "AddressTB"
        Me.AddressTB.Size = New System.Drawing.Size(211, 47)
        Me.AddressTB.TabIndex = 45
        '
        'Address
        '
        Me.Address.AutoSize = True
        Me.Address.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address.Location = New System.Drawing.Point(7, 209)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(58, 15)
        Me.Address.TabIndex = 44
        Me.Address.Text = "Address"
        '
        'PatientIDTb
        '
        Me.PatientIDTb.Location = New System.Drawing.Point(99, 137)
        Me.PatientIDTb.Name = "PatientIDTb"
        Me.PatientIDTb.Size = New System.Drawing.Size(210, 20)
        Me.PatientIDTb.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 15)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "PatientName"
        '
        'DobDTPicker
        '
        Me.DobDTPicker.Location = New System.Drawing.Point(99, 356)
        Me.DobDTPicker.Name = "DobDTPicker"
        Me.DobDTPicker.Size = New System.Drawing.Size(210, 20)
        Me.DobDTPicker.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 272)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 15)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Age"
        '
        'GenderCB
        '
        Me.GenderCB.FormattingEnabled = True
        Me.GenderCB.Items.AddRange(New Object() {"Male", "Female"})
        Me.GenderCB.Location = New System.Drawing.Point(99, 311)
        Me.GenderCB.Name = "GenderCB"
        Me.GenderCB.Size = New System.Drawing.Size(210, 21)
        Me.GenderCB.TabIndex = 42
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 15)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "PatientID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 312)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 15)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Gender"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 356)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 15)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "DOB"
        '
        'PatientNameTB
        '
        Me.PatientNameTB.Location = New System.Drawing.Point(100, 173)
        Me.PatientNameTB.Name = "PatientNameTB"
        Me.PatientNameTB.Size = New System.Drawing.Size(210, 20)
        Me.PatientNameTB.TabIndex = 40
        '
        'AgeTB
        '
        Me.AgeTB.Location = New System.Drawing.Point(99, 272)
        Me.AgeTB.Name = "AgeTB"
        Me.AgeTB.Size = New System.Drawing.Size(210, 20)
        Me.AgeTB.TabIndex = 41
        '
        'ClearBTN
        '
        Me.ClearBTN.BackColor = System.Drawing.Color.Peru
        Me.ClearBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ClearBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearBTN.ForeColor = System.Drawing.Color.White
        Me.ClearBTN.Location = New System.Drawing.Point(236, 514)
        Me.ClearBTN.Name = "ClearBTN"
        Me.ClearBTN.Size = New System.Drawing.Size(75, 23)
        Me.ClearBTN.TabIndex = 31
        Me.ClearBTN.Text = "Clear"
        Me.ClearBTN.UseVisualStyleBackColor = False
        '
        'UpdateBTN
        '
        Me.UpdateBTN.BackColor = System.Drawing.Color.Peru
        Me.UpdateBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.UpdateBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateBTN.ForeColor = System.Drawing.Color.White
        Me.UpdateBTN.Location = New System.Drawing.Point(26, 485)
        Me.UpdateBTN.Name = "UpdateBTN"
        Me.UpdateBTN.Size = New System.Drawing.Size(75, 23)
        Me.UpdateBTN.TabIndex = 30
        Me.UpdateBTN.Text = "Update"
        Me.UpdateBTN.UseVisualStyleBackColor = False
        '
        'SearchBTN
        '
        Me.SearchBTN.BackColor = System.Drawing.Color.Peru
        Me.SearchBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SearchBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBTN.ForeColor = System.Drawing.Color.White
        Me.SearchBTN.Location = New System.Drawing.Point(26, 514)
        Me.SearchBTN.Name = "SearchBTN"
        Me.SearchBTN.Size = New System.Drawing.Size(75, 23)
        Me.SearchBTN.TabIndex = 29
        Me.SearchBTN.Text = "Search"
        Me.SearchBTN.UseVisualStyleBackColor = False
        '
        'DeleteBTN
        '
        Me.DeleteBTN.BackColor = System.Drawing.Color.Peru
        Me.DeleteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DeleteBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBTN.ForeColor = System.Drawing.Color.White
        Me.DeleteBTN.Location = New System.Drawing.Point(26, 456)
        Me.DeleteBTN.Name = "DeleteBTN"
        Me.DeleteBTN.Size = New System.Drawing.Size(75, 23)
        Me.DeleteBTN.TabIndex = 28
        Me.DeleteBTN.Text = "Delete"
        Me.DeleteBTN.UseVisualStyleBackColor = False
        '
        'AddBTN
        '
        Me.AddBTN.BackColor = System.Drawing.Color.Peru
        Me.AddBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AddBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBTN.ForeColor = System.Drawing.Color.White
        Me.AddBTN.Location = New System.Drawing.Point(26, 427)
        Me.AddBTN.Name = "AddBTN"
        Me.AddBTN.Size = New System.Drawing.Size(75, 23)
        Me.AddBTN.TabIndex = 27
        Me.AddBTN.Text = "Add "
        Me.AddBTN.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel3.Location = New System.Drawing.Point(206, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(111, 56)
        Me.Panel3.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(319, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(238, 37)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Patients Details"
        '
        'PatientdetailsDataGridView
        '
        Me.PatientdetailsDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.PatientdetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PatientdetailsDataGridView.Dock = System.Windows.Forms.DockStyle.Right
        Me.PatientdetailsDataGridView.Location = New System.Drawing.Point(317, 56)
        Me.PatientdetailsDataGridView.Name = "PatientdetailsDataGridView"
        Me.PatientdetailsDataGridView.Size = New System.Drawing.Size(557, 493)
        Me.PatientdetailsDataGridView.TabIndex = 33
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(874, 56)
        Me.Panel1.TabIndex = 32
        '
        'Patientdetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 549)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.SearchTB)
        Me.Controls.Add(Me.AddressTB)
        Me.Controls.Add(Me.Address)
        Me.Controls.Add(Me.PatientIDTb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DobDTPicker)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GenderCB)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PatientNameTB)
        Me.Controls.Add(Me.AgeTB)
        Me.Controls.Add(Me.ClearBTN)
        Me.Controls.Add(Me.UpdateBTN)
        Me.Controls.Add(Me.SearchBTN)
        Me.Controls.Add(Me.DeleteBTN)
        Me.Controls.Add(Me.AddBTN)
        Me.Controls.Add(Me.PatientdetailsDataGridView)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Patientdetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patientdetails"
        CType(Me.PatientdetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Search As Label
    Friend WithEvents SearchTB As TextBox
    Friend WithEvents AddressTB As TextBox
    Friend WithEvents Address As Label
    Friend WithEvents PatientIDTb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DobDTPicker As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents GenderCB As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PatientNameTB As TextBox
    Friend WithEvents AgeTB As TextBox
    Friend WithEvents ClearBTN As Button
    Friend WithEvents UpdateBTN As Button
    Friend WithEvents SearchBTN As Button
    Friend WithEvents DeleteBTN As Button
    Friend WithEvents AddBTN As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents PatientdetailsDataGridView As DataGridView
    Friend WithEvents Panel1 As Panel
End Class
