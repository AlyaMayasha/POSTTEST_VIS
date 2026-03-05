Public Class Form1

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If txtJudulTambah.Text = "" Or txtGenre.Text = "" Then
            MessageBox.Show("Judul atau Genre tidak boleh kosong")
            Exit Sub
        End If
        If CariIndexBuku(txtJudulTambah.Text) <> -1 Then
            MessageBox.Show("Buku sudah ada di daftar")
            Exit Sub
        End If
        TambahBuku(txtJudulTambah.Text, txtGenre.Text)
        TampilkanDaftar()

        txtJudulTambah.Clear()
        txtGenre.Clear()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        If txtJudulHapus.Text = "" Then
            MessageBox.Show("Masukkan judul buku yang ingin dihapus")
            Exit Sub
        End If

        Dim index As Integer = CariIndexBuku(txtJudulHapus.Text)

        If index = -1 Then
            MessageBox.Show("Buku tidak ditemukan")
        Else
            HapusBuku(index)
            MessageBox.Show("Buku berhasil dihapus")
            TampilkanDaftar()
        End If

        txtJudulHapus.Clear()

    End Sub

    Private Sub TampilkanDaftar()

        lstBuku.Items.Clear()

        For i As Integer = 0 To jumlahBuku - 1
            lstBuku.Items.Add(daftarJudul(i) & " (" & daftarGenre(i) & ")")
        Next

    End Sub
End Class
