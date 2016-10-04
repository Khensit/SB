<Serializable()>
Public Class Singer

    Public Property Name As String
    Public Property Song As String
    Public Property Country As Country.ID

    Public Sub New(name As String, song As String, country As Country.ID)
        Me.Name = name
        Me.Song = song
        Me.Country = country
    End Sub

End Class
