Module ModKeypressHandler

	Sub onlyNumeric(ByRef e As System.Windows.Forms.KeyPressEventArgs)
		If Asc(e.KeyChar) <> 8 Then															' if it's not a backspace
			If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then								' then if it isn't numeric
				e.Handled = True															' stop paying attention to it
			End If
		End If
	End Sub

End Module
