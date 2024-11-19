<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PropertyImages_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PropertyImages_Form))
        MySqlCommandBuilder1 = New MySqlConnector.MySqlCommandBuilder()
        PanelRight = New Panel()
        PictureBox1 = New PictureBox()
        Panel3 = New Panel()
        Button_ShowProperty = New Button()
        ButtonREMOVE = New Button()
        ButtonADD = New Button()
        Button_SelectImage = New Button()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        PictureBox_PropertyImage = New PictureBox()
        ListBox_Images = New ListBox()
        DataGridViewProperties = New DataGridView()
        DataGridViewType = New DataGridView()
        Panel2 = New Panel()
        Label6 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox_PropertyImage, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridViewProperties, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridViewType, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MySqlCommandBuilder1
        ' 
        MySqlCommandBuilder1.DataAdapter = Nothing
        MySqlCommandBuilder1.QuotePrefix = "`"
        MySqlCommandBuilder1.QuoteSuffix = "`"
        ' 
        ' PanelRight
        ' 
        PanelRight.BackColor = Color.RosyBrown
        PanelRight.Location = New Point(1813, 1)
        PanelRight.Name = "PanelRight"
        PanelRight.Size = New Size(5, 261)
        PanelRight.TabIndex = 5
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(16, -11)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(168, 123)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(168), CByte(216), CByte(205))
        Panel3.Controls.Add(Button_ShowProperty)
        Panel3.Controls.Add(ButtonREMOVE)
        Panel3.Controls.Add(ButtonADD)
        Panel3.Controls.Add(Button_SelectImage)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(PictureBox_PropertyImage)
        Panel3.Controls.Add(ListBox_Images)
        Panel3.Controls.Add(DataGridViewProperties)
        Panel3.Controls.Add(DataGridViewType)
        Panel3.Location = New Point(16, 118)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1329, 714)
        Panel3.TabIndex = 4
        ' 
        ' Button_ShowProperty
        ' 
        Button_ShowProperty.BackColor = Color.FromArgb(CByte(55), CByte(115), CByte(117))
        Button_ShowProperty.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button_ShowProperty.ForeColor = Color.White
        Button_ShowProperty.Location = New Point(280, 525)
        Button_ShowProperty.Name = "Button_ShowProperty"
        Button_ShowProperty.Size = New Size(350, 65)
        Button_ShowProperty.TabIndex = 17
        Button_ShowProperty.Text = "Show This Property Images"
        Button_ShowProperty.UseVisualStyleBackColor = False
        ' 
        ' ButtonREMOVE
        ' 
        ButtonREMOVE.BackColor = Color.DarkRed
        ButtonREMOVE.Font = New Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonREMOVE.ForeColor = Color.White
        ButtonREMOVE.Location = New Point(646, 523)
        ButtonREMOVE.Name = "ButtonREMOVE"
        ButtonREMOVE.Size = New Size(328, 65)
        ButtonREMOVE.TabIndex = 16
        ButtonREMOVE.Text = "DELETE"
        ButtonREMOVE.UseVisualStyleBackColor = False
        ' 
        ' ButtonADD
        ' 
        ButtonADD.BackColor = Color.FromArgb(CByte(55), CByte(115), CByte(117))
        ButtonADD.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        ButtonADD.ForeColor = Color.White
        ButtonADD.Location = New Point(993, 599)
        ButtonADD.Name = "ButtonADD"
        ButtonADD.Size = New Size(320, 59)
        ButtonADD.TabIndex = 15
        ButtonADD.Text = "Add Image"
        ButtonADD.UseVisualStyleBackColor = False
        ' 
        ' Button_SelectImage
        ' 
        Button_SelectImage.BackColor = Color.FromArgb(CByte(55), CByte(115), CByte(117))
        Button_SelectImage.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        Button_SelectImage.ForeColor = Color.White
        Button_SelectImage.Location = New Point(993, 524)
        Button_SelectImage.Name = "Button_SelectImage"
        Button_SelectImage.Size = New Size(320, 69)
        Button_SelectImage.TabIndex = 14
        Button_SelectImage.Text = "Select Image"
        Button_SelectImage.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label5.Location = New Point(1078, 27)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 28)
        Label5.TabIndex = 7
        Label5.Text = "IMAGE"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label4.Location = New Point(723, 27)
        Label4.Name = "Label4"
        Label4.Size = New Size(103, 28)
        Label4.TabIndex = 6
        Label4.Text = "IMAGES"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label3.Location = New Point(377, 27)
        Label3.Name = "Label3"
        Label3.Size = New Size(139, 28)
        Label3.TabIndex = 5
        Label3.Text = "PROPERTIES"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label2.Location = New Point(102, 27)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 28)
        Label2.TabIndex = 4
        Label2.Text = "Types"
        ' 
        ' PictureBox_PropertyImage
        ' 
        PictureBox_PropertyImage.BackColor = Color.MistyRose
        PictureBox_PropertyImage.Location = New Point(993, 72)
        PictureBox_PropertyImage.Name = "PictureBox_PropertyImage"
        PictureBox_PropertyImage.Size = New Size(320, 446)
        PictureBox_PropertyImage.TabIndex = 3
        PictureBox_PropertyImage.TabStop = False
        ' 
        ' ListBox_Images
        ' 
        ListBox_Images.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListBox_Images.FormattingEnabled = True
        ListBox_Images.ItemHeight = 21
        ListBox_Images.Location = New Point(646, 72)
        ListBox_Images.Name = "ListBox_Images"
        ListBox_Images.Size = New Size(328, 445)
        ListBox_Images.TabIndex = 2
        ' 
        ' DataGridViewProperties
        ' 
        DataGridViewProperties.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewProperties.Location = New Point(280, 71)
        DataGridViewProperties.Name = "DataGridViewProperties"
        DataGridViewProperties.RowHeadersWidth = 62
        DataGridViewProperties.Size = New Size(350, 441)
        DataGridViewProperties.TabIndex = 1
        ' 
        ' DataGridViewType
        ' 
        DataGridViewType.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewType.Location = New Point(12, 71)
        DataGridViewType.Name = "DataGridViewType"
        DataGridViewType.RowHeadersWidth = 62
        DataGridViewType.Size = New Size(253, 443)
        DataGridViewType.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Location = New Point(16, 88)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1319, 10)
        Panel2.TabIndex = 2
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BorderStyle = BorderStyle.FixedSingle
        Label6.Font = New Font("Gill Sans Ultra Bold", 25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(129, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(624, 74)
        Label6.TabIndex = 6
        Label6.Text = "PROPERTY IMAGES"
        ' 
        ' PropertyImages_Form
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(42), CByte(72), CByte(78))
        ClientSize = New Size(1399, 1050)
        Controls.Add(Label6)
        Controls.Add(Panel2)
        Controls.Add(Panel3)
        Controls.Add(PictureBox1)
        Controls.Add(PanelRight)
        FormBorderStyle = FormBorderStyle.None
        Name = "PropertyImages_Form"
        StartPosition = FormStartPosition.WindowsDefaultBounds
        Text = "PropertyImages_Form"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox_PropertyImage, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridViewProperties, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridViewType, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MySqlCommandBuilder1 As MySqlConnector.MySqlCommandBuilder
    Friend WithEvents PanelRight As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button_ShowProperty As Button
    Friend WithEvents ButtonREMOVE As Button
    Friend WithEvents ButtonADD As Button
    Friend WithEvents Button_SelectImage As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox_PropertyImage As PictureBox
    Friend WithEvents ListBox_Images As ListBox
    Friend WithEvents DataGridViewProperties As DataGridView
    Friend WithEvents DataGridViewType As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
End Class
