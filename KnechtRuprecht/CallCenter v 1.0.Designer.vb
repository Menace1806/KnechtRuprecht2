<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CallCenter
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CallCenter))
        Me.Anrufen = New System.Windows.Forms.Button()
        Me.Termin = New System.Windows.Forms.Button()
        Me.NichtErreicht = New System.Windows.Forms.Button()
        Me.ToteNummer = New System.Windows.Forms.Button()
        Me.lblKunde = New System.Windows.Forms.Label()
        Me.keininteresse = New System.Windows.Forms.Button()
        Me.txtKunde = New System.Windows.Forms.TextBox()
        Me.rtbNotizen = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NaechsterKunde = New System.Windows.Forms.Button()
        Me.dtpTerminVon = New System.Windows.Forms.DateTimePicker()
        Me.lblTerminvon = New System.Windows.Forms.Label()
        Me.lblTerminbis = New System.Windows.Forms.Label()
        Me.dtpTerminBis = New System.Windows.Forms.DateTimePicker()
        Me.btnTerminZettel = New System.Windows.Forms.Button()
        Me.PrintTerminZettel = New System.Drawing.Printing.PrintDocument()
        Me.adressen_basisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnFlyer = New System.Windows.Forms.Button()
        Me.btnNeuerKunde = New System.Windows.Forms.Button()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.btnSuche = New System.Windows.Forms.Button()
        Me.btnKdSuche = New System.Windows.Forms.Button()
        Me.SP_TerminzettelGetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.mankegmbhDataSet = New KnechtRuprecht.mankegmbhDataSet()
        Me.SP_TerminzettelGetTableAdapter = New KnechtRuprecht.mankegmbhDataSetTableAdapters.SP_TerminzettelGetTableAdapter()
        Me.cbGoogle = New System.Windows.Forms.CheckBox()
        Me.lblLastCall = New System.Windows.Forms.Label()
        Me.lblLetzterAnruf = New System.Windows.Forms.Label()
        Me.btnWiedervorlage = New System.Windows.Forms.Button()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.SpeakerVolumeTrackbar = New System.Windows.Forms.TrackBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MicrophoneVolumeTrackbar = New System.Windows.Forms.TrackBar()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.labelIdentifier = New System.Windows.Forms.Label()
        Me.labelRegStatus = New System.Windows.Forms.Label()
        Me.labelDialingNumber = New System.Windows.Forms.Label()
        Me.labelCallStateInfo = New System.Windows.Forms.Label()
        Me.buttonHangUp = New System.Windows.Forms.Button()
        Me.buttonPickUp = New System.Windows.Forms.Button()
        Me.button10 = New System.Windows.Forms.Button()
        Me.button11 = New System.Windows.Forms.Button()
        Me.button12 = New System.Windows.Forms.Button()
        Me.button7 = New System.Windows.Forms.Button()
        Me.button8 = New System.Windows.Forms.Button()
        Me.button9 = New System.Windows.Forms.Button()
        Me.button4 = New System.Windows.Forms.Button()
        Me.button5 = New System.Windows.Forms.Button()
        Me.button6 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        CType(Me.adressen_basisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_TerminzettelGetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mankegmbhDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        CType(Me.SpeakerVolumeTrackbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MicrophoneVolumeTrackbar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Anrufen
        '
        resources.ApplyResources(Me.Anrufen, "Anrufen")
        Me.Anrufen.Name = "Anrufen"
        Me.Anrufen.UseVisualStyleBackColor = True
        '
        'Termin
        '
        resources.ApplyResources(Me.Termin, "Termin")
        Me.Termin.Name = "Termin"
        Me.Termin.UseVisualStyleBackColor = True
        '
        'NichtErreicht
        '
        resources.ApplyResources(Me.NichtErreicht, "NichtErreicht")
        Me.NichtErreicht.Name = "NichtErreicht"
        Me.NichtErreicht.UseVisualStyleBackColor = True
        '
        'ToteNummer
        '
        resources.ApplyResources(Me.ToteNummer, "ToteNummer")
        Me.ToteNummer.Name = "ToteNummer"
        Me.ToteNummer.UseVisualStyleBackColor = True
        '
        'lblKunde
        '
        resources.ApplyResources(Me.lblKunde, "lblKunde")
        Me.lblKunde.Name = "lblKunde"
        '
        'keininteresse
        '
        resources.ApplyResources(Me.keininteresse, "keininteresse")
        Me.keininteresse.Name = "keininteresse"
        Me.keininteresse.UseVisualStyleBackColor = True
        '
        'txtKunde
        '
        Me.txtKunde.BackColor = System.Drawing.SystemColors.Control
        resources.ApplyResources(Me.txtKunde, "txtKunde")
        Me.txtKunde.Name = "txtKunde"
        Me.txtKunde.ReadOnly = True
        Me.txtKunde.TabStop = False
        '
        'rtbNotizen
        '
        resources.ApplyResources(Me.rtbNotizen, "rtbNotizen")
        Me.rtbNotizen.Name = "rtbNotizen"
        Me.rtbNotizen.TabStop = False
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'NaechsterKunde
        '
        resources.ApplyResources(Me.NaechsterKunde, "NaechsterKunde")
        Me.NaechsterKunde.Name = "NaechsterKunde"
        Me.NaechsterKunde.UseVisualStyleBackColor = True
        '
        'dtpTerminVon
        '
        resources.ApplyResources(Me.dtpTerminVon, "dtpTerminVon")
        Me.dtpTerminVon.Name = "dtpTerminVon"
        Me.dtpTerminVon.Value = New Date(2016, 6, 30, 13, 0, 0, 0)
        '
        'lblTerminvon
        '
        resources.ApplyResources(Me.lblTerminvon, "lblTerminvon")
        Me.lblTerminvon.Name = "lblTerminvon"
        '
        'lblTerminbis
        '
        resources.ApplyResources(Me.lblTerminbis, "lblTerminbis")
        Me.lblTerminbis.Name = "lblTerminbis"
        '
        'dtpTerminBis
        '
        resources.ApplyResources(Me.dtpTerminBis, "dtpTerminBis")
        Me.dtpTerminBis.Name = "dtpTerminBis"
        Me.dtpTerminBis.Value = New Date(2016, 6, 30, 13, 0, 0, 0)
        '
        'btnTerminZettel
        '
        resources.ApplyResources(Me.btnTerminZettel, "btnTerminZettel")
        Me.btnTerminZettel.Name = "btnTerminZettel"
        Me.btnTerminZettel.UseVisualStyleBackColor = True
        '
        'PrintTerminZettel
        '
        Me.PrintTerminZettel.DocumentName = "TerminZettel"
        '
        'adressen_basisBindingSource
        '
        Me.adressen_basisBindingSource.DataMember = "adressen_basis"
        '
        'btnFlyer
        '
        resources.ApplyResources(Me.btnFlyer, "btnFlyer")
        Me.btnFlyer.Name = "btnFlyer"
        Me.btnFlyer.UseVisualStyleBackColor = True
        '
        'btnNeuerKunde
        '
        resources.ApplyResources(Me.btnNeuerKunde, "btnNeuerKunde")
        Me.btnNeuerKunde.Name = "btnNeuerKunde"
        Me.btnNeuerKunde.UseVisualStyleBackColor = True
        '
        'btnAdmin
        '
        resources.ApplyResources(Me.btnAdmin, "btnAdmin")
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.UseVisualStyleBackColor = True
        '
        'btnSuche
        '
        resources.ApplyResources(Me.btnSuche, "btnSuche")
        Me.btnSuche.Name = "btnSuche"
        Me.btnSuche.UseVisualStyleBackColor = True
        '
        'btnKdSuche
        '
        resources.ApplyResources(Me.btnKdSuche, "btnKdSuche")
        Me.btnKdSuche.Name = "btnKdSuche"
        Me.btnKdSuche.UseVisualStyleBackColor = True
        '
        'SP_TerminzettelGetBindingSource
        '
        Me.SP_TerminzettelGetBindingSource.DataMember = "SP_TerminzettelGet"
        Me.SP_TerminzettelGetBindingSource.DataSource = Me.mankegmbhDataSet
        '
        'mankegmbhDataSet
        '
        Me.mankegmbhDataSet.DataSetName = "mankegmbhDataSet"
        Me.mankegmbhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP_TerminzettelGetTableAdapter
        '
        Me.SP_TerminzettelGetTableAdapter.ClearBeforeFill = True
        '
        'cbGoogle
        '
        resources.ApplyResources(Me.cbGoogle, "cbGoogle")
        Me.cbGoogle.Name = "cbGoogle"
        Me.cbGoogle.UseVisualStyleBackColor = True
        '
        'lblLastCall
        '
        resources.ApplyResources(Me.lblLastCall, "lblLastCall")
        Me.lblLastCall.Name = "lblLastCall"
        '
        'lblLetzterAnruf
        '
        resources.ApplyResources(Me.lblLetzterAnruf, "lblLetzterAnruf")
        Me.lblLetzterAnruf.Name = "lblLetzterAnruf"
        '
        'btnWiedervorlage
        '
        resources.ApplyResources(Me.btnWiedervorlage, "btnWiedervorlage")
        Me.btnWiedervorlage.Name = "btnWiedervorlage"
        Me.btnWiedervorlage.UseVisualStyleBackColor = True
        '
        'panel2
        '
        Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel2.Controls.Add(Me.Button13)
        Me.panel2.Controls.Add(Me.SpeakerVolumeTrackbar)
        Me.panel2.Controls.Add(Me.Label2)
        Me.panel2.Controls.Add(Me.Label3)
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
        resources.ApplyResources(Me.panel2, "panel2")
        Me.panel2.Name = "panel2"
        '
        'SpeakerVolumeTrackbar
        '
        resources.ApplyResources(Me.SpeakerVolumeTrackbar, "SpeakerVolumeTrackbar")
        Me.SpeakerVolumeTrackbar.Name = "SpeakerVolumeTrackbar"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'MicrophoneVolumeTrackbar
        '
        resources.ApplyResources(Me.MicrophoneVolumeTrackbar, "MicrophoneVolumeTrackbar")
        Me.MicrophoneVolumeTrackbar.Name = "MicrophoneVolumeTrackbar"
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.White
        Me.panel1.Controls.Add(Me.labelIdentifier)
        Me.panel1.Controls.Add(Me.labelRegStatus)
        Me.panel1.Controls.Add(Me.labelDialingNumber)
        Me.panel1.Controls.Add(Me.labelCallStateInfo)
        resources.ApplyResources(Me.panel1, "panel1")
        Me.panel1.Name = "panel1"
        '
        'labelIdentifier
        '
        resources.ApplyResources(Me.labelIdentifier, "labelIdentifier")
        Me.labelIdentifier.Name = "labelIdentifier"
        '
        'labelRegStatus
        '
        resources.ApplyResources(Me.labelRegStatus, "labelRegStatus")
        Me.labelRegStatus.Name = "labelRegStatus"
        '
        'labelDialingNumber
        '
        resources.ApplyResources(Me.labelDialingNumber, "labelDialingNumber")
        Me.labelDialingNumber.Name = "labelDialingNumber"
        '
        'labelCallStateInfo
        '
        resources.ApplyResources(Me.labelCallStateInfo, "labelCallStateInfo")
        Me.labelCallStateInfo.Name = "labelCallStateInfo"
        '
        'buttonHangUp
        '
        resources.ApplyResources(Me.buttonHangUp, "buttonHangUp")
        Me.buttonHangUp.Name = "buttonHangUp"
        Me.buttonHangUp.UseVisualStyleBackColor = True
        '
        'buttonPickUp
        '
        resources.ApplyResources(Me.buttonPickUp, "buttonPickUp")
        Me.buttonPickUp.Name = "buttonPickUp"
        Me.buttonPickUp.UseVisualStyleBackColor = True
        '
        'button10
        '
        resources.ApplyResources(Me.button10, "button10")
        Me.button10.Name = "button10"
        Me.button10.Tag = "10"
        Me.button10.UseVisualStyleBackColor = True
        '
        'button11
        '
        resources.ApplyResources(Me.button11, "button11")
        Me.button11.Name = "button11"
        Me.button11.Tag = "0"
        Me.button11.UseVisualStyleBackColor = True
        '
        'button12
        '
        resources.ApplyResources(Me.button12, "button12")
        Me.button12.Name = "button12"
        Me.button12.Tag = "11"
        Me.button12.UseVisualStyleBackColor = True
        '
        'button7
        '
        resources.ApplyResources(Me.button7, "button7")
        Me.button7.Name = "button7"
        Me.button7.Tag = "7"
        Me.button7.UseVisualStyleBackColor = True
        '
        'button8
        '
        resources.ApplyResources(Me.button8, "button8")
        Me.button8.Name = "button8"
        Me.button8.Tag = "8"
        Me.button8.UseVisualStyleBackColor = True
        '
        'button9
        '
        resources.ApplyResources(Me.button9, "button9")
        Me.button9.Name = "button9"
        Me.button9.Tag = "9"
        Me.button9.UseVisualStyleBackColor = True
        '
        'button4
        '
        resources.ApplyResources(Me.button4, "button4")
        Me.button4.Name = "button4"
        Me.button4.Tag = "4"
        Me.button4.UseVisualStyleBackColor = True
        '
        'button5
        '
        resources.ApplyResources(Me.button5, "button5")
        Me.button5.Name = "button5"
        Me.button5.Tag = "5"
        Me.button5.UseVisualStyleBackColor = True
        '
        'button6
        '
        resources.ApplyResources(Me.button6, "button6")
        Me.button6.Name = "button6"
        Me.button6.Tag = "6"
        Me.button6.UseVisualStyleBackColor = True
        '
        'button3
        '
        resources.ApplyResources(Me.button3, "button3")
        Me.button3.Name = "button3"
        Me.button3.Tag = "3"
        Me.button3.UseVisualStyleBackColor = True
        '
        'button2
        '
        resources.ApplyResources(Me.button2, "button2")
        Me.button2.Name = "button2"
        Me.button2.Tag = "2"
        Me.button2.UseVisualStyleBackColor = True
        '
        'Button13
        '
        resources.ApplyResources(Me.Button13, "Button13")
        Me.Button13.Name = "Button13"
        Me.Button13.Tag = "2"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'CallCenter
        '
        resources.ApplyResources(Me, "$this")
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.btnWiedervorlage)
        Me.Controls.Add(Me.lblLetzterAnruf)
        Me.Controls.Add(Me.lblLastCall)
        Me.Controls.Add(Me.cbGoogle)
        Me.Controls.Add(Me.btnKdSuche)
        Me.Controls.Add(Me.btnSuche)
        Me.Controls.Add(Me.btnAdmin)
        Me.Controls.Add(Me.btnNeuerKunde)
        Me.Controls.Add(Me.lblTerminbis)
        Me.Controls.Add(Me.btnFlyer)
        Me.Controls.Add(Me.btnTerminZettel)
        Me.Controls.Add(Me.dtpTerminBis)
        Me.Controls.Add(Me.lblTerminvon)
        Me.Controls.Add(Me.dtpTerminVon)
        Me.Controls.Add(Me.NaechsterKunde)
        Me.Controls.Add(Me.keininteresse)
        Me.Controls.Add(Me.NichtErreicht)
        Me.Controls.Add(Me.ToteNummer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rtbNotizen)
        Me.Controls.Add(Me.txtKunde)
        Me.Controls.Add(Me.Termin)
        Me.Controls.Add(Me.lblKunde)
        Me.Controls.Add(Me.Anrufen)
        Me.Name = "CallCenter"
        CType(Me.adressen_basisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_TerminzettelGetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mankegmbhDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        CType(Me.SpeakerVolumeTrackbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MicrophoneVolumeTrackbar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CchhhDataSetBindingSource As BindingSource
    Friend WithEvents AdressenBindingSource As BindingSource
    Friend WithEvents AdressNrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnredeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VornameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NachnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StrasseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HausnummerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlzDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RufnummerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatumAnlageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatumAenderungDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnwenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Anrufen As Button
    Friend WithEvents Termin As Button
    Friend WithEvents NichtErreicht As Button
    Friend WithEvents ToteNummer As Button
    Friend WithEvents lblKunde As Label
    Friend WithEvents keininteresse As Button
    Friend WithEvents txtKunde As TextBox
    Friend WithEvents rtbNotizen As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents NaechsterKunde As Button
    Friend WithEvents dtpTerminVon As DateTimePicker
    Friend WithEvents lblTerminvon As Label
    Friend WithEvents lblTerminbis As Label
    Friend WithEvents dtpTerminBis As DateTimePicker
    Friend WithEvents btnTerminZettel As Button
    Friend WithEvents PrintTerminZettel As Printing.PrintDocument
    Friend WithEvents adressen_basisBindingSource As BindingSource

    Friend WithEvents btnFlyer As Button
    Friend WithEvents btnNeuerKunde As Button
    Friend WithEvents SP_TerminzettelGetBindingSource As BindingSource
    Friend WithEvents mankegmbhDataSet As mankegmbhDataSet
    Friend WithEvents SP_TerminzettelGetTableAdapter As mankegmbhDataSetTableAdapters.SP_TerminzettelGetTableAdapter
    Friend WithEvents btnAdmin As Button
    Friend WithEvents btnSuche As Button
    Friend WithEvents btnKdSuche As Button
    Friend WithEvents cbGoogle As CheckBox
    Friend WithEvents lblLastCall As Label
    Friend WithEvents lblLetzterAnruf As Label
    Friend WithEvents btnWiedervorlage As Button
    Private WithEvents panel2 As Panel
    Friend WithEvents SpeakerVolumeTrackbar As TrackBar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MicrophoneVolumeTrackbar As TrackBar
    Private WithEvents panel1 As Panel
    Private WithEvents labelIdentifier As Label
    Private WithEvents labelRegStatus As Label
    Private WithEvents labelDialingNumber As Label
    Private WithEvents labelCallStateInfo As Label
    Private WithEvents buttonHangUp As Button
    Private WithEvents buttonPickUp As Button
    Private WithEvents button10 As Button
    Private WithEvents button11 As Button
    Private WithEvents button12 As Button
    Private WithEvents button7 As Button
    Private WithEvents button8 As Button
    Private WithEvents button9 As Button
    Private WithEvents button4 As Button
    Private WithEvents button5 As Button
    Private WithEvents button6 As Button
    Private WithEvents button3 As Button
    Private WithEvents button2 As Button
    Private WithEvents Button13 As Button
End Class
