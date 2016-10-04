<Serializable()>
Public Class Juror

    Public Property Name As String
    Public Property Country As Country.ID
    Public Property Weight As Integer

    Public Sub New(name As String, country As Country.ID, weight As Integer)
        Me.Name = name
        Me.Country = country
        Me.Weight = weight
    End Sub

End Class
