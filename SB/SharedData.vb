Public Class SharedData

#Region "Properties"

    Public Property Backup As Backup
    Public Property SequencePanel As SequencePanel

#End Region

#Region "Property shortcuts"

    Public Property Singers As List(Of Singer)
        Get
            Return Backup.Singers
        End Get
        Set(value As List(Of Singer))
            Backup.Singers = value
        End Set
    End Property

#End Region

End Class
