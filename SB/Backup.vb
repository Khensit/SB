<Serializable()>
Public Class Backup

#Region "Properties"

    Public Property Singers As List(Of Singer)
    Public Property Jury As List(Of Juror)

#End Region

#Region "Constructors"

    Public Sub New()

        Singers = New List(Of Singer)
        Jury = New List(Of Juror)

    End Sub

#End Region

End Class
