Imports System.Data.SqlClient

Public Class CfgJurorImpl
    Inherits SequencePanel

    Public Structure Data
        Dim Panel As System.Windows.Forms.Panel
        Dim Add As System.Windows.Forms.Button
        Dim Grid As System.Windows.Forms.DataGridView

        Dim sharedData As SharedData
    End Structure

    Private mData As Data

    Public Sub New(ByRef data As Data)
        MyBase.New(data.Panel)
        mData = data

        Debug.Assert(Not IsNothing(data.Add))

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
