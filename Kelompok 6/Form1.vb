Public Class form1
    Private luas As New PersegiPanjang
    Private volume As New Balok

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        luas.panjang = InputBox("masukan panjang dalam centimeter", "panjang")
        volume.panjang = luas.panjang
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        luas.lebar = InputBox("masukan lebar dalam centimeter", "lebar")
        volume.lebar = luas.lebar
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        volume.tinggi = InputBox("masukan tinggi dalam centimeter", "tinggi")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MessageBox.Show(luas.tostring, "Luas Persegi Panjang")
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MessageBox.Show(volume.tostring, "Volume Balok")
    End Sub
End Class