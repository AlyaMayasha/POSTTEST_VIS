Public Class FormCetak
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        Dim openFileDialog As New OpenFileDialog()

        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        openFileDialog.Title = "Pilih Foto"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            picFoto.Image = Image.FromFile(openFileDialog.FileName)
        End If

    End Sub

    Public Sub HanyaAngka(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress, txtTelpon.KeyPress

        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Public Sub HanyaHuruf(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress

        If Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If txtNama.Text = "" Or txtUmur.Text = "" Or txtTelpon.Text = "" Or txtAlamat.Text = "" Then
            MessageBox.Show("Inputan tidak boleh ada yang kosong yaa!")
            Exit Sub
        End If

        If rbLaki.Checked = False And rbPerempuan.Checked = False Then
            MessageBox.Show("Jenis Kelamin tidak boleh kosong")
            Exit Sub
        End If

        If ChkGaming.Checked = False And chkCoding.Checked = False And chkTraveling.Checked = False And chkMembaca.Checked = False And chkMenggambar.Checked = False And chkMenulis.Checked = False And chkMemancing.Checked = False And chkMemasak.Checked = False And chkMenyanyi.Checked = False And chkMenari.Checked = False Then
            MessageBox.Show("Hobby tidak boleh kosong")
            Exit Sub
        End If

        If picFoto.Image Is Nothing Then
            MessageBox.Show("Tolong Masukan Foto Anda")
            Exit Sub
        End If

        Dim hasil As New FormHasil
        hasil.lblNama.Text = txtNama.Text
        hasil.lblUmur.Text = txtUmur.Text
        hasil.lblTanggal.Text = dtpTanggal.Text
        hasil.lblTelp.Text = txtTelpon.Text
        hasil.lblAlamat.Text = txtAlamat.Text

        If rbLaki.Checked Then
            hasil.lblJK.Text = "Prince"
        Else
            hasil.lblJK.Text = "Princess"
        End If

        hasil.picHasilFoto.Image = picFoto.Image

        Dim hobby As String = ""

        If chkGaming.Checked Then
            hobby &= "Gaming, "
        End If

        If chkCoding.Checked Then
            hobby &= "Coding, "
        End If

        If chkTraveling.Checked Then
            hobby &= "Traveling, "
        End If

        If chkMembaca.Checked Then
            hobby &= "Membaca, "
        End If

        If chkMenggambar.Checked Then
            hobby &= "Menggambar, "
        End If

        If chkMenulis.Checked Then
            hobby &= "Menulis, "
        End If

        If chkMemancing.Checked Then
            hobby &= "Memancing, "
        End If

        If chkMemasak.Checked Then
            hobby &= "Memasak, "
        End If

        If chkMenyanyi.Checked Then
            hobby &= "Menyanyi, "
        End If

        If chkMenari.Checked Then
            hobby &= "Menari, "
        End If

        If chkMerajut.Checked Then
            hobby &= "Merajut, "
        End If

        If chkBerkuda.Checked Then
            hobby &= "Berkuda, "
        End If

        hobby = hobby.TrimEnd(","c, " "c)
        hasil.lblHobby.Text = hobby
        hasil.Show()
    End Sub

    Private Sub FormCetak_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
