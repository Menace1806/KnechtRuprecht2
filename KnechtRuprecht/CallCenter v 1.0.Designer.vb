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
        CType(Me.adressen_basisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_TerminzettelGetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mankegmbhDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'CallCenter
        '
        resources.ApplyResources(Me, "$this")
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
End Class
