<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NeuerKunde
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Speichern = New System.Windows.Forms.Button()
        Me.lblVorname = New System.Windows.Forms.Label()
        Me.lblNachname = New System.Windows.Forms.Label()
        Me.lblStraße = New System.Windows.Forms.Label()
        Me.lblPLZ = New System.Windows.Forms.Label()
        Me.lblOrt = New System.Windows.Forms.Label()
        Me.lblTelefon = New System.Windows.Forms.Label()
        Me.lblTerminbis = New System.Windows.Forms.Label()
        Me.btnTerminZettel = New System.Windows.Forms.Button()
        Me.dtpTerminBis = New System.Windows.Forms.DateTimePicker()
        Me.lblTerminvon = New System.Windows.Forms.Label()
        Me.dtpTerminVon = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rtbNotizen = New System.Windows.Forms.RichTextBox()
        Me.tbVorname = New System.Windows.Forms.TextBox()
        Me.tbNachname = New System.Windows.Forms.TextBox()
        Me.tbStraße = New System.Windows.Forms.TextBox()
        Me.tbPLZ = New System.Windows.Forms.TextBox()
        Me.tbOrt = New System.Windows.Forms.TextBox()
        Me.tbTelefon = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Speichern
        '
        Me.Speichern.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Speichern.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Speichern.Location = New System.Drawing.Point(798, 493)
        Me.Speichern.Name = "Speichern"
        Me.Speichern.Size = New System.Drawing.Size(200, 39)
        Me.Speichern.TabIndex = 2
        Me.Speichern.Text = "Speichern"
        Me.Speichern.UseVisualStyleBackColor = True
        '
        'lblVorname
        '
        Me.lblVorname.AutoSize = True
        Me.lblVorname.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVorname.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVorname.Location = New System.Drawing.Point(12, 9)
        Me.lblVorname.Name = "lblVorname"
        Me.lblVorname.Size = New System.Drawing.Size(109, 26)
        Me.lblVorname.TabIndex = 9
        Me.lblVorname.Text = "Vorname"
        '
        'lblNachname
        '
        Me.lblNachname.AutoSize = True
        Me.lblNachname.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNachname.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNachname.Location = New System.Drawing.Point(12, 46)
        Me.lblNachname.Name = "lblNachname"
        Me.lblNachname.Size = New System.Drawing.Size(127, 26)
        Me.lblNachname.TabIndex = 10
        Me.lblNachname.Text = "Nachname"
        '
        'lblStraße
        '
        Me.lblStraße.AutoSize = True
        Me.lblStraße.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStraße.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStraße.Location = New System.Drawing.Point(12, 84)
        Me.lblStraße.Name = "lblStraße"
        Me.lblStraße.Size = New System.Drawing.Size(85, 26)
        Me.lblStraße.TabIndex = 11
        Me.lblStraße.Text = "Straße"
        '
        'lblPLZ
        '
        Me.lblPLZ.AutoSize = True
        Me.lblPLZ.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPLZ.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPLZ.Location = New System.Drawing.Point(12, 121)
        Me.lblPLZ.Name = "lblPLZ"
        Me.lblPLZ.Size = New System.Drawing.Size(52, 26)
        Me.lblPLZ.TabIndex = 12
        Me.lblPLZ.Text = "PLZ"
        '
        'lblOrt
        '
        Me.lblOrt.AutoSize = True
        Me.lblOrt.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrt.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblOrt.Location = New System.Drawing.Point(12, 158)
        Me.lblOrt.Name = "lblOrt"
        Me.lblOrt.Size = New System.Drawing.Size(47, 26)
        Me.lblOrt.TabIndex = 13
        Me.lblOrt.Text = "Ort"
        '
        'lblTelefon
        '
        Me.lblTelefon.AutoSize = True
        Me.lblTelefon.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefon.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTelefon.Location = New System.Drawing.Point(12, 195)
        Me.lblTelefon.Name = "lblTelefon"
        Me.lblTelefon.Size = New System.Drawing.Size(91, 26)
        Me.lblTelefon.TabIndex = 14
        Me.lblTelefon.Text = "Telefon"
        '
        'lblTerminbis
        '
        Me.lblTerminbis.AutoSize = True
        Me.lblTerminbis.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTerminbis.Location = New System.Drawing.Point(444, 448)
        Me.lblTerminbis.Name = "lblTerminbis"
        Me.lblTerminbis.Size = New System.Drawing.Size(85, 20)
        Me.lblTerminbis.TabIndex = 20
        Me.lblTerminbis.Text = "Termin bis:"
        '
        'btnTerminZettel
        '
        Me.btnTerminZettel.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.btnTerminZettel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnTerminZettel.Location = New System.Drawing.Point(17, 493)
        Me.btnTerminZettel.Name = "btnTerminZettel"
        Me.btnTerminZettel.Size = New System.Drawing.Size(595, 39)
        Me.btnTerminZettel.TabIndex = 22
        Me.btnTerminZettel.Text = "Termin Zettel"
        Me.btnTerminZettel.UseVisualStyleBackColor = True
        '
        'dtpTerminBis
        '
        Me.dtpTerminBis.CalendarFont = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTerminBis.CustomFormat = "DD.MM.YYYY HH:MM:SS"
        Me.dtpTerminBis.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTerminBis.Location = New System.Drawing.Point(535, 436)
        Me.dtpTerminBis.MaximumSize = New System.Drawing.Size(200, 34)
        Me.dtpTerminBis.MinimumSize = New System.Drawing.Size(270, 34)
        Me.dtpTerminBis.Name = "dtpTerminBis"
        Me.dtpTerminBis.Size = New System.Drawing.Size(270, 34)
        Me.dtpTerminBis.TabIndex = 21
        Me.dtpTerminBis.Value = New Date(2016, 6, 30, 13, 0, 0, 0)
        '
        'lblTerminvon
        '
        Me.lblTerminvon.AutoSize = True
        Me.lblTerminvon.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTerminvon.Location = New System.Drawing.Point(12, 448)
        Me.lblTerminvon.Name = "lblTerminvon"
        Me.lblTerminvon.Size = New System.Drawing.Size(90, 20)
        Me.lblTerminvon.TabIndex = 19
        Me.lblTerminvon.Text = "Termin von:"
        '
        'dtpTerminVon
        '
        Me.dtpTerminVon.CustomFormat = "DD.MM.YYYY HH:MM:SS"
        Me.dtpTerminVon.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.dtpTerminVon.Location = New System.Drawing.Point(108, 436)
        Me.dtpTerminVon.MaximumSize = New System.Drawing.Size(200, 34)
        Me.dtpTerminVon.MinimumSize = New System.Drawing.Size(270, 34)
        Me.dtpTerminVon.Name = "dtpTerminVon"
        Me.dtpTerminVon.Size = New System.Drawing.Size(270, 34)
        Me.dtpTerminVon.TabIndex = 18
        Me.dtpTerminVon.Value = New Date(2016, 6, 30, 13, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(13, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 26)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Notizen zu Kunde :"
        '
        'rtbNotizen
        '
        Me.rtbNotizen.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.rtbNotizen.Location = New System.Drawing.Point(12, 263)
        Me.rtbNotizen.MinimumSize = New System.Drawing.Size(511, 170)
        Me.rtbNotizen.Name = "rtbNotizen"
        Me.rtbNotizen.Size = New System.Drawing.Size(986, 170)
        Me.rtbNotizen.TabIndex = 23
        Me.rtbNotizen.TabStop = False
        Me.rtbNotizen.Text = ""
        '
        'tbVorname
        '
        Me.tbVorname.Location = New System.Drawing.Point(158, 8)
        Me.tbVorname.Name = "tbVorname"
        Me.tbVorname.Size = New System.Drawing.Size(840, 26)
        Me.tbVorname.TabIndex = 25
        '
        'tbNachname
        '
        Me.tbNachname.Location = New System.Drawing.Point(158, 46)
        Me.tbNachname.Name = "tbNachname"
        Me.tbNachname.Size = New System.Drawing.Size(840, 26)
        Me.tbNachname.TabIndex = 26
        '
        'tbStraße
        '
        Me.tbStraße.Location = New System.Drawing.Point(158, 84)
        Me.tbStraße.Name = "tbStraße"
        Me.tbStraße.Size = New System.Drawing.Size(840, 26)
        Me.tbStraße.TabIndex = 27
        '
        'tbPLZ
        '
        Me.tbPLZ.Location = New System.Drawing.Point(158, 121)
        Me.tbPLZ.Name = "tbPLZ"
        Me.tbPLZ.Size = New System.Drawing.Size(840, 26)
        Me.tbPLZ.TabIndex = 28
        '
        'tbOrt
        '
        Me.tbOrt.Location = New System.Drawing.Point(158, 158)
        Me.tbOrt.Name = "tbOrt"
        Me.tbOrt.Size = New System.Drawing.Size(840, 26)
        Me.tbOrt.TabIndex = 29
        '
        'tbTelefon
        '
        Me.tbTelefon.Location = New System.Drawing.Point(158, 195)
        Me.tbTelefon.Name = "tbTelefon"
        Me.tbTelefon.Size = New System.Drawing.Size(840, 26)
        Me.tbTelefon.TabIndex = 30
        '
        'NeuerKunde
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 544)
        Me.Controls.Add(Me.tbTelefon)
        Me.Controls.Add(Me.tbOrt)
        Me.Controls.Add(Me.tbPLZ)
        Me.Controls.Add(Me.tbStraße)
        Me.Controls.Add(Me.tbNachname)
        Me.Controls.Add(Me.tbVorname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rtbNotizen)
        Me.Controls.Add(Me.lblTerminbis)
        Me.Controls.Add(Me.btnTerminZettel)
        Me.Controls.Add(Me.dtpTerminBis)
        Me.Controls.Add(Me.lblTerminvon)
        Me.Controls.Add(Me.dtpTerminVon)
        Me.Controls.Add(Me.lblTelefon)
        Me.Controls.Add(Me.lblOrt)
        Me.Controls.Add(Me.lblPLZ)
        Me.Controls.Add(Me.lblStraße)
        Me.Controls.Add(Me.lblNachname)
        Me.Controls.Add(Me.lblVorname)
        Me.Controls.Add(Me.Speichern)
        Me.MaximumSize = New System.Drawing.Size(1032, 600)
        Me.MinimumSize = New System.Drawing.Size(1032, 600)
        Me.Name = "NeuerKunde"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Neuer Kunde"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Speichern As Button
    Friend WithEvents lblVorname As Label
    Friend WithEvents lblNachname As Label
    Friend WithEvents lblStraße As Label
    Friend WithEvents lblPLZ As Label
    Friend WithEvents lblOrt As Label
    Friend WithEvents lblTelefon As Label
    Friend WithEvents lblTerminbis As Label
    Friend WithEvents btnTerminZettel As Button
    Friend WithEvents dtpTerminBis As DateTimePicker
    Friend WithEvents lblTerminvon As Label
    Friend WithEvents dtpTerminVon As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents rtbNotizen As RichTextBox
    Friend WithEvents tbVorname As TextBox
    Friend WithEvents tbNachname As TextBox
    Friend WithEvents tbStraße As TextBox
    Friend WithEvents tbPLZ As TextBox
    Friend WithEvents tbOrt As TextBox
    Friend WithEvents tbTelefon As TextBox
End Class
