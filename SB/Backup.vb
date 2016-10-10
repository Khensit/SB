<Serializable()>
Public Class Backup

#Region "Properties"

    Public Property Singers As List(Of Singer)
    Public Property Jury As List(Of Juror)
    Public Property Points As List(Of Points)

#End Region

#Region "Constructors"

    Public Sub New()

        Singers = New List(Of Singer)
        Jury = New List(Of Juror)
        Points = New List(Of Points)

    End Sub

#End Region

End Class
