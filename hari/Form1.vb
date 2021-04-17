Public Class Form1
    Private lblNamaHari As Object


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim strNamaHari(6) As String
        Dim x As Integer
        strNamaHari(0) = "Ahad"
        strNamaHari(1) = "Isnin"
        strNamaHari(2) = "Selasa"
        strNamaHari(3) = "Rabu"
        strNamaHari(4) = "Selasa"
        strNamaHari(5) = "Khamis"
        strNamaHari(6) = "Jumaat"
        Array.Reverse(strNamaHari)
        For x = 0 To 5

            ListBox1.Items.Add(strNamaHari(x))

        Next




    End Sub
End Class



