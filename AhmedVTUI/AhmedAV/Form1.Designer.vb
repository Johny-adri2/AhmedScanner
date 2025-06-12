<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ahmed
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ahmed))
        Button1 = New Button()
        TextBox1 = New TextBox()
        Label1 = New Label()
        TextBox2 = New TextBox()
        Button2 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        Label5 = New Label()
        Label6 = New Label()
        PictureBox2 = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox3 = New CheckBox()
        Button3 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 339)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "Scan"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 310)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(181, 23)
        TextBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 292)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 15)
        Label1.TabIndex = 2
        Label1.Text = "API Key"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(12, 266)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 3
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(118, 266)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 4
        Button2.Text = "Browse"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 248)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 15)
        Label2.TabIndex = 5
        Label2.Text = "Sample"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        Label3.ForeColor = SystemColors.ControlDark
        Label3.ImageAlign = ContentAlignment.BottomRight
        Label3.Location = New Point(235, 336)
        Label3.Name = "Label3"
        Label3.Size = New Size(231, 26)
        Label3.TabIndex = 6
        Label3.Text = "made by u/myuserisdrowned in Visual Basic" & vbCrLf & "automated with VirusTotal, do not abuse"
        Label3.TextAlign = ContentAlignment.BottomRight
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.Control
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 7)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(245, 277)
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.White
        Label5.Font = New Font("Comic Sans MS", 18.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(204))
        Label5.Location = New Point(30, 26)
        Label5.Name = "Label5"
        Label5.Size = New Size(139, 34)
        Label5.TabIndex = 9
        Label5.Text = "i'm Ahmed"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.White
        Label6.Font = New Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        Label6.Location = New Point(30, 60)
        Label6.Name = "Label6"
        Label6.Size = New Size(147, 38)
        Label6.TabIndex = 10
        Label6.Text = "i scan the files you " & vbCrLf & "upload with virustotal"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BorderStyle = BorderStyle.Fixed3D
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(252, 7)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(214, 232)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 11
        PictureBox2.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.ForeColor = SystemColors.ControlDarkDark
        CheckBox1.Location = New Point(118, 248)
        CheckBox1.Margin = New Padding(3, 2, 3, 2)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(48, 19)
        CheckBox1.TabIndex = 12
        CheckBox1.Text = "Link"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Checked = True
        CheckBox2.CheckState = CheckState.Checked
        CheckBox2.ForeColor = SystemColors.ControlDarkDark
        CheckBox2.Location = New Point(252, 248)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(76, 19)
        CheckBox2.TabIndex = 13
        CheckBox2.Text = "VT notice"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.ForeColor = SystemColors.ControlDarkDark
        CheckBox3.Location = New Point(334, 248)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(89, 19)
        CheckBox3.TabIndex = 14
        CheckBox3.Text = "ALT phrases"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(215, 301)
        Button3.Name = "Button3"
        Button3.Size = New Size(52, 22)
        Button3.TabIndex = 15
        Button3.Text = "OK"
        Button3.UseVisualStyleBackColor = True
        Button3.Visible = False
        ' 
        ' ahmed
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(478, 374)
        Controls.Add(Button3)
        Controls.Add(CheckBox3)
        Controls.Add(CheckBox2)
        Controls.Add(CheckBox1)
        Controls.Add(PictureBox2)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button2)
        Controls.Add(TextBox2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "ahmed"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AhmedScanner - Allah will help you!"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents Button3 As Button

End Class
