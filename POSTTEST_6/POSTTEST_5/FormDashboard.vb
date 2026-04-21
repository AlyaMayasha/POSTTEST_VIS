Imports MySql.Data.MySqlClient

Public Class FormDashboard

    Sub LoadDashboard()

        Dim conn As MySqlConnection = GetConnection()
        conn.Open()

        Dim cmd1 As New MySqlCommand("SELECT COUNT(*) FROM tb_produk", conn)
        txtTotalProduk.Text = cmd1.ExecuteScalar().ToString()

        Dim cmd2 As New MySqlCommand("SELECT SUM(stok) FROM tb_produk", conn)
        Dim hasilStok As Object = cmd2.ExecuteScalar()

        If IsDBNull(hasilStok) Then
            txtTotalStok.Text = "0"
        Else
            txtTotalStok.Text = hasilStok.ToString()
        End If

        Dim cmd3 As New MySqlCommand("SELECT COUNT(*) FROM tb_transaksi", conn)
        txtTotalTransaksi.Text = cmd3.ExecuteScalar().ToString()

        Dim cmd4 As New MySqlCommand("SELECT SUM(jumlah) FROM tb_transaksi", conn)
        Dim hasilJual As Object = cmd4.ExecuteScalar()

        If IsDBNull(hasilJual) Then
            txtTotalTerjual.Text = "0"
        Else
            txtTotalTerjual.Text = hasilJual.ToString()
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

    Private Sub TransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiToolStripMenuItem.Click

        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is FormTransaksi Then
                frm.Focus()
                Exit Sub
            End If
        Next

        Dim f As New FormTransaksi


        AddHandler f.FormClosed, Sub() LoadDashboard()

        f.StartPosition = FormStartPosition.CenterScreen
        f.Show()

    End Sub

    Private Sub KeluarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem1.Click
        Dim hasil As DialogResult
        hasil = MessageBox.Show("Keluar aplikasi?", "Konfirmasi", MessageBoxButtons.YesNo)

        If hasil = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub
End Class