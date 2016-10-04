<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.mainNextButton = New System.Windows.Forms.Button()
        Me.mainPrevButton = New System.Windows.Forms.Button()
        Me.startPanel = New System.Windows.Forms.Panel()
        Me.startTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.startCreateButton = New System.Windows.Forms.Button()
        Me.startLoadButton = New System.Windows.Forms.Button()
        Me.cfgSingerPanel = New System.Windows.Forms.Panel()
        Me.cfgSingerAddButton = New System.Windows.Forms.Button()
        Me.cfgSingerDataGridView = New System.Windows.Forms.DataGridView()
        Me.cfgJurorPanel = New System.Windows.Forms.Panel()
        Me.cfgJurorDataGridView = New System.Windows.Forms.DataGridView()
        Me.cfgJurorAddButton = New System.Windows.Forms.Button()
        Me.jurorNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jurorCountryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jurorWeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JurorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.singerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.singerSongDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.singerCountryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SingerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.startPanel.SuspendLayout()
        Me.startTableLayoutPanel.SuspendLayout()
        Me.cfgSingerPanel.SuspendLayout()
        CType(Me.cfgSingerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cfgJurorPanel.SuspendLayout()
        CType(Me.cfgJurorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JurorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SingerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainNextButton
        '
        Me.mainNextButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mainNextButton.Location = New System.Drawing.Point(397, 276)
        Me.mainNextButton.Name = "mainNextButton"
        Me.mainNextButton.Size = New System.Drawing.Size(75, 23)
        Me.mainNextButton.TabIndex = 1
        Me.mainNextButton.Text = "Next"
        Me.mainNextButton.UseVisualStyleBackColor = True
        '
        'mainPrevButton
        '
        Me.mainPrevButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.mainPrevButton.Location = New System.Drawing.Point(12, 276)
        Me.mainPrevButton.Name = "mainPrevButton"
        Me.mainPrevButton.Size = New System.Drawing.Size(75, 23)
        Me.mainPrevButton.TabIndex = 2
        Me.mainPrevButton.Text = "Previous"
        Me.mainPrevButton.UseVisualStyleBackColor = True
        '
        'startPanel
        '
        Me.startPanel.Controls.Add(Me.startTableLayoutPanel)
        Me.startPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.startPanel.Location = New System.Drawing.Point(0, 0)
        Me.startPanel.Name = "startPanel"
        Me.startPanel.Size = New System.Drawing.Size(484, 311)
        Me.startPanel.TabIndex = 3
        '
        'startTableLayoutPanel
        '
        Me.startTableLayoutPanel.ColumnCount = 4
        Me.startTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.startTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.startTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.startTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.startTableLayoutPanel.Controls.Add(Me.startCreateButton, 1, 1)
        Me.startTableLayoutPanel.Controls.Add(Me.startLoadButton, 1, 3)
        Me.startTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.startTableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.startTableLayoutPanel.Name = "startTableLayoutPanel"
        Me.startTableLayoutPanel.RowCount = 5
        Me.startTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.startTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.startTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.startTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.startTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.startTableLayoutPanel.Size = New System.Drawing.Size(484, 311)
        Me.startTableLayoutPanel.TabIndex = 0
        '
        'startCreateButton
        '
        Me.startTableLayoutPanel.SetColumnSpan(Me.startCreateButton, 2)
        Me.startCreateButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.startCreateButton.Location = New System.Drawing.Point(124, 65)
        Me.startCreateButton.Name = "startCreateButton"
        Me.startCreateButton.Size = New System.Drawing.Size(236, 56)
        Me.startCreateButton.TabIndex = 0
        Me.startCreateButton.Text = "Create Configuration"
        Me.startCreateButton.UseVisualStyleBackColor = True
        '
        'startLoadButton
        '
        Me.startTableLayoutPanel.SetColumnSpan(Me.startLoadButton, 2)
        Me.startLoadButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.startLoadButton.Location = New System.Drawing.Point(124, 189)
        Me.startLoadButton.Name = "startLoadButton"
        Me.startLoadButton.Size = New System.Drawing.Size(236, 56)
        Me.startLoadButton.TabIndex = 1
        Me.startLoadButton.Text = "Load Configuration File"
        Me.startLoadButton.UseVisualStyleBackColor = True
        '
        'cfgSingerPanel
        '
        Me.cfgSingerPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cfgSingerPanel.Controls.Add(Me.cfgSingerAddButton)
        Me.cfgSingerPanel.Controls.Add(Me.cfgSingerDataGridView)
        Me.cfgSingerPanel.Location = New System.Drawing.Point(0, 0)
        Me.cfgSingerPanel.Name = "cfgSingerPanel"
        Me.cfgSingerPanel.Size = New System.Drawing.Size(484, 270)
        Me.cfgSingerPanel.TabIndex = 2
        Me.cfgSingerPanel.Visible = False
        '
        'cfgSingerAddButton
        '
        Me.cfgSingerAddButton.Location = New System.Drawing.Point(12, 12)
        Me.cfgSingerAddButton.Name = "cfgSingerAddButton"
        Me.cfgSingerAddButton.Size = New System.Drawing.Size(104, 23)
        Me.cfgSingerAddButton.TabIndex = 1
        Me.cfgSingerAddButton.Text = "Add new singer"
        Me.cfgSingerAddButton.UseVisualStyleBackColor = True
        '
        'cfgSingerDataGridView
        '
        Me.cfgSingerDataGridView.AllowUserToAddRows = False
        Me.cfgSingerDataGridView.AllowUserToDeleteRows = False
        Me.cfgSingerDataGridView.AllowUserToResizeColumns = False
        Me.cfgSingerDataGridView.AllowUserToResizeRows = False
        Me.cfgSingerDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cfgSingerDataGridView.AutoGenerateColumns = False
        Me.cfgSingerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.cfgSingerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.singerNameDataGridViewTextBoxColumn, Me.singerSongDataGridViewTextBoxColumn, Me.singerCountryDataGridViewTextBoxColumn})
        Me.cfgSingerDataGridView.DataSource = Me.SingerBindingSource
        Me.cfgSingerDataGridView.Location = New System.Drawing.Point(0, 41)
        Me.cfgSingerDataGridView.MultiSelect = False
        Me.cfgSingerDataGridView.Name = "cfgSingerDataGridView"
        Me.cfgSingerDataGridView.ReadOnly = True
        Me.cfgSingerDataGridView.RowHeadersVisible = False
        Me.cfgSingerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.cfgSingerDataGridView.Size = New System.Drawing.Size(484, 229)
        Me.cfgSingerDataGridView.TabIndex = 0
        '
        'cfgJurorPanel
        '
        Me.cfgJurorPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cfgJurorPanel.Controls.Add(Me.cfgJurorDataGridView)
        Me.cfgJurorPanel.Controls.Add(Me.cfgJurorAddButton)
        Me.cfgJurorPanel.Location = New System.Drawing.Point(0, 0)
        Me.cfgJurorPanel.Name = "cfgJurorPanel"
        Me.cfgJurorPanel.Size = New System.Drawing.Size(484, 270)
        Me.cfgJurorPanel.TabIndex = 2
        Me.cfgJurorPanel.Visible = False
        '
        'cfgJurorDataGridView
        '
        Me.cfgJurorDataGridView.AllowUserToAddRows = False
        Me.cfgJurorDataGridView.AllowUserToDeleteRows = False
        Me.cfgJurorDataGridView.AllowUserToResizeColumns = False
        Me.cfgJurorDataGridView.AllowUserToResizeRows = False
        Me.cfgJurorDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cfgJurorDataGridView.AutoGenerateColumns = False
        Me.cfgJurorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.cfgJurorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.jurorNameDataGridViewTextBoxColumn, Me.jurorCountryDataGridViewTextBoxColumn, Me.jurorWeightDataGridViewTextBoxColumn})
        Me.cfgJurorDataGridView.DataSource = Me.JurorBindingSource
        Me.cfgJurorDataGridView.Location = New System.Drawing.Point(0, 41)
        Me.cfgJurorDataGridView.MultiSelect = False
        Me.cfgJurorDataGridView.Name = "cfgJurorDataGridView"
        Me.cfgJurorDataGridView.ReadOnly = True
        Me.cfgJurorDataGridView.RowHeadersVisible = False
        Me.cfgJurorDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.cfgJurorDataGridView.Size = New System.Drawing.Size(484, 229)
        Me.cfgJurorDataGridView.TabIndex = 1
        '
        'cfgJurorAddButton
        '
        Me.cfgJurorAddButton.Location = New System.Drawing.Point(12, 12)
        Me.cfgJurorAddButton.Name = "cfgJurorAddButton"
        Me.cfgJurorAddButton.Size = New System.Drawing.Size(104, 23)
        Me.cfgJurorAddButton.TabIndex = 0
        Me.cfgJurorAddButton.Text = "Add new juror"
        Me.cfgJurorAddButton.UseVisualStyleBackColor = True
        '
        'jurorNameDataGridViewTextBoxColumn
        '
        Me.jurorNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.jurorNameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.jurorNameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.jurorNameDataGridViewTextBoxColumn.Name = "jurorNameDataGridViewTextBoxColumn"
        Me.jurorNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.jurorNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.jurorNameDataGridViewTextBoxColumn.Width = 60
        '
        'jurorCountryDataGridViewTextBoxColumn
        '
        Me.jurorCountryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.jurorCountryDataGridViewTextBoxColumn.DataPropertyName = "Country"
        Me.jurorCountryDataGridViewTextBoxColumn.HeaderText = "Country"
        Me.jurorCountryDataGridViewTextBoxColumn.Name = "jurorCountryDataGridViewTextBoxColumn"
        Me.jurorCountryDataGridViewTextBoxColumn.ReadOnly = True
        Me.jurorCountryDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.jurorCountryDataGridViewTextBoxColumn.Width = 68
        '
        'jurorWeightDataGridViewTextBoxColumn
        '
        Me.jurorWeightDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.jurorWeightDataGridViewTextBoxColumn.DataPropertyName = "Weight"
        Me.jurorWeightDataGridViewTextBoxColumn.HeaderText = "Weight"
        Me.jurorWeightDataGridViewTextBoxColumn.Name = "jurorWeightDataGridViewTextBoxColumn"
        Me.jurorWeightDataGridViewTextBoxColumn.ReadOnly = True
        Me.jurorWeightDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.jurorWeightDataGridViewTextBoxColumn.Width = 66
        '
        'JurorBindingSource
        '
        Me.JurorBindingSource.DataSource = GetType(SB.Juror)
        '
        'singerNameDataGridViewTextBoxColumn
        '
        Me.singerNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.singerNameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.singerNameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.singerNameDataGridViewTextBoxColumn.Name = "singerNameDataGridViewTextBoxColumn"
        Me.singerNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.singerNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.singerNameDataGridViewTextBoxColumn.Width = 60
        '
        'singerSongDataGridViewTextBoxColumn
        '
        Me.singerSongDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.singerSongDataGridViewTextBoxColumn.DataPropertyName = "Song"
        Me.singerSongDataGridViewTextBoxColumn.HeaderText = "Song"
        Me.singerSongDataGridViewTextBoxColumn.Name = "singerSongDataGridViewTextBoxColumn"
        Me.singerSongDataGridViewTextBoxColumn.ReadOnly = True
        Me.singerSongDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.singerSongDataGridViewTextBoxColumn.Width = 57
        '
        'singerCountryDataGridViewTextBoxColumn
        '
        Me.singerCountryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.singerCountryDataGridViewTextBoxColumn.DataPropertyName = "Country"
        Me.singerCountryDataGridViewTextBoxColumn.HeaderText = "Country"
        Me.singerCountryDataGridViewTextBoxColumn.Name = "singerCountryDataGridViewTextBoxColumn"
        Me.singerCountryDataGridViewTextBoxColumn.ReadOnly = True
        Me.singerCountryDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.singerCountryDataGridViewTextBoxColumn.Width = 68
        '
        'SingerBindingSource
        '
        Me.SingerBindingSource.DataSource = GetType(SB.Singer)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 311)
        Me.Controls.Add(Me.cfgJurorPanel)
        Me.Controls.Add(Me.cfgSingerPanel)
        Me.Controls.Add(Me.startPanel)
        Me.Controls.Add(Me.mainNextButton)
        Me.Controls.Add(Me.mainPrevButton)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Scoreboard"
        Me.startPanel.ResumeLayout(False)
        Me.startTableLayoutPanel.ResumeLayout(False)
        Me.cfgSingerPanel.ResumeLayout(False)
        CType(Me.cfgSingerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cfgJurorPanel.ResumeLayout(False)
        CType(Me.cfgJurorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JurorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SingerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mainNextButton As Button
    Friend WithEvents mainPrevButton As Button
    Friend WithEvents startPanel As Panel
    Friend WithEvents startTableLayoutPanel As TableLayoutPanel
    Friend WithEvents startCreateButton As Button
    Friend WithEvents startLoadButton As Button
    Friend WithEvents cfgSingerPanel As Panel
    Friend WithEvents cfgSingerAddButton As Button
    Friend WithEvents cfgSingerDataGridView As DataGridView
    Friend WithEvents singerNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents singerSongDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents singerCountryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents cfgJurorPanel As Panel
    Friend WithEvents cfgJurorDataGridView As DataGridView
    Friend WithEvents cfgJurorAddButton As Button
    Friend WithEvents SingerBindingSource As BindingSource
    Friend WithEvents JurorBindingSource As BindingSource
    Friend WithEvents jurorNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents jurorCountryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents jurorWeightDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
