Public Class DGVColumnText
    Inherits DataGridViewTextBoxColumn

    Public Sub New()
        Me.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ReadOnly = True
        Me.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
    End Sub

End Class
