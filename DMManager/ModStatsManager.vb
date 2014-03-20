Module ModStatsManager

	Public Enum Abilities																														' enum of Abilities for below
		STR
		CON
		DEX
		INT
		CHA
		WIS
	End Enum

	Public Sub initialize()
	End Sub

	Private Function TextPlusHalf(ByRef _abilPlusField As TextBox) As String
		Return If(CharacterSheet.TxtLevel.Text = Nothing, TextAbilMod(_abilPlusField), _
				  Convert.ToInt32(TextAbilMod(_abilPlusField)) + Math.Floor(Convert.ToInt32(CharacterSheet.TxtLevel.Text) / 2))				' return ABIMod + (Level / 2)
	End Function

	Private Function TextAbilMod(ByRef _abilModField As TextBox) As String
		Return If(_abilModField.Text = Nothing, "0", Math.Floor((Convert.ToInt32(_abilModField.Text) - 10) / 2))							' return (ABI - 10) / 2
	End Function

	Private Sub ValidateAbilScore(ByRef _abilScoreField As TextBox)
		If _abilScoreField.Text <> Nothing Then
			If Convert.ToInt32(_abilScoreField.Text) < 2 Then																				' if it's less than 2
				_abilScoreField.Text = "2"																										' set it to 2
			End If
		End If
	End Sub

	Private Sub UpdateAbilFields(ByRef _abilScoreField As TextBox, ByRef _abilModField As TextBox, ByRef _abilPlusField As TextBox)
		ValidateAbilScore(_abilScoreField)																										' validate the ability score
		_abilModField.Text = TextAbilMod(_abilScoreField)																						' set the modifier field
		_abilPlusField.Text = TextPlusHalf(_abilScoreField)																						' set the modifier + 1/2 level 
	End Sub

	Public Sub UpdateAbility(ByVal _abil As ModStatsManager.Abilities)																			' update the selected field
		If _abil = ModStatsManager.Abilities.CHA Then																							' if charisma selected
			UpdateAbilFields(CharacterSheet.TxtAbilScoreCha, CharacterSheet.TxtAbilModCha, CharacterSheet.TxtAbilPlusCha)						' update charisma
		ElseIf _abil = ModStatsManager.Abilities.CON Then																						' if constitution selected
			UpdateAbilFields(CharacterSheet.TxtAbilScoreCon, CharacterSheet.TxtAbilModCon, CharacterSheet.TxtAbilPlusCon)						' update constitution
		ElseIf _abil = ModStatsManager.Abilities.DEX Then																						' if dexterity selected
			UpdateAbilFields(CharacterSheet.TxtAbilScoreDex, CharacterSheet.TxtAbilModDex, CharacterSheet.TxtAbilPlusDex)						' update dexterity
		ElseIf _abil = ModStatsManager.Abilities.INT Then																						' if intelligence selected
			UpdateAbilFields(CharacterSheet.TxtAbilScoreInt, CharacterSheet.TxtAbilModInt, CharacterSheet.TxtAbilPlusInt)						' update intelligence
		ElseIf _abil = ModStatsManager.Abilities.STR Then																						' if strength selected
			UpdateAbilFields(CharacterSheet.TxtAbilScoreStr, CharacterSheet.TxtAbilModStr, CharacterSheet.TxtAbilPlusStr)						' update strength
		ElseIf _abil = ModStatsManager.Abilities.WIS Then																						' if wisdom selected
			UpdateAbilFields(CharacterSheet.TxtAbilScoreWis, CharacterSheet.TxtAbilModWis, CharacterSheet.TxtAbilPlusWis)						' update wisdom
		End If
	End Sub

	Public Sub UpdateAllAbilities()																												' update all fields at once
		ModStatsManager.UpdateAbility(ModStatsManager.Abilities.STR)																			' update strength
		ModStatsManager.UpdateAbility(ModStatsManager.Abilities.CON)																			' update constitution
		ModStatsManager.UpdateAbility(ModStatsManager.Abilities.DEX)																			' update dexterity
		ModStatsManager.UpdateAbility(ModStatsManager.Abilities.INT)																			' update intelligence
		ModStatsManager.UpdateAbility(ModStatsManager.Abilities.WIS)																			' update wisdom
		ModStatsManager.UpdateAbility(ModStatsManager.Abilities.CHA)																			' update charisma
	End Sub

	Public Function StatSum(ByVal ParamArray args() As String) As String
		Dim sumVal As Integer = 0
		For Each arg In args
			sumVal += If(arg = "", 0, Convert.ToInt32(arg))
		Next
		Return sumVal
	End Function

End Module
