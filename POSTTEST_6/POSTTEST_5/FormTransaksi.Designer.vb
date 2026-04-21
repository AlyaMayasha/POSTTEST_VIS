<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransaksi
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.txtID = New System.Windows.Forms.TextBox()
		Me.txtJumlah = New System.Windows.Forms.TextBox()
		Me.txtTotal = New System.Windows.Forms.TextBox()
		Me.txtCari = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.cboProduk = New System.Windows.Forms.ComboBox()
		Me.btnTutup = New System.Windows.Forms.Button()
		Me.btnReset = New System.Windows.Forms.Button()
		Me.btnHapus = New System.Windows.Forms.Button()
		Me.btnUbah = New System.Windows.Forms.Button()
		Me.btnTambah = New System.Windows.Forms.Button()
		Me.dgvTransaksi = New System.Windows.Forms.DataGridView()
		Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.dtpTanggal = New System.Windows.Forms.DateTimePicker()
		CType(Me.dgvTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel2.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.DeepPink
		Me.Label1.Location = New System.Drawing.Point(41, 150)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(101, 21)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "ID Transaksi"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.DeepPink
		Me.Label2.Location = New System.Drawing.Point(41, 201)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(65, 21)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Produk"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.DeepPink
		Me.Label3.Location = New System.Drawing.Point(40, 255)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(66, 21)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "Jumlah"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.ForeColor = System.Drawing.Color.DeepPink
		Me.Label4.Location = New System.Drawing.Point(41, 314)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(48, 21)
		Me.Label4.TabIndex = 3
		Me.Label4.Text = "Total"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.ForeColor = System.Drawing.Color.DeepPink
		Me.Label5.Location = New System.Drawing.Point(41, 368)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(145, 21)
		Me.Label5.TabIndex = 4
		Me.Label5.Text = "Tanggal Transaksi"
		'
		'txtID
		'
		Me.txtID.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtID.ForeColor = System.Drawing.Color.DeepPink
		Me.txtID.Location = New System.Drawing.Point(236, 147)
		Me.txtID.Name = "txtID"
		Me.txtID.Size = New System.Drawing.Size(545, 29)
		Me.txtID.TabIndex = 5
		'
		'txtJumlah
		'
		Me.txtJumlah.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtJumlah.ForeColor = System.Drawing.Color.DeepPink
		Me.txtJumlah.Location = New System.Drawing.Point(236, 252)
		Me.txtJumlah.Name = "txtJumlah"
		Me.txtJumlah.Size = New System.Drawing.Size(545, 29)
		Me.txtJumlah.TabIndex = 6
		'
		'txtTotal
		'
		Me.txtTotal.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTotal.ForeColor = System.Drawing.Color.DeepPink
		Me.txtTotal.Location = New System.Drawing.Point(236, 311)
		Me.txtTotal.Name = "txtTotal"
		Me.txtTotal.ReadOnly = True
		Me.txtTotal.Size = New System.Drawing.Size(545, 29)
		Me.txtTotal.TabIndex = 7
		'
		'txtCari
		'
		Me.txtCari.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCari.ForeColor = System.Drawing.Color.DeepPink
		Me.txtCari.Location = New System.Drawing.Point(44, 515)
		Me.txtCari.Name = "txtCari"
		Me.txtCari.Size = New System.Drawing.Size(737, 29)
		Me.txtCari.TabIndex = 8
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.ForeColor = System.Drawing.Color.DeepPink
		Me.Label6.Location = New System.Drawing.Point(41, 478)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(61, 21)
		Me.Label6.TabIndex = 9
		Me.Label6.Text = "Search"
		'
		'cboProduk
		'
		Me.cboProduk.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboProduk.ForeColor = System.Drawing.Color.DeepPink
		Me.cboProduk.FormattingEnabled = True
		Me.cboProduk.Location = New System.Drawing.Point(236, 198)
		Me.cboProduk.Name = "cboProduk"
		Me.cboProduk.Size = New System.Drawing.Size(545, 29)
		Me.cboProduk.TabIndex = 10
		'
		'btnTutup
		'
		Me.btnTutup.BackColor = System.Drawing.Color.Pink
		Me.btnTutup.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnTutup.ForeColor = System.Drawing.Color.DeepPink
		Me.btnTutup.Location = New System.Drawing.Point(681, 423)
		Me.btnTutup.Name = "btnTutup"
		Me.btnTutup.Size = New System.Drawing.Size(100, 34)
		Me.btnTutup.TabIndex = 22
		Me.btnTutup.Text = "Close"
		Me.btnTutup.UseVisualStyleBackColor = False
		'
		'btnReset
		'
		Me.btnReset.BackColor = System.Drawing.Color.Pink
		Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnReset.ForeColor = System.Drawing.Color.DeepPink
		Me.btnReset.Location = New System.Drawing.Point(528, 423)
		Me.btnReset.Name = "btnReset"
		Me.btnReset.Size = New System.Drawing.Size(100, 34)
		Me.btnReset.TabIndex = 21
		Me.btnReset.Text = "Reset"
		Me.btnReset.UseVisualStyleBackColor = False
		'
		'btnHapus
		'
		Me.btnHapus.BackColor = System.Drawing.Color.Pink
		Me.btnHapus.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnHapus.ForeColor = System.Drawing.Color.DeepPink
		Me.btnHapus.Location = New System.Drawing.Point(367, 423)
		Me.btnHapus.Name = "btnHapus"
		Me.btnHapus.Size = New System.Drawing.Size(100, 34)
		Me.btnHapus.TabIndex = 20
		Me.btnHapus.Text = "Hapus"
		Me.btnHapus.UseVisualStyleBackColor = False
		'
		'btnUbah
		'
		Me.btnUbah.BackColor = System.Drawing.Color.Pink
		Me.btnUbah.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnUbah.ForeColor = System.Drawing.Color.DeepPink
		Me.btnUbah.Location = New System.Drawing.Point(206, 423)
		Me.btnUbah.Name = "btnUbah"
		Me.btnUbah.Size = New System.Drawing.Size(100, 34)
		Me.btnUbah.TabIndex = 19
		Me.btnUbah.Text = "Ubah"
		Me.btnUbah.UseVisualStyleBackColor = False
		'
		'btnTambah
		'
		Me.btnTambah.BackColor = System.Drawing.Color.Pink
		Me.btnTambah.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnTambah.ForeColor = System.Drawing.Color.DeepPink
		Me.btnTambah.Location = New System.Drawing.Point(41, 423)
		Me.btnTambah.Name = "btnTambah"
		Me.btnTambah.Size = New System.Drawing.Size(100, 34)
		Me.btnTambah.TabIndex = 18
		Me.btnTambah.Text = "Tambah"
		Me.btnTambah.UseVisualStyleBackColor = False
		'
		'dgvTransaksi
		'
		Me.dgvTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvTransaksi.Location = New System.Drawing.Point(12, 577)
		Me.dgvTransaksi.Name = "dgvTransaksi"
		Me.dgvTransaksi.RowHeadersWidth = 62
		Me.dgvTransaksi.RowTemplate.Height = 28
		Me.dgvTransaksi.Size = New System.Drawing.Size(808, 377)
		Me.dgvTransaksi.TabIndex = 23
		'
		'ErrorProvider1
		'
		Me.ErrorProvider1.ContainerControl = Me
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.Pink
		Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Panel2.Controls.Add(Me.PictureBox1)
		Me.Panel2.Controls.Add(Me.Label7)
		Me.Panel2.Controls.Add(Me.Label8)
		Me.Panel2.Location = New System.Drawing.Point(-11, -6)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(849, 126)
		Me.Panel2.TabIndex = 24
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.POSTTEST_5.My.Resources.Resources.download__14__removebg_preview
		Me.PictureBox1.Location = New System.Drawing.Point(690, 4)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(128, 115)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 9
		Me.PictureBox1.TabStop = False
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.ForeColor = System.Drawing.Color.DeepPink
		Me.Label7.Location = New System.Drawing.Point(45, 70)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(197, 28)
		Me.Label7.TabIndex = 8
		Me.Label7.Text = "Transaksi Penjualan"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.BackColor = System.Drawing.Color.Pink
		Me.Label8.Font = New System.Drawing.Font("Bauhaus 93", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.ForeColor = System.Drawing.Color.DeepPink
		Me.Label8.Location = New System.Drawing.Point(43, 30)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(365, 40)
		Me.Label8.TabIndex = 0
		Me.Label8.Text = "Espeon Knitting House"
		'
		'dtpTanggal
		'
		Me.dtpTanggal.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dtpTanggal.Location = New System.Drawing.Point(236, 363)
		Me.dtpTanggal.Name = "dtpTanggal"
		Me.dtpTanggal.Size = New System.Drawing.Size(545, 29)
		Me.dtpTanggal.TabIndex = 25
		'
		'FormTransaksi
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(835, 966)
		Me.Controls.Add(Me.dtpTanggal)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.dgvTransaksi)
		Me.Controls.Add(Me.btnTutup)
		Me.Controls.Add(Me.btnReset)
		Me.Controls.Add(Me.btnHapus)
		Me.Controls.Add(Me.btnUbah)
		Me.Controls.Add(Me.btnTambah)
		Me.Controls.Add(Me.cboProduk)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.txtCari)
		Me.Controls.Add(Me.txtTotal)
		Me.Controls.Add(Me.txtJumlah)
		Me.Controls.Add(Me.txtID)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Name = "FormTransaksi"
		Me.Text = "FormTransaksi"
		CType(Me.dgvTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel2.ResumeLayout(False)
		Me.Panel2.PerformLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
	Friend WithEvents txtID As TextBox
	Friend WithEvents txtJumlah As TextBox
	Friend WithEvents txtTotal As TextBox
	Friend WithEvents txtCari As TextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents cboProduk As ComboBox
	Friend WithEvents btnTutup As Button
	Friend WithEvents btnReset As Button
	Friend WithEvents btnHapus As Button
	Friend WithEvents btnUbah As Button
	Friend WithEvents btnTambah As Button
	Friend WithEvents dgvTransaksi As DataGridView
	Friend WithEvents ErrorProvider1 As ErrorProvider
	Friend WithEvents Panel2 As Panel
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Label7 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents dtpTanggal As DateTimePicker
End Class
