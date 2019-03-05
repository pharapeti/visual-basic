<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormHome))
        Me.ButtonNext = New System.Windows.Forms.Button()
        Me.ButtonHelp = New System.Windows.Forms.Button()
        Me.ButtonQuit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureScience2 = New System.Windows.Forms.PictureBox()
        Me.PictureScience = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureScience2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureScience, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonNext
        '
        Me.ButtonNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonNext.Location = New System.Drawing.Point(707, 544)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(75, 23)
        Me.ButtonNext.TabIndex = 0
        Me.ButtonNext.Text = "Next"
        Me.ButtonNext.UseVisualStyleBackColor = False
        '
        'ButtonHelp
        '
        Me.ButtonHelp.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonHelp.Location = New System.Drawing.Point(12, 538)
        Me.ButtonHelp.Name = "ButtonHelp"
        Me.ButtonHelp.Size = New System.Drawing.Size(75, 23)
        Me.ButtonHelp.TabIndex = 1
        Me.ButtonHelp.Text = "Help"
        Me.ButtonHelp.UseVisualStyleBackColor = False
        '
        'ButtonQuit
        '
        Me.ButtonQuit.BackColor = System.Drawing.Color.Red
        Me.ButtonQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonQuit.Location = New System.Drawing.Point(12, 12)
        Me.ButtonQuit.Name = "ButtonQuit"
        Me.ButtonQuit.Size = New System.Drawing.Size(75, 23)
        Me.ButtonQuit.TabIndex = 2
        Me.ButtonQuit.Text = "Quit"
        Me.ButtonQuit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Mincho", 20.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(239, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 27)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Year 7 Science Game:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.PaleGreen
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 343)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(721, 142)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'PictureScience2
        '
        Me.PictureScience2.BackgroundImage = Global.SDD_YR12_AE1.My.Resources.Resources.science2
        Me.PictureScience2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureScience2.Location = New System.Drawing.Point(520, 72)
        Me.PictureScience2.Name = "PictureScience2"
        Me.PictureScience2.Size = New System.Drawing.Size(236, 230)
        Me.PictureScience2.TabIndex = 6
        Me.PictureScience2.TabStop = False
        '
        'PictureScience
        '
        Me.PictureScience.BackgroundImage = Global.SDD_YR12_AE1.My.Resources.Resources.Science
        Me.PictureScience.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureScience.Location = New System.Drawing.Point(35, 72)
        Me.PictureScience.Name = "PictureScience"
        Me.PictureScience.Size = New System.Drawing.Size(421, 230)
        Me.PictureScience.TabIndex = 5
        Me.PictureScience.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(301, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Created by Patrice Harapeti"
        '
        'FormHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureScience2)
        Me.Controls.Add(Me.PictureScience)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonQuit)
        Me.Controls.Add(Me.ButtonHelp)
        Me.Controls.Add(Me.ButtonNext)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome"
        CType(Me.PictureScience2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureScience, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonNext As System.Windows.Forms.Button
    Friend WithEvents ButtonHelp As System.Windows.Forms.Button
    Friend WithEvents ButtonQuit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureScience As System.Windows.Forms.PictureBox
    Friend WithEvents PictureScience2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
