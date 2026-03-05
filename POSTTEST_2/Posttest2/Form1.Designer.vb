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
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.btnTambah = New System.Windows.Forms.Button()
		Me.txtGenre = New System.Windows.Forms.TextBox()
		Me.txtJudulTambah = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.btnHapus = New System.Windows.Forms.Button()
		Me.txtJudulHapus = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.lstBuku = New System.Windows.Forms.ListBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.BackColor = System.Drawing.Color.Thistle
		Me.GroupBox1.Controls.Add(Me.btnTambah)
		Me.GroupBox1.Controls.Add(Me.txtGenre)
		Me.GroupBox1.Controls.Add(Me.txtJudulTambah)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox1.ForeColor = System.Drawing.Color.PaleVioletRed
		Me.GroupBox1.Location = New System.Drawing.Point(49, 53)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(319, 193)
		Me.GroupBox1.TabIndex = 0
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Tambah Buku"
		'
		'btnTambah
		'
		Me.btnTambah.BackColor = System.Drawing.Color.PaleGreen
		Me.btnTambah.Location = New System.Drawing.Point(204, 144)
		Me.btnTambah.Name = "btnTambah"
		Me.btnTambah.Size = New System.Drawing.Size(98, 34)
		Me.btnTambah.TabIndex = 0
		Me.btnTambah.Text = "Tambah"
		Me.btnTambah.UseVisualStyleBackColor = False
		'
		'txtGenre
		'
		Me.txtGenre.BackColor = System.Drawing.Color.Pink
		Me.txtGenre.ForeColor = System.Drawing.Color.PaleVioletRed
		Me.txtGenre.Location = New System.Drawing.Point(150, 101)
		Me.txtGenre.Name = "txtGenre"
		Me.txtGenre.Size = New System.Drawing.Size(100, 29)
		Me.txtGenre.TabIndex = 2
		'
		'txtJudulTambah
		'
		Me.txtJudulTambah.BackColor = System.Drawing.Color.Pink
		Me.txtJudulTambah.ForeColor = System.Drawing.Color.PaleVioletRed
		Me.txtJudulTambah.Location = New System.Drawing.Point(150, 50)
		Me.txtJudulTambah.Name = "txtJudulTambah"
		Me.txtJudulTambah.Size = New System.Drawing.Size(100, 29)
		Me.txtJudulTambah.TabIndex = 0
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(30, 104)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(55, 21)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Genre"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(17, 56)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(95, 21)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Judul Buku"
		'
		'GroupBox2
		'
		Me.GroupBox2.BackColor = System.Drawing.Color.PaleGreen
		Me.GroupBox2.Controls.Add(Me.btnHapus)
		Me.GroupBox2.Controls.Add(Me.txtJudulHapus)
		Me.GroupBox2.Controls.Add(Me.Label3)
		Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox2.ForeColor = System.Drawing.Color.PaleVioletRed
		Me.GroupBox2.Location = New System.Drawing.Point(433, 53)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(319, 193)
		Me.GroupBox2.TabIndex = 1
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Hapus Buku"
		'
		'btnHapus
		'
		Me.btnHapus.BackColor = System.Drawing.Color.Thistle
		Me.btnHapus.Location = New System.Drawing.Point(199, 144)
		Me.btnHapus.Name = "btnHapus"
		Me.btnHapus.Size = New System.Drawing.Size(98, 34)
		Me.btnHapus.TabIndex = 3
		Me.btnHapus.Text = "Hapus"
		Me.btnHapus.UseVisualStyleBackColor = False
		'
		'txtJudulHapus
		'
		Me.txtJudulHapus.BackColor = System.Drawing.Color.Pink
		Me.txtJudulHapus.ForeColor = System.Drawing.Color.PaleVioletRed
		Me.txtJudulHapus.Location = New System.Drawing.Point(163, 77)
		Me.txtJudulHapus.Name = "txtJudulHapus"
		Me.txtJudulHapus.Size = New System.Drawing.Size(100, 29)
		Me.txtJudulHapus.TabIndex = 1
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(53, 80)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(95, 21)
		Me.Label3.TabIndex = 0
		Me.Label3.Text = "Judul Buku"
		'
		'lstBuku
		'
		Me.lstBuku.BackColor = System.Drawing.Color.Pink
		Me.lstBuku.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstBuku.ForeColor = System.Drawing.Color.DeepPink
		Me.lstBuku.FormattingEnabled = True
		Me.lstBuku.ItemHeight = 21
		Me.lstBuku.Location = New System.Drawing.Point(253, 263)
		Me.lstBuku.Name = "lstBuku"
		Me.lstBuku.Size = New System.Drawing.Size(281, 214)
		Me.lstBuku.TabIndex = 2
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.ForeColor = System.Drawing.Color.PaleVioletRed
		Me.Label4.Location = New System.Drawing.Point(192, 9)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(434, 38)
		Me.Label4.TabIndex = 3
		Me.Label4.Text = "DAFTAR BUKU PERPUSTAKAAN"
		'
		'PictureBox2
		'
		Me.PictureBox2.Image = Global.Posttest2.My.Resources.Resources.download__3__removebg_preview
		Me.PictureBox2.Location = New System.Drawing.Point(574, 273)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(178, 178)
		Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox2.TabIndex = 5
		Me.PictureBox2.TabStop = False
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.Posttest2.My.Resources.Resources.download__5__removebg_preview
		Me.PictureBox1.Location = New System.Drawing.Point(49, 283)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(178, 178)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 4
		Me.PictureBox1.TabStop = False
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.PowderBlue
		Me.ClientSize = New System.Drawing.Size(800, 499)
		Me.Controls.Add(Me.PictureBox2)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.lstBuku)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "Form1"
		Me.Text = "DataBuku"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents btnTambah As Button
	Friend WithEvents txtGenre As TextBox
	Friend WithEvents txtJudulTambah As TextBox
	Friend WithEvents btnHapus As Button
	Friend WithEvents txtJudulHapus As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents lstBuku As ListBox
	Friend WithEvents Label4 As Label
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents PictureBox2 As PictureBox
End Class
