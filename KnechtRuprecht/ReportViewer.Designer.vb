<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportViewer
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportViewer))
        Me.SPTerminzettelGetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MankegmbhDataSet1 = New KnechtRuprecht.mankegmbhDataSet()
        Me.prtReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SP_TerminzettelGetTableAdapter1 = New KnechtRuprecht.mankegmbhDataSetTableAdapters.SP_TerminzettelGetTableAdapter()
        Me.mankegmbhDataSet = New KnechtRuprecht.mankegmbhDataSet()
        Me.SP_TerminzettelGetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_TerminzettelGetTableAdapter = New KnechtRuprecht.mankegmbhDataSetTableAdapters.SP_TerminzettelGetTableAdapter()
        CType(Me.SPTerminzettelGetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MankegmbhDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mankegmbhDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_TerminzettelGetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SPTerminzettelGetBindingSource
        '
        Me.SPTerminzettelGetBindingSource.DataMember = "SP_TerminzettelGet"
        Me.SPTerminzettelGetBindingSource.DataSource = Me.MankegmbhDataSet1
        '
        'MankegmbhDataSet1
        '
        Me.MankegmbhDataSet1.DataSetName = "mankegmbhDataSet"
        Me.MankegmbhDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'prtReportViewer
        '
        ReportDataSource1.Name = "DataSetTerminzettel"
        ReportDataSource1.Value = Me.SP_TerminzettelGetBindingSource
        Me.prtReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.prtReportViewer.LocalReport.ReportEmbeddedResource = "KnechtRuprecht.Terminzettel.rdlc"
        Me.prtReportViewer.Location = New System.Drawing.Point(2, -3)
        Me.prtReportViewer.Name = "prtReportViewer"
        Me.prtReportViewer.Size = New System.Drawing.Size(1008, 548)
        Me.prtReportViewer.TabIndex = 21
        '
        'SP_TerminzettelGetTableAdapter1
        '
        Me.SP_TerminzettelGetTableAdapter1.ClearBeforeFill = True
        '
        'mankegmbhDataSet
        '
        Me.mankegmbhDataSet.DataSetName = "mankegmbhDataSet"
        Me.mankegmbhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP_TerminzettelGetBindingSource
        '
        Me.SP_TerminzettelGetBindingSource.DataMember = "SP_TerminzettelGet"
        Me.SP_TerminzettelGetBindingSource.DataSource = Me.mankegmbhDataSet
        '
        'SP_TerminzettelGetTableAdapter
        '
        Me.SP_TerminzettelGetTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 544)
        Me.Controls.Add(Me.prtReportViewer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1032, 600)
        Me.MinimumSize = New System.Drawing.Size(1032, 600)
        Me.Name = "ReportViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReportViewer"
        CType(Me.SPTerminzettelGetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MankegmbhDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mankegmbhDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_TerminzettelGetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents prtReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SPTerminzettelGetBindingSource As BindingSource
    Friend WithEvents MankegmbhDataSet1 As mankegmbhDataSet
    Friend WithEvents SP_TerminzettelGetTableAdapter1 As mankegmbhDataSetTableAdapters.SP_TerminzettelGetTableAdapter
    Friend WithEvents SP_TerminzettelGetBindingSource As BindingSource
    Friend WithEvents mankegmbhDataSet As mankegmbhDataSet
    Friend WithEvents SP_TerminzettelGetTableAdapter As mankegmbhDataSetTableAdapters.SP_TerminzettelGetTableAdapter
End Class
