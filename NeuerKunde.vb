Imports MySql.Data.MySqlClient

Public Class NeuerKunde
    Dim Err As Integer = 0
    Dim druck As New Word_Oeffnen
    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim reader As MySqlDataReader


    Dim int_AdressNr As Integer

    Private Sub NeuerKunde_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call SetMyCustomFormat()
        Dim verweis As New My.MySettings
        con.ConnectionString = verweis.cchhhConnectionString
        tbVorname.MaxLength = 50
        tbNachname.MaxLength = 50
        tbStraße.MaxLength = 100
        tbPLZ.MaxLength = 10
        tbOrt.MaxLength = 20
        tbTelefon.MaxLength = 25
        lblTerminvon.Visible = False
        lblTerminbis.Visible = False
        dtpTerminBis.Visible = False
        dtpTerminVon.Visible = False
        btnTerminZettel.Visible = False
    End Sub
    Public Sub SetMyCustomFormat()
        dtpTerminVon.Format = DateTimePickerFormat.Custom
        dtpTerminVon.CustomFormat = "dd.MM.yyyy HH:00"
        dtpTerminBis.Format = DateTimePickerFormat.Custom
        dtpTerminBis.CustomFormat = "dd.MM.yyyy HH:00"
        dtpTerminVon.Value = DateTime.Now
        dtpTerminBis.Value = DateTime.Now.AddHours(1)

    End Sub

    Private Function checker(ByVal Fehler As Integer)

        If tbVorname.Text = String.Empty Then
            tbVorname.BackColor = Color.Red
            Err = 1
        Else
            tbVorname.BackColor = Color.White
            Err = 0

            If tbNachname.Text = String.Empty Then
                tbNachname.BackColor = Color.Red
                Err = 1
            Else
                tbNachname.BackColor = Color.White
                Err = 0

                If tbStraße.Text = String.Empty Then
                    tbStraße.BackColor = Color.Red
                    Err = 1
                Else
                    tbStraße.BackColor = Color.White
                    Err = 0

                    If tbPLZ.Text = String.Empty Then
                        tbPLZ.BackColor = Color.Red
                        Err = 1
                    Else
                        tbPLZ.BackColor = Color.White
                        Err = 0

                        If tbOrt.Text = String.Empty Then
                            tbOrt.BackColor = Color.Red
                            Err = 1

                        Else
                            tbOrt.BackColor = Color.White
                            Err = 0

                            If tbTelefon.Text = String.Empty Then
                                tbTelefon.BackColor = Color.Red
                                Err = 1
                            Else
                                tbTelefon.BackColor = Color.White
                                Err = 0
                            End If
                        End If
                    End If
                End If
            End If
        End If


        Return Err

    End Function

    Private Sub Speichern_Click(sender As Object, e As EventArgs) Handles Speichern.Click

        If checker(0) = 1 Then
            MsgBox("Bitte füllen sie die Roten Felder mit Werten",, "Warnung")
        Else
            If insert_kd() = 0 Then
                lblTerminvon.Visible = True
                lblTerminbis.Visible = True
                dtpTerminBis.Visible = True
                dtpTerminVon.Visible = True
                btnTerminZettel.Visible = True
            End If
        End If


    End Sub

    Private Sub dtpTerminVon_ValueChanged(sender As Object, e As EventArgs) Handles dtpTerminVon.ValueChanged
        dtpTerminBis.Value = dtpTerminVon.Value.AddHours(1)

    End Sub

    Private Sub dtpTerminBis_ValueChanged(sender As Object, e As EventArgs) Handles dtpTerminBis.ValueChanged
        dtpTerminVon.Value = dtpTerminBis.Value.AddHours(-1)

    End Sub

    Private Sub btnTerminZettel_Click(sender As Object, e As EventArgs) Handles btnTerminZettel.Click

        update_kd()

        drucken(1)

        flush()

    End Sub

    Private Sub drucken(ByVal art As Integer)
        druck.oeffnen(art, int_AdressNr)
    End Sub

    Private Function insert_kd()
        Dim err As Integer
        Dim cmd As New MySqlCommand
        Dim query As String


        query = "INSERT INTO `adressen`(`Vorname`,`Nachname`,`Strasse`,`PLZ`,`ORT`,`Telefon`,`Notiz`)" &
                "VALUES(@Vorname,@Nachname,@Strasse,@PLZ,@ORT,@Telefon,@Notiz);"

        Try
            With cmd
                .Connection = con
                .CommandText = query

                .Parameters.AddWithValue("@Vorname", Convert.ToString(tbVorname.Text))
                .Parameters.AddWithValue("@Nachname", Convert.ToString(tbNachname.Text))
                .Parameters.AddWithValue("@Strasse", Convert.ToString(tbStraße.Text))
                .Parameters.AddWithValue("@PLZ", Convert.ToString(tbPLZ.Text))
                .Parameters.AddWithValue("@ORT", Convert.ToString(tbOrt.Text))
                .Parameters.AddWithValue("@Telefon", Convert.ToString(tbTelefon.Text))
                .Parameters.AddWithValue("@Notiz", Convert.ToString(rtbNotizen.Text))

            End With

            con.Open()
            cmd.ExecuteNonQuery()
            err = 0
        Catch ex As Exception
            MsgBox("Fehler" & vbCrLf & ex.Message)
            err = 1

        Finally
            cmd = Nothing
            con.Close()
        End Try

        auslesen()

        Return err


    End Function


    Private Sub flush()

        tbVorname.Text = Nothing
        tbNachname.Text = Nothing
        tbStraße.Text = Nothing
        tbPLZ.Text = Nothing
        tbOrt.Text = Nothing
        tbTelefon.Text = Nothing
        rtbNotizen.Text = Nothing

        SetMyCustomFormat()

    End Sub

    Private Sub auslesen()
        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM adressen order by adressnr desc limit 1;"

        Try
            con.Open()
            reader = cmd.ExecuteReader()
            Do While reader.Read()
                int_AdressNr = reader("AdressNr")
            Loop
            reader.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & "auslesen")
        End Try

    End Sub


    Private Function update_kd()
        Dim err As Integer
        Dim cmd As New MySqlCommand

        Dim query As String

        query = "UPDATE `adressen`SET `TerminJN` = 1, `Termin_von` = @dtpTerminVon.Value ,`Termin_bis` = @dtpTerminBis.Value where AdressNr =  @int_AdressNr"

        Try
            With cmd
                .Connection = con
                .CommandText = query

                .Parameters.AddWithValue("@int_AdressNr", int_AdressNr)
                .Parameters.AddWithValue("@dtpTerminVon.Value", dtpTerminVon.Value)
                .Parameters.AddWithValue("@dtpTerminBis.Value", dtpTerminBis.Value)
            End With

            con.Open()
            cmd.ExecuteNonQuery()
            err = 0
        Catch ex As Exception
            MsgBox("Fehler" & vbCrLf & ex.Message)
            err = 1

        Finally
            cmd = Nothing
            con.Close()
        End Try

        Return err

    End Function

End Class