Module ModIOHandler

	Private LstTxts As List(Of TextBox) = New List(Of TextBox)										' list of all TextBoxes that need their values saved
	Private LstCmbs As List(Of ComboBox) = New List(Of ComboBox)									' list of all ComboBoxes that need their values saved

	Public Sub saveControls(ByVal _fileName As String)
		Using streamWriter1 As New System.IO.StreamWriter(_fileName)								' the StreamWriter for the savefile
			If streamWriter1 IsNot Nothing Then														' if there's something to write to
				For Each txt In LstTxts																' save all the TextBoxes
					streamWriter1.Write(txt.Text)
					If LstTxts.IndexOf(txt) + 1 < LstTxts.Count Then								' if this isn't the last field
						streamWriter1.Write("•")													' add a separator
					End If
				Next
				streamWriter1.Write(vbCrLf)
				For Each cmb In LstCmbs																' save all the ComboBoxes
					streamWriter1.Write(cmb.Text)
					If LstCmbs.IndexOf(cmb) + 1 < LstCmbs.Count Then								' if this isn't the last field
						streamWriter1.Write("•")													' add a separator
					End If
				Next
				streamWriter1.Close()																' close the stream
			End If
		End Using
	End Sub

	Public Sub loadControls(ByVal _fileName As String)
		Using textParser As New Microsoft.VisualBasic.FileIO.TextFieldParser(_fileName)				' the TextFieldParser
			textParser.TextFieldType = FileIO.FieldType.Delimited									' set TextFieldType to delimited
			textParser.SetDelimiters("•")															' set delimiters
			Dim currentLine As String()																' the currently accessed line
			Dim fieldID As Integer = 0																' the field ID we're working with
			Try
				currentLine = textParser.ReadFields()												' read a line
				For Each currentField As String In currentLine										' for every field in this line
					LstTxts(fieldID).Text = currentField											' put it in the right TextBox
					fieldID += 1																	' and increment the current fieldID
				Next
				fieldID = 0																			' reset the field ID
				currentLine = textParser.ReadFields()												' read the next line
				For Each currentField As String In currentLine										' for every field in this line
					LstCmbs(fieldID).Text = currentField											' put it in the right ComboBox
					fieldID += 1																	' and increment the current fieldID
				Next
			Catch ex As Exception																	' if there's an error
				MessageBox.Show("Error reading " & _fileName)										' throw an error message
			End Try
		End Using
	End Sub

	Public Sub clearControls()
		For Each txt As TextBox In LstTxts															' for every control in LstTxts
			txt.Text = Nothing																		' clear the field
		Next
		For Each cmb As ComboBox In LstCmbs															' for every control in LstCmbs
			cmb.Text = Nothing																		' clear the field
		Next
	End Sub

	Public Sub addControl(ByRef _textBox As TextBox)												' add an item to the TextBox save/load list
		LstTxts.Add(_textBox)
	End Sub

	Public Sub addControl(ByRef _comboBox As ComboBox)												' add an item to the ComboBox save/load list
		LstCmbs.Add(_comboBox)
	End Sub

End Module
