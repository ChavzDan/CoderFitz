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
        SplitContainer1 = New SplitContainer()
        Button1 = New Button()
        Button2 = New Button()
        SALES = New Button()
        Button_Owner = New Button()
        ButtonIMAGES = New Button()
        Button3 = New Button()
        Button4 = New Button()
        PrintPreviewControl1 = New PrintPreviewControl()
        Panel_Menu.SuspendLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel_Menu
        ' 
        Panel_Menu.BackColor = Color.FromArgb(CByte(55), CByte(115), CByte(117))
        Panel_Menu.BackgroundImageLayout = ImageLayout.None
        Panel_Menu.Controls.Add(SplitContainer1)
        Panel_Menu.Controls.Add(PrintPreviewControl1)
        Panel_Menu.Dock = DockStyle.Fill
        Panel_Menu.ForeColor = Color.Black
        Panel_Menu.Location = New Point(0, 0)
        Panel_Menu.Margin = New Padding(2)
        Panel_Menu.Name = "Panel_Menu"
        Panel_Menu.Size = New Size(984, 561)
        Panel_Menu.TabIndex = 0
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        SplitContainer1.BorderStyle = BorderStyle.FixedSingle
        SplitContainer1.IsSplitterFixed = True
        SplitContainer1.Location = New Point(3, 60)
        SplitContainer1.MinimumSize = New Size(940, 540)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(Button1)
        SplitContainer1.Panel1.Controls.Add(Button2)
        SplitContainer1.Panel1.Controls.Add(SALES)
        SplitContainer1.Panel1.Controls.Add(Button_Owner)
        SplitContainer1.Panel1.Controls.Add(ButtonIMAGES)
        SplitContainer1.Panel1.Controls.Add(Button3)
        SplitContainer1.Panel1.Controls.Add(Button4)
        SplitContainer1.Panel1MinSize = 180
        SplitContainer1.Panel2MinSize = 760
        SplitContainer1.Size = New Size(978, 540)
        SplitContainer1.SplitterDistance = 180
        SplitContainer1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Button1.BackColor = Color.FromArgb(CByte(55), CByte(115), CByte(117))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Century Gothic", 13.0F, FontStyle.Bold)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(7, 280)
        Button1.Margin = New Padding(2)
        Button1.MinimumSize = New Size(162, 37)
        Button1.Name = "Button1"
        Button1.Size = New Size(162, 37)
        Button1.TabIndex = 7
        Button1.Text = "ABOUT US"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Button2.BackColor = Color.FromArgb(CByte(42), CByte(72), CByte(78))
        Button2.FlatAppearance.BorderColor = Color.FromArgb(CByte(42), CByte(72), CByte(78))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Century Gothic", 13.0F, FontStyle.Bold)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(7, 2)
        Button2.Margin = New Padding(2)
        Button2.MinimumSize = New Size(162, 37)
        Button2.Name = "Button2"
        Button2.Size = New Size(162, 37)
        Button2.TabIndex = 1
        Button2.Text = "CLIENTS"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' SALES
        ' 
        SALES.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        SALES.BackColor = Color.FromArgb(CByte(42), CByte(72), CByte(78))
        SALES.FlatAppearance.BorderColor = Color.FromArgb(CByte(42), CByte(72), CByte(78))
        SALES.FlatStyle = FlatStyle.Flat
        SALES.Font = New Font("Century Gothic", 13.0F, FontStyle.Bold)
        SALES.ForeColor = Color.White
        SALES.Location = New Point(7, 207)
        SALES.Margin = New Padding(2)
        SALES.MinimumSize = New Size(162, 37)
        SALES.Name = "SALES"
        SALES.Size = New Size(162, 37)
        SALES.TabIndex = 6
        SALES.Text = "SALES"
        SALES.UseVisualStyleBackColor = False
        ' 
        ' Button_Owner
        ' 
        Button_Owner.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Button_Owner.BackColor = Color.FromArgb(CByte(42), CByte(72), CByte(78))
        Button_Owner.FlatAppearance.BorderColor = Color.FromArgb(CByte(42), CByte(72), CByte(78))
        Button_Owner.FlatStyle = FlatStyle.Flat
        Button_Owner.Font = New Font("Century Gothic", 13.0F, FontStyle.Bold)
        Button_Owner.ForeColor = Color.White
        Button_Owner.Location = New Point(7, 43)
        Button_Owner.Margin = New Padding(2)
        Button_Owner.MinimumSize = New Size(162, 37)
        Button_Owner.Name = "Button_Owner"
        Button_Owner.Size = New Size(162, 37)
        Button_Owner.TabIndex = 0
        Button_Owner.Text = "OWNERS"
        Button_Owner.UseMnemonic = False
        Button_Owner.UseVisualStyleBackColor = False
        ' 
        ' ButtonIMAGES
        ' 
        ButtonIMAGES.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        ButtonIMAGES.BackColor = Color.FromArgb(CByte(42), CByte(72), CByte(78))
        ButtonIMAGES.FlatAppearance.BorderColor = Color.FromArgb(CByte(42), CByte(72), CByte(78))
        ButtonIMAGES.FlatStyle = FlatStyle.Flat
        ButtonIMAGES.Font = New Font("Century Gothic", 13.0F, FontStyle.Bold)
        ButtonIMAGES.ForeColor = Color.White
        ButtonIMAGES.Location = New Point(7, 166)
        ButtonIMAGES.Margin = New Padding(2)
        ButtonIMAGES.MinimumSize = New Size(162, 37)
        ButtonIMAGES.Name = "ButtonIMAGES"
        ButtonIMAGES.Size = New Size(162, 37)
        ButtonIMAGES.TabIndex = 4
        ButtonIMAGES.Text = "IMAGES"
        ButtonIMAGES.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Button3.BackColor = Color.FromArgb(CByte(42), CByte(72), CByte(78))
        Button3.FlatAppearance.BorderColor = Color.FromArgb(CByte(42), CByte(72), CByte(78))
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Century Gothic", 13.0F, FontStyle.Bold)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(7, 84)
        Button3.Margin = New Padding(2)
        Button3.MinimumSize = New Size(162, 37)
        Button3.Name = "Button3"
        Button3.Size = New Size(162, 37)
        Button3.TabIndex = 2
        Button3.Text = "PROPERTIES"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Button4.BackColor = Color.FromArgb(CByte(42), CByte(72), CByte(78))
        Button4.FlatAppearance.BorderColor = Color.FromArgb(CByte(42), CByte(72), CByte(78))
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Century Gothic", 13.0F, FontStyle.Bold)
        Button4.ForeColor = Color.White
        Button4.Location = New Point(7, 125)
        Button4.Margin = New Padding(2)
        Button4.MinimumSize = New Size(162, 37)
        Button4.Name = "Button4"
        Button4.Size = New Size(162, 37)
        Button4.TabIndex = 3
        Button4.Text = "TYPES"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' PrintPreviewControl1
        ' 
        PrintPreviewControl1.Location = New Point(533, 408)
        PrintPreviewControl1.Name = "PrintPreviewControl1"
        PrintPreviewControl1.Size = New Size(100, 100)
        PrintPreviewControl1.TabIndex = 0
        ' 
        ' Main_Form
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(984, 561)
        Controls.Add(Panel_Menu)
        Margin = New Padding(2)
        MinimumSize = New Size(1000, 600)
        Name = "Main_Form"
        StartPosition = FormStartPosition.CenterScreen
        Text = "-"
        WindowState = FormWindowState.Maximized
        Panel_Menu.ResumeLayout(False)
        SplitContainer1.Panel1.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel_Menu As Panel
    Friend WithEvents Button_Owner As Button
    Friend WithEvents ButtonIMAGES As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents SALES As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents PrintPreviewControl1 As PrintPreviewControl
End Class
