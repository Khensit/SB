Public Class Country

    Public Enum ID As Integer
        UNKNOWN

        ANDORRA
        ALBANIA
        ARMENIA
        AUSTRALIA
        AUSTRIA
        AZERBAIJAN
        BELARUS
        BELGIUM
        BOSNIA_HERZEGOVINA
        BULGARIA
        CROATIA
        CYPRUS
        CZECH_REPUBLIC
        DENMARK
        ESTONIA
        FINLAND
        FRANCE
        GERMANY
        GEORGIA
        GREECE
        HUNGARY
        IRELAND
        ISLAND
        ISRAEL
        ITALY
        LATVIA
        LITHUANIA
        LUXEMBOURG
        FYR_MACEDONIA
        MOLDOVA
        MONTENEGRO
        MONACO
        MOROCCO
        MALTA
        THE_NETHERLANDS
        NORWAY
        POLAND
        PORTUGAL
        ROMANIA
        RUSSIA
        SERBIA
        SAN_MARINO
        SLOVAKIA
        SLOVENIA
        SPAIN
        SWEDEN
        SWITZERLAND
        TURKEY
        UKRAINE
        UNITED_KINGDOM

        LAST
    End Enum

#Region "Local variables"

    Private _iso As String
    Private _name As String

#End Region

#Region "Properties"

    Public ReadOnly Property ISO
        Get
            Return _iso
        End Get
    End Property

    Public ReadOnly Property Name
        Get
            Return _name
        End Get
    End Property

#End Region

#Region "Constructors"

    Private Sub New(iso As String, name As String)
        _iso = iso
        _name = name
    End Sub

#End Region

#Region "Shared Function"

    Private Shared _countries As List(Of Country) = Nothing

    Private Shared Function getSupportedCountries() As List(Of Country)
        Dim countries As New List(Of Country)(ID.LAST)

        countries.Insert(ID.UNKNOWN, New Country("??", "-- Select a country --"))
        countries.Insert(ID.ANDORRA, New Country("ad", "Andorra"))
        countries.Insert(ID.ALBANIA, New Country("a", "Albania"))
        countries.Insert(ID.ARMENIA, New Country("am", "Armenia"))
        countries.Insert(ID.AUSTRIA, New Country("at", "Austria"))
        countries.Insert(ID.AUSTRALIA, New Country("au", "Australia"))
        countries.Insert(ID.AZERBAIJAN, New Country("az", "Azerbaijan"))
        countries.Insert(ID.BOSNIA_HERZEGOVINA, New Country("ba", "Bosnia-Herzegovina"))
        countries.Insert(ID.BELGIUM, New Country("be", "Belgium"))
        countries.Insert(ID.BULGARIA, New Country("bg", "Bulgaria"))
        countries.Insert(ID.BELARUS, New Country("by", "Belarus"))
        countries.Insert(ID.SWITZERLAND, New Country("ch", "Switzerland"))
        countries.Insert(ID.CYPRUS, New Country("cy", "Cyprus"))
        countries.Insert(ID.CZECH_REPUBLIC, New Country("cz", "Czech Republic"))
        countries.Insert(ID.GERMANY, New Country("de", "Germany"))
        countries.Insert(ID.DENMARK, New Country("dk", "Denmark"))
        countries.Insert(ID.ESTONIA, New Country("ee", "Estonia"))
        countries.Insert(ID.SPAIN, New Country("es", "Spain"))
        countries.Insert(ID.FINLAND, New Country("fi", "Finland"))
        countries.Insert(ID.FRANCE, New Country("fr", "France"))
        countries.Insert(ID.UNITED_KINGDOM, New Country("gb", "United Kingdom"))
        countries.Insert(ID.GEORGIA, New Country("ge", "Georgia"))
        countries.Insert(ID.GREECE, New Country("gr", "Greece"))
        countries.Insert(ID.CROATIA, New Country("hr", "Croatia"))
        countries.Insert(ID.HUNGARY, New Country("hu", "Hungary"))
        countries.Insert(ID.IRELAND, New Country("ie", "Ireland"))
        countries.Insert(ID.ISRAEL, New Country("i", "Israe"))
        countries.Insert(ID.ISLAND, New Country("is", "Iceland"))
        countries.Insert(ID.ITALY, New Country("it", "Italy"))
        countries.Insert(ID.LITHUANIA, New Country("lt", "Lithuania"))
        countries.Insert(ID.LUXEMBOURG, New Country("lu", "Luxembourg"))
        countries.Insert(ID.LATVIA, New Country("lv", "Latvia"))
        countries.Insert(ID.MOROCCO, New Country("ma", "Morocco"))
        countries.Insert(ID.MONACO, New Country("mc", "Monaco"))
        countries.Insert(ID.MOLDOVA, New Country("md", "Moldova"))
        countries.Insert(ID.MONTENEGRO, New Country("me", "Montenegro"))
        countries.Insert(ID.FYR_MACEDONIA, New Country("mk", "FYR Macedonia"))
        countries.Insert(ID.MALTA, New Country("mt", "Malta"))
        countries.Insert(ID.THE_NETHERLANDS, New Country("n", "The Netherlands"))
        countries.Insert(ID.NORWAY, New Country("no", "Norway"))
        countries.Insert(ID.POLAND, New Country("p", "Poland"))
        countries.Insert(ID.PORTUGAL, New Country("pt", "Portuga"))
        countries.Insert(ID.ROMANIA, New Country("ro", "Romania"))
        countries.Insert(ID.SERBIA, New Country("rs", "Serbia"))
        countries.Insert(ID.RUSSIA, New Country("ru", "Russia"))
        countries.Insert(ID.SWEDEN, New Country("se", "Sweden"))
        countries.Insert(ID.SLOVENIA, New Country("si", "Slovenia"))
        countries.Insert(ID.SLOVAKIA, New Country("sk", "Slovakia"))
        countries.Insert(ID.SAN_MARINO, New Country("sm", "San Marino"))
        countries.Insert(ID.TURKEY, New Country("tr", "Turkey"))
        countries.Insert(ID.UKRAINE, New Country("ua", "Ukraine"))

        Return countries
    End Function

    Public Shared Function getCountry(id As ID) As Country
        If IsNothing(_countries) Then
            _countries = getSupportedCountries()
        End If

        Dim country As Country = _countries(id)
        Debug.Assert(Not IsNothing(country))
        Return country
    End Function

#End Region

End Class
