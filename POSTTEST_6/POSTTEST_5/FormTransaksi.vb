Imports MySql.Data.MySqlClient

Public Class FormTransaksi

    Private Sub FormTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProduk()
        TampilTransaksi()
    End Sub

    Sub LoadProduk()
        Dim conn As MySqlConnection = GetConnection()
        conn.Open()

        Dim da As New MySqlDataAdapter("SELECT kode_produk, nama_produk FROM tb_produk", conn)
        Dim dt As New DataTable
        da.Fill(dt)

        cboProduk.DataSource = dt
        cboProduk.DisplayMember = "nama_produk"
        cboProduk.ValueMember = "kode_produk"

        conn.Close()
    End Sub

    Sub TampilTransaksi()
        dgvTransaksi.DataSource = GetAllTransaksi()
    End Sub

    Sub HitungTotal()
        If cboProduk.SelectedValue Is Nothing Or txtJumlah.Text = "" Then
            txtTotal.Text = ""
            Exit Sub
        End If

        Dim conn As MySqlConnection = GetConnection()
        conn.Open()

        Dim cmd As New MySqlCommand("SELECT harga FROM tb_produk WHERE kode_produk=@kode", conn)
        cmd.Parameters.AddWithValue("@kode", cboProduk.SelectedValue)

        Dim hargaObj As Object = cmd.ExecuteScalar()
        conn.Close()

        If IsDBNull(hargaObj) Then
            txtTotal.Text = "0"
        Else
            Dim harga As Integer = Convert.ToInt32(hargaObj)
            Dim jumlah As Integer = Val(txtJumlah.Text)
            txtTotal.Text = (harga * jumlah).ToString()
        End If
    End Sub

    Private Sub cboProduk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProduk.SelectedIndexChanged
        HitungTotal()
    End Sub

    Private Sub txtJumlah_TextChanged(sender As Object, e As EventArgs) Handles txtJumlah.TextChanged
        HitungTotal()
        ValidasiTextBox(ErrorProvider1, txtJumlah, "Jumlah tidak boleh kosong")
    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged
        ValidasiTextBox(ErrorProvider1, txtID, "ID tidak boleh kosong")
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        Dim valid As Boolean = True

        valid = valid And ValidasiTextBox(ErrorProvider1, txtID, "ID tidak boleh kosong")
        valid = valid And ValidasiTextBox(ErrorProvider1, txtJumlah, "Jumlah tidak boleh kosong")

        If cboProduk.Text = "" Then
            ErrorProvider1.SetError(cboProduk, "Produk harus dipilih")
            valid = False
        Else
            ErrorProvider1.SetError(cboProduk, "")
        End If

        If txtTotal.Text = "" Then
            ErrorProvider1.SetError(txtTotal, "Total belum terhitung")
            valid = False
        Else
            ErrorProvider1.SetError(txtTotal, "")
        End If

        If CekIDTransaksi(txtID.Text) Then
            MessageBox.Show("ID transaksi sudah ada!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not valid Then
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim stok As Integer = GetStokProduk(cboProduk.SelectedValue.ToString())
        Dim jumlah As Integer = Val(txtJumlah.Text)

        If jumlah > stok Then
            MessageBox.Show("Stok tidak mencukupi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        InsertTransaksi(
            txtID.Text,
            cboProduk.SelectedValue.ToString(),
            txtJumlah.Text,
            txtTotal.Text,
            dtpTanggal.Value
        )

        KurangiStok(cboProduk.SelectedValue.ToString(), Val(txtJumlah.Text))

        MessageBox.Show("Data berhasil ditambahkan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

        TampilTransaksi()
        ResetForm()

    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click

        If txtID.Text = "" Then
            MessageBox.Show("Pilih data dulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim valid As Boolean = True

        valid = valid And ValidasiTextBox(ErrorProvider1, txtJumlah, "Jumlah tidak boleh kosong")

        If cboProduk.Text = "" Then
            ErrorProvider1.SetError(cboProduk, "Produk harus dipilih")
            valid = False
        Else
            ErrorProvider1.SetError(cboProduk, "")
        End If

        If txtTotal.Text = "" Then
            ErrorProvider1.SetError(txtTotal, "Total belum terhitung")
            valid = False
        Else
            ErrorProvider1.SetError(txtTotal, "")
        End If

        If Not valid Then
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim kode As String = cboProduk.SelectedValue.ToString()
        Dim jumlahBaru As Integer = Val(txtJumlah.Text)
        Dim jumlahLama As Integer = GetJumlahLama(txtID.Text)

        TambahStok(kode, jumlahLama)

        Dim stok As Integer = GetStokProduk(kode)

        If jumlahBaru > stok Then
            MessageBox.Show("Stok tidak mencukupi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            KurangiStok(kode, jumlahLama)

            Exit Sub
        End If

        KurangiStok(kode, jumlahBaru)

        UpdateTransaksi(
            txtID.Text,
            cboProduk.SelectedValue.ToString(),
            txtJumlah.Text,
            txtTotal.Text,
            dtpTanggal.Value
        )

        MessageBox.Show("Data berhasil diubah", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

        TampilTransaksi()
        ResetForm()

    End Sub
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        If txtID.Text = "" Then
            MessageBox.Show("Pilih data dulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim hasil As DialogResult
        hasil = MessageBox.Show("Yakin ingin hapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then
            DeleteTransaksi(txtID.Text)

            MessageBox.Show("Data berhasil dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            TampilTransaksi()
            ResetForm()
        End If

    End Sub

    Sub ResetForm()
        txtID.Clear()
        txtJumlah.Clear()
        txtTotal.Clear()
        cboProduk.SelectedIndex = -1
        dtpTanggal.Value = DateTime.Now

        ErrorProvider1.Clear()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetForm()
    End Sub

    Private Sub dgvTransaksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransaksi.CellClick

        If e.RowIndex >= 0 Then
            Dim row = dgvTransaksi.Rows(e.RowIndex)

            txtID.Text = row.Cells("id_transaksi").Value.ToString()
            cboProduk.Text = row.Cells("nama_produk").Value.ToString()
            txtJumlah.Text = row.Cells("jumlah").Value.ToString()
            txtTotal.Text = row.Cells("total").Value.ToString()
            dtpTanggal.Value = Convert.ToDateTime(row.Cells("tanggal").Value)
        End If

    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        dgvTransaksi.DataSource = SearchTransaksi(txtCari.Text)
    End Sub

    Private Sub txtJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJumlah.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

    Function CekIDTransaksi(id As String) As Boolean

        Dim conn As MySqlConnection = GetConnection()
        conn.Open()

        Dim cmd As New MySqlCommand(
            "SELECT COUNT(*) FROM tb_transaksi WHERE id_transaksi=@id", conn)

        cmd.Parameters.AddWithValue("@id", id)

        Dim count As Integer = cmd.ExecuteScalar()

        conn.Close()

        If count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

End Class