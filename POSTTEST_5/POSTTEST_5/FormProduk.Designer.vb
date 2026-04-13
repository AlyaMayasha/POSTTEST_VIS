<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProduk
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
		Me.Label6 = New System.Windows.Forms.Label()
		Me.txtKode = New System.Windows.Forms.TextBox()
		Me.txtNama = New System.Windows.Forms.TextBox()
		Me.txtHarga = New System.Windows.Forms.TextBox()
		Me.txtStok = New System.Windows.Forms.TextBox()
		Me.txtCari = New System.Windows.Forms.TextBox()
		Me.cboKategori = New System.Windows.Forms.ComboBox()
		Me.btnTambah = New System.Windows.Forms.Button()
		Me.btnUbah = New System.Windows.Forms.Button()
		Me.btnHapus = New System.Windows.Forms.Button()
		Me.btnReset = New System.Windows.Forms.Button()
		Me.dgvProduk = New System.Windows.Forms.DataGridView()
		Me.btnTutup = New System.Windows.Forms.Button()
		Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		CType(Me.dgvProduk, System.ComponentModel.ISupportInitialize).BeginInit()
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
		Me.Label1.Location = New System.Drawing.Point(41, 148)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(108, 21)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Kode Produk"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.DeepPink
		Me.Label2.Location = New System.Drawing.Point(41, 191)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(115, 21)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Nama Produk"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.DeepPink
		Me.Label3.Location = New System.Drawing.Point(41, 236)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(75, 21)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "Kategori"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.ForeColor = System.Drawing.Color.DeepPink
		Me.Label4.Location = New System.Drawing.Point(42, 280)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(56, 21)
		Me.Label4.TabIndex = 3
		Me.Label4.Text = "Harga"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.ForeColor = System.Drawing.Color.DeepPink
		Me.Label5.Location = New System.Drawing.Point(41, 322)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(44, 21)
		Me.Label5.TabIndex = 4
		Me.Label5.Text = "Stok"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.ForeColor = System.Drawing.Color.DeepPink
		Me.Label6.Location = New System.Drawing.Point(42, 436)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(61, 21)
		Me.Label6.TabIndex = 5
		Me.Label6.Text = "Search"
		'
		'txtKode
		'
		Me.txtKode.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtKode.ForeColor = System.Drawing.Color.DeepPink
		Me.txtKode.Location = New System.Drawing.Point(265, 145)
		Me.txtKode.Name = "txtKode"
		Me.txtKode.Size = New System.Drawing.Size(520, 29)
		Me.txtKode.TabIndex = 6
		'
		'txtNama
		'
		Me.txtNama.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtNama.ForeColor = System.Drawing.Color.DeepPink
		Me.txtNama.Location = New System.Drawing.Point(265, 188)
		Me.txtNama.Name = "txtNama"
		Me.txtNama.Size = New System.Drawing.Size(520, 29)
		Me.txtNama.TabIndex = 7
		'
		'txtHarga
		'
		Me.txtHarga.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtHarga.ForeColor = System.Drawing.Color.DeepPink
		Me.txtHarga.Location = New System.Drawing.Point(265, 277)
		Me.txtHarga.Name = "txtHarga"
		Me.txtHarga.Size = New System.Drawing.Size(520, 29)
		Me.txtHarga.TabIndex = 8
		'
		'txtStok
		'
		Me.txtStok.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtStok.ForeColor = System.Drawing.Color.DeepPink
		Me.txtStok.Location = New System.Drawing.Point(265, 319)
		Me.txtStok.Name = "txtStok"
		Me.txtStok.Size = New System.Drawing.Size(520, 29)
		Me.txtStok.TabIndex = 9
		'
		'txtCari
		'
		Me.txtCari.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCari.ForeColor = System.Drawing.Color.DeepPink
		Me.txtCari.Location = New System.Drawing.Point(45, 469)
		Me.txtCari.Name = "txtCari"
		Me.txtCari.Size = New System.Drawing.Size(740, 29)
		Me.txtCari.TabIndex = 10
		'
		'cboKategori
		'
		Me.cboKategori.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboKategori.ForeColor = System.Drawing.Color.DeepPink
		Me.cboKategori.FormattingEnabled = True
		Me.cboKategori.Items.AddRange(New Object() {"Tas Rajut", "Dompet Rajut", "Pouch Rajut", "Boneka Rajut", "Keychain Rajut"})
		Me.cboKategori.Location = New System.Drawing.Point(265, 233)
		Me.cboKategori.Name = "cboKategori"
		Me.cboKategori.Size = New System.Drawing.Size(520, 29)
		Me.cboKategori.TabIndex = 11
		'
		'btnTambah
		'
		Me.btnTambah.BackColor = System.Drawing.Color.Pink
		Me.btnTambah.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnTambah.ForeColor = System.Drawing.Color.DeepPink
		Me.btnTambah.Location = New System.Drawing.Point(45, 377)
		Me.btnTambah.Name = "btnTambah"
		Me.btnTambah.Size = New System.Drawing.Size(100, 34)
		Me.btnTambah.TabIndex = 12
		Me.btnTambah.Text = "Tambah"
		Me.btnTambah.UseVisualStyleBackColor = False
		'
		'btnUbah
		'
		Me.btnUbah.BackColor = System.Drawing.Color.Pink
		Me.btnUbah.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnUbah.ForeColor = System.Drawing.Color.DeepPink
		Me.btnUbah.Location = New System.Drawing.Point(210, 377)
		Me.btnUbah.Name = "btnUbah"
		Me.btnUbah.Size = New System.Drawing.Size(100, 34)
		Me.btnUbah.TabIndex = 13
		Me.btnUbah.Text = "Ubah"
		Me.btnUbah.UseVisualStyleBackColor = False
		'
		'btnHapus
		'
		Me.btnHapus.BackColor = System.Drawing.Color.Pink
		Me.btnHapus.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnHapus.ForeColor = System.Drawing.Color.DeepPink
		Me.btnHapus.Location = New System.Drawing.Point(371, 377)
		Me.btnHapus.Name = "btnHapus"
		Me.btnHapus.Size = New System.Drawing.Size(100, 34)
		Me.btnHapus.TabIndex = 14
		Me.btnHapus.Text = "Hapus"
		Me.btnHapus.UseVisualStyleBackColor = False
		'
		'btnReset
		'
		Me.btnReset.BackColor = System.Drawing.Color.Pink
		Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnReset.ForeColor = System.Drawing.Color.DeepPink
		Me.btnReset.Location = New System.Drawing.Point(532, 377)
		Me.btnReset.Name = "btnReset"
		Me.btnReset.Size = New System.Drawing.Size(100, 34)
		Me.btnReset.TabIndex = 15
		Me.btnReset.Text = "Reset"
		Me.btnReset.UseVisualStyleBackColor = False
		'
		'dgvProduk
		'
		Me.dgvProduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvProduk.Location = New System.Drawing.Point(45, 537)
		Me.dgvProduk.Name = "dgvProduk"
		Me.dgvProduk.RowHeadersWidth = 62
		Me.dgvProduk.RowTemplate.Height = 28
		Me.dgvProduk.Size = New System.Drawing.Size(740, 343)
		Me.dgvProduk.TabIndex = 16
		'
		'btnTutup
		'
		Me.btnTutup.BackColor = System.Drawing.Color.Pink
		Me.btnTutup.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnTutup.ForeColor = System.Drawing.Color.DeepPink
		Me.btnTutup.Location = New System.Drawing.Point(685, 377)
		Me.btnTutup.Name = "btnTutup"
		Me.btnTutup.Size = New System.Drawing.Size(100, 34)
		Me.btnTutup.TabIndex = 17
		Me.btnTutup.Text = "Close"
		Me.btnTutup.UseVisualStyleBackColor = False
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
		Me.Panel2.Location = New System.Drawing.Point(-8, -1)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(838, 120)
		Me.Panel2.TabIndex = 18
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.POSTTEST_5.My.Resources.Resources.download__14__removebg_preview
		Me.PictureBox1.Location = New System.Drawing.Point(678, -2)
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
		Me.Label7.Location = New System.Drawing.Point(36, 64)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(144, 28)
		Me.Label7.TabIndex = 8
		Me.Label7.Text = "Kelola Produk"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.BackColor = System.Drawing.Color.Pink
		Me.Label8.Font = New System.Drawing.Font("Bauhaus 93", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.ForeColor = System.Drawing.Color.DeepPink
		Me.Label8.Location = New System.Drawing.Point(34, 24)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(365, 40)
		Me.Label8.TabIndex = 0
		Me.Label8.Text = "Espeon Knitting House"
		'
		'FormProduk
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(827, 892)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.btnTutup)
		Me.Controls.Add(Me.dgvProduk)
		Me.Controls.Add(Me.btnReset)
		Me.Controls.Add(Me.btnHapus)
		Me.Controls.Add(Me.btnUbah)
		Me.Controls.Add(Me.btnTambah)
		Me.Controls.Add(Me.cboKategori)
		Me.Controls.Add(Me.txtCari)
		Me.Controls.Add(Me.txtStok)
		Me.Controls.Add(Me.txtHarga)
		Me.Controls.Add(Me.txtNama)
		Me.Controls.Add(Me.txtKode)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Name = "FormProduk"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "FormProduk"
		CType(Me.dgvProduk, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label6 As Label
	Friend WithEvents txtKode As TextBox
	Friend WithEvents txtNama As TextBox
	Friend WithEvents txtHarga As TextBox
	Friend WithEvents txtStok As TextBox
	Friend WithEvents txtCari As TextBox
	Friend WithEvents cboKategori As ComboBox
	Friend WithEvents btnTambah As Button
	Friend WithEvents btnUbah As Button
	Friend WithEvents btnHapus As Button
	Friend WithEvents btnReset As Button
	Friend WithEvents dgvProduk As DataGridView
	Friend WithEvents btnTutup As Button
	Friend WithEvents ErrorProvider1 As ErrorProvider
	Friend WithEvents Panel2 As Panel
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Label7 As Label
	Friend WithEvents Label8 As Label
End Class
