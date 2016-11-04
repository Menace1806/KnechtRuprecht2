



Public Class ReportViewer

    Dim int_AdressNr As Integer


    Private Sub ReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            SP_TerminzettelGetTableAdapter.Fill(MankegmbhDataSet.SP_TerminzettelGet, int_AdressNr)
        Catch ex As Exception
        End Try

        With prtReportViewer
            .RefreshReport()
        End With

    End Sub

    Public Function Adresse(ByVal adr As Integer)

        int_AdressNr = adr
        Return 0

    End Function


End Class