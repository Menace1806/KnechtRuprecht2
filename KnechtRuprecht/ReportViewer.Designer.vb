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
        Me.MankegmbhDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MankegmbhDataSet = New KnechtRuprecht.mankegmbhDataSet()
        Me.prtReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SP_TerminzettelGetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_TerminzettelGetTableAdapter = New KnechtRuprecht.mankegmbhDataSetTableAdapters.SP_TerminzettelGetTableAdapter()
        CType(Me.MankegmbhDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MankegmbhDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_TerminzettelGetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MankegmbhDataSetBindingSource
        '
        Me.MankegmbhDataSetBindingSource.DataSource = Me.MankegmbhDataSet
        Me.MankegmbhDataSetBindingSource.Position = 0
        '
        'MankegmbhDataSet
        '
        Me.MankegmbhDataSet.DataSetName = "mankegmbhDataSet"
        Me.MankegmbhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'prtReportViewer
        '
        ReportDataSource1.Name = "DataSetTerminzettel"
        ReportDataSource1.Value = Me.SP_TerminzettelGetBindingSource
        Me.prtReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.prtReportViewer.LocalReport.ReportEmbeddedResource = "KnechtRuprecht.Report1.rdlc"
        Me.prtReportViewer.Location = New System.Drawing.Point(2, -3)
        Me.prtReportViewer.Name = "prtReportViewer"
        Me.prtReportViewer.Size = New System.Drawing.Size(1008, 548)
        Me.prtReportViewer.TabIndex = 21
        '
        'SP_TerminzettelGetBindingSource
        '
        Me.SP_TerminzettelGetBindingSource.DataMember = "SP_TerminzettelGet"
        Me.SP_TerminzettelGetBindingSource.DataSource = Me.MankegmbhDataSet
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
        CType(Me.MankegmbhDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MankegmbhDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_TerminzettelGetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents prtReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MankegmbhDataSetBindingSource As BindingSource
    Friend WithEvents MankegmbhDataSet As mankegmbhDataSet
    Friend WithEvents SP_TerminzettelGetBindingSource As BindingSource
    Friend WithEvents SP_TerminzettelGetTableAdapter As mankegmbhDataSetTableAdapters.SP_TerminzettelGetTableAdapter
End Class
