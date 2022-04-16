Imports System.Data.SqlClient
Imports System.IO.Compression
Imports System.Linq.Expressions
Imports System.Text

Public Class Form1
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim student = New StudentInfo()
        student.FirstName = txtFirstName.Text
        student.LastName = txtLastName.Text
        student.MiddleName = txtMiddleName.Text

        'Check if Male or Female is checked by user if not no gender selected
        If rdbmale.Checked Or rdbFemale.Checked Then
            If rdbmale.Checked Then
                student.Gender = "Male"
            Else
                student.Gender = "Female"
            End If
        Else
            'TODO: show message box please select gender
            MessageBox.Show("Please select gender.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return ' to not proceed below weewww
        End If

        student.Birthday = dtpBirthday.Value
        student.ContactNum = txtContactNum.Text
        student.Address = txtAddress.Text
        student.Course = txtCourse.Text
        student.Year = cbYear.Text
        student.Section = cbSection.Text
        student.SchoolAddress = txtSchoolAddress.Text
        student.Created = DateTime.Now
        Try
            Dim result = Insert(student)
            If result Then
                LoadData()
                'Refresh the DataGrid 
                MessageBox.Show("Student Information successfully created.", "SUCCESS",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        Catch ex As Exception
            MessageBox.Show("Student Information FAILED to save see the exception below." +
            Environment.NewLine + ex.ToString(), "WARNING",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFirstName.Clear()
        txtLastName.Clear()
        txtMiddleName.Clear()
        txtAddress.Clear()
        rdbmale.Checked = False
        rdbFemale.Checked = False
        dtpBirthday.Text = ""
        txtContactNum.Clear()
        txtCourse.Clear()
        cbSection.SelectedItem = 0
        cbYear.SelectedItem = 0
        txtSchoolAddress.Clear()

        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LoadData()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        LoadData()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        'Check if ther's is rows index selected
        If e.RowIndex < 0 Then Return

        Dim row = DataGridView1.Rows(e.RowIndex)
        'Global (StudentId) ID for student record
        StudentId = Convert.ToInt64(row.Cells("Id").Value)
        txtFirstName.Text = row.Cells("FirstName").Value.ToString()
        txtLastName.Text = row.Cells("LastName").Value.ToString()
        Dim gender = row.Cells("Gender").Value.ToString()

        rdbmale.Checked = gender = "Male"

        rdbFemale.Checked = Not gender = "Male" And Not gender = ""

        txtMiddleName.Text = row.Cells("MiddleName").Value.ToString()
        dtpBirthday.Value = Convert.ToDateTime(row.Cells("Birthday").Value.ToString())
        txtContactNum.Text = row.Cells("ContactNum").Value.ToString()
        txtAddress.Text = row.Cells("Address").Value.ToString()
        txtCourse.Text = row.Cells("Course").Value.ToString()
        txtSchoolAddress.Text = row.Cells("SchoolAddress").Value.ToString()
        Dim year = row.Cells("Year").Value.ToString()
        Dim section = row.Cells("Section").Value.ToString()
        cbSection.SelectedIndex = cbSection.FindStringExact(section)
        cbYear.SelectedIndex = cbYear.FindStringExact(year)
        txtAge.Text = CopmuteAge(dtpBirthday.Value)
        btnSave.Enabled = False
        btnUpdate.Enabled = True
        btnDelete.Enabled = True

    End Sub

    Private Function CopmuteAge(ByVal bday As DateTime) As Int32

        Dim now = DateTime.Now
        'Subtract year to birthday
        Dim age = now.Year - bday.Year
        'check if the date of birth is not happening
        If bday.Month < now.Month Then
            'subtract 1
            age -= 1
        End If
        Return age

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If StudentId <= 0 Then
            MessageBox.Show("Please select student to update.")
            Return
        End If

        Dim student = New StudentInfo()
        student.Id = StudentId
        student.FirstName = txtFirstName.Text
        student.LastName = txtLastName.Text
        student.MiddleName = txtMiddleName.Text

        'Check if Male or Female is checked by user if not no gender selected
        If rdbmale.Checked Or rdbFemale.Checked Then
            If rdbmale.Checked Then
                student.Gender = "Male"
            Else
                student.Gender = "Female"
            End If
        Else
            'TODO: show message box please select gender
            MessageBox.Show("Please select gender.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return ' to not proceed below weewww
        End If

        student.Birthday = dtpBirthday.Value
        student.ContactNum = txtContactNum.Text
        student.Address = txtAddress.Text
        student.Course = txtCourse.Text
        student.Year = cbYear.Text
        student.Section = cbSection.Text
        student.SchoolAddress = txtSchoolAddress.Text
        student.Created = DateTime.Now
        Try
            Dim result = UpdateStudentInfo(student)
            If result Then
                LoadData()
                StudentId = 0
                'Refresh the DataGrid 
                MessageBox.Show("Student Information successfully UPDATED.", "SUCCESS",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Student Information FAILED to save see the exception below." +
                            Environment.NewLine + ex.ToString(), "WARNING",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try



    End Sub
    Private Sub LoadData()
        DataGridView1.DataSource = LoadStudentData() 'bind list into data source
        DataGridView1.Columns("Id").Visible = False 'hide this column ID
        lblTotal.Text = "Total:" & DataGridView1.Rows.Count

        'Dim tb = New DataTable()
        'tb.Columns.Add("YourColumn1")
        'tb.Columns.Add("YourColumn2")
        'tb.Columns.Add("YourColumn3")
        'tb.Columns.Add("YourColumn4")
        'Dim tr = tb.NewRow()
        'tr("YourColumn1") = "Row1"
        'tr("YourColumn2") = "Row2"
        'tr("YourColumn3") = "Row3"
        'tr("YourColumn4") = "Row4"
        'tb.Rows.Add(tr)
        'DataGridView1.DataSource = tb

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If StudentId <= 0 Then
            MessageBox.Show("Please select student to delete.")
            Return
        End If

        Dim action = MessageBox.Show("Are you sure do you want to delete this data?", "CONFIRM ACTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If action = DialogResult.No Then
            Return
        End If
        Dim student = New StudentInfo()
        student.Id = StudentId

        Try
            Dim result = DeleteStudentInfo(student)
            If result Then
                LoadData()
                'Refresh the DataGrid 
                StudentId = 0
                MessageBox.Show("Student Information successfully DELETED.", "SUCCESS",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Student Information FAILED to save see the exception below." +
                            Environment.NewLine + ex.ToString(), "WARNING",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub dtpBirthday_ValueChanged(sender As Object, e As EventArgs) Handles dtpBirthday.ValueChanged
        txtAge.Text = CopmuteAge(dtpBirthday.Value)

    End Sub

    Private Sub ButtonBackup_Click(sender As Object, e As EventArgs) Handles ButtonBackup.Click
        Dim tempDir As String = System.IO.Path.Combine(System.IO.Path.GetTempPath(), RandomString())
        If Not System.IO.Directory.Exists(tempDir) Then System.IO.Directory.CreateDirectory(tempDir)
        Try
            Dim mdfs() As String = System.IO.Directory.GetFiles(System.IO.Directory.GetCurrentDirectory(), "*.mdf").ToArray()
            Dim ldfs() As String = System.IO.Directory.GetFiles(System.IO.Directory.GetCurrentDirectory(), "*.ldf").ToArray()
            Dim dbs() As String = mdfs.Union(ldfs).ToArray()

            If dbs.Length.Equals(0) Then
                MessageBox.Show("No database found!", "Oops!")
                Return
            End If

            For Each db In dbs
                Try
                    System.IO.File.Copy(db, System.IO.Path.Combine(tempDir, System.IO.Path.GetFileName(db)), True)
                Catch
                End Try
            Next
            ZipFile.CreateFromDirectory(tempDir, $"BACKUP-{DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")}.zip", CompressionLevel.Optimal, False)
            Try
                System.IO.Directory.Delete(tempDir)
            Catch
            End Try
            MessageBox.Show("Backup created successfully", "Woo!")
        Catch ex As Exception
            Try
                System.IO.Directory.Delete(tempDir)
            Catch
            End Try
            MessageBox.Show("Failed to create backup", "Oops!")
        End Try
    End Sub

    Private Sub ButtonRestore_Click(sender As Object, e As EventArgs) Handles ButtonRestore.Click
        Dim dlg As New OpenFileDialog With {
            .InitialDirectory = System.IO.Directory.GetCurrentDirectory(),
            .Title = "Browse Backup Files",
            .CheckFileExists = True,
            .CheckPathExists = True,
            .DefaultExt = "zip",
            .Filter = "Zip files (*.zip)|*.zip",
            .FilterIndex = 2,
            .RestoreDirectory = True,
            .ReadOnlyChecked = True,
            .ShowReadOnly = True
        }

        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                Dim tempDir As String = System.IO.Path.Combine(System.IO.Path.GetTempPath(), RandomString())
                If Not System.IO.Directory.Exists(tempDir) Then System.IO.Directory.CreateDirectory(tempDir)
                ZipFile.ExtractToDirectory(dlg.FileName, tempDir)

                Dim files() As String = System.IO.Directory.GetFiles(tempDir)
                For Each file As String In files
                    Try
                        System.IO.File.Copy(file, System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), System.IO.Path.GetFileName(file)), True)
                    Catch
                    End Try
                Next
                MessageBox.Show("Restored successfully", "Woo!")
            Catch ex As Exception
                MessageBox.Show("Failed to restore", "Oops!")
            End Try
        End If
    End Sub
    Shared random As New Random
    Function RandomString()
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
        Dim sb As New StringBuilder
        Dim cnt As Integer = random.Next(15, 33)
        For i As Integer = 1 To cnt
            Dim idx As Integer = random.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function
End Class
