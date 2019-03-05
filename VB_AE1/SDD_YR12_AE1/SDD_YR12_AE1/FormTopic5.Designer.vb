<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTypes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTypes))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.Mag = New System.Windows.Forms.TabPage()
        Me.LabelMagnetismTitle = New System.Windows.Forms.Label()
        Me.PictureMagnetism = New System.Windows.Forms.PictureBox()
        Me.ButtonMagQuiz = New System.Windows.Forms.Button()
        Me.LabelMag = New System.Windows.Forms.Label()
        Me.Kin = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Heat = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Light = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Grav = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Chem = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Sound = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Elec = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Elastic = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Nuclear = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.TabControl.SuspendLayout()
        Me.Mag.SuspendLayout()
        CType(Me.PictureMagnetism, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Kin.SuspendLayout()
        Me.Heat.SuspendLayout()
        Me.Light.SuspendLayout()
        Me.Grav.SuspendLayout()
        Me.Chem.SuspendLayout()
        Me.Sound.SuspendLayout()
        Me.Elec.SuspendLayout()
        Me.Elastic.SuspendLayout()
        Me.Nuclear.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(311, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Types of Energy"
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.Mag)
        Me.TabControl.Controls.Add(Me.Kin)
        Me.TabControl.Controls.Add(Me.Heat)
        Me.TabControl.Controls.Add(Me.Light)
        Me.TabControl.Controls.Add(Me.Grav)
        Me.TabControl.Controls.Add(Me.Chem)
        Me.TabControl.Controls.Add(Me.Sound)
        Me.TabControl.Controls.Add(Me.Elec)
        Me.TabControl.Controls.Add(Me.Elastic)
        Me.TabControl.Controls.Add(Me.Nuclear)
        Me.TabControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl.Location = New System.Drawing.Point(16, 47)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(768, 514)
        Me.TabControl.TabIndex = 1
        '
        'Mag
        '
        Me.Mag.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Mag.Controls.Add(Me.LabelMagnetismTitle)
        Me.Mag.Controls.Add(Me.PictureMagnetism)
        Me.Mag.Controls.Add(Me.ButtonMagQuiz)
        Me.Mag.Controls.Add(Me.LabelMag)
        Me.Mag.Location = New System.Drawing.Point(4, 24)
        Me.Mag.Name = "Mag"
        Me.Mag.Padding = New System.Windows.Forms.Padding(3)
        Me.Mag.Size = New System.Drawing.Size(760, 486)
        Me.Mag.TabIndex = 0
        Me.Mag.Text = "Magnetic"
        '
        'LabelMagnetismTitle
        '
        Me.LabelMagnetismTitle.AutoSize = True
        Me.LabelMagnetismTitle.Font = New System.Drawing.Font("Corbel", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMagnetismTitle.Location = New System.Drawing.Point(299, 26)
        Me.LabelMagnetismTitle.Name = "LabelMagnetismTitle"
        Me.LabelMagnetismTitle.Size = New System.Drawing.Size(135, 29)
        Me.LabelMagnetismTitle.TabIndex = 4
        Me.LabelMagnetismTitle.Text = "Magnetism:"
        '
        'PictureMagnetism
        '
        Me.PictureMagnetism.BackgroundImage = Global.SDD_YR12_AE1.My.Resources.Resources.edit
        Me.PictureMagnetism.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureMagnetism.Location = New System.Drawing.Point(20, 93)
        Me.PictureMagnetism.Name = "PictureMagnetism"
        Me.PictureMagnetism.Size = New System.Drawing.Size(232, 225)
        Me.PictureMagnetism.TabIndex = 3
        Me.PictureMagnetism.TabStop = False
        '
        'ButtonMagQuiz
        '
        Me.ButtonMagQuiz.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonMagQuiz.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonMagQuiz.Location = New System.Drawing.Point(666, 443)
        Me.ButtonMagQuiz.Name = "ButtonMagQuiz"
        Me.ButtonMagQuiz.Size = New System.Drawing.Size(75, 23)
        Me.ButtonMagQuiz.TabIndex = 2
        Me.ButtonMagQuiz.Text = "Quiz"
        Me.ButtonMagQuiz.UseVisualStyleBackColor = False
        '
        'LabelMag
        '
        Me.LabelMag.AutoSize = True
        Me.LabelMag.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabelMag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelMag.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelMag.Font = New System.Drawing.Font("Corbel", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMag.Location = New System.Drawing.Point(271, 110)
        Me.LabelMag.Name = "LabelMag"
        Me.LabelMag.Size = New System.Drawing.Size(476, 194)
        Me.LabelMag.TabIndex = 0
        Me.LabelMag.Text = resources.GetString("LabelMag.Text")
        '
        'Kin
        '
        Me.Kin.BackColor = System.Drawing.Color.Silver
        Me.Kin.Controls.Add(Me.Label3)
        Me.Kin.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kin.Location = New System.Drawing.Point(4, 24)
        Me.Kin.Name = "Kin"
        Me.Kin.Padding = New System.Windows.Forms.Padding(3)
        Me.Kin.Size = New System.Drawing.Size(760, 486)
        Me.Kin.TabIndex = 1
        Me.Kin.Text = "Kinetic"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(321, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "In development"
        '
        'Heat
        '
        Me.Heat.BackColor = System.Drawing.Color.Silver
        Me.Heat.Controls.Add(Me.Label4)
        Me.Heat.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Heat.Location = New System.Drawing.Point(4, 24)
        Me.Heat.Name = "Heat"
        Me.Heat.Size = New System.Drawing.Size(760, 486)
        Me.Heat.TabIndex = 2
        Me.Heat.Text = "Heat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(321, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "In development"
        '
        'Light
        '
        Me.Light.BackColor = System.Drawing.Color.Silver
        Me.Light.Controls.Add(Me.Label5)
        Me.Light.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Light.Location = New System.Drawing.Point(4, 24)
        Me.Light.Name = "Light"
        Me.Light.Size = New System.Drawing.Size(760, 486)
        Me.Light.TabIndex = 3
        Me.Light.Text = "Light"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(321, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "In development"
        '
        'Grav
        '
        Me.Grav.BackColor = System.Drawing.Color.Silver
        Me.Grav.Controls.Add(Me.Label6)
        Me.Grav.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grav.Location = New System.Drawing.Point(4, 24)
        Me.Grav.Name = "Grav"
        Me.Grav.Size = New System.Drawing.Size(760, 486)
        Me.Grav.TabIndex = 4
        Me.Grav.Text = "Gravitational Potential"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(321, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 20)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "In development"
        '
        'Chem
        '
        Me.Chem.BackColor = System.Drawing.Color.Silver
        Me.Chem.Controls.Add(Me.Label7)
        Me.Chem.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chem.Location = New System.Drawing.Point(4, 24)
        Me.Chem.Name = "Chem"
        Me.Chem.Size = New System.Drawing.Size(760, 486)
        Me.Chem.TabIndex = 5
        Me.Chem.Text = "Chemical"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(321, 206)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 20)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "In development"
        '
        'Sound
        '
        Me.Sound.BackColor = System.Drawing.Color.Silver
        Me.Sound.Controls.Add(Me.Label8)
        Me.Sound.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sound.Location = New System.Drawing.Point(4, 24)
        Me.Sound.Name = "Sound"
        Me.Sound.Size = New System.Drawing.Size(760, 486)
        Me.Sound.TabIndex = 6
        Me.Sound.Text = "Sound"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(321, 206)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 20)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "In development"
        '
        'Elec
        '
        Me.Elec.BackColor = System.Drawing.Color.Silver
        Me.Elec.Controls.Add(Me.Label9)
        Me.Elec.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Elec.Location = New System.Drawing.Point(4, 24)
        Me.Elec.Name = "Elec"
        Me.Elec.Size = New System.Drawing.Size(760, 486)
        Me.Elec.TabIndex = 7
        Me.Elec.Text = "Electrical"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(321, 206)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 20)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "In development"
        '
        'Elastic
        '
        Me.Elastic.BackColor = System.Drawing.Color.Silver
        Me.Elastic.Controls.Add(Me.Label10)
        Me.Elastic.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Elastic.Location = New System.Drawing.Point(4, 24)
        Me.Elastic.Name = "Elastic"
        Me.Elastic.Size = New System.Drawing.Size(760, 486)
        Me.Elastic.TabIndex = 8
        Me.Elastic.Text = "Elastic Potential"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(321, 206)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 20)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "In development"
        '
        'Nuclear
        '
        Me.Nuclear.BackColor = System.Drawing.Color.Silver
        Me.Nuclear.Controls.Add(Me.Label11)
        Me.Nuclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nuclear.Location = New System.Drawing.Point(4, 24)
        Me.Nuclear.Name = "Nuclear"
        Me.Nuclear.Size = New System.Drawing.Size(760, 486)
        Me.Nuclear.TabIndex = 9
        Me.Nuclear.Text = "Nuclear"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(321, 206)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 20)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "In development"
        '
        'ButtonBack
        '
        Me.ButtonBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonBack.Location = New System.Drawing.Point(16, 9)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBack.TabIndex = 2
        Me.ButtonBack.Text = "Back"
        Me.ButtonBack.UseVisualStyleBackColor = False
        '
        'FormTypes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.Controls.Add(Me.ButtonBack)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormTypes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Types of Energy"
        Me.TabControl.ResumeLayout(False)
        Me.Mag.ResumeLayout(False)
        Me.Mag.PerformLayout()
        CType(Me.PictureMagnetism, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Kin.ResumeLayout(False)
        Me.Kin.PerformLayout()
        Me.Heat.ResumeLayout(False)
        Me.Heat.PerformLayout()
        Me.Light.ResumeLayout(False)
        Me.Light.PerformLayout()
        Me.Grav.ResumeLayout(False)
        Me.Grav.PerformLayout()
        Me.Chem.ResumeLayout(False)
        Me.Chem.PerformLayout()
        Me.Sound.ResumeLayout(False)
        Me.Sound.PerformLayout()
        Me.Elec.ResumeLayout(False)
        Me.Elec.PerformLayout()
        Me.Elastic.ResumeLayout(False)
        Me.Elastic.PerformLayout()
        Me.Nuclear.ResumeLayout(False)
        Me.Nuclear.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents Mag As System.Windows.Forms.TabPage
    Friend WithEvents Kin As System.Windows.Forms.TabPage
    Friend WithEvents Heat As System.Windows.Forms.TabPage
    Friend WithEvents Light As System.Windows.Forms.TabPage
    Friend WithEvents Grav As System.Windows.Forms.TabPage
    Friend WithEvents Chem As System.Windows.Forms.TabPage
    Friend WithEvents Sound As System.Windows.Forms.TabPage
    Friend WithEvents Elec As System.Windows.Forms.TabPage
    Friend WithEvents Elastic As System.Windows.Forms.TabPage
    Friend WithEvents Nuclear As System.Windows.Forms.TabPage
    Friend WithEvents LabelMag As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ButtonBack As System.Windows.Forms.Button
    Friend WithEvents ButtonMagQuiz As System.Windows.Forms.Button
    Friend WithEvents LabelMagnetismTitle As System.Windows.Forms.Label
    Friend WithEvents PictureMagnetism As System.Windows.Forms.PictureBox
End Class
