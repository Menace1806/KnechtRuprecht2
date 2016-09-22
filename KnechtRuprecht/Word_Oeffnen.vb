Imports Microsoft.Office.Interop.Word
Imports System.IO


Public Class Word_Oeffnen
    Public Sub oeffnen()
        Dim Zettel As New Application
        Dim doc As New Document


        Try
            With Zettel
                ' Word anzeigen
                .Application.Visible = True
                .Application.Activate()


                doc = .Documents.Open("C:\Program Files\Flyer.docx")
                doc.Activate()

            End With


        Catch ex As IOException
            MessageBox.Show("Datei nicht vorhanden.")
        End Try



    End Sub


End Class
