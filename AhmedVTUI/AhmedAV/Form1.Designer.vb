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
        Label6 = New Label()
        PictureBox2 = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        CheckBox3 = New CheckBox()
        Button3 = New Button()
        Label5 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("MS UI Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        Button1.Location = New Point(13, 222)
        Button1.Margin = New Padding(4, 2, 4, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(38, 19)
        Button1.TabIndex = 0
        Button1.Text = "Scan"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("MS UI Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        TextBox1.Location = New Point(13, 200)
        TextBox1.Margin = New Padding(4, 2, 4, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 18)
        TextBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("MS UI Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        Label1.Location = New Point(13, 187)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 11)
        Label1.TabIndex = 2
        Label1.Text = "API Key"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("MS UI Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(13, 167)
        TextBox2.Margin = New Padding(4, 2, 4, 2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 18)
        TextBox2.TabIndex = 3
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("MS UI Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        Button2.Location = New Point(116, 168)
        Button2.Margin = New Padding(4, 2, 4, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(49, 18)
        Button2.TabIndex = 4
        Button2.Text = "Browse"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("MS UI Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        Label2.Location = New Point(13, 154)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(38, 11)
        Label2.TabIndex = 5
        Label2.Text = "Sample"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("MS UI Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        Label3.ForeColor = SystemColors.ControlDark
        Label3.ImageAlign = ContentAlignment.BottomRight
        Label3.Location = New Point(168, 219)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(140, 22)
        Label3.TabIndex = 6
        Label3.Text = "made by u/myuserisdrowned " & vbCrLf & "in Visual Basic" & vbCrLf
        Label3.TextAlign = ContentAlignment.BottomRight
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.Control
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(13, 11)
        PictureBox1.Margin = New Padding(4, 2, 4, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(160, 137)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.LemonChiffon
        Label6.Font = New Font("MS UI Gothic", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        Label6.Location = New Point(28, 47)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(103, 24)
        Label6.TabIndex = 10
        Label6.Text = "i scan the files " & vbCrLf & "you upload"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BorderStyle = BorderStyle.Fixed3D
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(181, 11)
        PictureBox2.Margin = New Padding(4, 2, 4, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(128, 138)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 11
        PictureBox2.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Font = New Font("MS UI Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        CheckBox3.ForeColor = SystemColors.ControlDarkDark
        CheckBox3.Location = New Point(180, 153)
        CheckBox3.Margin = New Padding(4, 2, 4, 2)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(82, 15)
        CheckBox3.TabIndex = 14
        CheckBox3.Text = "ALT phrases"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("MS UI Gothic", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        Button3.Location = New Point(131, 192)
        Button3.Margin = New Padding(4, 2, 4, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(66, 22)
        Button3.TabIndex = 15
        Button3.Text = "Thanks"
        Button3.UseVisualStyleBackColor = True
        Button3.Visible = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.LemonChiffon
        Label5.Font = New Font("MS UI Gothic", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        Label5.Location = New Point(28, 27)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(83, 16)
        Label5.TabIndex = 16
        Label5.Text = "i'm ahmed"
        ' 
        ' ahmed
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(321, 253)
        Controls.Add(Label5)
        Controls.Add(Button3)
        Controls.Add(CheckBox3)
        Controls.Add(PictureBox2)
        Controls.Add(Label6)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button2)
        Controls.Add(TextBox2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(PictureBox1)
        Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 2, 4, 2)
        MaximizeBox = False
        Name = "ahmed"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Ahmed - Allah will help you!"
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
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label5 As Label

End Class
