
Public Class ReportViewer

    Dim int_AdressNr As Integer


    Private Sub ReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SP_TerminzettelGetTableAdapter.Fill(mankegmbhDataSet.SP_TerminzettelGet, int_AdressNr)

        With prtReportViewer
            .RefreshReport()
        End With

    End Sub

    Public Function Adresse(ByVal adr As Integer)

        int_AdressNr = adr
        Return 0

    End Function



End Class