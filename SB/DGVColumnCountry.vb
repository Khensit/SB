Public Class DGVColumnCountry
    Inherits DGVColumnText

    Private Class DatagirdViewCountryCell
        Inherits DataGridViewTextBoxCell

        Protected Overrides Sub Paint(graphics As Graphics,
                                      clipBounds As Rectangle,
                                      cellBounds As Rectangle,
                                      rowIndex As Integer,
                                      cellState As DataGridViewElementStates,
                                      value As Object,
                                      formattedValue As Object,
                                      errorText As String,
                                      cellStyle As DataGridViewCellStyle,
                                      advancedBorderStyle As DataGridViewAdvancedBorderStyle,
                                      paintParts As DataGridViewPaintParts)

            Try
                Dim country As Country = Country.getCountry(CType(value, Country.ID))
                Dim rect As New RectangleF(cellBounds.X, cellBounds.Y, cellBounds.Height, cellBounds.Height)

                graphics.FillRectangle(Brushes.Black, rect)
                cellBounds.X += rect.Width
                formattedValue = country.Name

            Catch e As InvalidCastException
                formattedValue = "Invalid cast"
            End Try

            MyBase.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts)

        End Sub

    End Class

    Public Sub New()
        Me.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ReadOnly = True
        Me.Resizable = System.Windows.Forms.DataGridViewTriState.[False]

        CellTemplate = New DatagirdViewCountryCell()

    End Sub

End Class