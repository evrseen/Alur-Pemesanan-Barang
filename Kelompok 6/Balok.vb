Public Class Balok
    Inherits PersegiPanjang
    Public tinggi As Integer
    Public Property t() As Integer
        Get
            t = tinggi
        End Get
        Set(value As Integer)
            tinggi = value
        End Set
    End Property
    Public Shared Function volume(ByVal panjang, lebar, tinggi) As Integer
        Return panjang * lebar * tinggi
    End Function
    Public Overrides Function tostring() As String
        Return "volume = panjang x lebar x tinggi" & Environment.NewLine & "Volume = " & volume(panjang, lebar, tinggi) & " cm^3"
    End Function
End Class
