<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Form
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
        Panel_Menu = New Panel()
        Panel2 = New Panel()
        Button1 = New Button()
        Button_Owner = New Button()
        SALES = New Button()
        Button2 = New Button()
        Button3 = New Button()
        ButtonIMAGES = New Button()
        Button4 = New Button()
        PanelLeft = New Panel()
        PanelRight = New Panel()
        Panel_Menu.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel_Menu
        ' 
        Panel_Menu.BackColor = Color.FromArgb(CByte(55), CByte(115), CByte(117))
        Panel_Menu.BackgroundImageLayout = ImageLayout.None
        Panel_Menu.Controls.Add(Panel2)
        Panel_Menu.Dock = DockStyle.Fill
        Panel_Menu.Location = New Point(0, 0)
        Panel_Menu.Name = "Panel_Menu"
        Panel_Menu.Size = New Size(1818, 1050)
        Panel_Menu.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Button_Owner)
        Panel2.Controls.Add(SALES)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(ButtonIMAGES)
        Panel2.Controls.Add(Button4)
        Panel2.Location = New Point(3, 83)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(240, 955)
        Panel2.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(55), CByte(115), CByte(117))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Century Gothic", 13F, FontStyle.Bold)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(-3, 824)
        Button1.Name = "Button1"
        Button1.Size = New Size(231, 118)
        Button1.TabIndex = 7
        Button1.Text = "ABOUT US"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button_Owner
        ' 
        Button_Owner.BackColor = Color.FromArgb(CByte(42), CByte(72), CByte(78))
        Button_Owner.FlatAppearance.BorderColor = Color.FromArgb(CByte(42), CByte(72), CByte(78))
        Button_Owner.FlatStyle = FlatStyle.Flat
        Button_Owner.Font = New Font("Century Gothic", 13F, FontStyle.Bold)
        Button_Owner.ForeColor = Color.White
        Button_Owner.Location = New Point(0, 3)
        Button_Owner.Name = "Button_Owner"
        Button_Owner.Size = New Size(231, 118)
        Button_Owner.TabIndex = 0
        Button_Owner.Text = "OWNERS"
        Button_Owner.UseVisualStyleBackColor = False
        ' 
        ' SALES
        ' 
        SALES.BackColor = Color.FromArgb(CByte(42), CByte(72), CByte(78))
        SALES.FlatAppearance.BorderColor = Color.FromArgb(CByte(42), CByte(72), CByte(78))
        SALES.FlatStyle = FlatStyle.Flat
        SALES.Font = New Font("Century Gothic", 13F, FontStyle.Bold)
        SALES.ForeColor = Color.White
        SALES.Location = New Point(-3, 692)
        SALES.Name = "SALES"
        SALES.Size = New Size(231, 112)
        SALES.TabIndex = 6
        SALES.Text = "SALES"
        SALES.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(42), CByte(72), CByte(78))
        Button2.FlatAppearance.BorderColor = Color.FromArgb(CByte(42), CByte(72), CByte(78))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Century Gothic", 13F, FontStyle.Bold)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(1, 138)
        Button2.Name = "Button2"
        Button2.Size = New Size(231, 111)
        Button2.TabIndex = 1
        Button2.Text = "CLIENTS"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(42), CByte(72), CByte(78))
        Button3.FlatAppearance.BorderColor = Color.FromArgb(CByte(42), CByte(72), CByte(78))
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Century Gothic", 13F, FontStyle.Bold)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(0, 266)
        Button3.Name = "Button3"
        Button3.Size = New Size(231, 124)
        Button3.TabIndex = 2
        Button3.Text = "PROPERTIES"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' ButtonIMAGES
        ' 
        ButtonIMAGES.BackColor = Color.FromArgb(CByte(42), CByte(72), CByte(78))
        ButtonIMAGES.FlatAppearance.BorderColor = Color.FromArgb(CByte(42), CByte(72), CByte(78))
        ButtonIMAGES.FlatStyle = FlatStyle.Flat
        ButtonIMAGES.Font = New Font("Century Gothic", 13F, FontStyle.Bold)
        ButtonIMAGES.ForeColor = Color.White
        ButtonIMAGES.Location = New Point(-3, 551)
        ButtonIMAGES.Name = "ButtonIMAGES"
        ButtonIMAGES.Size = New Size(231, 123)
        ButtonIMAGES.TabIndex = 4
        ButtonIMAGES.Text = "IMAGES"
        ButtonIMAGES.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(42), CByte(72), CByte(78))
        Button4.FlatAppearance.BorderColor = Color.FromArgb(CByte(42), CByte(72), CByte(78))
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Century Gothic", 13F, FontStyle.Bold)
        Button4.ForeColor = Color.White
        Button4.Location = New Point(-3, 408)
        Button4.Name = "Button4"
        Button4.Size = New Size(231, 124)
        Button4.TabIndex = 3
        Button4.Text = "TYPES"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' PanelLeft
        ' 
        PanelLeft.BackColor = Color.RosyBrown
        PanelLeft.Location = New Point(0, 0)
        PanelLeft.Name = "PanelLeft"
        PanelLeft.Size = New Size(5, 261)
        PanelLeft.TabIndex = 2
        ' 
        ' PanelRight
        ' 
        PanelRight.BackColor = Color.RosyBrown
        PanelRight.Location = New Point(1813, 0)
        PanelRight.Name = "PanelRight"
        PanelRight.Size = New Size(5, 261)
        PanelRight.TabIndex = 3
        ' 
        ' Main_Form
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1818, 1050)
        Controls.Add(PanelRight)
        Controls.Add(PanelLeft)
        Controls.Add(Panel_Menu)
        Name = "Main_Form"
        StartPosition = FormStartPosition.CenterScreen
        Text = "-"
        WindowState = FormWindowState.Maximized
        Panel_Menu.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel_Menu As Panel
    Friend WithEvents Button_Owner As Button
    Friend WithEvents ButtonIMAGES As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PanelLeft As Panel
    Friend WithEvents PanelRight As Panel
    Friend WithEvents SALES As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
End Class
