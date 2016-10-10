Public Class CfgPointsImpl
    Inherits SequencePanel

    Public Structure Data
        Dim Panel As System.Windows.Forms.Panel
        Dim Grid As System.Windows.Forms.DataGridView

        Dim sharedData As SharedData
    End Structure

    Private mData As Data
    Private mBindingSource As System.Windows.Forms.BindingSource
    Private mPointsColumn As DGVColumnNumber

    Public Sub New(ByRef data As Data)
        MyBase.New(data.Panel)
        mData = data

        Debug.Assert(Not IsNothing(data.Grid))

        mBindingSource = New System.Windows.Forms.BindingSource()
        mBindingSource.DataSource = GetType(SB.Points)

        mPointsColumn = New DGVColumnNumber
        mPointsColumn.DataPropertyName = "Value"
        mPointsColumn.HeaderText = "Points"
        mPointsColumn.Name = "Points"

        mData.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {mPointsColumn})
        mData.Grid.DataSource = mBindingSource

        AddHandler VisibilityChanged, AddressOf OnVisibilityChangedImpl
    End Sub

    Private Sub OnVisibilityChangedImpl(visible As Boolean)
        If visible Then
            Dim capacity As Integer = mData.sharedData.Singers.Count
            Dim count As Integer = mData.sharedData.Points.Count

            If count > capacity Then
                mData.sharedData.Points.RemoveRange(count, count - capacity)
            End If

            If count < capacity Then
                For i As Integer = count To capacity - 1
                    mData.sharedData.Points.Add(New Points)
                Next
            End If

            mData.Grid.DataSource = mData.sharedData.Points
            End If
    End Sub

End Class
