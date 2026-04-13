Imports MySql.Data.MySqlClient

Public Class FormDashboard

    Sub LoadDashboard()

        Dim conn As MySqlConnection = GetConnection()
        conn.Open()

        Dim cmd1 As New MySqlCommand("SELECT COUNT(*) FROM tb_produk", conn)
        txtTotalProduk.Text = cmd1.ExecuteScalar().ToString()

        Dim cmd2 As New MySqlCommand("SELECT SUM(stok) FROM tb_produk", conn)

        Dim hasil As Object = cmd2.ExecuteScalar()

        If IsDBNull(hasil) Then
            txtTotalStok.Text = "0"
        Else
            txtTotalStok.Text = hasil.ToString()
        End If

        conn.Close()

    End Sub

    Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDashboard()
    End Sub

    Private Sub KelolaProdukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KelolaProdukToolStripMenuItem.Click
        Dim f As New FormProduk
        AddHandler f.FormClosed, Sub() LoadDashboard()

        f.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click

        Dim hasil As DialogResult
        hasil = MessageBox.Show("Keluar aplikasi?", "Konfirmasi", MessageBoxButtons.YesNo)

        If hasil = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

End Class