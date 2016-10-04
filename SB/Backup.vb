<Serializable()>
Public Class Backup

#Region "Properties"

    Public Property Singers As List(Of Singer)

#End Region

#Region "Constructors"

    Public Sub New()

        Singers = New List(Of Singer)

    End Sub

#End Region

End Class
