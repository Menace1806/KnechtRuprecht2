<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PhoneForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PhoneForm))
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.labelIdentifier = New System.Windows.Forms.Label()
        Me.labelRegStatus = New System.Windows.Forms.Label()
        Me.labelDialingNumber = New System.Windows.Forms.Label()
        Me.labelCallStateInfo = New System.Windows.Forms.Label()
        Me.buttonHangUp = New System.Windows.Forms.Button()
        Me.buttonPickUp = New System.Windows.Forms.Button()
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.toolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusbLabel_Ozeki = New System.Windows.Forms.ToolStripStatusLabel()
        Me.button10 = New System.Windows.Forms.Button()
        Me.button11 = New System.Windows.Forms.Button()
        Me.button12 = New System.Windows.Forms.Button()
        Me.button7 = New System.Windows.Forms.Button()
        Me.button8 = New System.Windows.Forms.Button()
        Me.button9 = New System.Windows.Forms.Button()
        Me.button4 = New System.Windows.Forms.Button()
        Me.button5 = New System.Windows.Forms.Button()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.MicrophoneVolumeTrackbar = New System.Windows.Forms.TrackBar()
        Me.button6 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.Tsmi_HelpPage = New System.Windows.Forms.ToolStripMenuItem()
        Me.aboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.helpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SpeakerVolumeTrackbar = New System.Windows.Forms.TrackBar()
        Me.panel1.SuspendLayout()
        Me.statusStrip1.SuspendLayout()
        Me.panel2.SuspendLayout()
        CType(Me.MicrophoneVolumeTrackbar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuStrip1.SuspendLayout()
        CType(Me.SpeakerVolumeTrackbar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.White
        Me.panel1.Controls.Add(Me.labelIdentifier)
        Me.panel1.Controls.Add(Me.labelRegStatus)
        Me.panel1.Controls.Add(Me.labelDialingNumber)
        Me.panel1.Controls.Add(Me.labelCallStateInfo)
        Me.panel1.Location = New System.Drawing.Point(20, 17)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(203, 130)
        Me.panel1.TabIndex = 18
        '
        'labelIdentifier
        '
        Me.labelIdentifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.labelIdentifier.Location = New System.Drawing.Point(121, 6)
        Me.labelIdentifier.Name = "labelIdentifier"
        Me.labelIdentifier.Size = New System.Drawing.Size(79, 18)
        Me.labelIdentifier.TabIndex = 3
        Me.labelIdentifier.Text = "Identifier"
        Me.labelIdentifier.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'labelRegStatus
        '
        Me.labelRegStatus.AutoSize = True
        Me.labelRegStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.labelRegStatus.Location = New System.Drawing.Point(3, 6)
        Me.labelRegStatus.Name = "labelRegStatus"
        Me.labelRegStatus.Size = New System.Drawing.Size(50, 18)
        Me.labelRegStatus.TabIndex = 2
        Me.labelRegStatus.Text = "Offline"
        '
        'labelDialingNumber
        '
        Me.labelDialingNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.labelDialingNumber.Location = New System.Drawing.Point(9, 80)
        Me.labelDialingNumber.Name = "labelDialingNumber"
        Me.labelDialingNumber.Size = New System.Drawing.Size(180, 22)
        Me.labelDialingNumber.TabIndex = 1
        Me.labelDialingNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'labelCallStateInfo
        '
        Me.labelCallStateInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.labelCallStateInfo.Location = New System.Drawing.Point(5, 44)
        Me.labelCallStateInfo.Name = "labelCallStateInfo"
        Me.labelCallStateInfo.Size = New System.Drawing.Size(195, 24)
        Me.labelCallStateInfo.TabIndex = 0
        Me.labelCallStateInfo.Text = "No connection"
        Me.labelCallStateInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'buttonHangUp
        '
        Me.buttonHangUp.Location = New System.Drawing.Point(161, 167)
        Me.buttonHangUp.Name = "buttonHangUp"
        Me.buttonHangUp.Size = New System.Drawing.Size(63, 35)
        Me.buttonHangUp.TabIndex = 17
        Me.buttonHangUp.Text = "Hang Up"
        Me.buttonHangUp.UseVisualStyleBackColor = True
        '
        'buttonPickUp
        '
        Me.buttonPickUp.Location = New System.Drawing.Point(23, 167)
        Me.buttonPickUp.Name = "buttonPickUp"
        Me.buttonPickUp.Size = New System.Drawing.Size(63, 35)
        Me.buttonPickUp.TabIndex = 16
        Me.buttonPickUp.Text = "Pick Up"
        Me.buttonPickUp.UseVisualStyleBackColor = True
        '
        'statusStrip1
        '
        Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripStatusLabel2, Me.statusbLabel_Ozeki})
        Me.statusStrip1.Location = New System.Drawing.Point(0, 530)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.Size = New System.Drawing.Size(286, 22)
        Me.statusStrip1.TabIndex = 21
        Me.statusStrip1.Text = "statusStrip1"
        '
        'toolStripStatusLabel2
        '
        Me.toolStripStatusLabel2.AutoSize = False
        Me.toolStripStatusLabel2.Name = "toolStripStatusLabel2"
        Me.toolStripStatusLabel2.Size = New System.Drawing.Size(190, 17)
        Me.toolStripStatusLabel2.Spring = True
        '
        'statusbLabel_Ozeki
        '
        Me.statusbLabel_Ozeki.Name = "statusbLabel_Ozeki"
        Me.statusbLabel_Ozeki.Size = New System.Drawing.Size(81, 17)
        Me.statusbLabel_Ozeki.Text = "Ozeki product"
        '
        'button10
        '
        Me.button10.Location = New System.Drawing.Point(23, 331)
        Me.button10.Name = "button10"
        Me.button10.Size = New System.Drawing.Size(63, 35)
        Me.button10.TabIndex = 15
        Me.button10.Tag = "10"
        Me.button10.Text = "*"
        Me.button10.UseVisualStyleBackColor = True
        '
        'button11
        '
        Me.button11.Location = New System.Drawing.Point(92, 331)
        Me.button11.Name = "button11"
        Me.button11.Size = New System.Drawing.Size(63, 35)
        Me.button11.TabIndex = 14
        Me.button11.Tag = "0"
        Me.button11.Text = "0/+"
        Me.button11.UseVisualStyleBackColor = True
        '
        'button12
        '
        Me.button12.Location = New System.Drawing.Point(161, 331)
        Me.button12.Name = "button12"
        Me.button12.Size = New System.Drawing.Size(63, 35)
        Me.button12.TabIndex = 13
        Me.button12.Tag = "11"
        Me.button12.Text = "#"
        Me.button12.UseVisualStyleBackColor = True
        '
        'button7
        '
        Me.button7.Location = New System.Drawing.Point(23, 290)
        Me.button7.Name = "button7"
        Me.button7.Size = New System.Drawing.Size(63, 35)
        Me.button7.TabIndex = 12
        Me.button7.Tag = "7"
        Me.button7.Text = "7"
        Me.button7.UseVisualStyleBackColor = True
        '
        'button8
        '
        Me.button8.Location = New System.Drawing.Point(92, 290)
        Me.button8.Name = "button8"
        Me.button8.Size = New System.Drawing.Size(63, 35)
        Me.button8.TabIndex = 11
        Me.button8.Tag = "8"
        Me.button8.Text = "8"
        Me.button8.UseVisualStyleBackColor = True
        '
        'button9
        '
        Me.button9.Location = New System.Drawing.Point(161, 290)
        Me.button9.Name = "button9"
        Me.button9.Size = New System.Drawing.Size(63, 35)
        Me.button9.TabIndex = 10
        Me.button9.Tag = "9"
        Me.button9.Text = "9"
        Me.button9.UseVisualStyleBackColor = True
        '
        'button4
        '
        Me.button4.Location = New System.Drawing.Point(23, 249)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(63, 35)
        Me.button4.TabIndex = 9
        Me.button4.Tag = "4"
        Me.button4.Text = "4"
        Me.button4.UseVisualStyleBackColor = True
        '
        'button5
        '
        Me.button5.Location = New System.Drawing.Point(92, 249)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(63, 35)
        Me.button5.TabIndex = 8
        Me.button5.Tag = "5"
        Me.button5.Text = "5"
        Me.button5.UseVisualStyleBackColor = True
        '
        'panel2
        '
        Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel2.Controls.Add(Me.SpeakerVolumeTrackbar)
        Me.panel2.Controls.Add(Me.Label2)
        Me.panel2.Controls.Add(Me.Label1)
        Me.panel2.Controls.Add(Me.MicrophoneVolumeTrackbar)
        Me.panel2.Controls.Add(Me.panel1)
        Me.panel2.Controls.Add(Me.buttonHangUp)
        Me.panel2.Controls.Add(Me.buttonPickUp)
        Me.panel2.Controls.Add(Me.button10)
        Me.panel2.Controls.Add(Me.button11)
        Me.panel2.Controls.Add(Me.button12)
        Me.panel2.Controls.Add(Me.button7)
        Me.panel2.Controls.Add(Me.button8)
        Me.panel2.Controls.Add(Me.button9)
        Me.panel2.Controls.Add(Me.button4)
        Me.panel2.Controls.Add(Me.button5)
        Me.panel2.Controls.Add(Me.button6)
        Me.panel2.Controls.Add(Me.button3)
        Me.panel2.Controls.Add(Me.button2)
        Me.panel2.Controls.Add(Me.button1)
        Me.panel2.Location = New System.Drawing.Point(21, 39)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(245, 476)
        Me.panel2.TabIndex = 22
        '
        'MicrophoneVolumeTrackbar
        '
        Me.MicrophoneVolumeTrackbar.Location = New System.Drawing.Point(120, 382)
        Me.MicrophoneVolumeTrackbar.Name = "MicrophoneVolumeTrackbar"
        Me.MicrophoneVolumeTrackbar.Size = New System.Drawing.Size(104, 45)
        Me.MicrophoneVolumeTrackbar.TabIndex = 19
        '
        'button6
        '
        Me.button6.Location = New System.Drawing.Point(161, 249)
        Me.button6.Name = "button6"
        Me.button6.Size = New System.Drawing.Size(63, 35)
        Me.button6.TabIndex = 7
        Me.button6.Tag = "6"
        Me.button6.Text = "6"
        Me.button6.UseVisualStyleBackColor = True
        '
        'button3
        '
        Me.button3.Location = New System.Drawing.Point(161, 208)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(63, 35)
        Me.button3.TabIndex = 6
        Me.button3.Tag = "3"
        Me.button3.Text = "3"
        Me.button3.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(92, 208)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(63, 35)
        Me.button2.TabIndex = 5
        Me.button2.Tag = "2"
        Me.button2.Text = "2"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(23, 208)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(63, 35)
        Me.button1.TabIndex = 4
        Me.button1.Tag = "1"
        Me.button1.Text = "1"
        Me.button1.UseVisualStyleBackColor = True
        '
        'Tsmi_HelpPage
        '
        Me.Tsmi_HelpPage.Name = "Tsmi_HelpPage"
        Me.Tsmi_HelpPage.Size = New System.Drawing.Size(250, 24)
        Me.Tsmi_HelpPage.Text = "Open online documentation"
        '
        'aboutToolStripMenuItem
        '
        Me.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
        Me.aboutToolStripMenuItem.Size = New System.Drawing.Size(250, 24)
        Me.aboutToolStripMenuItem.Text = "About"
        '
        'helpToolStripMenuItem
        '
        Me.helpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tsmi_HelpPage, Me.aboutToolStripMenuItem})
        Me.helpToolStripMenuItem.Name = "helpToolStripMenuItem"
        Me.helpToolStripMenuItem.Size = New System.Drawing.Size(49, 23)
        Me.helpToolStripMenuItem.Text = "Help"
        '
        'menuStrip1
        '
        Me.menuStrip1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem, Me.helpToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(286, 27)
        Me.menuStrip1.TabIndex = 20
        Me.menuStrip1.Text = "menuStrip1"
        '
        'fileToolStripMenuItem
        '
        Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.exitToolStripMenuItem})
        Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
        Me.fileToolStripMenuItem.Size = New System.Drawing.Size(41, 23)
        Me.fileToolStripMenuItem.Text = "File"
        '
        'exitToolStripMenuItem
        '
        Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
        Me.exitToolStripMenuItem.Size = New System.Drawing.Size(99, 24)
        Me.exitToolStripMenuItem.Text = "Exit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 391)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Microphone Volume:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 426)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Speaker Volume:"
        '
        'SpeakerVolumeTrackbar
        '
        Me.SpeakerVolumeTrackbar.Location = New System.Drawing.Point(120, 426)
        Me.SpeakerVolumeTrackbar.Name = "SpeakerVolumeTrackbar"
        Me.SpeakerVolumeTrackbar.Size = New System.Drawing.Size(104, 45)
        Me.SpeakerVolumeTrackbar.TabIndex = 22
        '
        'PhoneForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 552)
        Me.Controls.Add(Me.statusStrip1)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.menuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PhoneForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ozeki VB.Net Softphone Sample"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.statusStrip1.ResumeLayout(False)
        Me.statusStrip1.PerformLayout()
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        CType(Me.MicrophoneVolumeTrackbar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        CType(Me.SpeakerVolumeTrackbar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents labelIdentifier As System.Windows.Forms.Label
    Private WithEvents labelRegStatus As System.Windows.Forms.Label
    Private WithEvents labelDialingNumber As System.Windows.Forms.Label
    Private WithEvents labelCallStateInfo As System.Windows.Forms.Label
    Private WithEvents buttonHangUp As System.Windows.Forms.Button
    Private WithEvents buttonPickUp As System.Windows.Forms.Button
    Private WithEvents statusStrip1 As System.Windows.Forms.StatusStrip
    Private WithEvents toolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents statusbLabel_Ozeki As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents button10 As System.Windows.Forms.Button
    Private WithEvents button11 As System.Windows.Forms.Button
    Private WithEvents button12 As System.Windows.Forms.Button
    Private WithEvents button7 As System.Windows.Forms.Button
    Private WithEvents button8 As System.Windows.Forms.Button
    Private WithEvents button9 As System.Windows.Forms.Button
    Private WithEvents button4 As System.Windows.Forms.Button
    Private WithEvents button5 As System.Windows.Forms.Button
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents button6 As System.Windows.Forms.Button
    Private WithEvents button3 As System.Windows.Forms.Button
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents Tsmi_HelpPage As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents aboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents helpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents menuStrip1 As System.Windows.Forms.MenuStrip
    Private WithEvents fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MicrophoneVolumeTrackbar As System.Windows.Forms.TrackBar
    Friend WithEvents SpeakerVolumeTrackbar As System.Windows.Forms.TrackBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
