Imports Microsoft.Office.Interop.Word
Imports System.Runtime.InteropServices
Imports System.IO
Imports MySql.Data.MySqlClient
Imports KnechtRuprecht

Public Class Word_Oeffnen

    Dim reader As MySqlDataReader
    Dim verweis As New My.MySettings

    Dim int_adressnr As Integer
    Dim str_Strasse As String
    Dim str_Hausnummer As String
    Dim str_PLZ As String
    Dim str_Nachname As String
    Dim str_Vorname As String
    Dim str_Ort As String
    Dim str_Notizen As String
    Dim dat_Termin As Date

    Public Sub oeffnen(ByVal int_case As Integer, ByVal adressnr As String)
        Dim Zettel As New Application
        Dim doc As New Document
        Dim cmd As New MySqlCommand
        Dim con As New MySqlConnection

        If con.ConnectionString = Nothing Then
            con.ConnectionString = verweis.cchhhConnectionString
        End If

        cmd.Connection = con
        cmd.CommandText = "Select * from `adressen` where `AdressNr`= " & adressnr

        Try
            con.Open()
            reader = cmd.ExecuteReader()
            Do While reader.Read()
                int_adressnr = reader("AdressNr")
                str_Vorname = reader("Vorname")
                str_Nachname = reader("Nachname")
                str_Strasse = reader("Strasse")
                str_PLZ = reader("PLZ")
                str_Ort = reader("ORT")
                dat_Termin = reader("Termin_von")
                str_Notizen = reader("Notiz")
            Loop
            reader.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & " Word_Öffnen")
        Finally
            con.Close()
        End Try

        Try
            With Zettel
                ' Word anzeigen
                .Application.Visible = True
                .Application.Activate()

                'Word-Dokument laden und anzeigen
                ' 1= Terminzettel
                ' 2= Flyer Anschreiben öffnen

                If int_case = 1 Then
                    doc = .Documents.Open("C:\Users\Dennis\Desktop\USB STICK\FLYER\test.docx")
                    doc.Activate()
                    If doc.Bookmarks.Exists("AdressNr") Then
                        doc.Bookmarks().Item("AdressNr").Range.Text = CStr(int_adressnr)
                    End If
                    If doc.Bookmarks.Exists("Vorname") Then
                        doc.Bookmarks().Item("Vorname").Range.Text = str_Vorname
                    End If
                    If doc.Bookmarks.Exists("Nachname") Then
                        doc.Bookmarks().Item("Nachname").Range.Text = str_Nachname
                    End If
                    If doc.Bookmarks.Exists("Strasse") Then
                        doc.Bookmarks().Item("Strasse").Range.Text = str_Strasse
                    End If
                    If doc.Bookmarks.Exists("PLZ") Then
                        doc.Bookmarks().Item("PLZ").Range.Text = str_PLZ
                    End If
                    If doc.Bookmarks.Exists("ORT") Then
                        doc.Bookmarks().Item("ORT").Range.Text = str_Ort
                    End If
                    If doc.Bookmarks.Exists("Notizen") Then
                        doc.Bookmarks().Item("Notizen").Range.Text = str_Notizen
                    End If
                    If doc.Bookmarks.Exists("Termin") Then
                        doc.Bookmarks().Item("Termin").Range.Text = CStr(dat_Termin)
                    End If


                    doc.PrintOut(Background:=False)

                    doc.PrintOut(Background:=False)

                    If doc.Bookmarks.Exists("AdressNr") Then
                        doc.Bookmarks().Item("AdressNr").Range.Text = Replace(doc.Bookmarks().Item("AdressNr").Range.Text, CStr(int_adressnr), "")
                        'doc.Bookmarks.Add("AdressNr", doc.Bookmarks().Item("AdressNr").Range)
                    End If
                    'If doc.Bookmarks.Exists("Vorname") Then
                    '    doc.Bookmarks().Item("Vorname").Range.End = doc.Bookmarks().Item("Vorname").Range.Start
                    '    doc.Bookmarks().Item("Vorname").Range.Delete()
                    '    System.Threading.Thread.Sleep(2000)
                    'End If
                    'If doc.Bookmarks.Exists("Nachname") Then
                    '    doc.Bookmarks().Item("Nachname").Range.End = doc.Bookmarks().Item("Nachname").Range.Start
                    '    doc.Bookmarks().Item("Nachname").Range.Delete()
                    '    System.Threading.Thread.Sleep(2000)
                    'End If
                    'If doc.Bookmarks.Exists("Strasse") Then
                    '    doc.Bookmarks().Item("Strasse").Range.End = doc.Bookmarks().Item("Strasse").Range.Start
                    '    doc.Bookmarks().Item("Strasse").Range.Delete()
                    '    System.Threading.Thread.Sleep(2000)
                    'End If
                    'If doc.Bookmarks.Exists("PLZ") Then
                    '    doc.Bookmarks().Item("PLZ").Range.End = doc.Bookmarks().Item("PLZ").Range.Start
                    '    doc.Bookmarks().Item("PLZ").Range.Delete()
                    '    System.Threading.Thread.Sleep(2000)
                    'End If
                    'If doc.Bookmarks.Exists("ORT") Then
                    '    doc.Bookmarks().Item("ORT").Range.End = doc.Bookmarks().Item("ORT").Range.Start
                    '    doc.Bookmarks().Item("ORT").Range.Delete()
                    '    System.Threading.Thread.Sleep(2000)
                    'End If
                    'If doc.Bookmarks.Exists("Notizen") Then
                    '    doc.Bookmarks().Item("Notizen").Range.End = doc.Bookmarks().Item("Notizen").Range.Start
                    '    doc.Bookmarks().Item("Notizen").Range.Delete()
                    '    System.Threading.Thread.Sleep(2000)
                    'End If
                    'If doc.Bookmarks.Exists("Termin") Then
                    '    doc.Bookmarks().Item("Termin").Range.End = doc.Bookmarks().Item("Termin").Range.Start
                    '    doc.Bookmarks().Item("Termin").Range.Delete()
                    '    System.Threading.Thread.Sleep(2000)
                    'End If



                    doc.Close()

                ElseIf int_case = 2 Then
                    doc = .Documents.Open("C:\Users\Dennis\Desktop\USB STICK\FLYER\anschreiben_flyer.docx")
                End If
            End With


        Catch ex As IOException

            MessageBox.Show("Datei nicht vorhanden.")

        Finally
            Zettel.Application.Quit()
            con = Nothing
            Zettel = Nothing
            cmd = Nothing
            reader = Nothing
            doc = Nothing
        End Try




    End Sub

    'Private Function dok()

    'Dim word As New Application



    '    Try

    '        word.Visible = (True) 'Word sehen zum Test?
    '        doc = word.Documents.Open("C:\Users\Dennis\Desktop\USB STICK\FLYER\anschreiben_flyer.docx")

    '        doc.Activate()


    '            doc.Bookmarks().Item(textmarke).Range.Text = textm_value

    '        Else

    '            MessageBox.Show("Textmarke nicht vorhanden!")

    '        End If
    '        doc.SaveAs("C:\Users\Dennis\Desktop\USB STICK\FLYER\test.doc")

    '        doc.PrintOut(Background:=False)

    '        doc.Close()

    '        MessageBox.Show("Datei erstellt")
    '    Catch ex As IOException

    '        MessageBox.Show("Datei nicht vorhanden.")

    '    Finally

    '        word.Application.Quit()

    '    End Try

    '    Return (0)

    'End Function


End Class
