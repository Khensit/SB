Public Class CfgSingerImpl
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
    Private mSongColumn As DGVColumnText
    Private mCountryColumn As DGVColumnCountry

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

        mSongColumn = New DGVColumnText
        mSongColumn.DataPropertyName = "Song"
        mSongColumn.HeaderText = "Song"
        mSongColumn.Name = "Song"

        mCountryColumn = New DGVColumnCountry
        mCountryColumn.DataPropertyName = "Country"
        mCountryColumn.HeaderText = "Country"
        mCountryColumn.Name = "Country"

        mData.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {mNameColumn, mSongColumn, mCountryColumn})
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
            mData.Grid.DataSource = mData.sharedData.Singers
        End If
    End Sub

End Class
