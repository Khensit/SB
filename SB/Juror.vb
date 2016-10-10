<Serializable()>
Public Class Juror

    Public Property Name As String
    Public Property Country As Country.ID
    Public Property Preview As Integer
    Public Property Weight As String

    Public Sub New(name As String, country As Country.ID, preview As Integer, weight As Integer)
        Me.Name = name
        Me.Country = country
        Me.Preview = preview
        Me.Weight = weight
    End Sub

End Class
