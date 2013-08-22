<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CharacterSheet
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CharacterSheet))
		Me.TabControl = New System.Windows.Forms.TabControl()
		Me.TabPageBasicInfo = New System.Windows.Forms.TabPage()
		Me.TblBasicInfo = New System.Windows.Forms.TableLayoutPanel()
		Me.GBoxDefenses = New System.Windows.Forms.GroupBox()
		Me.GBoxMovement = New System.Windows.Forms.GroupBox()
		Me.GBoxInitiative = New System.Windows.Forms.GroupBox()
		Me.GBoxAbilities = New System.Windows.Forms.GroupBox()
		Me.TxtAbilPlusCha = New System.Windows.Forms.TextBox()
		Me.TxtAbilPlusWis = New System.Windows.Forms.TextBox()
		Me.TxtAbilPlusInt = New System.Windows.Forms.TextBox()
		Me.TxtAbilPlusDex = New System.Windows.Forms.TextBox()
		Me.TxtAbilPlusCon = New System.Windows.Forms.TextBox()
		Me.TxtAbilPlusStr = New System.Windows.Forms.TextBox()
		Me.TxtAbilModCha = New System.Windows.Forms.TextBox()
		Me.TxtAbilModWis = New System.Windows.Forms.TextBox()
		Me.TxtAbilModInt = New System.Windows.Forms.TextBox()
		Me.TxtAbilModDex = New System.Windows.Forms.TextBox()
		Me.TxtAbilModCon = New System.Windows.Forms.TextBox()
		Me.TxtAbilModStr = New System.Windows.Forms.TextBox()
		Me.LblAbility = New System.Windows.Forms.Label()
		Me.LblAbilCha = New System.Windows.Forms.Label()
		Me.LblAbilWis = New System.Windows.Forms.Label()
		Me.LblAbilInt = New System.Windows.Forms.Label()
		Me.LblAbilDex = New System.Windows.Forms.Label()
		Me.LblAbilCon = New System.Windows.Forms.Label()
		Me.LblAbilStr = New System.Windows.Forms.Label()
		Me.TxtAbilScoreCha = New System.Windows.Forms.TextBox()
		Me.TxtAbilScoreWis = New System.Windows.Forms.TextBox()
		Me.TxtAbilScoreInt = New System.Windows.Forms.TextBox()
		Me.TxtAbilScoreDex = New System.Windows.Forms.TextBox()
		Me.TxtAbilScoreCon = New System.Windows.Forms.TextBox()
		Me.TxtAbilScoreStr = New System.Windows.Forms.TextBox()
		Me.LblAbilityScore = New System.Windows.Forms.Label()
		Me.GboxCharInfo = New System.Windows.Forms.GroupBox()
		Me.LblPlayerName = New System.Windows.Forms.Label()
		Me.LblParagonPath = New System.Windows.Forms.Label()
		Me.TxtPlayerName = New System.Windows.Forms.TextBox()
		Me.LblTotalXP = New System.Windows.Forms.Label()
		Me.LblEpicDestiny = New System.Windows.Forms.Label()
		Me.TxtTotalXP = New System.Windows.Forms.TextBox()
		Me.TxtEpicDestiny = New System.Windows.Forms.TextBox()
		Me.TxtParagonPath = New System.Windows.Forms.TextBox()
		Me.LblClass = New System.Windows.Forms.Label()
		Me.TxtClass = New System.Windows.Forms.TextBox()
		Me.LblAffiliation = New System.Windows.Forms.Label()
		Me.LblDeity = New System.Windows.Forms.Label()
		Me.LblLevel = New System.Windows.Forms.Label()
		Me.TxtLevel = New System.Windows.Forms.TextBox()
		Me.LblAlignment = New System.Windows.Forms.Label()
		Me.LblWeight = New System.Windows.Forms.Label()
		Me.LblHeight = New System.Windows.Forms.Label()
		Me.LblGender = New System.Windows.Forms.Label()
		Me.LblAge = New System.Windows.Forms.Label()
		Me.LblSize = New System.Windows.Forms.Label()
		Me.LblRace = New System.Windows.Forms.Label()
		Me.TxtSize = New System.Windows.Forms.TextBox()
		Me.TxtAffiliation = New System.Windows.Forms.TextBox()
		Me.CmbAlignment2 = New System.Windows.Forms.ComboBox()
		Me.LblName = New System.Windows.Forms.Label()
		Me.CmbGender = New System.Windows.Forms.ComboBox()
		Me.CmbAlignment1 = New System.Windows.Forms.ComboBox()
		Me.TxtRace = New System.Windows.Forms.TextBox()
		Me.TxtAge = New System.Windows.Forms.TextBox()
		Me.TxtWeight = New System.Windows.Forms.TextBox()
		Me.TxtHeight = New System.Windows.Forms.TextBox()
		Me.TxtDeity = New System.Windows.Forms.TextBox()
		Me.TxtCharacterName = New System.Windows.Forms.TextBox()
		Me.GBoxSenses = New System.Windows.Forms.GroupBox()
		Me.GBoxOptions = New System.Windows.Forms.GroupBox()
		Me.TabPageCombat = New System.Windows.Forms.TabPage()
		Me.TblCombat = New System.Windows.Forms.TableLayoutPanel()
		Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
		Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
		Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.TabControl.SuspendLayout()
		Me.TabPageBasicInfo.SuspendLayout()
		Me.TblBasicInfo.SuspendLayout()
		Me.GBoxAbilities.SuspendLayout()
		Me.GboxCharInfo.SuspendLayout()
		Me.TabPageCombat.SuspendLayout()
		Me.MenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'TabControl
		'
		Me.TabControl.Controls.Add(Me.TabPageBasicInfo)
		Me.TabControl.Controls.Add(Me.TabPageCombat)
		Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TabControl.Location = New System.Drawing.Point(0, 24)
		Me.TabControl.Name = "TabControl"
		Me.TabControl.SelectedIndex = 0
		Me.TabControl.Size = New System.Drawing.Size(977, 568)
		Me.TabControl.TabIndex = 0
		Me.TabControl.TabStop = False
		'
		'TabPageBasicInfo
		'
		Me.TabPageBasicInfo.Controls.Add(Me.TblBasicInfo)
		Me.TabPageBasicInfo.Location = New System.Drawing.Point(4, 22)
		Me.TabPageBasicInfo.Name = "TabPageBasicInfo"
		Me.TabPageBasicInfo.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPageBasicInfo.Size = New System.Drawing.Size(969, 542)
		Me.TabPageBasicInfo.TabIndex = 0
		Me.TabPageBasicInfo.Text = "Basic Info"
		Me.TabPageBasicInfo.UseVisualStyleBackColor = True
		'
		'TblBasicInfo
		'
		Me.TblBasicInfo.ColumnCount = 3
		Me.TblBasicInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332!))
		Me.TblBasicInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
		Me.TblBasicInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
		Me.TblBasicInfo.Controls.Add(Me.GBoxDefenses, 1, 1)
		Me.TblBasicInfo.Controls.Add(Me.GBoxMovement, 2, 1)
		Me.TblBasicInfo.Controls.Add(Me.GBoxInitiative, 0, 1)
		Me.TblBasicInfo.Controls.Add(Me.GBoxAbilities, 0, 2)
		Me.TblBasicInfo.Controls.Add(Me.GboxCharInfo, 0, 0)
		Me.TblBasicInfo.Controls.Add(Me.GBoxSenses, 2, 2)
		Me.TblBasicInfo.Controls.Add(Me.GBoxOptions, 2, 3)
		Me.TblBasicInfo.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TblBasicInfo.Location = New System.Drawing.Point(3, 3)
		Me.TblBasicInfo.Name = "TblBasicInfo"
		Me.TblBasicInfo.RowCount = 4
		Me.TblBasicInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.40816!))
		Me.TblBasicInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.2449!))
		Me.TblBasicInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.67347!))
		Me.TblBasicInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.67347!))
		Me.TblBasicInfo.Size = New System.Drawing.Size(963, 536)
		Me.TblBasicInfo.TabIndex = 0
		'
		'GBoxDefenses
		'
		Me.GBoxDefenses.Dock = System.Windows.Forms.DockStyle.Fill
		Me.GBoxDefenses.Location = New System.Drawing.Point(323, 112)
		Me.GBoxDefenses.Name = "GBoxDefenses"
		Me.TblBasicInfo.SetRowSpan(Me.GBoxDefenses, 3)
		Me.GBoxDefenses.Size = New System.Drawing.Size(315, 421)
		Me.GBoxDefenses.TabIndex = 3
		Me.GBoxDefenses.TabStop = False
		Me.GBoxDefenses.Text = "Defenses"
		'
		'GBoxMovement
		'
		Me.GBoxMovement.Dock = System.Windows.Forms.DockStyle.Fill
		Me.GBoxMovement.Location = New System.Drawing.Point(644, 112)
		Me.GBoxMovement.Name = "GBoxMovement"
		Me.GBoxMovement.Size = New System.Drawing.Size(316, 59)
		Me.GBoxMovement.TabIndex = 4
		Me.GBoxMovement.TabStop = False
		Me.GBoxMovement.Text = "Movement"
		'
		'GBoxInitiative
		'
		Me.GBoxInitiative.Dock = System.Windows.Forms.DockStyle.Fill
		Me.GBoxInitiative.Location = New System.Drawing.Point(3, 112)
		Me.GBoxInitiative.Name = "GBoxInitiative"
		Me.GBoxInitiative.Size = New System.Drawing.Size(314, 59)
		Me.GBoxInitiative.TabIndex = 1
		Me.GBoxInitiative.TabStop = False
		Me.GBoxInitiative.Text = "Initiative"
		'
		'GBoxAbilities
		'
		Me.GBoxAbilities.Controls.Add(Me.TxtAbilPlusCha)
		Me.GBoxAbilities.Controls.Add(Me.TxtAbilPlusWis)
		Me.GBoxAbilities.Controls.Add(Me.TxtAbilPlusInt)
		Me.GBoxAbilities.Controls.Add(Me.TxtAbilPlusDex)
		Me.GBoxAbilities.Controls.Add(Me.TxtAbilPlusCon)
		Me.GBoxAbilities.Controls.Add(Me.TxtAbilPlusStr)
		Me.GBoxAbilities.Controls.Add(Me.TxtAbilModCha)
		Me.GBoxAbilities.Controls.Add(Me.TxtAbilModWis)
		Me.GBoxAbilities.Controls.Add(Me.TxtAbilModInt)
		Me.GBoxAbilities.Controls.Add(Me.TxtAbilModDex)
		Me.GBoxAbilities.Controls.Add(Me.TxtAbilModCon)
		Me.GBoxAbilities.Controls.Add(Me.TxtAbilModStr)
		Me.GBoxAbilities.Controls.Add(Me.LblAbility)
		Me.GBoxAbilities.Controls.Add(Me.LblAbilCha)
		Me.GBoxAbilities.Controls.Add(Me.LblAbilWis)
		Me.GBoxAbilities.Controls.Add(Me.LblAbilInt)
		Me.GBoxAbilities.Controls.Add(Me.LblAbilDex)
		Me.GBoxAbilities.Controls.Add(Me.LblAbilCon)
		Me.GBoxAbilities.Controls.Add(Me.LblAbilStr)
		Me.GBoxAbilities.Controls.Add(Me.TxtAbilScoreCha)
		Me.GBoxAbilities.Controls.Add(Me.TxtAbilScoreWis)
		Me.GBoxAbilities.Controls.Add(Me.TxtAbilScoreInt)
		Me.GBoxAbilities.Controls.Add(Me.TxtAbilScoreDex)
		Me.GBoxAbilities.Controls.Add(Me.TxtAbilScoreCon)
		Me.GBoxAbilities.Controls.Add(Me.TxtAbilScoreStr)
		Me.GBoxAbilities.Controls.Add(Me.LblAbilityScore)
		Me.GBoxAbilities.Dock = System.Windows.Forms.DockStyle.Fill
		Me.GBoxAbilities.Location = New System.Drawing.Point(3, 177)
		Me.GBoxAbilities.Name = "GBoxAbilities"
		Me.TblBasicInfo.SetRowSpan(Me.GBoxAbilities, 2)
		Me.GBoxAbilities.Size = New System.Drawing.Size(314, 356)
		Me.GBoxAbilities.TabIndex = 2
		Me.GBoxAbilities.TabStop = False
		Me.GBoxAbilities.Text = "Ability Scores"
		'
		'TxtAbilPlusCha
		'
		Me.TxtAbilPlusCha.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtAbilPlusCha.Location = New System.Drawing.Point(247, 310)
		Me.TxtAbilPlusCha.Name = "TxtAbilPlusCha"
		Me.TxtAbilPlusCha.ReadOnly = True
		Me.TxtAbilPlusCha.Size = New System.Drawing.Size(46, 32)
		Me.TxtAbilPlusCha.TabIndex = 59
		'
		'TxtAbilPlusWis
		'
		Me.TxtAbilPlusWis.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtAbilPlusWis.Location = New System.Drawing.Point(247, 272)
		Me.TxtAbilPlusWis.Name = "TxtAbilPlusWis"
		Me.TxtAbilPlusWis.ReadOnly = True
		Me.TxtAbilPlusWis.Size = New System.Drawing.Size(46, 32)
		Me.TxtAbilPlusWis.TabIndex = 58
		'
		'TxtAbilPlusInt
		'
		Me.TxtAbilPlusInt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtAbilPlusInt.Location = New System.Drawing.Point(247, 196)
		Me.TxtAbilPlusInt.Name = "TxtAbilPlusInt"
		Me.TxtAbilPlusInt.ReadOnly = True
		Me.TxtAbilPlusInt.Size = New System.Drawing.Size(46, 32)
		Me.TxtAbilPlusInt.TabIndex = 57
		'
		'TxtAbilPlusDex
		'
		Me.TxtAbilPlusDex.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtAbilPlusDex.Location = New System.Drawing.Point(247, 158)
		Me.TxtAbilPlusDex.Name = "TxtAbilPlusDex"
		Me.TxtAbilPlusDex.ReadOnly = True
		Me.TxtAbilPlusDex.Size = New System.Drawing.Size(46, 32)
		Me.TxtAbilPlusDex.TabIndex = 56
		'
		'TxtAbilPlusCon
		'
		Me.TxtAbilPlusCon.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtAbilPlusCon.Location = New System.Drawing.Point(247, 82)
		Me.TxtAbilPlusCon.Name = "TxtAbilPlusCon"
		Me.TxtAbilPlusCon.ReadOnly = True
		Me.TxtAbilPlusCon.Size = New System.Drawing.Size(46, 32)
		Me.TxtAbilPlusCon.TabIndex = 55
		'
		'TxtAbilPlusStr
		'
		Me.TxtAbilPlusStr.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtAbilPlusStr.Location = New System.Drawing.Point(247, 44)
		Me.TxtAbilPlusStr.Name = "TxtAbilPlusStr"
		Me.TxtAbilPlusStr.ReadOnly = True
		Me.TxtAbilPlusStr.Size = New System.Drawing.Size(46, 32)
		Me.TxtAbilPlusStr.TabIndex = 54
		'
		'TxtAbilModCha
		'
		Me.TxtAbilModCha.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtAbilModCha.Location = New System.Drawing.Point(134, 310)
		Me.TxtAbilModCha.Name = "TxtAbilModCha"
		Me.TxtAbilModCha.ReadOnly = True
		Me.TxtAbilModCha.Size = New System.Drawing.Size(46, 32)
		Me.TxtAbilModCha.TabIndex = 53
		'
		'TxtAbilModWis
		'
		Me.TxtAbilModWis.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtAbilModWis.Location = New System.Drawing.Point(134, 272)
		Me.TxtAbilModWis.Name = "TxtAbilModWis"
		Me.TxtAbilModWis.ReadOnly = True
		Me.TxtAbilModWis.Size = New System.Drawing.Size(46, 32)
		Me.TxtAbilModWis.TabIndex = 52
		'
		'TxtAbilModInt
		'
		Me.TxtAbilModInt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtAbilModInt.Location = New System.Drawing.Point(134, 196)
		Me.TxtAbilModInt.Name = "TxtAbilModInt"
		Me.TxtAbilModInt.ReadOnly = True
		Me.TxtAbilModInt.Size = New System.Drawing.Size(46, 32)
		Me.TxtAbilModInt.TabIndex = 51
		'
		'TxtAbilModDex
		'
		Me.TxtAbilModDex.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtAbilModDex.Location = New System.Drawing.Point(134, 158)
		Me.TxtAbilModDex.Name = "TxtAbilModDex"
		Me.TxtAbilModDex.ReadOnly = True
		Me.TxtAbilModDex.Size = New System.Drawing.Size(46, 32)
		Me.TxtAbilModDex.TabIndex = 50
		'
		'TxtAbilModCon
		'
		Me.TxtAbilModCon.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtAbilModCon.Location = New System.Drawing.Point(134, 82)
		Me.TxtAbilModCon.Name = "TxtAbilModCon"
		Me.TxtAbilModCon.ReadOnly = True
		Me.TxtAbilModCon.Size = New System.Drawing.Size(46, 32)
		Me.TxtAbilModCon.TabIndex = 49
		'
		'TxtAbilModStr
		'
		Me.TxtAbilModStr.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtAbilModStr.Location = New System.Drawing.Point(134, 44)
		Me.TxtAbilModStr.Name = "TxtAbilModStr"
		Me.TxtAbilModStr.ReadOnly = True
		Me.TxtAbilModStr.Size = New System.Drawing.Size(46, 32)
		Me.TxtAbilModStr.TabIndex = 48
		'
		'LblAbility
		'
		Me.LblAbility.AutoSize = True
		Me.LblAbility.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblAbility.Location = New System.Drawing.Point(46, 25)
		Me.LblAbility.Name = "LblAbility"
		Me.LblAbility.Size = New System.Drawing.Size(34, 13)
		Me.LblAbility.TabIndex = 47
		Me.LblAbility.Text = "Ability"
		'
		'LblAbilCha
		'
		Me.LblAbilCha.AutoSize = True
		Me.LblAbilCha.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblAbilCha.Location = New System.Drawing.Point(44, 310)
		Me.LblAbilCha.Name = "LblAbilCha"
		Me.LblAbilCha.Size = New System.Drawing.Size(59, 26)
		Me.LblAbilCha.TabIndex = 46
		Me.LblAbilCha.Text = "CHA"
		'
		'LblAbilWis
		'
		Me.LblAbilWis.AutoSize = True
		Me.LblAbilWis.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblAbilWis.Location = New System.Drawing.Point(44, 272)
		Me.LblAbilWis.Name = "LblAbilWis"
		Me.LblAbilWis.Size = New System.Drawing.Size(54, 26)
		Me.LblAbilWis.TabIndex = 45
		Me.LblAbilWis.Text = "WIS"
		'
		'LblAbilInt
		'
		Me.LblAbilInt.AutoSize = True
		Me.LblAbilInt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblAbilInt.Location = New System.Drawing.Point(44, 196)
		Me.LblAbilInt.Name = "LblAbilInt"
		Me.LblAbilInt.Size = New System.Drawing.Size(46, 26)
		Me.LblAbilInt.TabIndex = 44
		Me.LblAbilInt.Text = "INT"
		'
		'LblAbilDex
		'
		Me.LblAbilDex.AutoSize = True
		Me.LblAbilDex.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblAbilDex.Location = New System.Drawing.Point(44, 158)
		Me.LblAbilDex.Name = "LblAbilDex"
		Me.LblAbilDex.Size = New System.Drawing.Size(58, 26)
		Me.LblAbilDex.TabIndex = 43
		Me.LblAbilDex.Text = "DEX"
		'
		'LblAbilCon
		'
		Me.LblAbilCon.AutoSize = True
		Me.LblAbilCon.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblAbilCon.Location = New System.Drawing.Point(44, 82)
		Me.LblAbilCon.Name = "LblAbilCon"
		Me.LblAbilCon.Size = New System.Drawing.Size(61, 26)
		Me.LblAbilCon.TabIndex = 42
		Me.LblAbilCon.Text = "CON"
		'
		'LblAbilStr
		'
		Me.LblAbilStr.AutoSize = True
		Me.LblAbilStr.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblAbilStr.Location = New System.Drawing.Point(44, 44)
		Me.LblAbilStr.Name = "LblAbilStr"
		Me.LblAbilStr.Size = New System.Drawing.Size(55, 26)
		Me.LblAbilStr.TabIndex = 41
		Me.LblAbilStr.Text = "STR"
		'
		'TxtAbilScoreCha
		'
		Me.TxtAbilScoreCha.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtAbilScoreCha.Location = New System.Drawing.Point(6, 307)
		Me.TxtAbilScoreCha.MaxLength = 2
		Me.TxtAbilScoreCha.Name = "TxtAbilScoreCha"
		Me.TxtAbilScoreCha.Size = New System.Drawing.Size(32, 32)
		Me.TxtAbilScoreCha.TabIndex = 40
		'
		'TxtAbilScoreWis
		'
		Me.TxtAbilScoreWis.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtAbilScoreWis.Location = New System.Drawing.Point(6, 269)
		Me.TxtAbilScoreWis.MaxLength = 2
		Me.TxtAbilScoreWis.Name = "TxtAbilScoreWis"
		Me.TxtAbilScoreWis.Size = New System.Drawing.Size(32, 32)
		Me.TxtAbilScoreWis.TabIndex = 39
		'
		'TxtAbilScoreInt
		'
		Me.TxtAbilScoreInt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtAbilScoreInt.Location = New System.Drawing.Point(6, 193)
		Me.TxtAbilScoreInt.MaxLength = 2
		Me.TxtAbilScoreInt.Name = "TxtAbilScoreInt"
		Me.TxtAbilScoreInt.Size = New System.Drawing.Size(32, 32)
		Me.TxtAbilScoreInt.TabIndex = 37
		'
		'TxtAbilScoreDex
		'
		Me.TxtAbilScoreDex.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtAbilScoreDex.Location = New System.Drawing.Point(6, 155)
		Me.TxtAbilScoreDex.MaxLength = 2
		Me.TxtAbilScoreDex.Name = "TxtAbilScoreDex"
		Me.TxtAbilScoreDex.Size = New System.Drawing.Size(32, 32)
		Me.TxtAbilScoreDex.TabIndex = 36
		'
		'TxtAbilScoreCon
		'
		Me.TxtAbilScoreCon.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtAbilScoreCon.Location = New System.Drawing.Point(6, 79)
		Me.TxtAbilScoreCon.MaxLength = 2
		Me.TxtAbilScoreCon.Name = "TxtAbilScoreCon"
		Me.TxtAbilScoreCon.Size = New System.Drawing.Size(32, 32)
		Me.TxtAbilScoreCon.TabIndex = 34
		'
		'TxtAbilScoreStr
		'
		Me.TxtAbilScoreStr.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtAbilScoreStr.Location = New System.Drawing.Point(6, 41)
		Me.TxtAbilScoreStr.MaxLength = 2
		Me.TxtAbilScoreStr.Name = "TxtAbilScoreStr"
		Me.TxtAbilScoreStr.Size = New System.Drawing.Size(32, 32)
		Me.TxtAbilScoreStr.TabIndex = 33
		'
		'LblAbilityScore
		'
		Me.LblAbilityScore.AutoSize = True
		Me.LblAbilityScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblAbilityScore.Location = New System.Drawing.Point(3, 25)
		Me.LblAbilityScore.Name = "LblAbilityScore"
		Me.LblAbilityScore.Size = New System.Drawing.Size(35, 13)
		Me.LblAbilityScore.TabIndex = 33
		Me.LblAbilityScore.Text = "Score"
		'
		'GboxCharInfo
		'
		Me.TblBasicInfo.SetColumnSpan(Me.GboxCharInfo, 3)
		Me.GboxCharInfo.Controls.Add(Me.LblPlayerName)
		Me.GboxCharInfo.Controls.Add(Me.LblParagonPath)
		Me.GboxCharInfo.Controls.Add(Me.TxtPlayerName)
		Me.GboxCharInfo.Controls.Add(Me.LblTotalXP)
		Me.GboxCharInfo.Controls.Add(Me.LblEpicDestiny)
		Me.GboxCharInfo.Controls.Add(Me.TxtTotalXP)
		Me.GboxCharInfo.Controls.Add(Me.TxtEpicDestiny)
		Me.GboxCharInfo.Controls.Add(Me.TxtParagonPath)
		Me.GboxCharInfo.Controls.Add(Me.LblClass)
		Me.GboxCharInfo.Controls.Add(Me.TxtClass)
		Me.GboxCharInfo.Controls.Add(Me.LblAffiliation)
		Me.GboxCharInfo.Controls.Add(Me.LblDeity)
		Me.GboxCharInfo.Controls.Add(Me.LblLevel)
		Me.GboxCharInfo.Controls.Add(Me.TxtLevel)
		Me.GboxCharInfo.Controls.Add(Me.LblAlignment)
		Me.GboxCharInfo.Controls.Add(Me.LblWeight)
		Me.GboxCharInfo.Controls.Add(Me.LblHeight)
		Me.GboxCharInfo.Controls.Add(Me.LblGender)
		Me.GboxCharInfo.Controls.Add(Me.LblAge)
		Me.GboxCharInfo.Controls.Add(Me.LblSize)
		Me.GboxCharInfo.Controls.Add(Me.LblRace)
		Me.GboxCharInfo.Controls.Add(Me.TxtSize)
		Me.GboxCharInfo.Controls.Add(Me.TxtAffiliation)
		Me.GboxCharInfo.Controls.Add(Me.CmbAlignment2)
		Me.GboxCharInfo.Controls.Add(Me.LblName)
		Me.GboxCharInfo.Controls.Add(Me.CmbGender)
		Me.GboxCharInfo.Controls.Add(Me.CmbAlignment1)
		Me.GboxCharInfo.Controls.Add(Me.TxtRace)
		Me.GboxCharInfo.Controls.Add(Me.TxtAge)
		Me.GboxCharInfo.Controls.Add(Me.TxtWeight)
		Me.GboxCharInfo.Controls.Add(Me.TxtHeight)
		Me.GboxCharInfo.Controls.Add(Me.TxtDeity)
		Me.GboxCharInfo.Controls.Add(Me.TxtCharacterName)
		Me.GboxCharInfo.Dock = System.Windows.Forms.DockStyle.Fill
		Me.GboxCharInfo.Location = New System.Drawing.Point(3, 3)
		Me.GboxCharInfo.Name = "GboxCharInfo"
		Me.GboxCharInfo.Size = New System.Drawing.Size(957, 103)
		Me.GboxCharInfo.TabIndex = 0
		Me.GboxCharInfo.TabStop = False
		Me.GboxCharInfo.Text = "Character Info"
		'
		'LblPlayerName
		'
		Me.LblPlayerName.AutoSize = True
		Me.LblPlayerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblPlayerName.Location = New System.Drawing.Point(845, 42)
		Me.LblPlayerName.Name = "LblPlayerName"
		Me.LblPlayerName.Size = New System.Drawing.Size(67, 13)
		Me.LblPlayerName.TabIndex = 32
		Me.LblPlayerName.Text = "Player Name"
		'
		'LblParagonPath
		'
		Me.LblParagonPath.AutoSize = True
		Me.LblParagonPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblParagonPath.Location = New System.Drawing.Point(482, 42)
		Me.LblParagonPath.Name = "LblParagonPath"
		Me.LblParagonPath.Size = New System.Drawing.Size(72, 13)
		Me.LblParagonPath.TabIndex = 26
		Me.LblParagonPath.Text = "Paragon Path"
		'
		'TxtPlayerName
		'
		Me.TxtPlayerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtPlayerName.Location = New System.Drawing.Point(848, 19)
		Me.TxtPlayerName.Name = "TxtPlayerName"
		Me.TxtPlayerName.Size = New System.Drawing.Size(103, 20)
		Me.TxtPlayerName.TabIndex = 6
		'
		'LblTotalXP
		'
		Me.LblTotalXP.AutoSize = True
		Me.LblTotalXP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblTotalXP.Location = New System.Drawing.Point(767, 42)
		Me.LblTotalXP.Name = "LblTotalXP"
		Me.LblTotalXP.Size = New System.Drawing.Size(48, 13)
		Me.LblTotalXP.TabIndex = 30
		Me.LblTotalXP.Text = "Total XP"
		'
		'LblEpicDestiny
		'
		Me.LblEpicDestiny.AutoSize = True
		Me.LblEpicDestiny.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblEpicDestiny.Location = New System.Drawing.Point(629, 42)
		Me.LblEpicDestiny.Name = "LblEpicDestiny"
		Me.LblEpicDestiny.Size = New System.Drawing.Size(66, 13)
		Me.LblEpicDestiny.TabIndex = 28
		Me.LblEpicDestiny.Text = "Epic Destiny"
		'
		'TxtTotalXP
		'
		Me.TxtTotalXP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtTotalXP.Location = New System.Drawing.Point(770, 19)
		Me.TxtTotalXP.Name = "TxtTotalXP"
		Me.TxtTotalXP.Size = New System.Drawing.Size(72, 20)
		Me.TxtTotalXP.TabIndex = 5
		'
		'TxtEpicDestiny
		'
		Me.TxtEpicDestiny.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtEpicDestiny.Location = New System.Drawing.Point(632, 19)
		Me.TxtEpicDestiny.Name = "TxtEpicDestiny"
		Me.TxtEpicDestiny.Size = New System.Drawing.Size(132, 20)
		Me.TxtEpicDestiny.TabIndex = 4
		'
		'TxtParagonPath
		'
		Me.TxtParagonPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtParagonPath.Location = New System.Drawing.Point(485, 19)
		Me.TxtParagonPath.Name = "TxtParagonPath"
		Me.TxtParagonPath.Size = New System.Drawing.Size(141, 20)
		Me.TxtParagonPath.TabIndex = 3
		'
		'LblClass
		'
		Me.LblClass.AutoSize = True
		Me.LblClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblClass.Location = New System.Drawing.Point(337, 42)
		Me.LblClass.Name = "LblClass"
		Me.LblClass.Size = New System.Drawing.Size(32, 13)
		Me.LblClass.TabIndex = 24
		Me.LblClass.Text = "Class"
		'
		'TxtClass
		'
		Me.TxtClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtClass.Location = New System.Drawing.Point(340, 19)
		Me.TxtClass.Name = "TxtClass"
		Me.TxtClass.Size = New System.Drawing.Size(139, 20)
		Me.TxtClass.TabIndex = 2
		'
		'LblAffiliation
		'
		Me.LblAffiliation.AutoSize = True
		Me.LblAffiliation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblAffiliation.Location = New System.Drawing.Point(713, 85)
		Me.LblAffiliation.Name = "LblAffiliation"
		Me.LblAffiliation.Size = New System.Drawing.Size(49, 13)
		Me.LblAffiliation.TabIndex = 20
		Me.LblAffiliation.Text = "Affiliation"
		'
		'LblDeity
		'
		Me.LblDeity.AutoSize = True
		Me.LblDeity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblDeity.Location = New System.Drawing.Point(607, 85)
		Me.LblDeity.Name = "LblDeity"
		Me.LblDeity.Size = New System.Drawing.Size(31, 13)
		Me.LblDeity.TabIndex = 18
		Me.LblDeity.Text = "Deity"
		'
		'LblLevel
		'
		Me.LblLevel.AutoSize = True
		Me.LblLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblLevel.Location = New System.Drawing.Point(296, 42)
		Me.LblLevel.Name = "LblLevel"
		Me.LblLevel.Size = New System.Drawing.Size(33, 13)
		Me.LblLevel.TabIndex = 22
		Me.LblLevel.Text = "Level"
		'
		'TxtLevel
		'
		Me.TxtLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtLevel.Location = New System.Drawing.Point(299, 19)
		Me.TxtLevel.Name = "TxtLevel"
		Me.TxtLevel.ReadOnly = True
		Me.TxtLevel.Size = New System.Drawing.Size(35, 20)
		Me.TxtLevel.TabIndex = 1
		'
		'LblAlignment
		'
		Me.LblAlignment.AutoSize = True
		Me.LblAlignment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblAlignment.Location = New System.Drawing.Point(445, 85)
		Me.LblAlignment.Name = "LblAlignment"
		Me.LblAlignment.Size = New System.Drawing.Size(53, 13)
		Me.LblAlignment.TabIndex = 14
		Me.LblAlignment.Text = "Alignment"
		'
		'LblWeight
		'
		Me.LblWeight.AutoSize = True
		Me.LblWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblWeight.Location = New System.Drawing.Point(381, 85)
		Me.LblWeight.Name = "LblWeight"
		Me.LblWeight.Size = New System.Drawing.Size(41, 13)
		Me.LblWeight.TabIndex = 13
		Me.LblWeight.Text = "Weight"
		'
		'LblHeight
		'
		Me.LblHeight.AutoSize = True
		Me.LblHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblHeight.Location = New System.Drawing.Point(317, 85)
		Me.LblHeight.Name = "LblHeight"
		Me.LblHeight.Size = New System.Drawing.Size(38, 13)
		Me.LblHeight.TabIndex = 11
		Me.LblHeight.Text = "Height"
		'
		'LblGender
		'
		Me.LblGender.AutoSize = True
		Me.LblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblGender.Location = New System.Drawing.Point(253, 85)
		Me.LblGender.Name = "LblGender"
		Me.LblGender.Size = New System.Drawing.Size(42, 13)
		Me.LblGender.TabIndex = 8
		Me.LblGender.Text = "Gender"
		'
		'LblAge
		'
		Me.LblAge.AutoSize = True
		Me.LblAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblAge.Location = New System.Drawing.Point(197, 85)
		Me.LblAge.Name = "LblAge"
		Me.LblAge.Size = New System.Drawing.Size(26, 13)
		Me.LblAge.TabIndex = 7
		Me.LblAge.Text = "Age"
		'
		'LblSize
		'
		Me.LblSize.AutoSize = True
		Me.LblSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblSize.Location = New System.Drawing.Point(139, 85)
		Me.LblSize.Name = "LblSize"
		Me.LblSize.Size = New System.Drawing.Size(27, 13)
		Me.LblSize.TabIndex = 5
		Me.LblSize.Text = "Size"
		'
		'LblRace
		'
		Me.LblRace.AutoSize = True
		Me.LblRace.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblRace.Location = New System.Drawing.Point(10, 85)
		Me.LblRace.Name = "LblRace"
		Me.LblRace.Size = New System.Drawing.Size(33, 13)
		Me.LblRace.TabIndex = 3
		Me.LblRace.Text = "Race"
		'
		'TxtSize
		'
		Me.TxtSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtSize.Location = New System.Drawing.Point(142, 62)
		Me.TxtSize.Name = "TxtSize"
		Me.TxtSize.Size = New System.Drawing.Size(52, 20)
		Me.TxtSize.TabIndex = 7
		'
		'TxtAffiliation
		'
		Me.TxtAffiliation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtAffiliation.Location = New System.Drawing.Point(716, 62)
		Me.TxtAffiliation.Name = "TxtAffiliation"
		Me.TxtAffiliation.Size = New System.Drawing.Size(235, 20)
		Me.TxtAffiliation.TabIndex = 15
		'
		'CmbAlignment2
		'
		Me.CmbAlignment2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CmbAlignment2.FormattingEnabled = True
		Me.CmbAlignment2.Items.AddRange(New Object() {"Good", "Neutral", "Evil"})
		Me.CmbAlignment2.Location = New System.Drawing.Point(529, 62)
		Me.CmbAlignment2.MaxDropDownItems = 2
		Me.CmbAlignment2.Name = "CmbAlignment2"
		Me.CmbAlignment2.Size = New System.Drawing.Size(75, 21)
		Me.CmbAlignment2.TabIndex = 13
		'
		'LblName
		'
		Me.LblName.AutoSize = True
		Me.LblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblName.Location = New System.Drawing.Point(9, 26)
		Me.LblName.Name = "LblName"
		Me.LblName.Size = New System.Drawing.Size(51, 20)
		Me.LblName.TabIndex = 1
		Me.LblName.Text = "Name"
		'
		'CmbGender
		'
		Me.CmbGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CmbGender.FormattingEnabled = True
		Me.CmbGender.Items.AddRange(New Object() {"Male", "Female"})
		Me.CmbGender.Location = New System.Drawing.Point(256, 62)
		Me.CmbGender.MaxDropDownItems = 2
		Me.CmbGender.Name = "CmbGender"
		Me.CmbGender.Size = New System.Drawing.Size(60, 21)
		Me.CmbGender.TabIndex = 9
		'
		'CmbAlignment1
		'
		Me.CmbAlignment1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CmbAlignment1.FormattingEnabled = True
		Me.CmbAlignment1.Items.AddRange(New Object() {"Lawful", "Neutral", "Chaotic"})
		Me.CmbAlignment1.Location = New System.Drawing.Point(448, 62)
		Me.CmbAlignment1.MaxDropDownItems = 2
		Me.CmbAlignment1.Name = "CmbAlignment1"
		Me.CmbAlignment1.Size = New System.Drawing.Size(75, 21)
		Me.CmbAlignment1.TabIndex = 12
		'
		'TxtRace
		'
		Me.TxtRace.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtRace.Location = New System.Drawing.Point(13, 62)
		Me.TxtRace.Name = "TxtRace"
		Me.TxtRace.Size = New System.Drawing.Size(123, 20)
		Me.TxtRace.TabIndex = 6
		'
		'TxtAge
		'
		Me.TxtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtAge.Location = New System.Drawing.Point(200, 62)
		Me.TxtAge.Name = "TxtAge"
		Me.TxtAge.Size = New System.Drawing.Size(50, 20)
		Me.TxtAge.TabIndex = 8
		'
		'TxtWeight
		'
		Me.TxtWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtWeight.Location = New System.Drawing.Point(384, 62)
		Me.TxtWeight.Name = "TxtWeight"
		Me.TxtWeight.Size = New System.Drawing.Size(58, 20)
		Me.TxtWeight.TabIndex = 11
		'
		'TxtHeight
		'
		Me.TxtHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtHeight.Location = New System.Drawing.Point(320, 62)
		Me.TxtHeight.Name = "TxtHeight"
		Me.TxtHeight.Size = New System.Drawing.Size(58, 20)
		Me.TxtHeight.TabIndex = 10
		'
		'TxtDeity
		'
		Me.TxtDeity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtDeity.Location = New System.Drawing.Point(610, 62)
		Me.TxtDeity.Name = "TxtDeity"
		Me.TxtDeity.Size = New System.Drawing.Size(100, 20)
		Me.TxtDeity.TabIndex = 14
		'
		'TxtCharacterName
		'
		Me.TxtCharacterName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtCharacterName.Location = New System.Drawing.Point(66, 19)
		Me.TxtCharacterName.Name = "TxtCharacterName"
		Me.TxtCharacterName.Size = New System.Drawing.Size(227, 32)
		Me.TxtCharacterName.TabIndex = 0
		'
		'GBoxSenses
		'
		Me.GBoxSenses.Dock = System.Windows.Forms.DockStyle.Fill
		Me.GBoxSenses.Location = New System.Drawing.Point(644, 177)
		Me.GBoxSenses.Name = "GBoxSenses"
		Me.GBoxSenses.Size = New System.Drawing.Size(316, 174)
		Me.GBoxSenses.TabIndex = 5
		Me.GBoxSenses.TabStop = False
		Me.GBoxSenses.Text = "Senses"
		'
		'GBoxOptions
		'
		Me.GBoxOptions.Dock = System.Windows.Forms.DockStyle.Fill
		Me.GBoxOptions.Location = New System.Drawing.Point(644, 357)
		Me.GBoxOptions.Name = "GBoxOptions"
		Me.GBoxOptions.Size = New System.Drawing.Size(316, 176)
		Me.GBoxOptions.TabIndex = 6
		Me.GBoxOptions.TabStop = False
		Me.GBoxOptions.Text = "Options"
		'
		'TabPageCombat
		'
		Me.TabPageCombat.Controls.Add(Me.TblCombat)
		Me.TabPageCombat.Location = New System.Drawing.Point(4, 22)
		Me.TabPageCombat.Name = "TabPageCombat"
		Me.TabPageCombat.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPageCombat.Size = New System.Drawing.Size(969, 542)
		Me.TabPageCombat.TabIndex = 1
		Me.TabPageCombat.Text = "Combat"
		Me.TabPageCombat.UseVisualStyleBackColor = True
		'
		'TblCombat
		'
		Me.TblCombat.ColumnCount = 2
		Me.TblCombat.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TblCombat.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TblCombat.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TblCombat.Location = New System.Drawing.Point(3, 3)
		Me.TblCombat.Name = "TblCombat"
		Me.TblCombat.RowCount = 2
		Me.TblCombat.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TblCombat.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TblCombat.Size = New System.Drawing.Size(963, 536)
		Me.TblCombat.TabIndex = 0
		'
		'SaveFileDialog1
		'
		Me.SaveFileDialog1.DefaultExt = "dmc"
		Me.SaveFileDialog1.Filter = "DMC files|*.dmc"
		'
		'OpenFileDialog1
		'
		Me.OpenFileDialog1.FileName = "OpenFileDialog1"
		Me.OpenFileDialog1.Filter = "DMC Files|*.dmc"
		'
		'MenuStrip1
		'
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(977, 24)
		Me.MenuStrip1.TabIndex = 1
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'FileToolStripMenuItem
		'
		Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
		Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
		Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
		Me.FileToolStripMenuItem.Text = "File"
		'
		'NewToolStripMenuItem
		'
		Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
		Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
		Me.NewToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
		Me.NewToolStripMenuItem.Text = "New"
		'
		'OpenToolStripMenuItem
		'
		Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
		Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
		Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
		Me.OpenToolStripMenuItem.Text = "Open"
		'
		'SaveToolStripMenuItem
		'
		Me.SaveToolStripMenuItem.Enabled = False
		Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
		Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
		Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
		Me.SaveToolStripMenuItem.Text = "Save"
		'
		'SaveAsToolStripMenuItem
		'
		Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
		Me.SaveAsToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
			Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
		Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
		Me.SaveAsToolStripMenuItem.Text = "Save As"
		'
		'ToolStripMenuItem1
		'
		Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
		Me.ToolStripMenuItem1.Size = New System.Drawing.Size(183, 6)
		'
		'ExitToolStripMenuItem
		'
		Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
		Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
		Me.ExitToolStripMenuItem.Text = "Exit"
		'
		'CharacterSheet
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(977, 592)
		Me.Controls.Add(Me.TabControl)
		Me.Controls.Add(Me.MenuStrip1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Name = "CharacterSheet"
		Me.Text = "DM Manager: Character Sheet"
		Me.TabControl.ResumeLayout(False)
		Me.TabPageBasicInfo.ResumeLayout(False)
		Me.TblBasicInfo.ResumeLayout(False)
		Me.GBoxAbilities.ResumeLayout(False)
		Me.GBoxAbilities.PerformLayout()
		Me.GboxCharInfo.ResumeLayout(False)
		Me.GboxCharInfo.PerformLayout()
		Me.TabPageCombat.ResumeLayout(False)
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents TabControl As System.Windows.Forms.TabControl
	Friend WithEvents TabPageBasicInfo As System.Windows.Forms.TabPage
	Friend WithEvents TabPageCombat As System.Windows.Forms.TabPage
	Friend WithEvents TblBasicInfo As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents GBoxDefenses As System.Windows.Forms.GroupBox
	Friend WithEvents GBoxMovement As System.Windows.Forms.GroupBox
	Friend WithEvents GBoxInitiative As System.Windows.Forms.GroupBox
	Friend WithEvents GBoxAbilities As System.Windows.Forms.GroupBox
	Friend WithEvents GboxCharInfo As System.Windows.Forms.GroupBox
	Friend WithEvents GBoxSenses As System.Windows.Forms.GroupBox
	Friend WithEvents GBoxOptions As System.Windows.Forms.GroupBox
	Friend WithEvents TblCombat As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents CmbGender As System.Windows.Forms.ComboBox
	Friend WithEvents LblGender As System.Windows.Forms.Label
	Friend WithEvents LblAge As System.Windows.Forms.Label
	Friend WithEvents TxtAge As System.Windows.Forms.TextBox
	Friend WithEvents LblSize As System.Windows.Forms.Label
	Friend WithEvents TxtSize As System.Windows.Forms.TextBox
	Friend WithEvents LblRace As System.Windows.Forms.Label
	Friend WithEvents TxtRace As System.Windows.Forms.TextBox
	Friend WithEvents LblName As System.Windows.Forms.Label
	Friend WithEvents TxtCharacterName As System.Windows.Forms.TextBox
	Friend WithEvents LblHeight As System.Windows.Forms.Label
	Friend WithEvents TxtHeight As System.Windows.Forms.TextBox
	Friend WithEvents CmbAlignment2 As System.Windows.Forms.ComboBox
	Friend WithEvents CmbAlignment1 As System.Windows.Forms.ComboBox
	Friend WithEvents LblAlignment As System.Windows.Forms.Label
	Friend WithEvents LblWeight As System.Windows.Forms.Label
	Friend WithEvents TxtWeight As System.Windows.Forms.TextBox
	Friend WithEvents LblLevel As System.Windows.Forms.Label
	Friend WithEvents TxtLevel As System.Windows.Forms.TextBox
	Friend WithEvents LblAffiliation As System.Windows.Forms.Label
	Friend WithEvents TxtAffiliation As System.Windows.Forms.TextBox
	Friend WithEvents LblDeity As System.Windows.Forms.Label
	Friend WithEvents TxtDeity As System.Windows.Forms.TextBox
	Friend WithEvents LblClass As System.Windows.Forms.Label
	Friend WithEvents TxtClass As System.Windows.Forms.TextBox
	Friend WithEvents LblParagonPath As System.Windows.Forms.Label
	Friend WithEvents TxtParagonPath As System.Windows.Forms.TextBox
	Friend WithEvents TxtTotalXP As System.Windows.Forms.TextBox
	Friend WithEvents LblTotalXP As System.Windows.Forms.Label
	Friend WithEvents LblEpicDestiny As System.Windows.Forms.Label
	Friend WithEvents TxtEpicDestiny As System.Windows.Forms.TextBox
	Friend WithEvents TxtPlayerName As System.Windows.Forms.TextBox
	Friend WithEvents LblPlayerName As System.Windows.Forms.Label
	Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
	Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
	Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
	Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents LblAbilCha As System.Windows.Forms.Label
	Friend WithEvents LblAbilWis As System.Windows.Forms.Label
	Friend WithEvents LblAbilInt As System.Windows.Forms.Label
	Friend WithEvents LblAbilDex As System.Windows.Forms.Label
	Friend WithEvents LblAbilCon As System.Windows.Forms.Label
	Friend WithEvents LblAbilStr As System.Windows.Forms.Label
	Friend WithEvents TxtAbilScoreCha As System.Windows.Forms.TextBox
	Friend WithEvents TxtAbilScoreWis As System.Windows.Forms.TextBox
	Friend WithEvents TxtAbilScoreInt As System.Windows.Forms.TextBox
	Friend WithEvents TxtAbilScoreDex As System.Windows.Forms.TextBox
	Friend WithEvents TxtAbilScoreCon As System.Windows.Forms.TextBox
	Friend WithEvents TxtAbilScoreStr As System.Windows.Forms.TextBox
	Friend WithEvents LblAbilityScore As System.Windows.Forms.Label
	Friend WithEvents LblAbility As System.Windows.Forms.Label
	Friend WithEvents TxtAbilPlusCha As System.Windows.Forms.TextBox
	Friend WithEvents TxtAbilPlusWis As System.Windows.Forms.TextBox
	Friend WithEvents TxtAbilPlusInt As System.Windows.Forms.TextBox
	Friend WithEvents TxtAbilPlusDex As System.Windows.Forms.TextBox
	Friend WithEvents TxtAbilPlusCon As System.Windows.Forms.TextBox
	Friend WithEvents TxtAbilPlusStr As System.Windows.Forms.TextBox
	Friend WithEvents TxtAbilModCha As System.Windows.Forms.TextBox
	Friend WithEvents TxtAbilModWis As System.Windows.Forms.TextBox
	Friend WithEvents TxtAbilModInt As System.Windows.Forms.TextBox
	Friend WithEvents TxtAbilModDex As System.Windows.Forms.TextBox
	Friend WithEvents TxtAbilModCon As System.Windows.Forms.TextBox
	Friend WithEvents TxtAbilModStr As System.Windows.Forms.TextBox

End Class
