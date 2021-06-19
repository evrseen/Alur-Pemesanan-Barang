Public Class PersegiPanjang
    Public panjang As Integer
    Public lebar As Integer
    Public Property p() As Integer
        Get
            p = panjang
        End Get
        Set(value As Integer)
            panjang = value
        End Set
    End Property
    Public Property l() As Integer
        Get
            l = lebar
        End Get
        Set(value As Integer)
            lebar = value
        End Set
    End Property
    Public Shared Function luas(ByVal panjang, lebar) As Integer
        Return panjang * lebar
    End Function
    Public Overrides Function tostring() As String
        Return "volume = panjang x lebar" & Environment.NewLine & "Volume = " & luas(panjang, lebar) & " cm^2"
    End Function
End Class
