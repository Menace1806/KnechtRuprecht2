Public Class Wiedervorlage

    Dim int_AdressNr As Integer


    Public Function Adresse(ByVal adr As Integer)

        int_AdressNr = adr
        Return 0

    End Function

    Private Sub Wiedervorlage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SP_WiedervorlageGetTableAdapter.Fill(MankegmbhDataSet.SP_WiedervorlageGet, int_AdressNr)

        With ReportViewer1
            .RefreshReport()
        End With
    End Sub


End Class