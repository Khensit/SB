Public Class StartPanelImpl
    Inherits SequencePanel

    Public Structure Data
        Dim Panel As System.Windows.Forms.Panel
        Dim Create As System.Windows.Forms.Button
        Dim Load As System.Windows.Forms.Button

        Dim sharedData As SharedData
    End Structure

    Private mData As Data

    Public Sub New(ByRef data As Data)
        MyBase.New(data.Panel)
        mData = data

        Debug.Assert(Not IsNothing(data.Create))
        Debug.Assert(Not IsNothing(data.Create))

        Visible = True

        AddHandler data.Create.Click, AddressOf onClick
        AddHandler data.Load.Click, AddressOf onClick
    End Sub

    Private Sub onClick(sender As Object, e As EventArgs)
        Dim backup As Backup = Nothing

        If sender Is mData.Create Then
            backup = New Backup
        ElseIf sender Is mData.Load Then
        End If

        If Not IsNothing(backup) Then
            mData.sharedData.Backup = backup
            mData.sharedData.sequencePanel = NextPanel()
        End If

    End Sub

End Class
