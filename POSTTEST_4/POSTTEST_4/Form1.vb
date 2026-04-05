Public Class Form1

    Private KartuTerakhir As FormKartu = Nothing
    Private DataCetak As New Dictionary(Of String, String)
    Private FotoCetak As Image = Nothing

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        HanyaHuruf(e)
    End Sub

    Private Sub txtNama_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged
        ValidasiTextBox(ErrorProvider1, txtNama, "Nama tidak boleh kosong")
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged
        ValidasiTextBox(ErrorProvider1, txtID, "ID tidak boleh kosong")
    End Sub

    Private Sub mtbTelepon_TextChanged(sender As Object, e As EventArgs) Handles mtbTelepon.TextChanged
        If Not mtbTelepon.MaskCompleted Then
            ErrorProvider1.SetError(mtbTelepon, "Nomor telepon belum lengkap")
        Else
            ErrorProvider1.SetError(mtbTelepon, "")
        End If
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        ValidasiTextBox(ErrorProvider1, txtEmail, "Email tidak boleh kosong")
    End Sub

    Private Sub txtAlamat_TextChanged(sender As Object, e As EventArgs) Handles txtAlamat.TextChanged
        ValidasiTextBox(ErrorProvider1, txtAlamat, "Alamat tidak boleh kosong")
    End Sub

    Private Sub cboTipePokemon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipePokemon.SelectedIndexChanged
        ValidasiComboBox(ErrorProvider1, cboTipePokemon, "Pilih Tipe Pokemon")
    End Sub

    Private Sub btnBrowseFoto_Click(sender As Object, e As EventArgs) Handles btnBrowseFoto.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.png;*.jpeg"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PicProfil.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Function AmbilRole() As String
        For Each rb As RadioButton In gbRole.Controls
            If rb.Checked Then
                Return rb.Text
            End If
        Next
        Return ""
    End Function

    Private Sub btnSimpanCetak_Click(sender As Object, e As EventArgs) Handles btnSimpanCetak.Click
        If Not ValidasiSemuaInput(ErrorProvider1,
                          txtNama, txtID, txtEmail, txtAlamat,
                          rbLaki, rbPerempuan,
                          cboTipePokemon, mtbTelepon,
                          gbActivity,
                          dtpTanggalLahir,
                          gbRole,
                          PicProfil) Then
            Exit Sub
        End If

        Dim hasil As DialogResult
        hasil = MessageBox.Show("Cetak kartu?", "Konfirmasi", MessageBoxButtons.YesNoCancel)

        If hasil = DialogResult.Yes Then

            DataCetak("Nama") = txtNama.Text
            DataCetak("ID") = txtID.Text
            DataCetak("Komunitas") = cboTipePokemon.Text
            DataCetak("Kontak") = mtbTelepon.Text
            DataCetak("Role") = AmbilRole()

            Dim activity As String = ""
            For Each cb As CheckBox In gbActivity.Controls
                If cb.Checked Then
                    activity &= cb.Text & ", "
                End If
            Next
            activity = activity.TrimEnd(","c, " "c)
            DataCetak("Activity") = activity

            If PicProfil.Image IsNot Nothing Then
                FotoCetak = PicProfil.Image
            End If

            Dim f As New FormKartu

            f.lblNama.Text = DataCetak("Nama")
            f.lblID.Text = DataCetak("ID")
            f.lblTipePokemon.Text = DataCetak("Komunitas")
            f.lblKontak.Text = DataCetak("Kontak")
            f.lblRole.Text = DataCetak("Role")
            f.lblActivity.Text = DataCetak("Activity")

            If FotoCetak IsNot Nothing Then
                f.PicFoto.Image = FotoCetak
            End If

            f.Show()

        End If
    End Sub

    Private Sub mnuInputData_Click(sender As Object, e As EventArgs) Handles mnuInputData.Click
        TabControl1.SelectedTab = tabDataUtama
    End Sub

    Private Sub mnuLihatKartu_Click(sender As Object, e As EventArgs) Handles mnuLihatKartu.Click

        If DataCetak.Count = 0 Then
            MessageBox.Show("Belum ada kartu yang dicetak.", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim f As New FormKartu

        f.lblNama.Text = DataCetak("Nama")
        f.lblID.Text = DataCetak("ID")
        f.lblTipePokemon.Text = DataCetak("Komunitas")
        f.lblKontak.Text = DataCetak("Kontak")
        f.lblRole.Text = DataCetak("Role")
        f.lblActivity.Text = DataCetak("Activity")

        If FotoCetak IsNot Nothing Then
            f.PicFoto.Image = FotoCetak
        End If

        f.Show()
    End Sub

    Private Sub mnuKeluar_Click(sender As Object, e As EventArgs) Handles mnuKeluar.Click
        Dim hasil = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo)

        If hasil = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub mnuSimpan_Click(sender As Object, e As EventArgs) Handles mnuSimpan.Click

        Dim konfirmasi As DialogResult =
        MessageBox.Show("Apakah Anda ingin menyimpan data?", "Konfirmasi Simpan",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If konfirmasi = DialogResult.No Then Exit Sub

        Dim aktivitas As String = ""
        For Each cb As CheckBox In gbActivity.Controls
            If cb.Checked Then aktivitas &= cb.Text & ", "
        Next
        aktivitas = aktivitas.TrimEnd(","c, " "c)

        Dim gender As String = If(rbLaki.Checked, "Laki-laki", "Perempuan")
        Dim isi As String = BuatIsiFile(
        txtNama.Text,
        txtID.Text,
        cboTipePokemon.Text,
        txtEmail.Text,
        txtAlamat.Text,
        gender,
        mtbTelepon.Text,
        AmbilRole(),
        aktivitas
    )

        If SimpanDataKeFile(SaveFileDialog1, isi) Then
            MessageBox.Show("Data berhasil disimpan!", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Data gagal disimpan!", "Gagal",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub mnuBuka_Click(sender As Object, e As EventArgs) Handles mnuBuka.Click
        Dim data = BukaDataDariFile(OpenFileDialog1)
        If data Is Nothing Then Exit Sub

        txtNama.Text = AmbilNilai(data, "Nama")
        txtID.Text = AmbilNilai(data, "ID")
        cboTipePokemon.Text = AmbilNilai(data, "Tipe Pokemon")
        TabControl1.SelectedTab = tabDataUtama
    End Sub

End Class
