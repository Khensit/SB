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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.mainNextButton = New System.Windows.Forms.Button()
        Me.mainPrevButton = New System.Windows.Forms.Button()
        Me.startPanel = New System.Windows.Forms.Panel()
        Me.startTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.startCreateButton = New System.Windows.Forms.Button()
        Me.startLoadButton = New System.Windows.Forms.Button()
        Me.cfgSingerPanel = New System.Windows.Forms.Panel()
        Me.cfgSingerAddButton = New System.Windows.Forms.Button()
        Me.cfgSingerDataGridView = New System.Windows.Forms.DataGridView()
        Me.CSingerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SingerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SingerSongDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SingerCountryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.startPanel.SuspendLayout()
        Me.startTableLayoutPanel.SuspendLayout()
        Me.cfgSingerPanel.SuspendLayout()
        CType(Me.cfgSingerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CSingerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cfgSingerDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.cfgSingerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.cfgSingerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SingerNameDataGridViewTextBoxColumn, Me.SingerSongDataGridViewTextBoxColumn, Me.SingerCountryDataGridViewTextBoxColumn})
        Me.cfgSingerDataGridView.DataSource = Me.CSingerBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.cfgSingerDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.cfgSingerDataGridView.Location = New System.Drawing.Point(0, 41)
        Me.cfgSingerDataGridView.MultiSelect = False
        Me.cfgSingerDataGridView.Name = "cfgSingerDataGridView"
        Me.cfgSingerDataGridView.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cfgSingerDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.cfgSingerDataGridView.RowHeadersVisible = False
        Me.cfgSingerDataGridView.Size = New System.Drawing.Size(484, 229)
        Me.cfgSingerDataGridView.TabIndex = 0
        '
        'CSingerBindingSource
        '
        Me.CSingerBindingSource.DataSource = GetType(SB.Singer)
        '
        'SingerNameDataGridViewTextBoxColumn
        '
        Me.SingerNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SingerNameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.SingerNameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.SingerNameDataGridViewTextBoxColumn.Name = "SingerNameDataGridViewTextBoxColumn"
        Me.SingerNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.SingerNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SingerNameDataGridViewTextBoxColumn.Width = 60
        '
        'SingerSongDataGridViewTextBoxColumn
        '
        Me.SingerSongDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SingerSongDataGridViewTextBoxColumn.DataPropertyName = "Song"
        Me.SingerSongDataGridViewTextBoxColumn.HeaderText = "Song"
        Me.SingerSongDataGridViewTextBoxColumn.Name = "SingerSongDataGridViewTextBoxColumn"
        Me.SingerSongDataGridViewTextBoxColumn.ReadOnly = True
        Me.SingerSongDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SingerSongDataGridViewTextBoxColumn.Width = 57
        '
        'SingerCountryDataGridViewTextBoxColumn
        '
        Me.SingerCountryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SingerCountryDataGridViewTextBoxColumn.DataPropertyName = "Country"
        Me.SingerCountryDataGridViewTextBoxColumn.HeaderText = "Country"
        Me.SingerCountryDataGridViewTextBoxColumn.Name = "SingerCountryDataGridViewTextBoxColumn"
        Me.SingerCountryDataGridViewTextBoxColumn.ReadOnly = True
        Me.SingerCountryDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SingerCountryDataGridViewTextBoxColumn.Width = 68
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 311)
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
        CType(Me.CSingerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents CSingerBindingSource As BindingSource
    Friend WithEvents SingerNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SingerSongDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SingerCountryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
