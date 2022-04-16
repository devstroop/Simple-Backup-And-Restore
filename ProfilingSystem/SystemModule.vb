Imports System.Data.SqlClient

Module SystemModule
	Property ConnString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|ProfilingDatabases.mdf;Integrated Security=True;Connect Timeout=30"
	Property StudentId As Int64
	Public Function LoadStudentData() As List(Of StudentInfo)
		Dim list = New List(Of StudentInfo)

		Dim query = "SELECT * FROM StudentInfo"

		'1. Initialize the SqlConnection string
		Using con = New SqlConnection(ConnString)
			'2. Initialize the SqlCommand
			Using cmd = New SqlCommand(query, con)
				'3. open the connection
				con.Open()
				'4. Execute the data reader
				Using reader = cmd.ExecuteReader()

					'If reader.Read() Then 'this will read only one column
					If reader.HasRows Then 'check if there is rows to read
						While reader.Read()
							Dim student = New StudentInfo()
							student.Id = Convert.ToInt32(reader("Id").ToString())
							student.LastName = reader("LastName").ToString()
							student.FirstName = reader("FirstName").ToString()
							student.MiddleName = reader("MiddleName").ToString()
							student.Gender = reader("Gender").ToString()
							student.Birthday = Convert.ToDateTime(reader("Birthday").ToString())
							student.ContactNum = reader("ContactNumber").ToString()
							student.Address = reader("Address").ToString()
							student.Course = reader("Course").ToString()
							student.Year = reader("Year").ToString()
							student.Section = reader("Section").ToString()
							student.SchoolAddress = reader("SchoolAddress").ToString()
							student.Created = Convert.ToDateTime(reader("Created").ToString())
							'Add the student to list
							list.Add(student)
						End While
					End If
				End Using
				con.Close()
			End Using
		End Using

		Return list
	End Function

	''' <summary>
	''' Insert Student Record
	''' </summary>
	''' <param name="student"></param>
	''' <returns></returns>
	Public Function Insert(ByVal student As StudentInfo) As Boolean
		Dim query = "INSERT INTO StudentInfo (LastName,FirstName,MiddleName,Gender,Birthday,ContactNumber,Address,Course,Year,Section,SchoolAddress,Created) VALUES (@LastName,@FirstName,@MiddleName,@Gender,@Birthday,@ContactNum,@Address,@Course,@Year,@Section,@SchoolAddress,@Created)"
		Try

			'1. Initialize the SqlConnection string
			Using con = New SqlConnection(ConnString)
				'2. Initialize the SqlCommand
				Using cmd = New SqlCommand(query, con)
					'3. Create Command Parameter to avoid sql injection
					cmd.Parameters.Add(New SqlParameter("@LastName", student.LastName))
					cmd.Parameters.Add(New SqlParameter("@FirstName", student.FirstName))
					cmd.Parameters.Add(New SqlParameter("@MiddleName", student.MiddleName))
					cmd.Parameters.Add(New SqlParameter("@Gender", student.Gender))
					cmd.Parameters.Add(New SqlParameter("@Birthday", student.Birthday))
					cmd.Parameters.Add(New SqlParameter("@ContactNum", student.ContactNum))
					cmd.Parameters.Add(New SqlParameter("@Address", student.Address))
					cmd.Parameters.Add(New SqlParameter("@Course", student.Course))
					cmd.Parameters.Add(New SqlParameter("@Year", student.Year))
					cmd.Parameters.Add(New SqlParameter("@Section", student.Section))
					cmd.Parameters.Add(New SqlParameter("@SchoolAddress", student.SchoolAddress))
					cmd.Parameters.Add(New SqlParameter("@Created", student.Created))
					'4. open the connection
					con.Open()
					'Execute non query to insert data
					cmd.ExecuteNonQuery()
					con.Close()
					Return True ' if successfully save in database
				End Using
			End Using

		Catch ex As Exception
			Throw ex
		End Try
	End Function

	''' <summary>
	''' Update Student Record
	''' </summary>
	''' <returns></returns>
	Public Function UpdateStudentInfo(ByVal student As StudentInfo) As Boolean
		Dim query = "UPDATE StudentInfo  SET LastName=@LastName,FirstName=@FirstName,MiddleName=@MiddleName,Gender=@Gender,Birthday=@Birthday,ContactNumber=@ContactNum,Address=@Address,Course=@Course,Year=@Year,Section=@Section,SchoolAddress=@SchoolAddress,Created=@Created WHERE Id=@Id"
		Try

			'1. Initialize the SqlConnection string
			Using con = New SqlConnection(ConnString)
				'2. Initialize the SqlCommand
				Using cmd = New SqlCommand(query, con)
					'3. Create Command Parameter to avoid sql injection
					cmd.Parameters.Add(New SqlParameter("@LastName", student.LastName))
					cmd.Parameters.Add(New SqlParameter("@FirstName", student.FirstName))
					cmd.Parameters.Add(New SqlParameter("@MiddleName", student.MiddleName))
					cmd.Parameters.Add(New SqlParameter("@Gender", student.Gender))
					cmd.Parameters.Add(New SqlParameter("@Birthday", student.Birthday))
					cmd.Parameters.Add(New SqlParameter("@ContactNum", student.ContactNum))
					cmd.Parameters.Add(New SqlParameter("@Address", student.Address))
					cmd.Parameters.Add(New SqlParameter("@Course", student.Course))
					cmd.Parameters.Add(New SqlParameter("@Year", student.Year))
					cmd.Parameters.Add(New SqlParameter("@Section", student.Section))
					cmd.Parameters.Add(New SqlParameter("@SchoolAddress", student.SchoolAddress))
					cmd.Parameters.Add(New SqlParameter("@Created", student.Created))
					cmd.Parameters.Add(New SqlParameter("@Id", student.Id))
					'4. open the connection
					con.Open()
					'Execute non query to insert data
					cmd.ExecuteNonQuery()
					con.Close()
					Return True ' if successfully save in database
				End Using
			End Using

		Catch ex As Exception
			Throw ex
		End Try

	End Function

	''' <summary>
	''' Delete Student Record
	''' </summary>
	''' <param name="student"></param>
	''' <returns></returns>
	Public Function DeleteStudentInfo(ByVal student As StudentInfo) As Boolean
		Dim query = "DELETE FROM StudentInfo WHERE Id=@Id"
		Try

			'1. Initialize the SqlConnection string
			Using con = New SqlConnection(ConnString)
				'2. Initialize the SqlCommand
				Using cmd = New SqlCommand(query, con)
					'3. Create Command Parameter to avoid sql injection
					cmd.Parameters.Add(New SqlParameter("@Id", student.Id))
					'4. open the connection
					con.Open()
					'Execute non query to insert data
					cmd.ExecuteNonQuery()
					con.Close()
					Return True ' if successfully save in database
				End Using
			End Using

		Catch ex As Exception
			Throw ex
		End Try

		Return False
	End Function

End Module

Friend Class StudentInfo
	Property Id As Int64
	Property LastName As String
	Property FirstName As String
	Property MiddleName As String
	Property Gender As String
	Property Birthday As DateTime
	Property ContactNum As String
	Property Address As String
	Property Course As String
	Property Year As String
	Property Section As String
	Property SchoolAddress As String
	Property Created As DateTime
End Class
