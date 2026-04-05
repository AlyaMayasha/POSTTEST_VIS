Module ValidationModule

    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse
           Char.IsWhiteSpace(e.KeyChar) OrElse
           Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function

    Public Function ValidasiComboBox(ep As ErrorProvider, cbo As ComboBox, pesan As String) As Boolean
        If cbo.SelectedIndex = -1 OrElse cbo.Text.Trim() = "" Then
            ep.SetError(cbo, pesan)
            Return False
        Else
            ep.SetError(cbo, "")
            Return True
        End If
    End Function

    Public Function ValidasiMaskedTextBox(ep As ErrorProvider, mtb As MaskedTextBox, pesan As String) As Boolean
        If Not mtb.MaskCompleted Then
            ep.SetError(mtb, pesan)
            Return False
        Else
            ep.SetError(mtb, "")
            Return True
        End If
    End Function

    Public Function ValidasiRadio(r1 As RadioButton, r2 As RadioButton, pesan As String) As Boolean
        If Not r1.Checked AndAlso Not r2.Checked Then
            MessageBox.Show(pesan, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    Public Function ValidasiCheckbox(group As GroupBox, pesan As String) As Boolean
        For Each cb As CheckBox In group.Controls
            If cb.Checked Then Return True
        Next
        MessageBox.Show(pesan, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Return False
    End Function

    Public Function ValidasiDate(dtp As DateTimePicker, pesan As String) As Boolean
        If dtp.Value = Date.Today Then
            MessageBox.Show(pesan, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    Public Function ValidasiRole(gb As GroupBox, pesan As String) As Boolean
        For Each rb As RadioButton In gb.Controls
            If rb.Checked Then
                Return True
            End If
        Next
        MessageBox.Show(pesan, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Return False
    End Function

    Public Function ValidasiFoto(pic As PictureBox, pesan As String) As Boolean
        If pic.Image Is Nothing Then
            MessageBox.Show(pesan, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    Public Function ValidasiSemuaInput(
        ep As ErrorProvider,
        txtNama As TextBox,
        txtID As TextBox,
        txtEmail As TextBox,
        txtAlamat As TextBox,
        rbLaki As RadioButton,
        rbPerempuan As RadioButton,
        cboTipe As ComboBox,
        mtbTelepon As MaskedTextBox,
        gbActivity As GroupBox,
        dtpTanggalLahir As DateTimePicker,
        gbRole As GroupBox,
        picFoto As PictureBox
    ) As Boolean

        Dim v1 = ValidasiTextBox(ep, txtNama, "Nama tidak boleh kosong")
        Dim v2 = ValidasiTextBox(ep, txtID, "ID tidak boleh kosong")
        Dim v3 = ValidasiTextBox(ep, txtEmail, "Email tidak boleh kosong")
        Dim v4 = ValidasiTextBox(ep, txtAlamat, "Alamat tidak boleh kosong")
        Dim v5 = ValidasiRadio(rbLaki, rbPerempuan, "Pilih jenis kelamin")
        Dim v6 = ValidasiComboBox(ep, cboTipe, "Pilih Tipe Pokemon")
        Dim v7 = ValidasiMaskedTextBox(ep, mtbTelepon, "Nomor telepon belum lengkap")
        Dim v8 = ValidasiCheckbox(gbActivity, "Pilih Minimal 1 Aktivitas")
        Dim v9 = ValidasiDate(dtpTanggalLahir, "Masukkan Tanggal Lahir")
        Dim v10 = ValidasiRole(gbRole, "Pilih role/peran Anda")
        Dim v11 = ValidasiFoto(picFoto, "Foto profil harus di-upload")

        Return v1 And v2 And v3 And v4 And v5 And v6 And v7 And v8 And v9 And v10 And v11
    End Function

End Module