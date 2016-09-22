<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Wiedervorlage
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MankegmbhDataSet = New KnechtRuprecht.mankegmbhDataSet()
        Me.SP_WiedervorlageGetTableAdapter = New KnechtRuprecht.mankegmbhDataSetTableAdapters.SP_WiedervorlageGetTableAdapter()
        Me.SP_WiedervorlageGetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.MankegmbhDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_WiedervorlageGetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource2.Name = "DataSetWiedervorlage"
        ReportDataSource2.Value = Me.SP_WiedervorlageGetBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "KnechtRuprecht.Wiedervorlage.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 1)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1009, 542)
        Me.ReportViewer1.TabIndex = 0
        '
        'MankegmbhDataSet
        '
        Me.MankegmbhDataSet.DataSetName = "mankegmbhDataSet"
        Me.MankegmbhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP_WiedervorlageGetTableAdapter
        '
        Me.SP_WiedervorlageGetTableAdapter.ClearBeforeFill = True
        '
        'SP_WiedervorlageGetBindingSource
        '
        Me.SP_WiedervorlageGetBindingSource.DataMember = "SP_WiedervorlageGet"
        Me.SP_WiedervorlageGetBindingSource.DataSource = Me.MankegmbhDataSet
        '
        'Wiedervorlage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 544)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximumSize = New System.Drawing.Size(1032, 600)
        Me.MinimumSize = New System.Drawing.Size(1032, 600)
        Me.Name = "Wiedervorlage"
        Me.Text = "Wiedervorlage"
        CType(Me.MankegmbhDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_WiedervorlageGetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SP_WiedervorlageGetBindingSource As BindingSource
    Friend WithEvents MankegmbhDataSet As mankegmbhDataSet
    Friend WithEvents SP_WiedervorlageGetTableAdapter As mankegmbhDataSetTableAdapters.SP_WiedervorlageGetTableAdapter
End Class
