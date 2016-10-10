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

    Public Property Jury As List(Of Juror)
        Get
            Return Backup.Jury
        End Get
        Set(value As List(Of Juror))
            Backup.Jury = value
        End Set
    End Property

    Public Property Points As List(Of Points)
        Get
            Return Backup.Points
        End Get
        Set(value As List(Of Points))
            Backup.Points = value
        End Set
    End Property

#End Region

End Class
