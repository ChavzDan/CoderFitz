<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_Form))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        PanelUsername = New Panel()
        textUsername = New TextBox()
        PictureBox2 = New PictureBox()
        PanelPassword = New Panel()
        textPassword = New TextBox()
        PictureBox4 = New PictureBox()
        btnLOGIN = New Button()
        btnCANCEL = New Button()
        LabelError = New Label()
        Panel2 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PanelUsername.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        PanelPassword.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(190, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(147, 175)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Colonna MT", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(197, 168)
        Label1.Name = "Label1"
        Label1.Size = New Size(135, 43)
        Label1.TabIndex = 1
        Label1.Text = "ADAM"
        ' 
        ' PanelUsername
        ' 
        PanelUsername.BackColor = Color.White
        PanelUsername.Controls.Add(textUsername)
        PanelUsername.Controls.Add(PictureBox2)
        PanelUsername.Location = New Point(114, 253)
        PanelUsername.Name = "PanelUsername"
        PanelUsername.Size = New Size(323, 67)
        PanelUsername.TabIndex = 2
        ' 
        ' textUsername
        ' 
        textUsername.BorderStyle = BorderStyle.None
        textUsername.ForeColor = Color.Black
        textUsername.Location = New Point(73, 24)
        textUsername.Name = "textUsername"
        textUsername.Size = New Size(233, 24)
        textUsername.TabIndex = 1
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(8, 5)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(57, 56)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' PanelPassword
        ' 
        PanelPassword.BackColor = Color.White
        PanelPassword.Controls.Add(textPassword)
        PanelPassword.Controls.Add(PictureBox4)
        PanelPassword.Location = New Point(114, 351)
        PanelPassword.Name = "PanelPassword"
        PanelPassword.Size = New Size(323, 69)
        PanelPassword.TabIndex = 4
        ' 
        ' textPassword
        ' 
        textPassword.BorderStyle = BorderStyle.None
        textPassword.ForeColor = Color.Black
        textPassword.Location = New Point(76, 22)
        textPassword.Name = "textPassword"
        textPassword.Size = New Size(229, 24)
        textPassword.TabIndex = 1
        textPassword.UseSystemPasswordChar = True
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(7, 6)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(60, 58)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 0
        PictureBox4.TabStop = False
        ' 
        ' btnLOGIN
        ' 
        btnLOGIN.BackColor = Color.FromArgb(CByte(55), CByte(115), CByte(117))
        btnLOGIN.Font = New Font("Century Gothic", 13F, FontStyle.Bold)
        btnLOGIN.ForeColor = Color.White
        btnLOGIN.Location = New Point(114, 483)
        btnLOGIN.Name = "btnLOGIN"
        btnLOGIN.Size = New Size(323, 66)
        btnLOGIN.TabIndex = 5
        btnLOGIN.Text = "Login"
        btnLOGIN.UseVisualStyleBackColor = False
        ' 
        ' btnCANCEL
        ' 
        btnCANCEL.BackColor = Color.FromArgb(CByte(168), CByte(216), CByte(205))
        btnCANCEL.Font = New Font("Century Gothic", 13F, FontStyle.Bold)
        btnCANCEL.Location = New Point(114, 568)
        btnCANCEL.Name = "btnCANCEL"
        btnCANCEL.Size = New Size(323, 68)
        btnCANCEL.TabIndex = 6
        btnCANCEL.Text = "Cancel"
        btnCANCEL.UseVisualStyleBackColor = False
        ' 
        ' LabelError
        ' 
        LabelError.AutoSize = True
        LabelError.Font = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelError.ForeColor = Color.Red
        LabelError.Location = New Point(187, 436)
        LabelError.Name = "LabelError"
        LabelError.Size = New Size(145, 21)
        LabelError.TabIndex = 7
        LabelError.Text = "Error message here"
        LabelError.Visible = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Location = New Point(71, 214)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(397, 10)
        Panel2.TabIndex = 8
        ' 
        ' Login_Form
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(42), CByte(72), CByte(78))
        ClientSize = New Size(530, 712)
        Controls.Add(Panel2)
        Controls.Add(LabelError)
        Controls.Add(btnCANCEL)
        Controls.Add(btnLOGIN)
        Controls.Add(PanelPassword)
        Controls.Add(PanelUsername)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Login_Form"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login_Form"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PanelUsername.ResumeLayout(False)
        PanelUsername.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        PanelPassword.ResumeLayout(False)
        PanelPassword.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelUsername As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents textUsername As TextBox
    Friend WithEvents PanelPassword As Panel
    Friend WithEvents textPassword As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btnLOGIN As Button
    Friend WithEvents btnCANCEL As Button
    Friend WithEvents LabelError As Label
    Friend WithEvents Panel2 As Panel
End Class
