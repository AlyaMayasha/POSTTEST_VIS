<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCetak
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
		Me.btnBrowse = New System.Windows.Forms.Button()
		Me.lblNama = New System.Windows.Forms.Label()
		Me.lblUmur = New System.Windows.Forms.Label()
		Me.lblTgl = New System.Windows.Forms.Label()
		Me.lblTelp = New System.Windows.Forms.Label()
		Me.lblAlamat = New System.Windows.Forms.Label()
		Me.txtNama = New System.Windows.Forms.TextBox()
		Me.txtUmur = New System.Windows.Forms.TextBox()
		Me.txtTelpon = New System.Windows.Forms.TextBox()
		Me.txtAlamat = New System.Windows.Forms.TextBox()
		Me.dtpTanggal = New System.Windows.Forms.DateTimePicker()
		Me.grpJK = New System.Windows.Forms.GroupBox()
		Me.rbPerempuan = New System.Windows.Forms.RadioButton()
		Me.rbLaki = New System.Windows.Forms.RadioButton()
		Me.grpHobby = New System.Windows.Forms.GroupBox()
		Me.chkBerkuda = New System.Windows.Forms.CheckBox()
		Me.chkMerajut = New System.Windows.Forms.CheckBox()
		Me.chkMenari = New System.Windows.Forms.CheckBox()
		Me.chkMenyanyi = New System.Windows.Forms.CheckBox()
		Me.chkMemasak = New System.Windows.Forms.CheckBox()
		Me.chkMemancing = New System.Windows.Forms.CheckBox()
		Me.chkMenulis = New System.Windows.Forms.CheckBox()
		Me.chkMenggambar = New System.Windows.Forms.CheckBox()
		Me.chkMembaca = New System.Windows.Forms.CheckBox()
		Me.chkTraveling = New System.Windows.Forms.CheckBox()
		Me.chkCoding = New System.Windows.Forms.CheckBox()
		Me.chkGaming = New System.Windows.Forms.CheckBox()
		Me.btnCetak = New System.Windows.Forms.Button()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.picFoto = New System.Windows.Forms.PictureBox()
		Me.grpJK.SuspendLayout()
		Me.grpHobby.SuspendLayout()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picFoto, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'btnBrowse
		'
		Me.btnBrowse.Font = New System.Drawing.Font("Century Schoolbook", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnBrowse.ForeColor = System.Drawing.Color.DeepPink
		Me.btnBrowse.Location = New System.Drawing.Point(84, 285)
		Me.btnBrowse.Name = "btnBrowse"
		Me.btnBrowse.Size = New System.Drawing.Size(108, 36)
		Me.btnBrowse.TabIndex = 1
		Me.btnBrowse.Text = "Browse"
		Me.btnBrowse.UseVisualStyleBackColor = True
		'
		'lblNama
		'
		Me.lblNama.AutoSize = True
		Me.lblNama.Font = New System.Drawing.Font("Century Schoolbook", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNama.ForeColor = System.Drawing.Color.DeepPink
		Me.lblNama.Location = New System.Drawing.Point(281, 68)
		Me.lblNama.Name = "lblNama"
		Me.lblNama.Size = New System.Drawing.Size(65, 23)
		Me.lblNama.TabIndex = 2
		Me.lblNama.Text = "Name"
		'
		'lblUmur
		'
		Me.lblUmur.AutoSize = True
		Me.lblUmur.Font = New System.Drawing.Font("Century Schoolbook", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblUmur.ForeColor = System.Drawing.Color.DeepPink
		Me.lblUmur.Location = New System.Drawing.Point(281, 106)
		Me.lblUmur.Name = "lblUmur"
		Me.lblUmur.Size = New System.Drawing.Size(45, 23)
		Me.lblUmur.TabIndex = 3
		Me.lblUmur.Text = "Age"
		'
		'lblTgl
		'
		Me.lblTgl.AutoSize = True
		Me.lblTgl.Font = New System.Drawing.Font("Century Schoolbook", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTgl.ForeColor = System.Drawing.Color.DeepPink
		Me.lblTgl.Location = New System.Drawing.Point(281, 146)
		Me.lblTgl.Name = "lblTgl"
		Me.lblTgl.Size = New System.Drawing.Size(110, 23)
		Me.lblTgl.TabIndex = 4
		Me.lblTgl.Text = "Birth Date"
		'
		'lblTelp
		'
		Me.lblTelp.AutoSize = True
		Me.lblTelp.Font = New System.Drawing.Font("Century Schoolbook", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTelp.ForeColor = System.Drawing.Color.DeepPink
		Me.lblTelp.Location = New System.Drawing.Point(281, 185)
		Me.lblTelp.Name = "lblTelp"
		Me.lblTelp.Size = New System.Drawing.Size(67, 23)
		Me.lblTelp.TabIndex = 5
		Me.lblTelp.Text = "Phone"
		'
		'lblAlamat
		'
		Me.lblAlamat.AutoSize = True
		Me.lblAlamat.Font = New System.Drawing.Font("Century Schoolbook", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAlamat.ForeColor = System.Drawing.Color.DeepPink
		Me.lblAlamat.Location = New System.Drawing.Point(281, 223)
		Me.lblAlamat.Name = "lblAlamat"
		Me.lblAlamat.Size = New System.Drawing.Size(83, 23)
		Me.lblAlamat.TabIndex = 6
		Me.lblAlamat.Text = "Address"
		'
		'txtNama
		'
		Me.txtNama.Font = New System.Drawing.Font("Century Schoolbook", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtNama.ForeColor = System.Drawing.Color.DeepPink
		Me.txtNama.Location = New System.Drawing.Point(398, 65)
		Me.txtNama.Name = "txtNama"
		Me.txtNama.Size = New System.Drawing.Size(200, 29)
		Me.txtNama.TabIndex = 7
		'
		'txtUmur
		'
		Me.txtUmur.Font = New System.Drawing.Font("Century Schoolbook", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtUmur.ForeColor = System.Drawing.Color.DeepPink
		Me.txtUmur.Location = New System.Drawing.Point(398, 106)
		Me.txtUmur.Name = "txtUmur"
		Me.txtUmur.Size = New System.Drawing.Size(200, 29)
		Me.txtUmur.TabIndex = 8
		'
		'txtTelpon
		'
		Me.txtTelpon.Font = New System.Drawing.Font("Century Schoolbook", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTelpon.ForeColor = System.Drawing.Color.DeepPink
		Me.txtTelpon.Location = New System.Drawing.Point(398, 183)
		Me.txtTelpon.Name = "txtTelpon"
		Me.txtTelpon.Size = New System.Drawing.Size(200, 29)
		Me.txtTelpon.TabIndex = 9
		'
		'txtAlamat
		'
		Me.txtAlamat.Font = New System.Drawing.Font("Century Schoolbook", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtAlamat.ForeColor = System.Drawing.Color.DeepPink
		Me.txtAlamat.Location = New System.Drawing.Point(398, 223)
		Me.txtAlamat.Name = "txtAlamat"
		Me.txtAlamat.Size = New System.Drawing.Size(200, 29)
		Me.txtAlamat.TabIndex = 10
		'
		'dtpTanggal
		'
		Me.dtpTanggal.CalendarForeColor = System.Drawing.Color.DeepPink
		Me.dtpTanggal.CalendarMonthBackground = System.Drawing.Color.Pink
		Me.dtpTanggal.CalendarTitleBackColor = System.Drawing.Color.LavenderBlush
		Me.dtpTanggal.CalendarTitleForeColor = System.Drawing.Color.DeepPink
		Me.dtpTanggal.CalendarTrailingForeColor = System.Drawing.Color.Pink
		Me.dtpTanggal.Font = New System.Drawing.Font("Century Schoolbook", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpTanggal.Location = New System.Drawing.Point(398, 146)
		Me.dtpTanggal.Name = "dtpTanggal"
		Me.dtpTanggal.Size = New System.Drawing.Size(200, 29)
		Me.dtpTanggal.TabIndex = 11
		'
		'grpJK
		'
		Me.grpJK.BackColor = System.Drawing.Color.LavenderBlush
		Me.grpJK.Controls.Add(Me.rbPerempuan)
		Me.grpJK.Controls.Add(Me.rbLaki)
		Me.grpJK.Font = New System.Drawing.Font("Century Schoolbook", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.grpJK.ForeColor = System.Drawing.Color.DeepPink
		Me.grpJK.Location = New System.Drawing.Point(323, 285)
		Me.grpJK.Name = "grpJK"
		Me.grpJK.Size = New System.Drawing.Size(171, 121)
		Me.grpJK.TabIndex = 12
		Me.grpJK.TabStop = False
		Me.grpJK.Text = "Gender"
		'
		'rbPerempuan
		'
		Me.rbPerempuan.AutoSize = True
		Me.rbPerempuan.Location = New System.Drawing.Point(35, 77)
		Me.rbPerempuan.Name = "rbPerempuan"
		Me.rbPerempuan.Size = New System.Drawing.Size(112, 27)
		Me.rbPerempuan.TabIndex = 14
		Me.rbPerempuan.TabStop = True
		Me.rbPerempuan.Text = "Princess"
		Me.rbPerempuan.UseVisualStyleBackColor = True
		'
		'rbLaki
		'
		Me.rbLaki.AutoSize = True
		Me.rbLaki.ForeColor = System.Drawing.Color.DarkSlateBlue
		Me.rbLaki.Location = New System.Drawing.Point(35, 44)
		Me.rbLaki.Name = "rbLaki"
		Me.rbLaki.Size = New System.Drawing.Size(94, 27)
		Me.rbLaki.TabIndex = 13
		Me.rbLaki.TabStop = True
		Me.rbLaki.Text = "Prince"
		Me.rbLaki.UseVisualStyleBackColor = True
		'
		'grpHobby
		'
		Me.grpHobby.BackColor = System.Drawing.Color.LavenderBlush
		Me.grpHobby.Controls.Add(Me.chkBerkuda)
		Me.grpHobby.Controls.Add(Me.chkMerajut)
		Me.grpHobby.Controls.Add(Me.chkMenari)
		Me.grpHobby.Controls.Add(Me.chkMenyanyi)
		Me.grpHobby.Controls.Add(Me.chkMemasak)
		Me.grpHobby.Controls.Add(Me.chkMemancing)
		Me.grpHobby.Controls.Add(Me.chkMenulis)
		Me.grpHobby.Controls.Add(Me.chkMenggambar)
		Me.grpHobby.Controls.Add(Me.chkMembaca)
		Me.grpHobby.Controls.Add(Me.chkTraveling)
		Me.grpHobby.Controls.Add(Me.chkCoding)
		Me.grpHobby.Controls.Add(Me.chkGaming)
		Me.grpHobby.Font = New System.Drawing.Font("Century Schoolbook", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.grpHobby.ForeColor = System.Drawing.Color.DeepPink
		Me.grpHobby.Location = New System.Drawing.Point(544, 285)
		Me.grpHobby.Name = "grpHobby"
		Me.grpHobby.Size = New System.Drawing.Size(298, 224)
		Me.grpHobby.TabIndex = 15
		Me.grpHobby.TabStop = False
		Me.grpHobby.Text = "Hobby"
		'
		'chkBerkuda
		'
		Me.chkBerkuda.AutoSize = True
		Me.chkBerkuda.Location = New System.Drawing.Point(163, 181)
		Me.chkBerkuda.Name = "chkBerkuda"
		Me.chkBerkuda.Size = New System.Drawing.Size(108, 26)
		Me.chkBerkuda.TabIndex = 26
		Me.chkBerkuda.Text = "Berkuda"
		Me.chkBerkuda.UseVisualStyleBackColor = True
		'
		'chkMerajut
		'
		Me.chkMerajut.AutoSize = True
		Me.chkMerajut.Location = New System.Drawing.Point(6, 181)
		Me.chkMerajut.Name = "chkMerajut"
		Me.chkMerajut.Size = New System.Drawing.Size(103, 26)
		Me.chkMerajut.TabIndex = 25
		Me.chkMerajut.Text = "Merajut"
		Me.chkMerajut.UseVisualStyleBackColor = True
		'
		'chkMenari
		'
		Me.chkMenari.AutoSize = True
		Me.chkMenari.Location = New System.Drawing.Point(163, 151)
		Me.chkMenari.Name = "chkMenari"
		Me.chkMenari.Size = New System.Drawing.Size(97, 26)
		Me.chkMenari.TabIndex = 24
		Me.chkMenari.Text = "Menari"
		Me.chkMenari.UseVisualStyleBackColor = True
		'
		'chkMenyanyi
		'
		Me.chkMenyanyi.AutoSize = True
		Me.chkMenyanyi.Location = New System.Drawing.Point(163, 121)
		Me.chkMenyanyi.Name = "chkMenyanyi"
		Me.chkMenyanyi.Size = New System.Drawing.Size(120, 26)
		Me.chkMenyanyi.TabIndex = 23
		Me.chkMenyanyi.Text = "Menyanyi"
		Me.chkMenyanyi.UseVisualStyleBackColor = True
		'
		'chkMemasak
		'
		Me.chkMemasak.AutoSize = True
		Me.chkMemasak.Location = New System.Drawing.Point(163, 91)
		Me.chkMemasak.Name = "chkMemasak"
		Me.chkMemasak.Size = New System.Drawing.Size(117, 26)
		Me.chkMemasak.TabIndex = 22
		Me.chkMemasak.Text = "Memasak"
		Me.chkMemasak.UseVisualStyleBackColor = True
		'
		'chkMemancing
		'
		Me.chkMemancing.AutoSize = True
		Me.chkMemancing.Location = New System.Drawing.Point(163, 61)
		Me.chkMemancing.Name = "chkMemancing"
		Me.chkMemancing.Size = New System.Drawing.Size(134, 26)
		Me.chkMemancing.TabIndex = 21
		Me.chkMemancing.Text = "Memancing"
		Me.chkMemancing.UseVisualStyleBackColor = True
		'
		'chkMenulis
		'
		Me.chkMenulis.AutoSize = True
		Me.chkMenulis.Location = New System.Drawing.Point(163, 32)
		Me.chkMenulis.Name = "chkMenulis"
		Me.chkMenulis.Size = New System.Drawing.Size(104, 26)
		Me.chkMenulis.TabIndex = 20
		Me.chkMenulis.Text = "Menulis"
		Me.chkMenulis.UseVisualStyleBackColor = True
		'
		'chkMenggambar
		'
		Me.chkMenggambar.AutoSize = True
		Me.chkMenggambar.Location = New System.Drawing.Point(6, 151)
		Me.chkMenggambar.Name = "chkMenggambar"
		Me.chkMenggambar.Size = New System.Drawing.Size(147, 26)
		Me.chkMenggambar.TabIndex = 19
		Me.chkMenggambar.Text = "Menggambar"
		Me.chkMenggambar.UseVisualStyleBackColor = True
		'
		'chkMembaca
		'
		Me.chkMembaca.AutoSize = True
		Me.chkMembaca.Location = New System.Drawing.Point(6, 121)
		Me.chkMembaca.Name = "chkMembaca"
		Me.chkMembaca.Size = New System.Drawing.Size(116, 26)
		Me.chkMembaca.TabIndex = 18
		Me.chkMembaca.Text = "Membaca"
		Me.chkMembaca.UseVisualStyleBackColor = True
		'
		'chkTraveling
		'
		Me.chkTraveling.AutoSize = True
		Me.chkTraveling.Location = New System.Drawing.Point(6, 91)
		Me.chkTraveling.Name = "chkTraveling"
		Me.chkTraveling.Size = New System.Drawing.Size(118, 26)
		Me.chkTraveling.TabIndex = 17
		Me.chkTraveling.Text = "Traveling"
		Me.chkTraveling.UseVisualStyleBackColor = True
		'
		'chkCoding
		'
		Me.chkCoding.AutoSize = True
		Me.chkCoding.Location = New System.Drawing.Point(6, 61)
		Me.chkCoding.Name = "chkCoding"
		Me.chkCoding.Size = New System.Drawing.Size(95, 26)
		Me.chkCoding.TabIndex = 16
		Me.chkCoding.Text = "Coding"
		Me.chkCoding.UseVisualStyleBackColor = True
		'
		'chkGaming
		'
		Me.chkGaming.AutoSize = True
		Me.chkGaming.Location = New System.Drawing.Point(6, 31)
		Me.chkGaming.Name = "chkGaming"
		Me.chkGaming.Size = New System.Drawing.Size(103, 26)
		Me.chkGaming.TabIndex = 0
		Me.chkGaming.Text = "Gaming"
		Me.chkGaming.UseVisualStyleBackColor = True
		'
		'btnCetak
		'
		Me.btnCetak.Font = New System.Drawing.Font("Century Schoolbook", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCetak.ForeColor = System.Drawing.Color.DeepPink
		Me.btnCetak.Location = New System.Drawing.Point(323, 436)
		Me.btnCetak.Name = "btnCetak"
		Me.btnCetak.Size = New System.Drawing.Size(171, 37)
		Me.btnCetak.TabIndex = 16
		Me.btnCetak.Text = "Print Card"
		Me.btnCetak.UseVisualStyleBackColor = True
		'
		'PictureBox2
		'
		Me.PictureBox2.Image = Global.POSTTEST_3.My.Resources.Resources.download__7__removebg_preview1
		Me.PictureBox2.Location = New System.Drawing.Point(21, 327)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(236, 175)
		Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox2.TabIndex = 18
		Me.PictureBox2.TabStop = False
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.POSTTEST_3.My.Resources.Resources.download__7__removebg_preview1
		Me.PictureBox1.Location = New System.Drawing.Point(606, 12)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(236, 264)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 17
		Me.PictureBox1.TabStop = False
		'
		'picFoto
		'
		Me.picFoto.BackColor = System.Drawing.Color.LavenderBlush
		Me.picFoto.Location = New System.Drawing.Point(41, 40)
		Me.picFoto.Name = "picFoto"
		Me.picFoto.Size = New System.Drawing.Size(196, 236)
		Me.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.picFoto.TabIndex = 0
		Me.picFoto.TabStop = False
		'
		'FormCetak
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Pink
		Me.ClientSize = New System.Drawing.Size(854, 527)
		Me.Controls.Add(Me.PictureBox2)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.btnCetak)
		Me.Controls.Add(Me.grpHobby)
		Me.Controls.Add(Me.grpJK)
		Me.Controls.Add(Me.dtpTanggal)
		Me.Controls.Add(Me.txtAlamat)
		Me.Controls.Add(Me.txtTelpon)
		Me.Controls.Add(Me.txtUmur)
		Me.Controls.Add(Me.txtNama)
		Me.Controls.Add(Me.lblAlamat)
		Me.Controls.Add(Me.lblTelp)
		Me.Controls.Add(Me.lblTgl)
		Me.Controls.Add(Me.lblUmur)
		Me.Controls.Add(Me.lblNama)
		Me.Controls.Add(Me.btnBrowse)
		Me.Controls.Add(Me.picFoto)
		Me.Name = "FormCetak"
		Me.Text = "Form Cetak"
		Me.grpJK.ResumeLayout(False)
		Me.grpJK.PerformLayout()
		Me.grpHobby.ResumeLayout(False)
		Me.grpHobby.PerformLayout()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picFoto, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents picFoto As PictureBox
    Friend WithEvents btnBrowse As Button
	Friend WithEvents lblNama As Label
	Friend WithEvents lblUmur As Label
	Friend WithEvents lblTgl As Label
	Friend WithEvents lblTelp As Label
	Friend WithEvents lblAlamat As Label
	Friend WithEvents txtNama As TextBox
	Friend WithEvents txtUmur As TextBox
	Friend WithEvents txtTelpon As TextBox
	Friend WithEvents txtAlamat As TextBox
	Friend WithEvents dtpTanggal As DateTimePicker
	Friend WithEvents grpJK As GroupBox
	Friend WithEvents rbPerempuan As RadioButton
	Friend WithEvents rbLaki As RadioButton
	Friend WithEvents grpHobby As GroupBox
	Friend WithEvents chkMenari As CheckBox
	Friend WithEvents chkMenyanyi As CheckBox
	Friend WithEvents chkMemasak As CheckBox
	Friend WithEvents chkMemancing As CheckBox
	Friend WithEvents chkMenulis As CheckBox
	Friend WithEvents chkMenggambar As CheckBox
	Friend WithEvents chkMembaca As CheckBox
	Friend WithEvents chkTraveling As CheckBox
	Friend WithEvents chkCoding As CheckBox
	Friend WithEvents chkGaming As CheckBox
	Friend WithEvents chkBerkuda As CheckBox
	Friend WithEvents chkMerajut As CheckBox
	Friend WithEvents btnCetak As Button
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents PictureBox2 As PictureBox
End Class
