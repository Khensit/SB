Public Class CfgJurorImpl
    Inherits SequencePanel

    Public Structure Data
        Dim Panel As System.Windows.Forms.Panel
        Dim Add As System.Windows.Forms.Button
        Dim Grid As System.Windows.Forms.DataGridView

        Dim sharedData As SharedData
    End Structure

    Private mData As Data
    Private mBindingSource As System.Windows.Forms.BindingSource
    Private mNameColumn As DGVColumnText
    Private mCountryColumn As DGVColumnCountry
    Private mPreviewColumn As DGVColumnNumber
    Private mWeightColumn As DGVColumnNumber

    Public Sub New(ByRef data As Data)
        MyBase.New(data.Panel)
        mData = data

        Debug.Assert(Not IsNothing(data.Add))
        Debug.Assert(Not IsNothing(data.Grid))

        mBindingSource = New System.Windows.Forms.BindingSource()
        mBindingSource.DataSource = GetType(SB.Singer)

        mNameColumn = New DGVColumnText
        mNameColumn.DataPropertyName = "Name"
        mNameColumn.HeaderText = "Name"
        mNameColumn.Name = "Name"

        mCountryColumn = New DGVColumnCountry
        mCountryColumn.DataPropertyName = "Country"
        mCountryColumn.HeaderText = "Country"
        mCountryColumn.Name = "Country"

        mPreviewColumn = New DGVColumnNumber
        mPreviewColumn.DataPropertyName = "Preview"
        mPreviewColumn.HeaderText = "Preview"
        mPreviewColumn.Name = "Preview"

        mWeightColumn = New DGVColumnNumber
        mWeightColumn.DataPropertyName = "Weight"
        mWeightColumn.HeaderText = "Weight"
        mWeightColumn.Name = "Weight"

        mData.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {mNameColumn, mCountryColumn, mPreviewColumn, mWeightColumn})
        mData.Grid.DataSource = mBindingSource

        AddHandler data.Add.Click, AddressOf onClick
        AddHandler VisibilityChanged, AddressOf OnVisibilityChangedImpl
    End Sub

    Private Sub onClick(sender As Object, e As EventArgs)
        If sender Is mData.Add Then
        End If
    End Sub

    Private Sub OnVisibilityChangedImpl(visible As Boolean)
        If visible Then
            mData.Grid.DataSource = mData.sharedData.Jury
        End If
    End Sub

End Class
