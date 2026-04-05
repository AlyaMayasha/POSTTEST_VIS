<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.mnuInputData = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuLihatKartu = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuSimpan = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuBuka = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuKeluar = New System.Windows.Forms.ToolStripMenuItem()
		Me.TabControl1 = New System.Windows.Forms.TabControl()
		Me.tabDataUtama = New System.Windows.Forms.TabPage()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.cboTipePokemon = New System.Windows.Forms.ComboBox()
		Me.rbPerempuan = New System.Windows.Forms.RadioButton()
		Me.rbLaki = New System.Windows.Forms.RadioButton()
		Me.dtpTanggalLahir = New System.Windows.Forms.DateTimePicker()
		Me.txtID = New System.Windows.Forms.TextBox()
		Me.txtNama = New System.Windows.Forms.TextBox()
		Me.tabKontak = New System.Windows.Forms.TabPage()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.txtAlamat = New System.Windows.Forms.TextBox()
		Me.txtEmail = New System.Windows.Forms.TextBox()
		Me.mtbTelepon = New System.Windows.Forms.MaskedTextBox()
		Me.tabProfil = New System.Windows.Forms.TabPage()
		Me.btnSimpanCetak = New System.Windows.Forms.Button()
		Me.gbRole = New System.Windows.Forms.GroupBox()
		Me.RadioButton5 = New System.Windows.Forms.RadioButton()
		Me.RadioButton4 = New System.Windows.Forms.RadioButton()
		Me.RadioButton3 = New System.Windows.Forms.RadioButton()
		Me.RadioButton2 = New System.Windows.Forms.RadioButton()
		Me.RadioButton1 = New System.Windows.Forms.RadioButton()
		Me.btnBrowseFoto = New System.Windows.Forms.Button()
		Me.gbActivity = New System.Windows.Forms.GroupBox()
		Me.CheckBox1 = New System.Windows.Forms.CheckBox()
		Me.CheckBox2 = New System.Windows.Forms.CheckBox()
		Me.CheckBox3 = New System.Windows.Forms.CheckBox()
		Me.CheckBox4 = New System.Windows.Forms.CheckBox()
		Me.CheckBox5 = New System.Windows.Forms.CheckBox()
		Me.CheckBox6 = New System.Windows.Forms.CheckBox()
		Me.CheckBox7 = New System.Windows.Forms.CheckBox()
		Me.CheckBox8 = New System.Windows.Forms.CheckBox()
		Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.PictureBox5 = New System.Windows.Forms.PictureBox()
		Me.PictureBox6 = New System.Windows.Forms.PictureBox()
		Me.PictureBox3 = New System.Windows.Forms.PictureBox()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.PictureBox4 = New System.Windows.Forms.PictureBox()
		Me.PictureBox9 = New System.Windows.Forms.PictureBox()
		Me.PicProfil = New System.Windows.Forms.PictureBox()
		Me.PictureBox8 = New System.Windows.Forms.PictureBox()
		Me.PictureBox7 = New System.Windows.Forms.PictureBox()
		Me.MenuStrip1.SuspendLayout()
		Me.TabControl1.SuspendLayout()
		Me.tabDataUtama.SuspendLayout()
		Me.tabKontak.SuspendLayout()
		Me.tabProfil.SuspendLayout()
		Me.gbRole.SuspendLayout()
		Me.gbActivity.SuspendLayout()
		CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PicProfil, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'MenuStrip1
		'
		Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
		Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuInputData, Me.mnuLihatKartu, Me.mnuSimpan, Me.mnuBuka, Me.mnuKeluar})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(880, 33)
		Me.MenuStrip1.TabIndex = 0
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'mnuInputData
		'
		Me.mnuInputData.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.mnuInputData.ForeColor = System.Drawing.Color.DeepPink
		Me.mnuInputData.Name = "mnuInputData"
		Me.mnuInputData.Size = New System.Drawing.Size(119, 32)
		Me.mnuInputData.Text = "Input Data"
		'
		'mnuLihatKartu
		'
		Me.mnuLihatKartu.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.mnuLihatKartu.ForeColor = System.Drawing.Color.DeepPink
		Me.mnuLihatKartu.Name = "mnuLihatKartu"
		Me.mnuLihatKartu.Size = New System.Drawing.Size(123, 32)
		Me.mnuLihatKartu.Text = "Lihat Kartu"
		'
		'mnuSimpan
		'
		Me.mnuSimpan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.mnuSimpan.ForeColor = System.Drawing.Color.DeepPink
		Me.mnuSimpan.Name = "mnuSimpan"
		Me.mnuSimpan.Size = New System.Drawing.Size(136, 32)
		Me.mnuSimpan.Text = "Simpan Data"
		'
		'mnuBuka
		'
		Me.mnuBuka.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.mnuBuka.ForeColor = System.Drawing.Color.DeepPink
		Me.mnuBuka.Name = "mnuBuka"
		Me.mnuBuka.Size = New System.Drawing.Size(116, 32)
		Me.mnuBuka.Text = "Buka Data"
		'
		'mnuKeluar
		'
		Me.mnuKeluar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.mnuKeluar.ForeColor = System.Drawing.Color.DeepPink
		Me.mnuKeluar.Name = "mnuKeluar"
		Me.mnuKeluar.Size = New System.Drawing.Size(83, 32)
		Me.mnuKeluar.Text = "Keluar"
		'
		'TabControl1
		'
		Me.TabControl1.Controls.Add(Me.tabDataUtama)
		Me.TabControl1.Controls.Add(Me.tabKontak)
		Me.TabControl1.Controls.Add(Me.tabProfil)
		Me.TabControl1.Location = New System.Drawing.Point(86, 166)
		Me.TabControl1.Name = "TabControl1"
		Me.TabControl1.SelectedIndex = 0
		Me.TabControl1.Size = New System.Drawing.Size(705, 520)
		Me.TabControl1.TabIndex = 1
		'
		'tabDataUtama
		'
		Me.tabDataUtama.BackColor = System.Drawing.Color.PaleTurquoise
		Me.tabDataUtama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.tabDataUtama.Controls.Add(Me.Label5)
		Me.tabDataUtama.Controls.Add(Me.Label4)
		Me.tabDataUtama.Controls.Add(Me.Label3)
		Me.tabDataUtama.Controls.Add(Me.Label2)
		Me.tabDataUtama.Controls.Add(Me.Label1)
		Me.tabDataUtama.Controls.Add(Me.cboTipePokemon)
		Me.tabDataUtama.Controls.Add(Me.rbPerempuan)
		Me.tabDataUtama.Controls.Add(Me.rbLaki)
		Me.tabDataUtama.Controls.Add(Me.dtpTanggalLahir)
		Me.tabDataUtama.Controls.Add(Me.txtID)
		Me.tabDataUtama.Controls.Add(Me.txtNama)
		Me.tabDataUtama.Controls.Add(Me.PictureBox5)
		Me.tabDataUtama.Controls.Add(Me.PictureBox6)
		Me.tabDataUtama.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tabDataUtama.ForeColor = System.Drawing.Color.DeepPink
		Me.tabDataUtama.Location = New System.Drawing.Point(4, 29)
		Me.tabDataUtama.Name = "tabDataUtama"
		Me.tabDataUtama.Padding = New System.Windows.Forms.Padding(3)
		Me.tabDataUtama.Size = New System.Drawing.Size(697, 487)
		Me.tabDataUtama.TabIndex = 0
		Me.tabDataUtama.Text = "Main Data"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.BackColor = System.Drawing.SystemColors.Control
		Me.Label5.Location = New System.Drawing.Point(84, 366)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(123, 21)
		Me.Label5.TabIndex = 10
		Me.Label5.Text = "Pokemon Type"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.BackColor = System.Drawing.SystemColors.Control
		Me.Label4.Location = New System.Drawing.Point(84, 301)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(65, 21)
		Me.Label4.TabIndex = 9
		Me.Label4.Text = "Gender"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.BackColor = System.Drawing.SystemColors.Control
		Me.Label3.Location = New System.Drawing.Point(84, 231)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(87, 21)
		Me.Label3.TabIndex = 8
		Me.Label3.Text = "Birth Date"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.BackColor = System.Drawing.SystemColors.Control
		Me.Label2.Location = New System.Drawing.Point(84, 165)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(95, 21)
		Me.Label2.TabIndex = 7
		Me.Label2.Text = "ID Member"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Location = New System.Drawing.Point(84, 104)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(56, 21)
		Me.Label1.TabIndex = 6
		Me.Label1.Text = "Name"
		'
		'cboTipePokemon
		'
		Me.cboTipePokemon.ForeColor = System.Drawing.Color.DeepPink
		Me.cboTipePokemon.FormattingEnabled = True
		Me.cboTipePokemon.Items.AddRange(New Object() {"Fire", "Water", "Grass", "Electric", "Psychic", "Dragon"})
		Me.cboTipePokemon.Location = New System.Drawing.Point(291, 363)
		Me.cboTipePokemon.Name = "cboTipePokemon"
		Me.cboTipePokemon.Size = New System.Drawing.Size(277, 29)
		Me.cboTipePokemon.TabIndex = 5
		'
		'rbPerempuan
		'
		Me.rbPerempuan.AutoSize = True
		Me.rbPerempuan.BackColor = System.Drawing.SystemColors.Control
		Me.rbPerempuan.Location = New System.Drawing.Point(443, 299)
		Me.rbPerempuan.Name = "rbPerempuan"
		Me.rbPerempuan.Size = New System.Drawing.Size(90, 25)
		Me.rbPerempuan.TabIndex = 4
		Me.rbPerempuan.TabStop = True
		Me.rbPerempuan.Text = "Female"
		Me.rbPerempuan.UseVisualStyleBackColor = False
		'
		'rbLaki
		'
		Me.rbLaki.AutoSize = True
		Me.rbLaki.BackColor = System.Drawing.SystemColors.Control
		Me.rbLaki.ForeColor = System.Drawing.Color.DarkTurquoise
		Me.rbLaki.Location = New System.Drawing.Point(341, 299)
		Me.rbLaki.Name = "rbLaki"
		Me.rbLaki.Size = New System.Drawing.Size(73, 25)
		Me.rbLaki.TabIndex = 3
		Me.rbLaki.TabStop = True
		Me.rbLaki.Text = "Male"
		Me.rbLaki.UseVisualStyleBackColor = False
		'
		'dtpTanggalLahir
		'
		Me.dtpTanggalLahir.CalendarForeColor = System.Drawing.Color.DeepPink
		Me.dtpTanggalLahir.Location = New System.Drawing.Point(291, 225)
		Me.dtpTanggalLahir.MaxDate = New Date(2026, 4, 4, 0, 0, 0, 0)
		Me.dtpTanggalLahir.Name = "dtpTanggalLahir"
		Me.dtpTanggalLahir.Size = New System.Drawing.Size(277, 29)
		Me.dtpTanggalLahir.TabIndex = 2
		Me.dtpTanggalLahir.Value = New Date(2026, 4, 4, 0, 0, 0, 0)
		'
		'txtID
		'
		Me.txtID.ForeColor = System.Drawing.Color.DeepPink
		Me.txtID.Location = New System.Drawing.Point(291, 159)
		Me.txtID.Name = "txtID"
		Me.txtID.Size = New System.Drawing.Size(277, 29)
		Me.txtID.TabIndex = 1
		'
		'txtNama
		'
		Me.txtNama.ForeColor = System.Drawing.Color.DeepPink
		Me.txtNama.Location = New System.Drawing.Point(291, 98)
		Me.txtNama.Name = "txtNama"
		Me.txtNama.Size = New System.Drawing.Size(277, 29)
		Me.txtNama.TabIndex = 0
		'
		'tabKontak
		'
		Me.tabKontak.BackColor = System.Drawing.Color.Pink
		Me.tabKontak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.tabKontak.Controls.Add(Me.PictureBox3)
		Me.tabKontak.Controls.Add(Me.Label8)
		Me.tabKontak.Controls.Add(Me.Label7)
		Me.tabKontak.Controls.Add(Me.Label6)
		Me.tabKontak.Controls.Add(Me.txtAlamat)
		Me.tabKontak.Controls.Add(Me.txtEmail)
		Me.tabKontak.Controls.Add(Me.mtbTelepon)
		Me.tabKontak.Controls.Add(Me.PictureBox2)
		Me.tabKontak.Controls.Add(Me.PictureBox4)
		Me.tabKontak.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tabKontak.ForeColor = System.Drawing.Color.DeepPink
		Me.tabKontak.Location = New System.Drawing.Point(4, 29)
		Me.tabKontak.Name = "tabKontak"
		Me.tabKontak.Padding = New System.Windows.Forms.Padding(3)
		Me.tabKontak.Size = New System.Drawing.Size(697, 487)
		Me.tabKontak.TabIndex = 1
		Me.tabKontak.Text = "Contact & Info"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.BackColor = System.Drawing.SystemColors.Control
		Me.Label8.Location = New System.Drawing.Point(87, 265)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(110, 21)
		Me.Label8.TabIndex = 9
		Me.Label8.Text = "Home Adress"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.BackColor = System.Drawing.SystemColors.Control
		Me.Label7.Location = New System.Drawing.Point(87, 185)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(117, 21)
		Me.Label7.TabIndex = 8
		Me.Label7.Text = "Email Address"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.BackColor = System.Drawing.SystemColors.Control
		Me.Label6.Location = New System.Drawing.Point(87, 112)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(59, 21)
		Me.Label6.TabIndex = 7
		Me.Label6.Text = "Phone"
		'
		'txtAlamat
		'
		Me.txtAlamat.ForeColor = System.Drawing.Color.DeepPink
		Me.txtAlamat.Location = New System.Drawing.Point(316, 265)
		Me.txtAlamat.Multiline = True
		Me.txtAlamat.Name = "txtAlamat"
		Me.txtAlamat.Size = New System.Drawing.Size(267, 146)
		Me.txtAlamat.TabIndex = 2
		'
		'txtEmail
		'
		Me.txtEmail.ForeColor = System.Drawing.Color.DeepPink
		Me.txtEmail.Location = New System.Drawing.Point(316, 179)
		Me.txtEmail.Name = "txtEmail"
		Me.txtEmail.Size = New System.Drawing.Size(267, 29)
		Me.txtEmail.TabIndex = 1
		'
		'mtbTelepon
		'
		Me.mtbTelepon.ForeColor = System.Drawing.Color.DeepPink
		Me.mtbTelepon.Location = New System.Drawing.Point(316, 106)
		Me.mtbTelepon.Mask = "0000-0000-0000"
		Me.mtbTelepon.Name = "mtbTelepon"
		Me.mtbTelepon.Size = New System.Drawing.Size(267, 29)
		Me.mtbTelepon.TabIndex = 0
		'
		'tabProfil
		'
		Me.tabProfil.BackColor = System.Drawing.Color.Thistle
		Me.tabProfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.tabProfil.Controls.Add(Me.btnSimpanCetak)
		Me.tabProfil.Controls.Add(Me.gbRole)
		Me.tabProfil.Controls.Add(Me.btnBrowseFoto)
		Me.tabProfil.Controls.Add(Me.gbActivity)
		Me.tabProfil.Controls.Add(Me.PicProfil)
		Me.tabProfil.Controls.Add(Me.PictureBox8)
		Me.tabProfil.Controls.Add(Me.PictureBox9)
		Me.tabProfil.Controls.Add(Me.PictureBox7)
		Me.tabProfil.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tabProfil.ForeColor = System.Drawing.Color.DeepPink
		Me.tabProfil.Location = New System.Drawing.Point(4, 29)
		Me.tabProfil.Name = "tabProfil"
		Me.tabProfil.Padding = New System.Windows.Forms.Padding(3)
		Me.tabProfil.Size = New System.Drawing.Size(697, 487)
		Me.tabProfil.TabIndex = 2
		Me.tabProfil.Text = "Profil & Activity"
		'
		'btnSimpanCetak
		'
		Me.btnSimpanCetak.BackColor = System.Drawing.SystemColors.Control
		Me.btnSimpanCetak.FlatAppearance.BorderColor = System.Drawing.Color.DeepPink
		Me.btnSimpanCetak.FlatAppearance.BorderSize = 2
		Me.btnSimpanCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSimpanCetak.Location = New System.Drawing.Point(236, 423)
		Me.btnSimpanCetak.Name = "btnSimpanCetak"
		Me.btnSimpanCetak.Size = New System.Drawing.Size(181, 38)
		Me.btnSimpanCetak.TabIndex = 7
		Me.btnSimpanCetak.Text = "Save and Print"
		Me.btnSimpanCetak.UseVisualStyleBackColor = False
		'
		'gbRole
		'
		Me.gbRole.BackColor = System.Drawing.SystemColors.Control
		Me.gbRole.Controls.Add(Me.RadioButton5)
		Me.gbRole.Controls.Add(Me.RadioButton4)
		Me.gbRole.Controls.Add(Me.RadioButton3)
		Me.gbRole.Controls.Add(Me.RadioButton2)
		Me.gbRole.Controls.Add(Me.RadioButton1)
		Me.gbRole.Location = New System.Drawing.Point(283, 25)
		Me.gbRole.Name = "gbRole"
		Me.gbRole.Size = New System.Drawing.Size(309, 161)
		Me.gbRole.TabIndex = 2
		Me.gbRole.TabStop = False
		Me.gbRole.Text = "Role"
		'
		'RadioButton5
		'
		Me.RadioButton5.AutoSize = True
		Me.RadioButton5.Location = New System.Drawing.Point(157, 83)
		Me.RadioButton5.Name = "RadioButton5"
		Me.RadioButton5.Size = New System.Drawing.Size(94, 25)
		Me.RadioButton5.TabIndex = 4
		Me.RadioButton5.TabStop = True
		Me.RadioButton5.Text = "Breeder"
		Me.RadioButton5.UseVisualStyleBackColor = True
		'
		'RadioButton4
		'
		Me.RadioButton4.AutoSize = True
		Me.RadioButton4.Location = New System.Drawing.Point(157, 53)
		Me.RadioButton4.Name = "RadioButton4"
		Me.RadioButton4.Size = New System.Drawing.Size(106, 25)
		Me.RadioButton4.TabIndex = 3
		Me.RadioButton4.TabStop = True
		Me.RadioButton4.Text = "Professor"
		Me.RadioButton4.UseVisualStyleBackColor = True
		'
		'RadioButton3
		'
		Me.RadioButton3.AutoSize = True
		Me.RadioButton3.Location = New System.Drawing.Point(18, 94)
		Me.RadioButton3.Name = "RadioButton3"
		Me.RadioButton3.Size = New System.Drawing.Size(107, 25)
		Me.RadioButton3.TabIndex = 2
		Me.RadioButton3.TabStop = True
		Me.RadioButton3.Text = "Elite Four"
		Me.RadioButton3.UseVisualStyleBackColor = True
		'
		'RadioButton2
		'
		Me.RadioButton2.AutoSize = True
		Me.RadioButton2.Location = New System.Drawing.Point(18, 64)
		Me.RadioButton2.Name = "RadioButton2"
		Me.RadioButton2.Size = New System.Drawing.Size(125, 25)
		Me.RadioButton2.TabIndex = 1
		Me.RadioButton2.TabStop = True
		Me.RadioButton2.Text = "Gym Leader"
		Me.RadioButton2.UseVisualStyleBackColor = True
		'
		'RadioButton1
		'
		Me.RadioButton1.AutoSize = True
		Me.RadioButton1.Location = New System.Drawing.Point(18, 34)
		Me.RadioButton1.Name = "RadioButton1"
		Me.RadioButton1.Size = New System.Drawing.Size(88, 25)
		Me.RadioButton1.TabIndex = 0
		Me.RadioButton1.TabStop = True
		Me.RadioButton1.Text = "Trainer"
		Me.RadioButton1.UseVisualStyleBackColor = True
		'
		'btnBrowseFoto
		'
		Me.btnBrowseFoto.BackColor = System.Drawing.SystemColors.Control
		Me.btnBrowseFoto.FlatAppearance.BorderColor = System.Drawing.Color.DeepPink
		Me.btnBrowseFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnBrowseFoto.Location = New System.Drawing.Point(89, 312)
		Me.btnBrowseFoto.Name = "btnBrowseFoto"
		Me.btnBrowseFoto.Size = New System.Drawing.Size(88, 36)
		Me.btnBrowseFoto.TabIndex = 1
		Me.btnBrowseFoto.Text = "Browse"
		Me.btnBrowseFoto.UseVisualStyleBackColor = False
		'
		'gbActivity
		'
		Me.gbActivity.BackColor = System.Drawing.SystemColors.Control
		Me.gbActivity.Controls.Add(Me.CheckBox1)
		Me.gbActivity.Controls.Add(Me.CheckBox2)
		Me.gbActivity.Controls.Add(Me.CheckBox3)
		Me.gbActivity.Controls.Add(Me.CheckBox4)
		Me.gbActivity.Controls.Add(Me.CheckBox5)
		Me.gbActivity.Controls.Add(Me.CheckBox6)
		Me.gbActivity.Controls.Add(Me.CheckBox7)
		Me.gbActivity.Controls.Add(Me.CheckBox8)
		Me.gbActivity.Location = New System.Drawing.Point(255, 206)
		Me.gbActivity.Name = "gbActivity"
		Me.gbActivity.Size = New System.Drawing.Size(389, 194)
		Me.gbActivity.TabIndex = 6
		Me.gbActivity.TabStop = False
		Me.gbActivity.Text = "Activity"
		'
		'CheckBox1
		'
		Me.CheckBox1.AutoSize = True
		Me.CheckBox1.Location = New System.Drawing.Point(18, 28)
		Me.CheckBox1.Name = "CheckBox1"
		Me.CheckBox1.Size = New System.Drawing.Size(181, 25)
		Me.CheckBox1.TabIndex = 3
		Me.CheckBox1.Text = "Catching Pokemon"
		Me.CheckBox1.UseVisualStyleBackColor = True
		'
		'CheckBox2
		'
		Me.CheckBox2.AutoSize = True
		Me.CheckBox2.Location = New System.Drawing.Point(18, 66)
		Me.CheckBox2.Name = "CheckBox2"
		Me.CheckBox2.Size = New System.Drawing.Size(176, 25)
		Me.CheckBox2.TabIndex = 4
		Me.CheckBox2.Text = "Pokemon Training"
		Me.CheckBox2.UseVisualStyleBackColor = True
		'
		'CheckBox3
		'
		Me.CheckBox3.AutoSize = True
		Me.CheckBox3.Location = New System.Drawing.Point(18, 106)
		Me.CheckBox3.Name = "CheckBox3"
		Me.CheckBox3.Size = New System.Drawing.Size(120, 25)
		Me.CheckBox3.TabIndex = 5
		Me.CheckBox3.Text = "Gym Battle"
		Me.CheckBox3.UseVisualStyleBackColor = True
		'
		'CheckBox4
		'
		Me.CheckBox4.AutoSize = True
		Me.CheckBox4.Location = New System.Drawing.Point(18, 144)
		Me.CheckBox4.Name = "CheckBox4"
		Me.CheckBox4.Size = New System.Drawing.Size(166, 25)
		Me.CheckBox4.TabIndex = 6
		Me.CheckBox4.Text = "Collecting Badge"
		Me.CheckBox4.UseVisualStyleBackColor = True
		'
		'CheckBox5
		'
		Me.CheckBox5.AutoSize = True
		Me.CheckBox5.Location = New System.Drawing.Point(205, 28)
		Me.CheckBox5.Name = "CheckBox5"
		Me.CheckBox5.Size = New System.Drawing.Size(182, 25)
		Me.CheckBox5.TabIndex = 7
		Me.CheckBox5.Text = "Pokemon Breeding"
		Me.CheckBox5.UseVisualStyleBackColor = True
		'
		'CheckBox6
		'
		Me.CheckBox6.AutoSize = True
		Me.CheckBox6.Location = New System.Drawing.Point(205, 66)
		Me.CheckBox6.Name = "CheckBox6"
		Me.CheckBox6.Size = New System.Drawing.Size(168, 25)
		Me.CheckBox6.TabIndex = 8
		Me.CheckBox6.Text = "Exploring Region"
		Me.CheckBox6.UseVisualStyleBackColor = True
		'
		'CheckBox7
		'
		Me.CheckBox7.AutoSize = True
		Me.CheckBox7.Location = New System.Drawing.Point(205, 106)
		Me.CheckBox7.Name = "CheckBox7"
		Me.CheckBox7.Size = New System.Drawing.Size(146, 25)
		Me.CheckBox7.TabIndex = 9
		Me.CheckBox7.Text = "Shiny Hunting"
		Me.CheckBox7.UseVisualStyleBackColor = True
		'
		'CheckBox8
		'
		Me.CheckBox8.AutoSize = True
		Me.CheckBox8.Location = New System.Drawing.Point(205, 144)
		Me.CheckBox8.Name = "CheckBox8"
		Me.CheckBox8.Size = New System.Drawing.Size(119, 25)
		Me.CheckBox8.TabIndex = 10
		Me.CheckBox8.Text = "Raid Battle"
		Me.CheckBox8.UseVisualStyleBackColor = True
		'
		'ErrorProvider1
		'
		Me.ErrorProvider1.ContainerControl = Me
		'
		'OpenFileDialog1
		'
		Me.OpenFileDialog1.FileName = "OpenFileDialog1"
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Font = New System.Drawing.Font("Bauhaus 93", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.ForeColor = System.Drawing.Color.LightPink
		Me.Label9.Location = New System.Drawing.Point(83, 107)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(476, 40)
		Me.Label9.TabIndex = 11
		Me.Label9.Text = "Pokemon Trainer Community"
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Font = New System.Drawing.Font("Bauhaus 93", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label10.ForeColor = System.Drawing.Color.DeepPink
		Me.Label10.Location = New System.Drawing.Point(83, 67)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(476, 40)
		Me.Label10.TabIndex = 13
		Me.Label10.Text = "Pokemon Trainer Community"
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.POSTTEST_4.My.Resources.Resources._____Photo_removebg_preview
		Me.PictureBox1.Location = New System.Drawing.Point(604, -2)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(293, 106)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 12
		Me.PictureBox1.TabStop = False
		'
		'PictureBox5
		'
		Me.PictureBox5.Image = Global.POSTTEST_4.My.Resources.Resources.Glaceon_removebg_preview
		Me.PictureBox5.Location = New System.Drawing.Point(-25, 2)
		Me.PictureBox5.Name = "PictureBox5"
		Me.PictureBox5.Size = New System.Drawing.Size(146, 125)
		Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox5.TabIndex = 11
		Me.PictureBox5.TabStop = False
		'
		'PictureBox6
		'
		Me.PictureBox6.Image = Global.POSTTEST_4.My.Resources.Resources.Vaporeon_removebg_preview
		Me.PictureBox6.Location = New System.Drawing.Point(529, 159)
		Me.PictureBox6.Name = "PictureBox6"
		Me.PictureBox6.Size = New System.Drawing.Size(171, 407)
		Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox6.TabIndex = 12
		Me.PictureBox6.TabStop = False
		'
		'PictureBox3
		'
		Me.PictureBox3.Image = Global.POSTTEST_4.My.Resources.Resources.download__10__removebg_preview
		Me.PictureBox3.Location = New System.Drawing.Point(-19, -1)
		Me.PictureBox3.Name = "PictureBox3"
		Me.PictureBox3.Size = New System.Drawing.Size(165, 110)
		Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox3.TabIndex = 15
		Me.PictureBox3.TabStop = False
		'
		'PictureBox2
		'
		Me.PictureBox2.Image = Global.POSTTEST_4.My.Resources.Resources.Slyveon_removebg_preview
		Me.PictureBox2.Location = New System.Drawing.Point(-19, 268)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(308, 218)
		Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox2.TabIndex = 14
		Me.PictureBox2.TabStop = False
		'
		'PictureBox4
		'
		Me.PictureBox4.Image = Global.POSTTEST_4.My.Resources.Resources.Sylveon_removebg_preview
		Me.PictureBox4.Location = New System.Drawing.Point(513, 91)
		Me.PictureBox4.Name = "PictureBox4"
		Me.PictureBox4.Size = New System.Drawing.Size(227, 195)
		Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox4.TabIndex = 16
		Me.PictureBox4.TabStop = False
		'
		'PictureBox9
		'
		Me.PictureBox9.Image = Global.POSTTEST_4.My.Resources.Resources.Umbreon_removebg_preview
		Me.PictureBox9.Location = New System.Drawing.Point(-33, 332)
		Me.PictureBox9.Name = "PictureBox9"
		Me.PictureBox9.Size = New System.Drawing.Size(175, 158)
		Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox9.TabIndex = 10
		Me.PictureBox9.TabStop = False
		'
		'PicProfil
		'
		Me.PicProfil.BackColor = System.Drawing.SystemColors.Control
		Me.PicProfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PicProfil.Location = New System.Drawing.Point(67, 128)
		Me.PicProfil.Name = "PicProfil"
		Me.PicProfil.Size = New System.Drawing.Size(132, 167)
		Me.PicProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PicProfil.TabIndex = 0
		Me.PicProfil.TabStop = False
		'
		'PictureBox8
		'
		Me.PictureBox8.Image = Global.POSTTEST_4.My.Resources.Resources.download__13__removebg_preview
		Me.PictureBox8.Location = New System.Drawing.Point(-6, -6)
		Me.PictureBox8.Name = "PictureBox8"
		Me.PictureBox8.Size = New System.Drawing.Size(148, 139)
		Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox8.TabIndex = 9
		Me.PictureBox8.TabStop = False
		'
		'PictureBox7
		'
		Me.PictureBox7.Image = Global.POSTTEST_4.My.Resources.Resources.download__12__removebg_preview
		Me.PictureBox7.Location = New System.Drawing.Point(120, -6)
		Me.PictureBox7.Name = "PictureBox7"
		Me.PictureBox7.Size = New System.Drawing.Size(148, 139)
		Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox7.TabIndex = 11
		Me.PictureBox7.TabStop = False
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(880, 715)
		Me.Controls.Add(Me.Label10)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.TabControl1)
		Me.Controls.Add(Me.MenuStrip1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MainMenuStrip = Me.MenuStrip1
		Me.MaximizeBox = False
		Me.Name = "Form1"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Pokemon Community"
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.TabControl1.ResumeLayout(False)
		Me.tabDataUtama.ResumeLayout(False)
		Me.tabDataUtama.PerformLayout()
		Me.tabKontak.ResumeLayout(False)
		Me.tabKontak.PerformLayout()
		Me.tabProfil.ResumeLayout(False)
		Me.gbRole.ResumeLayout(False)
		Me.gbRole.PerformLayout()
		Me.gbActivity.ResumeLayout(False)
		Me.gbActivity.PerformLayout()
		CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PicProfil, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents mnuInputData As ToolStripMenuItem
	Friend WithEvents mnuLihatKartu As ToolStripMenuItem
	Friend WithEvents mnuSimpan As ToolStripMenuItem
	Friend WithEvents mnuBuka As ToolStripMenuItem
	Friend WithEvents mnuKeluar As ToolStripMenuItem
	Friend WithEvents TabControl1 As TabControl
	Friend WithEvents tabDataUtama As TabPage
	Friend WithEvents tabKontak As TabPage
	Friend WithEvents dtpTanggalLahir As DateTimePicker
	Friend WithEvents txtID As TextBox
	Friend WithEvents txtNama As TextBox
	Friend WithEvents cboTipePokemon As ComboBox
	Friend WithEvents rbPerempuan As RadioButton
	Friend WithEvents rbLaki As RadioButton
	Friend WithEvents txtAlamat As TextBox
	Friend WithEvents txtEmail As TextBox
	Friend WithEvents mtbTelepon As MaskedTextBox
	Friend WithEvents tabProfil As TabPage
	Friend WithEvents PicProfil As PictureBox
	Friend WithEvents btnBrowseFoto As Button
	Friend WithEvents CheckBox8 As CheckBox
	Friend WithEvents CheckBox7 As CheckBox
	Friend WithEvents CheckBox6 As CheckBox
	Friend WithEvents CheckBox5 As CheckBox
	Friend WithEvents CheckBox4 As CheckBox
	Friend WithEvents CheckBox3 As CheckBox
	Friend WithEvents CheckBox2 As CheckBox
	Friend WithEvents CheckBox1 As CheckBox
	Friend WithEvents gbRole As GroupBox
	Friend WithEvents RadioButton4 As RadioButton
	Friend WithEvents RadioButton3 As RadioButton
	Friend WithEvents RadioButton2 As RadioButton
	Friend WithEvents RadioButton1 As RadioButton
	Friend WithEvents RadioButton5 As RadioButton
	Friend WithEvents gbActivity As GroupBox
	Friend WithEvents btnSimpanCetak As Button
	Friend WithEvents ErrorProvider1 As ErrorProvider
	Friend WithEvents OpenFileDialog1 As OpenFileDialog
	Friend WithEvents SaveFileDialog1 As SaveFileDialog
	Friend WithEvents Label4 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents Label9 As Label
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Label10 As Label
	Friend WithEvents PictureBox2 As PictureBox
	Friend WithEvents PictureBox3 As PictureBox
	Friend WithEvents PictureBox4 As PictureBox
	Friend WithEvents PictureBox5 As PictureBox
	Friend WithEvents PictureBox6 As PictureBox
	Friend WithEvents PictureBox8 As PictureBox
	Friend WithEvents PictureBox9 As PictureBox
	Friend WithEvents PictureBox7 As PictureBox
End Class
