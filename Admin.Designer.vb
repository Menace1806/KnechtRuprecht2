<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnVerteilen = New System.Windows.Forms.Button()
        Me.btnCallCenter = New System.Windows.Forms.Button()
        Me.lblOrt = New System.Windows.Forms.Label()
        Me.lblText4 = New System.Windows.Forms.Label()
        Me.lblText3 = New System.Windows.Forms.Label()
        Me.lblText2 = New System.Windows.Forms.Label()
        Me.lblText1 = New System.Windows.Forms.Label()
        Me.lblWelcherPool = New System.Windows.Forms.Label()
        Me.lblRest = New System.Windows.Forms.Label()
        Me.lblImPool = New System.Windows.Forms.Label()
        Me.lblInsgesamt = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbPoolIndex = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnVerteilen
        '
        Me.btnVerteilen.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerteilen.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnVerteilen.Location = New System.Drawing.Point(12, 493)
        Me.btnVerteilen.Name = "btnVerteilen"
        Me.btnVerteilen.Size = New System.Drawing.Size(200, 39)
        Me.btnVerteilen.TabIndex = 1
        Me.btnVerteilen.Text = "Verteilen"
        Me.btnVerteilen.UseVisualStyleBackColor = True
        '
        'btnCallCenter
        '
        Me.btnCallCenter.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCallCenter.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCallCenter.Location = New System.Drawing.Point(798, 493)
        Me.btnCallCenter.Name = "btnCallCenter"
        Me.btnCallCenter.Size = New System.Drawing.Size(200, 39)
        Me.btnCallCenter.TabIndex = 2
        Me.btnCallCenter.Text = "CallCenter"
        Me.btnCallCenter.UseVisualStyleBackColor = True
        '
        'lblOrt
        '
        Me.lblOrt.AutoSize = True
        Me.lblOrt.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrt.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblOrt.Location = New System.Drawing.Point(20, 13)
        Me.lblOrt.Name = "lblOrt"
        Me.lblOrt.Size = New System.Drawing.Size(277, 26)
        Me.lblOrt.TabIndex = 19
        Me.lblOrt.Text = "Adressen Informationen"
        '
        'lblText4
        '
        Me.lblText4.AutoSize = True
        Me.lblText4.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblText4.Location = New System.Drawing.Point(20, 183)
        Me.lblText4.Name = "lblText4"
        Me.lblText4.Size = New System.Drawing.Size(227, 26)
        Me.lblText4.TabIndex = 18
        Me.lblText4.Text = "Zugewiesener Pool:"
        '
        'lblText3
        '
        Me.lblText3.AutoSize = True
        Me.lblText3.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblText3.Location = New System.Drawing.Point(20, 141)
        Me.lblText3.Name = "lblText3"
        Me.lblText3.Size = New System.Drawing.Size(273, 26)
        Me.lblText3.TabIndex = 17
        Me.lblText3.Text = "Verbleibende Adressen:"
        '
        'lblText2
        '
        Me.lblText2.AutoSize = True
        Me.lblText2.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblText2.Location = New System.Drawing.Point(20, 99)
        Me.lblText2.Name = "lblText2"
        Me.lblText2.Size = New System.Drawing.Size(209, 26)
        Me.lblText2.TabIndex = 16
        Me.lblText2.Text = "Adressen im Pool:"
        '
        'lblText1
        '
        Me.lblText1.AutoSize = True
        Me.lblText1.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblText1.Location = New System.Drawing.Point(20, 58)
        Me.lblText1.Name = "lblText1"
        Me.lblText1.Size = New System.Drawing.Size(246, 26)
        Me.lblText1.TabIndex = 15
        Me.lblText1.Text = "Adressen Insgesamt:"
        '
        'lblWelcherPool
        '
        Me.lblWelcherPool.AutoSize = True
        Me.lblWelcherPool.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcherPool.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblWelcherPool.Location = New System.Drawing.Point(291, 183)
        Me.lblWelcherPool.Name = "lblWelcherPool"
        Me.lblWelcherPool.Size = New System.Drawing.Size(169, 26)
        Me.lblWelcherPool.TabIndex = 23
        Me.lblWelcherPool.Text = "lblWelcherPool"
        '
        'lblRest
        '
        Me.lblRest.AutoSize = True
        Me.lblRest.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRest.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRest.Location = New System.Drawing.Point(291, 141)
        Me.lblRest.Name = "lblRest"
        Me.lblRest.Size = New System.Drawing.Size(85, 26)
        Me.lblRest.TabIndex = 22
        Me.lblRest.Text = "lblRest"
        '
        'lblImPool
        '
        Me.lblImPool.AutoSize = True
        Me.lblImPool.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImPool.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblImPool.Location = New System.Drawing.Point(291, 99)
        Me.lblImPool.Name = "lblImPool"
        Me.lblImPool.Size = New System.Drawing.Size(113, 26)
        Me.lblImPool.TabIndex = 21
        Me.lblImPool.Text = "lblImPool"
        '
        'lblInsgesamt
        '
        Me.lblInsgesamt.AutoSize = True
        Me.lblInsgesamt.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsgesamt.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblInsgesamt.Location = New System.Drawing.Point(291, 58)
        Me.lblInsgesamt.Name = "lblInsgesamt"
        Me.lblInsgesamt.Size = New System.Drawing.Size(154, 26)
        Me.lblInsgesamt.TabIndex = 20
        Me.lblInsgesamt.Text = "lblInsgesamt"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.lblWelcherPool)
        Me.GroupBox1.Controls.Add(Me.lblRest)
        Me.GroupBox1.Controls.Add(Me.lblImPool)
        Me.GroupBox1.Controls.Add(Me.lblInsgesamt)
        Me.GroupBox1.Controls.Add(Me.lblOrt)
        Me.GroupBox1.Controls.Add(Me.lblText4)
        Me.GroupBox1.Controls.Add(Me.lblText3)
        Me.GroupBox1.Controls.Add(Me.lblText2)
        Me.GroupBox1.Controls.Add(Me.lblText1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(496, 232)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Location = New System.Drawing.Point(490, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(496, 232)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(291, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 26)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "lblWelcherPool"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(291, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 26)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "lblRest"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(291, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 26)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "lblImPool"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(291, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(154, 26)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "lblInsgesamt"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(20, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(277, 26)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Adressen Informationen"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(20, 183)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(227, 26)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Zugewiesener Pool:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(20, 141)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(273, 26)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Verbleibende Adressen:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(20, 99)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(209, 26)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Adressen im Pool:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(20, 58)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(246, 26)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Adressen Insgesamt:"
        '
        'tbPoolIndex
        '
        Me.tbPoolIndex.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPoolIndex.Location = New System.Drawing.Point(12, 453)
        Me.tbPoolIndex.Name = "tbPoolIndex"
        Me.tbPoolIndex.Size = New System.Drawing.Size(200, 34)
        Me.tbPoolIndex.TabIndex = 25
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 544)
        Me.Controls.Add(Me.tbPoolIndex)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCallCenter)
        Me.Controls.Add(Me.btnVerteilen)
        Me.MaximumSize = New System.Drawing.Size(1032, 600)
        Me.MinimumSize = New System.Drawing.Size(1032, 600)
        Me.Name = "Admin"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administration Call Center"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnVerteilen As Button
    Friend WithEvents btnCallCenter As Button
    Friend WithEvents lblOrt As Label
    Friend WithEvents lblText4 As Label
    Friend WithEvents lblText3 As Label
    Friend WithEvents lblText2 As Label
    Friend WithEvents lblText1 As Label
    Friend WithEvents lblWelcherPool As Label
    Friend WithEvents lblRest As Label
    Friend WithEvents lblImPool As Label
    Friend WithEvents lblInsgesamt As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents tbPoolIndex As TextBox
End Class
