<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTopic1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTopic1))
        Me.LabelRocks = New System.Windows.Forms.Label()
        Me.ButtonQuiz = New System.Windows.Forms.Button()
        Me.ButtonInfo = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.LabelSed = New System.Windows.Forms.Label()
        Me.LabelIg = New System.Windows.Forms.Label()
        Me.LabelMet = New System.Windows.Forms.Label()
        Me.PictureIg = New System.Windows.Forms.PictureBox()
        Me.PictureMet = New System.Windows.Forms.PictureBox()
        Me.PictureSed = New System.Windows.Forms.PictureBox()
        CType(Me.PictureIg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureMet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureSed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelRocks
        '
        Me.LabelRocks.AutoSize = True
        Me.LabelRocks.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRocks.Location = New System.Drawing.Point(315, 18)
        Me.LabelRocks.Name = "LabelRocks"
        Me.LabelRocks.Size = New System.Drawing.Size(147, 25)
        Me.LabelRocks.TabIndex = 0
        Me.LabelRocks.Text = "Types of Rocks"
        '
        'ButtonQuiz
        '
        Me.ButtonQuiz.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonQuiz.Location = New System.Drawing.Point(705, 538)
        Me.ButtonQuiz.Name = "ButtonQuiz"
        Me.ButtonQuiz.Size = New System.Drawing.Size(75, 23)
        Me.ButtonQuiz.TabIndex = 1
        Me.ButtonQuiz.Text = "Quiz"
        Me.ButtonQuiz.UseVisualStyleBackColor = False
        '
        'ButtonInfo
        '
        Me.ButtonInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonInfo.Location = New System.Drawing.Point(13, 537)
        Me.ButtonInfo.Name = "ButtonInfo"
        Me.ButtonInfo.Size = New System.Drawing.Size(75, 23)
        Me.ButtonInfo.TabIndex = 2
        Me.ButtonInfo.Text = "More info."
        Me.ButtonInfo.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(14, 18)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(141, 30)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Back to Topic Selection"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'LabelSed
        '
        Me.LabelSed.AutoSize = True
        Me.LabelSed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelSed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelSed.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSed.Location = New System.Drawing.Point(12, 277)
        Me.LabelSed.Name = "LabelSed"
        Me.LabelSed.Size = New System.Drawing.Size(256, 189)
        Me.LabelSed.TabIndex = 7
        Me.LabelSed.Text = resources.GetString("LabelSed.Text")
        '
        'LabelIg
        '
        Me.LabelIg.AutoSize = True
        Me.LabelIg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelIg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelIg.Location = New System.Drawing.Point(549, 277)
        Me.LabelIg.Name = "LabelIg"
        Me.LabelIg.Size = New System.Drawing.Size(237, 189)
        Me.LabelIg.TabIndex = 8
        Me.LabelIg.Text = resources.GetString("LabelIg.Text")
        '
        'LabelMet
        '
        Me.LabelMet.AutoSize = True
        Me.LabelMet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelMet.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMet.Location = New System.Drawing.Point(284, 277)
        Me.LabelMet.Name = "LabelMet"
        Me.LabelMet.Size = New System.Drawing.Size(250, 189)
        Me.LabelMet.TabIndex = 9
        Me.LabelMet.Text = resources.GetString("LabelMet.Text")
        '
        'PictureIg
        '
        Me.PictureIg.BackgroundImage = Global.SDD_YR12_AE1.My.Resources.Resources.Igneous
        Me.PictureIg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureIg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureIg.Location = New System.Drawing.Point(556, 96)
        Me.PictureIg.Name = "PictureIg"
        Me.PictureIg.Size = New System.Drawing.Size(197, 130)
        Me.PictureIg.TabIndex = 6
        Me.PictureIg.TabStop = False
        '
        'PictureMet
        '
        Me.PictureMet.BackgroundImage = Global.SDD_YR12_AE1.My.Resources.Resources.Metamorphic
        Me.PictureMet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureMet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureMet.Location = New System.Drawing.Point(300, 96)
        Me.PictureMet.Name = "PictureMet"
        Me.PictureMet.Size = New System.Drawing.Size(219, 130)
        Me.PictureMet.TabIndex = 5
        Me.PictureMet.TabStop = False
        '
        'PictureSed
        '
        Me.PictureSed.BackgroundImage = Global.SDD_YR12_AE1.My.Resources.Resources.Sedimentary
        Me.PictureSed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureSed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureSed.Location = New System.Drawing.Point(25, 96)
        Me.PictureSed.Name = "PictureSed"
        Me.PictureSed.Size = New System.Drawing.Size(222, 130)
        Me.PictureSed.TabIndex = 4
        Me.PictureSed.TabStop = False
        '
        'FormTopic1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.Controls.Add(Me.LabelMet)
        Me.Controls.Add(Me.LabelIg)
        Me.Controls.Add(Me.LabelSed)
        Me.Controls.Add(Me.PictureIg)
        Me.Controls.Add(Me.PictureMet)
        Me.Controls.Add(Me.PictureSed)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ButtonInfo)
        Me.Controls.Add(Me.ButtonQuiz)
        Me.Controls.Add(Me.LabelRocks)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormTopic1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Types of Rocks"
        CType(Me.PictureIg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureMet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureSed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelRocks As System.Windows.Forms.Label
    Friend WithEvents ButtonQuiz As System.Windows.Forms.Button
    Friend WithEvents ButtonInfo As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents PictureSed As System.Windows.Forms.PictureBox
    Friend WithEvents PictureMet As System.Windows.Forms.PictureBox
    Friend WithEvents PictureIg As System.Windows.Forms.PictureBox
    Friend WithEvents LabelSed As System.Windows.Forms.Label
    Friend WithEvents LabelIg As System.Windows.Forms.Label
    Friend WithEvents LabelMet As System.Windows.Forms.Label
End Class
