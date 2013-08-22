Imports System.Environment

Module ModLevelManager

	Private experienceTable As List(Of Integer) = New List(Of Integer)						' List containing all experience levels saved in experienceTable.ini

	Public Sub initialize()
		Try
			Dim streamReader1 As New System.IO.StreamReader(GetFolderPath(SpecialFolder.ApplicationData) + "\DMManager\experienceTable.ini")

			Do While streamReader1.Peek <> -1												' while there's something to read
				experienceTable.Add(Convert.ToInt32(streamReader1.ReadLine))				' read a line from the ini
			Loop
		Catch ex As Exception																' if there's an error
			MessageBox.Show("Error reading experienceTable.ini")							' throw an error message
		End Try
	End Sub

	Public Function getLevel(ByVal exp As Integer) As Integer
		Dim level As Integer = 0															' the level value to return
		For Each value As Integer In experienceTable										' check every value in the experienceTable list
			If value > exp Then Exit For
			level += 1																		' if we go over the experience level, quit, otherwise increment the level to be returned
		Next
		Return level																		' return the value
	End Function

End Module

