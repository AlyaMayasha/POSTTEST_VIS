<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDashboard
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
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.DashboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.KelolaProdukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.KeluarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.txtTotalStok = New System.Windows.Forms.TextBox()
		Me.txtTotalProduk = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.txtTotalTransaksi = New System.Windows.Forms.TextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.txtTotalTerjual = New System.Windows.Forms.TextBox()
		Me.MenuStrip1.SuspendLayout()
		Me.Panel1.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'MenuStrip1
		'
		Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
		Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DashboardToolStripMenuItem, Me.KelolaProdukToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.KeluarToolStripMenuItem1})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(672, 33)
		Me.MenuStrip1.TabIndex = 0
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'DashboardToolStripMenuItem
		'
		Me.DashboardToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DashboardToolStripMenuItem.ForeColor = System.Drawing.Color.DeepPink
		Me.DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem"
		Me.DashboardToolStripMenuItem.Size = New System.Drawing.Size(120, 29)
		Me.DashboardToolStripMenuItem.Text = "Dashboard"
		'
		'KelolaProdukToolStripMenuItem
		'
		Me.KelolaProdukToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.KelolaProdukToolStripMenuItem.ForeColor = System.Drawing.Color.DeepPink
		Me.KelolaProdukToolStripMenuItem.Name = "KelolaProdukToolStripMenuItem"
		Me.KelolaProdukToolStripMenuItem.Size = New System.Drawing.Size(147, 29)
		Me.KelolaProdukToolStripMenuItem.Text = "Kelola Produk"
		'
		'TransaksiToolStripMenuItem
		'
		Me.TransaksiToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TransaksiToolStripMenuItem.ForeColor = System.Drawing.Color.DeepPink
		Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
		Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(107, 29)
		Me.TransaksiToolStripMenuItem.Text = "Transaksi"
		'
		'KeluarToolStripMenuItem1
		'
		Me.KeluarToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.KeluarToolStripMenuItem1.ForeColor = System.Drawing.Color.DeepPink
		Me.KeluarToolStripMenuItem1.Name = "KeluarToolStripMenuItem1"
		Me.KeluarToolStripMenuItem1.Size = New System.Drawing.Size(83, 29)
		Me.KeluarToolStripMenuItem1.Text = "Keluar"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.DeepPink
		Me.Label1.Location = New System.Drawing.Point(30, 21)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(138, 28)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Total Produk "
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.BackColor = System.Drawing.SystemColors.Control
		Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.DeepPink
		Me.Label2.Location = New System.Drawing.Point(465, 21)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(113, 28)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Total Stok "
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.BackColor = System.Drawing.SystemColors.Control
		Me.Label3.Font = New System.Drawing.Font("Bauhaus 93", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.DeepPink
		Me.Label3.Location = New System.Drawing.Point(278, 120)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(365, 40)
		Me.Label3.TabIndex = 6
		Me.Label3.Text = "Espeon Knitting House"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.ForeColor = System.Drawing.Color.PaleVioletRed
		Me.Label4.Location = New System.Drawing.Point(301, 181)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(313, 25)
		Me.Label4.TabIndex = 9
		Me.Label4.Text = "Welcome to Espeon Knitting House"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.ForeColor = System.Drawing.Color.PaleVioletRed
		Me.Label5.Location = New System.Drawing.Point(301, 206)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(314, 25)
		Me.Label5.TabIndex = 10
		Me.Label5.Text = "karena setiap rajutan punya cerita !"
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.Pink
		Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Panel1.Controls.Add(Me.txtTotalTerjual)
		Me.Panel1.Controls.Add(Me.Label8)
		Me.Panel1.Controls.Add(Me.txtTotalTransaksi)
		Me.Panel1.Controls.Add(Me.Label7)
		Me.Panel1.Controls.Add(Me.txtTotalStok)
		Me.Panel1.Controls.Add(Me.txtTotalProduk)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Controls.Add(Me.Label2)
		Me.Panel1.Location = New System.Drawing.Point(25, 374)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(618, 235)
		Me.Panel1.TabIndex = 11
		'
		'txtTotalStok
		'
		Me.txtTotalStok.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTotalStok.ForeColor = System.Drawing.Color.DeepPink
		Me.txtTotalStok.Location = New System.Drawing.Point(359, 64)
		Me.txtTotalStok.Name = "txtTotalStok"
		Me.txtTotalStok.Size = New System.Drawing.Size(229, 29)
		Me.txtTotalStok.TabIndex = 6
		Me.txtTotalStok.TabStop = False
		'
		'txtTotalProduk
		'
		Me.txtTotalProduk.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTotalProduk.ForeColor = System.Drawing.Color.DeepPink
		Me.txtTotalProduk.Location = New System.Drawing.Point(30, 64)
		Me.txtTotalProduk.Name = "txtTotalProduk"
		Me.txtTotalProduk.Size = New System.Drawing.Size(229, 29)
		Me.txtTotalProduk.TabIndex = 5
		Me.txtTotalProduk.TabStop = False
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.ForeColor = System.Drawing.Color.DeepPink
		Me.Label6.Location = New System.Drawing.Point(20, 331)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(175, 28)
		Me.Label6.TabIndex = 12
		Me.Label6.Text = "Informasi Produk"
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.POSTTEST_5.My.Resources.Resources.download__14__removebg_preview
		Me.PictureBox1.Location = New System.Drawing.Point(25, 53)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(247, 248)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 5
		Me.PictureBox1.TabStop = False
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.BackColor = System.Drawing.SystemColors.Control
		Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.ForeColor = System.Drawing.Color.DeepPink
		Me.Label7.Location = New System.Drawing.Point(30, 122)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(152, 28)
		Me.Label7.TabIndex = 7
		Me.Label7.Text = "Total Transaksi"
		'
		'txtTotalTransaksi
		'
		Me.txtTotalTransaksi.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTotalTransaksi.ForeColor = System.Drawing.Color.DeepPink
		Me.txtTotalTransaksi.Location = New System.Drawing.Point(30, 176)
		Me.txtTotalTransaksi.Name = "txtTotalTransaksi"
		Me.txtTotalTransaksi.Size = New System.Drawing.Size(229, 29)
		Me.txtTotalTransaksi.TabIndex = 8
		Me.txtTotalTransaksi.TabStop = False
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.BackColor = System.Drawing.SystemColors.Control
		Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.ForeColor = System.Drawing.Color.DeepPink
		Me.Label8.Location = New System.Drawing.Point(367, 122)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(202, 28)
		Me.Label8.TabIndex = 11
		Me.Label8.Text = "Total Produk Terjual"
		'
		'txtTotalTerjual
		'
		Me.txtTotalTerjual.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTotalTerjual.ForeColor = System.Drawing.Color.DeepPink
		Me.txtTotalTerjual.Location = New System.Drawing.Point(359, 176)
		Me.txtTotalTerjual.Name = "txtTotalTerjual"
		Me.txtTotalTerjual.Size = New System.Drawing.Size(229, 29)
		Me.txtTotalTerjual.TabIndex = 12
		Me.txtTotalTerjual.TabStop = False
		'
		'FormDashboard
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(672, 637)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.MenuStrip1)
		Me.Controls.Add(Me.Panel1)
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Name = "FormDashboard"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "FormDashboard"
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents DashboardToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents KelolaProdukToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Panel1 As Panel
	Friend WithEvents Label6 As Label
	Friend WithEvents txtTotalStok As TextBox
	Friend WithEvents txtTotalProduk As TextBox
	Friend WithEvents KeluarToolStripMenuItem1 As ToolStripMenuItem
	Friend WithEvents txtTotalTransaksi As TextBox
	Friend WithEvents Label7 As Label
	Friend WithEvents txtTotalTerjual As TextBox
	Friend WithEvents Label8 As Label
End Class
