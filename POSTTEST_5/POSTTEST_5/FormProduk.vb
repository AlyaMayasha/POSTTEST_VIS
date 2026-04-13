Imports MySql.Data.MySqlClient

Public Class FormProduk

    Sub TampilProduk()
        dgvProduk.DataSource = GetAllProduk()
    End Sub

    Sub ResetForm()
        txtKode.Clear()
        txtNama.Clear()
        txtHarga.Clear()
        txtStok.Clear()
        cboKategori.SelectedIndex = -1
        ErrorProvider1.Clear()
    End Sub

    Private Sub FormProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilProduk()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        Dim valid As Boolean = True

        valid = valid And ValidasiTextBox(ErrorProvider1, txtKode, "Kode tidak boleh kosong")
        valid = valid And ValidasiTextBox(ErrorProvider1, txtNama, "Nama tidak boleh kosong")
        valid = valid And ValidasiTextBox(ErrorProvider1, txtHarga, "Harga tidak boleh kosong")
        valid = valid And ValidasiTextBox(ErrorProvider1, txtStok, "Stok tidak boleh kosong")

        If cboKategori.Text = "" Then
            MessageBox.Show("Kategori harus dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            valid = False
        End If

        If CekKodeProduk(txtKode.Text) Then
            MessageBox.Show("Kode produk sudah ada!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not valid Then
            MessageBox.Show("Masih ada input yang kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        InsertProduk(txtKode.Text, txtNama.Text, cboKategori.Text, txtHarga.Text, txtStok.Text)

        MessageBox.Show("Data berhasil ditambahkan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

        TampilProduk()
        ResetForm()

    End Sub

    Private Sub dgvProduk_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProduk.CellClick

        If e.RowIndex >= 0 Then
            Dim row = dgvProduk.Rows(e.RowIndex)

            txtKode.Text = row.Cells("kode_produk").Value.ToString()
            txtNama.Text = row.Cells("nama_produk").Value.ToString()
            cboKategori.Text = row.Cells("kategori").Value.ToString()
            txtHarga.Text = row.Cells("harga").Value.ToString()
            txtStok.Text = row.Cells("stok").Value.ToString()
        End If

    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click

        If txtKode.Text = "" Then
            MessageBox.Show("Pilih data dulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim valid As Boolean = True

        valid = valid And ValidasiTextBox(ErrorProvider1, txtNama, "Nama tidak boleh kosong")
        valid = valid And ValidasiTextBox(ErrorProvider1, txtHarga, "Harga tidak boleh kosong")
        valid = valid And ValidasiTextBox(ErrorProvider1, txtStok, "Stok tidak boleh kosong")

        If cboKategori.Text = "" Then
            MessageBox.Show("Kategori harus dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            valid = False
        End If

        If Not valid Then
            MessageBox.Show("Masih ada input yang kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        UpdateProduk(txtKode.Text, txtNama.Text, cboKategori.Text, txtHarga.Text, txtStok.Text)

        MessageBox.Show("Data berhasil diubah", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

        TampilProduk()
        ResetForm()

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        If txtKode.Text = "" Then
            MessageBox.Show("Pilih data dulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim hasil As DialogResult
        hasil = MessageBox.Show("Yakin ingin hapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then

            DeleteProduk(txtKode.Text)

            MessageBox.Show("Data berhasil dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            TampilProduk()
            ResetForm()

        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetForm()
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        dgvProduk.DataSource = SearchProduk(txtCari.Text)
    End Sub


    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub


    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        HanyaHuruf(e)
    End Sub

    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub txtStok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStok.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub txtKode_TextChanged(sender As Object, e As EventArgs) Handles txtKode.TextChanged
        ValidasiTextBox(ErrorProvider1, txtKode, "Kode tidak boleh kosong")
    End Sub

    Private Sub txtNama_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged
        ValidasiTextBox(ErrorProvider1, txtNama, "Nama tidak boleh kosong")
    End Sub

    Private Sub txtHarga_TextChanged(sender As Object, e As EventArgs) Handles txtHarga.TextChanged
        ValidasiTextBox(ErrorProvider1, txtHarga, "Harga tidak boleh kosong")
    End Sub

    Private Sub txtStok_TextChanged(sender As Object, e As EventArgs) Handles txtStok.TextChanged
        ValidasiTextBox(ErrorProvider1, txtStok, "Stok tidak boleh kosong")
    End Sub

End Class