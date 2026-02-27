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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtipsemester = New System.Windows.Forms.TextBox()
		Me.txtipkumulatif = New System.Windows.Forms.TextBox()
		Me.lblpredikat = New System.Windows.Forms.Label()
		Me.btntambah = New System.Windows.Forms.Button()
		Me.btnreset = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(167, 178)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(97, 20)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "IP Semester"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(170, 295)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(94, 20)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "IP Kumulatif"
		'
		'txtipsemester
		'
		Me.txtipsemester.Location = New System.Drawing.Point(341, 175)
		Me.txtipsemester.Name = "txtipsemester"
		Me.txtipsemester.Size = New System.Drawing.Size(100, 26)
		Me.txtipsemester.TabIndex = 2
		'
		'txtipkumulatif
		'
		Me.txtipkumulatif.Location = New System.Drawing.Point(341, 289)
		Me.txtipkumulatif.Name = "txtipkumulatif"
		Me.txtipkumulatif.ReadOnly = True
		Me.txtipkumulatif.Size = New System.Drawing.Size(100, 26)
		Me.txtipkumulatif.TabIndex = 3
		'
		'lblpredikat
		'
		Me.lblpredikat.AutoSize = True
		Me.lblpredikat.Location = New System.Drawing.Point(275, 361)
		Me.lblpredikat.Name = "lblpredikat"
		Me.lblpredikat.Size = New System.Drawing.Size(57, 20)
		Me.lblpredikat.TabIndex = 4
		Me.lblpredikat.Text = "Label3"
		'
		'btntambah
		'
		Me.btntambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.btntambah.Location = New System.Drawing.Point(297, 229)
		Me.btntambah.Name = "btntambah"
		Me.btntambah.Size = New System.Drawing.Size(87, 36)
		Me.btntambah.TabIndex = 5
		Me.btntambah.Text = "Tambah"
		Me.btntambah.UseVisualStyleBackColor = False
		'
		'btnreset
		'
		Me.btnreset.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.btnreset.Location = New System.Drawing.Point(407, 229)
		Me.btnreset.Name = "btnreset"
		Me.btnreset.Size = New System.Drawing.Size(83, 36)
		Me.btnreset.TabIndex = 6
		Me.btnreset.Text = "Reset"
		Me.btnreset.UseVisualStyleBackColor = False
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.btnreset)
		Me.Controls.Add(Me.btntambah)
		Me.Controls.Add(Me.lblpredikat)
		Me.Controls.Add(Me.txtipkumulatif)
		Me.Controls.Add(Me.txtipsemester)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Name = "Form1"
		Me.Text = "Kalkulator IP"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtipsemester As TextBox
    Friend WithEvents txtipkumulatif As TextBox
	Friend WithEvents lblpredikat As Label
	Friend WithEvents btntambah As Button
	Friend WithEvents btnreset As Button
End Class
