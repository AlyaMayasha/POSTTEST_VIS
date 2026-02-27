Public Class Form1

    Dim TotalIP As Double
    Dim JumlahSemester As Integer
    Dim IPK As Double
    Dim Predikat As String

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click

        Dim IPSemester As Double

        IPSemester = Val(txtipsemester.Text)

        TotalIP = TotalIP + IPSemester
        JumlahSemester = JumlahSemester + 1

        IPK = TotalIP / JumlahSemester

        txtipkumulatif.Text = Format(IPK, "0.00")

        If IPK >= 2.0 And IPK <= 2.75 Then
            Predikat = "Cukup"
        ElseIf IPK >= 2.76 And IPK <= 3.0 Then
            Predikat = "Memuaskan"
        ElseIf IPK >= 3.01 Then
            Predikat = "Sangat Memuaskan"
        Else
            Predikat = ""
        End If

        lblpredikat.Text = Predikat

        txtipsemester.Text = ""

    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click

        TotalIP = 0
        JumlahSemester = 0
        IPK = 0
        Predikat = ""

        txtipsemester.Text = ""
        txtipkumulatif.Text = ""
        lblpredikat.Text = ""

    End Sub

End Class