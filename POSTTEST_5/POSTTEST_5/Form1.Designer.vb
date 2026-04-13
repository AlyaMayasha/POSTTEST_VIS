<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtUsername = New System.Windows.Forms.TextBox()
		Me.txtPassword = New System.Windows.Forms.TextBox()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.btnLogin = New System.Windows.Forms.Button()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Panel1.SuspendLayout()
		Me.Panel2.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.DeepPink
		Me.Label1.Location = New System.Drawing.Point(34, 63)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(87, 21)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Username"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.BackColor = System.Drawing.SystemColors.Control
		Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.DeepPink
		Me.Label2.Location = New System.Drawing.Point(34, 148)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(82, 21)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Password"
		'
		'txtUsername
		'
		Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtUsername.ForeColor = System.Drawing.Color.DeepPink
		Me.txtUsername.Location = New System.Drawing.Point(170, 57)
		Me.txtUsername.Name = "txtUsername"
		Me.txtUsername.Size = New System.Drawing.Size(204, 29)
		Me.txtUsername.TabIndex = 2
		'
		'txtPassword
		'
		Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPassword.ForeColor = System.Drawing.Color.DeepPink
		Me.txtPassword.Location = New System.Drawing.Point(170, 145)
		Me.txtPassword.Name = "txtPassword"
		Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
		Me.txtPassword.Size = New System.Drawing.Size(204, 29)
		Me.txtPassword.TabIndex = 3
		'
		'btnClose
		'
		Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnClose.ForeColor = System.Drawing.Color.DeepPink
		Me.btnClose.Location = New System.Drawing.Point(91, 224)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(91, 32)
		Me.btnClose.TabIndex = 4
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'btnLogin
		'
		Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnLogin.ForeColor = System.Drawing.Color.DeepPink
		Me.btnLogin.Location = New System.Drawing.Point(231, 224)
		Me.btnLogin.Name = "btnLogin"
		Me.btnLogin.Size = New System.Drawing.Size(91, 32)
		Me.btnLogin.TabIndex = 5
		Me.btnLogin.Text = "Login"
		Me.btnLogin.UseVisualStyleBackColor = True
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.Pink
		Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Controls.Add(Me.btnClose)
		Me.Panel1.Controls.Add(Me.btnLogin)
		Me.Panel1.Controls.Add(Me.txtUsername)
		Me.Panel1.Controls.Add(Me.Label2)
		Me.Panel1.Controls.Add(Me.txtPassword)
		Me.Panel1.Location = New System.Drawing.Point(106, 170)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(407, 302)
		Me.Panel1.TabIndex = 6
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.Pink
		Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Panel2.Controls.Add(Me.PictureBox1)
		Me.Panel2.Controls.Add(Me.Label4)
		Me.Panel2.Controls.Add(Me.Label3)
		Me.Panel2.Location = New System.Drawing.Point(-7, -10)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(660, 129)
		Me.Panel2.TabIndex = 7
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.BackColor = System.Drawing.Color.Pink
		Me.Label3.Font = New System.Drawing.Font("Bauhaus 93", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.DeepPink
		Me.Label3.Location = New System.Drawing.Point(26, 39)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(365, 40)
		Me.Label3.TabIndex = 0
		Me.Label3.Text = "Espeon Knitting House"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.ForeColor = System.Drawing.Color.DeepPink
		Me.Label4.Location = New System.Drawing.Point(28, 79)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(116, 28)
		Me.Label4.TabIndex = 8
		Me.Label4.Text = "Login Page"
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.POSTTEST_5.My.Resources.Resources.download__14__removebg_preview
		Me.PictureBox1.Location = New System.Drawing.Point(492, 8)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(129, 114)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 9
		Me.PictureBox1.TabStop = False
		'
		'FormLogin
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(628, 533)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.Name = "FormLogin"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Form Login"
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.Panel2.ResumeLayout(False)
		Me.Panel2.PerformLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnLogin As Button
	Friend WithEvents Panel1 As Panel
	Friend WithEvents Panel2 As Panel
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents PictureBox1 As PictureBox
End Class
