Public Class CharacterSheet

	Private myIsChanged As Boolean = False
	Private myCurrentFile As String

	'---------------------
	' Load/Save Functions
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
		ModIOHandler.addControl(TxtAbilScoreStr)
		ModIOHandler.addControl(TxtAbilScoreCon)
		ModIOHandler.addControl(TxtAbilScoreDex)
		ModIOHandler.addControl(TxtAbilScoreInt)
		ModIOHandler.addControl(TxtAbilScoreWis)
		ModIOHandler.addControl(TxtAbilScoreCha)
		'-----------initialize Modules
		ModLevelManager.initialize()																								' pulls level config from .ini file
		ModStatsManager.initialize()
		'-----------if opened from filed, load data
		If My.Application.CommandLineArgs.Count > 0 Then																			' if there's a command line argument
			ModIOHandler.loadControls(My.Application.CommandLineArgs(0))															' load all controls marked above
			SetActiveFile(My.Application.CommandLineArgs(0))																		' set the active file to the command line arg
		End If
	End Sub

	Private Sub SetActiveFile(ByVal _fileName As String)
		myCurrentFile = _fileName																									' set the current file property
		SaveToolStripMenuItem.Enabled = True																						' allow saving to the current file
		Me.Text = myCurrentFile & " - DM Manager: Character Sheet"																	' update the title bar
	End Sub

	'---------------------
	' Validation Functions
	'---------------------
	Private Sub OnlyNumeric_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTotalXP.KeyPress,
			TxtAbilScoreStr.KeyPress, TxtAbilScoreCon.KeyPress, TxtAbilScoreDex.KeyPress, TxtAbilScoreInt.KeyPress, TxtAbilScoreWis.KeyPress,
			TxtAbilScoreCha.KeyPress																								' any field that needs to only accept numbers
		If Asc(e.KeyChar) <> 8 Then																									' if it's not a backspace
			If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then																		' then if it isn't numeric
				e.Handled = True																									' stop paying attention to it
			End If
		End If
	End Sub

	Private Sub TxtTotalXP_TextChanged(sender As Object, e As EventArgs) Handles TxtTotalXP.TextChanged								' changes to Total XP field
		If TxtTotalXP.Text IsNot "" Then																							' if there's something in the field
			TxtLevel.Text = getLevel(Convert.ToInt32(TxtTotalXP.Text))																' then get the level and put it in Level field
		Else
			TxtLevel.Text = Nothing																									' otherwise clear the Level field
		End If

		ModStatsManager.UpdateAllAbilities()
	End Sub

	Private Sub TxtAbilScoreStr_LostFocus(sender As Object, e As EventArgs) Handles TxtAbilScoreStr.LostFocus						' user moves out of ScoreStr field
		ModStatsManager.UpdateAbility(ModStatsManager.Abilities.STR)																' update strength fields
	End Sub

	Private Sub TxtAbilScoreCon_LostFocus(sender As Object, e As EventArgs) Handles TxtAbilScoreCon.LostFocus						' user moves out of ScoreCon field
		ModStatsManager.UpdateAbility(ModStatsManager.Abilities.CON)																' update constitution fields
	End Sub

	Private Sub TxtAbilScoreDex_LostFocus(sender As Object, e As EventArgs) Handles TxtAbilScoreDex.LostFocus						' user moves out of ScoreDex field
		ModStatsManager.UpdateAbility(ModStatsManager.Abilities.DEX)																' update dexterity fields
	End Sub

	Private Sub TxtAbilScoreInt_LostFocus(sender As Object, e As EventArgs) Handles TxtAbilScoreInt.LostFocus						' user moves out of ScoreInt field
		ModStatsManager.UpdateAbility(ModStatsManager.Abilities.INT)																' update inteligence fields
	End Sub

	Private Sub TxtAbilScoreWis_LostFocus(sender As Object, e As EventArgs) Handles TxtAbilScoreWis.LostFocus						' user moves out of ScoreWis field
		ModStatsManager.UpdateAbility(ModStatsManager.Abilities.WIS)																' update wisdom fields
	End Sub

	Private Sub TxtAbilScoreCha_LostFocus(sender As Object, e As EventArgs) Handles TxtAbilScoreCha.LostFocus						' user moves out of ScoreCha field
		ModStatsManager.UpdateAbility(ModStatsManager.Abilities.CHA)																' update charisma fields
	End Sub

	Private Sub TxtsSpeed_Changed(sender As Object, e As EventArgs) Handles TxtSpeedBase.LostFocus, TxtSpeedArmor.LostFocus,
			TxtSpeedItem.LostFocus, TxtSpeedMisc.LostFocus
		TxtSpeedTotal.Text = ModStatsManager.StatSum(TxtSpeedBase.Text, TxtSpeedArmor.Text, TxtSpeedItem.Text, TxtSpeedMisc.Text)
	End Sub

	'---------------------
	' Menu Bar Functions
	'---------------------
	Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
		ModIOHandler.saveControls(myCurrentFile)																					' save all controls marked above
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
			ModIOHandler.loadControls(myCurrentFile)																				' load all controls marked above
		End If
	End Sub

	Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
		Me.Close()																													' exit program
	End Sub

	Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
		ModIOHandler.clearControls()																								' clear all marked controls
	End Sub

End Class
