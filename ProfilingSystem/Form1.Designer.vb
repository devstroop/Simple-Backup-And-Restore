<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.rdbmale = New System.Windows.Forms.RadioButton()
        Me.cbSection = New System.Windows.Forms.ComboBox()
        Me.rdbFemale = New System.Windows.Forms.RadioButton()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.dtpBirthday = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbYear = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtContactNum = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSchoolAddress = New System.Windows.Forms.TextBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.ButtonBackup = New System.Windows.Forms.Button()
        Me.ButtonRestore = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(23, 44)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(129, 21)
        Me.txtLastName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Last Name:"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(102, 530)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(87, 39)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'rdbmale
        '
        Me.rdbmale.AutoSize = True
        Me.rdbmale.Location = New System.Drawing.Point(23, 71)
        Me.rdbmale.Name = "rdbmale"
        Me.rdbmale.Size = New System.Drawing.Size(53, 19)
        Me.rdbmale.TabIndex = 3
        Me.rdbmale.TabStop = True
        Me.rdbmale.Text = "Male"
        Me.rdbmale.UseVisualStyleBackColor = True
        '
        'cbSection
        '
        Me.cbSection.FormattingEnabled = True
        Me.cbSection.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G"})
        Me.cbSection.Location = New System.Drawing.Point(23, 98)
        Me.cbSection.Name = "cbSection"
        Me.cbSection.Size = New System.Drawing.Size(138, 23)
        Me.cbSection.TabIndex = 4
        '
        'rdbFemale
        '
        Me.rdbFemale.AutoSize = True
        Me.rdbFemale.Location = New System.Drawing.Point(85, 71)
        Me.rdbFemale.Name = "rdbFemale"
        Me.rdbFemale.Size = New System.Drawing.Size(67, 19)
        Me.rdbFemale.TabIndex = 5
        Me.rdbFemale.TabStop = True
        Me.rdbFemale.Text = "Female"
        Me.rdbFemale.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(381, 530)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(87, 39)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Address:"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(23, 210)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(397, 37)
        Me.txtAddress.TabIndex = 7
        '
        'dtpBirthday
        '
        Me.dtpBirthday.CustomFormat = "yyyy-MMM-dd"
        Me.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBirthday.Location = New System.Drawing.Point(23, 115)
        Me.dtpBirthday.Name = "dtpBirthday"
        Me.dtpBirthday.Size = New System.Drawing.Size(211, 21)
        Me.dtpBirthday.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Section:"
        '
        'cbYear
        '
        Me.cbYear.FormattingEnabled = True
        Me.cbYear.Items.AddRange(New Object() {"1st", "2nd", "3rd", "4th"})
        Me.cbYear.Location = New System.Drawing.Point(167, 98)
        Me.cbYear.Name = "cbYear"
        Me.cbYear.Size = New System.Drawing.Size(130, 23)
        Me.cbYear.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(167, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 15)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Year:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMiddleName)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtContactNum)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtAge)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtLastName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.rdbmale)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.dtpBirthday)
        Me.GroupBox1.Controls.Add(Me.rdbFemale)
        Me.GroupBox1.Location = New System.Drawing.Point(54, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(484, 262)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Information"
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Location = New System.Drawing.Point(291, 44)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(129, 21)
        Me.txtMiddleName.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(291, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 15)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Middle Name:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(158, 44)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(129, 21)
        Me.txtFirstName.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(158, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 15)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "First Name:"
        '
        'txtContactNum
        '
        Me.txtContactNum.Location = New System.Drawing.Point(23, 168)
        Me.txtContactNum.MaxLength = 11
        Me.txtContactNum.Name = "txtContactNum"
        Me.txtContactNum.Size = New System.Drawing.Size(274, 21)
        Me.txtContactNum.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 15)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Contact #:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(237, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Age:"
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(240, 115)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.ReadOnly = True
        Me.txtAge.Size = New System.Drawing.Size(57, 21)
        Me.txtAge.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Birthday:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCourse)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtSchoolAddress)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cbSection)
        Me.GroupBox2.Controls.Add(Me.cbYear)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(54, 299)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(484, 225)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "School Info"
        '
        'txtCourse
        '
        Me.txtCourse.Location = New System.Drawing.Point(23, 56)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(274, 21)
        Me.txtCourse.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(23, 38)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 15)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Course:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 131)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 15)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "School Address"
        '
        'txtSchoolAddress
        '
        Me.txtSchoolAddress.Location = New System.Drawing.Point(23, 149)
        Me.txtSchoolAddress.Multiline = True
        Me.txtSchoolAddress.Name = "txtSchoolAddress"
        Me.txtSchoolAddress.Size = New System.Drawing.Size(397, 37)
        Me.txtSchoolAddress.TabIndex = 13
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(569, 39)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(83, 32)
        Me.btnLoad.TabIndex = 15
        Me.btnLoad.Text = "Load Data"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(569, 77)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(435, 447)
        Me.DataGridView1.TabIndex = 16
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(195, 530)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(87, 39)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(288, 530)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(87, 39)
        Me.btnDelete.TabIndex = 17
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(567, 527)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(44, 15)
        Me.lblTotal.TabIndex = 19
        Me.lblTotal.Text = "Total:0"
        '
        'ButtonBackup
        '
        Me.ButtonBackup.Location = New System.Drawing.Point(824, 530)
        Me.ButtonBackup.Name = "ButtonBackup"
        Me.ButtonBackup.Size = New System.Drawing.Size(87, 39)
        Me.ButtonBackup.TabIndex = 20
        Me.ButtonBackup.Text = "Backup"
        Me.ButtonBackup.UseVisualStyleBackColor = True
        '
        'ButtonRestore
        '
        Me.ButtonRestore.Location = New System.Drawing.Point(917, 530)
        Me.ButtonRestore.Name = "ButtonRestore"
        Me.ButtonRestore.Size = New System.Drawing.Size(87, 39)
        Me.ButtonRestore.TabIndex = 21
        Me.ButtonRestore.Text = "Restore"
        Me.ButtonRestore.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1016, 592)
        Me.Controls.Add(Me.ButtonRestore)
        Me.Controls.Add(Me.ButtonBackup)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtLastName As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents btnSave As Button
	Friend WithEvents rdbmale As RadioButton
	Friend WithEvents cbSection As ComboBox
	Friend WithEvents rdbFemale As RadioButton
	Friend WithEvents btnClear As Button
	Friend WithEvents Label2 As Label
	Friend WithEvents txtAddress As TextBox
	Friend WithEvents dtpBirthday As DateTimePicker
	Friend WithEvents Label3 As Label
	Friend WithEvents cbYear As ComboBox
	Friend WithEvents Label4 As Label
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents Label6 As Label
	Friend WithEvents txtAge As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents txtMiddleName As TextBox
	Friend WithEvents Label9 As Label
	Friend WithEvents txtFirstName As TextBox
	Friend WithEvents Label8 As Label
	Friend WithEvents txtContactNum As TextBox
	Friend WithEvents Label7 As Label
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents txtCourse As TextBox
	Friend WithEvents Label11 As Label
	Friend WithEvents Label10 As Label
	Friend WithEvents txtSchoolAddress As TextBox
	Friend WithEvents btnLoad As Button
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents btnUpdate As Button
	Friend WithEvents btnDelete As Button
	Friend WithEvents lblTotal As Label
	Friend WithEvents ButtonBackup As Button
	Friend WithEvents ButtonRestore As Button
End Class
