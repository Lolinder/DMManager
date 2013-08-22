Public Class CharacterSheet

	Private isChanged As Boolean = False
	Private myCurrentFile As String

	'---------------------
	' KeyPress Functions
	'---------------------
	Private Sub CharacterSheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load											' initialization
		'-----------add all controls to be saved/loaded
		ModIOHandler.addControl(TxtCharacterName)
		ModIOHandler.addControl(TxtClass)
		ModIOHandler.addControl(TxtParagonPath)
		ModIOHandler.addControl(TxtEpicDestiny)
		ModIOHandler.addControl(TxtTotalXP)
		ModIOHandler.addControl(TxtPlayerName)
		ModIOHandler.addControl(TxtRace)
		ModIOHandler.addControl(TxtSize)
		ModIOHandler.addControl(TxtAge)
		ModIOHandler.addControl(CmbGender)
		ModIOHandler.addControl(TxtHeight)
		ModIOHandler.addControl(TxtWeight)
		ModIOHandler.addControl(CmbAlignment1)
		ModIOHandler.addControl(CmbAlignment2)
		ModIOHandler.addControl(TxtDeity)
		ModIOHandler.addControl(TxtAffiliation)
		'-----------initialize Modules
		ModLevelManager.initialize()
		'-----------if opened from filed, load data
		If My.Application.CommandLineArgs.Count > 0 Then
			ModIOHandler.loadControls(My.Application.CommandLineArgs(0))
			SetActiveFile(My.Application.CommandLineArgs(0))
		End If
	End Sub

	Private Sub SetActiveFile(ByVal _fileName As String)
		myCurrentFile = _fileName
		SaveToolStripMenuItem.Enabled = True
		Me.Text = myCurrentFile & " - DM Manager: Character Sheet"
	End Sub

	'---------------------
	' KeyPress Functions
	'---------------------
	Private Sub TxtTotalXP_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTotalXP.KeyPress		' entry in the Total XP Field
		ModKeypressHandler.onlyNumeric(e)
	End Sub

	Private Sub TxtTotalXP_TextChanged(sender As Object, e As EventArgs) Handles TxtTotalXP.TextChanged								' changes to Total XP field
		If TxtTotalXP.Text IsNot "" Then																							' if there's something in the field
			TxtLevel.Text = getLevel(Convert.ToInt32(TxtTotalXP.Text))																' then get the level and put it in Level field
		Else
			TxtLevel.Text = Nothing																									' otherwise clear the Level field
		End If
	End Sub
	'---------------------
	' Menu Bar Functions
	'---------------------
	Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
		saveControls(myCurrentFile)
	End Sub

	Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
		If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then														' if the SaveFileDialog was OK'ed
			SetActiveFile(SaveFileDialog1.FileName)																					' set the currently active file
			ModIOHandler.saveControls(myCurrentFile)
		End If
	End Sub

	Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
		If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then														' if the OpenFileDialog was OK'ed
			SetActiveFile(OpenFileDialog1.FileName)																					' set the currently active file
			ModIOHandler.loadControls(myCurrentFile)
		End If
	End Sub

	Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
		Me.Close()
	End Sub

	Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
		ModIOHandler.clearControls()
	End Sub

End Class
