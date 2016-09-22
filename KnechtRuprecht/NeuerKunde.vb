Imports MySql.Data.MySqlClient

Public Class NeuerKunde
    Dim Err As Integer = 0
    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim reader As MySqlDataReader
    Dim Rep As New ReportViewer
    Dim verweis As New My.MySettings
    Dim int_AdressNr As Integer
    Public Shared ReadOnly Property CurrentDomainUser() As String
        Get
            Dim name As String
            name = System.Windows.Forms.SystemInformation.UserName
            CurrentDomainUser = name

        End Get
    End Property
    Private Sub NeuerKunde_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call SetMyCustomFormat()


        con.ConnectionString = verweis.cchhhConnectionString

        tbVorname.MaxLength = 50
        tbNachname.MaxLength = 50
        tbStraße.MaxLength = 100
        tbPLZ.MaxLength = 10
        tbOrt.MaxLength = 20
        tbTelefon.MaxLength = 25
        rtbNotizen.MaxLength = 5000
        lblTerminvon.Visible = False
        lblTerminbis.Visible = False
        dtpTerminBis.Visible = False
        dtpTerminVon.Visible = False
        btnTerminZettel.Visible = False
    End Sub
    Public Sub SetMyCustomFormat()
        Dim vdat As String
        Dim bdat As String

        dtpTerminVon.Format = DateTimePickerFormat.Custom
        dtpTerminVon.CustomFormat = "dd.MM.yyyy HH:mm"
        dtpTerminBis.Format = DateTimePickerFormat.Custom
        dtpTerminBis.CustomFormat = "dd.MM.yyyy HH:mm"
        vdat = Date.Now.Day & "." & Date.Now.Month & "." & Date.Now.Year & " " & Date.Now.Hour & ":00"
        bdat = Date.Now.Day & "." & Date.Now.Month & "." & Date.Now.Year & " " & Date.Now.Hour + 1 & ":00"
        dtpTerminVon.Value = CStr(vdat)
        dtpTerminBis.Value = CStr(bdat)

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

        Speichern.Enabled = False

    End Sub
    Private Sub dtpTerminVon_ValueChanged(sender As Object, e As EventArgs) Handles dtpTerminVon.ValueChanged
        dtpTerminBis.Value = dtpTerminVon.Value.AddHours(1)

    End Sub
    Private Sub dtpTerminBis_ValueChanged(sender As Object, e As EventArgs) Handles dtpTerminBis.ValueChanged
        dtpTerminVon.Value = dtpTerminBis.Value.AddHours(-1)

    End Sub
    Private Sub btnTerminZettel_Click(sender As Object, e As EventArgs) Handles btnTerminZettel.Click

        If termincheck() = 1 Then
            MsgBox("Termin " & dtpTerminVon.Value & " ist schon vergeben!" & vbCrLf & "Bitte den Termin ändern.")

        Else
            terminkalender()

            termine()

            druckTabelle()

            update_kd()

            Aktualisieren()

            flush()

            btnTerminZettel.Visible = False
            dtpTerminBis.Visible = False
            dtpTerminVon.Visible = False

            Speichern.Enabled = True
        End If
    End Sub
    Private Function insert_kd()
        Dim err As Integer
        Dim cmd As New MySqlCommand
        Dim query As String
        con.ConnectionString = Nothing

        If con.ConnectionString = Nothing Then
            con.ConnectionString = verweis.cchhhConnectionString
        End If


        query = "INSERT INTO `adressen`(`Vorname`,`Nachname`,`Strasse`,`PLZ`,`ORT`,`Telefon`,`Notiz`,`LastCall`,`Anwender`)" &
                "VALUES(@Vorname,@Nachname,@Strasse,@PLZ,@ORT,@Telefon,@Notiz,@DateTime.Now,@Anwender);"

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
                .Parameters.AddWithValue("@Anwender", CurrentDomainUser())
                .Parameters.AddWithValue("@DateTime.Now", DateTime.Now)

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
        lblTerminvon.Visible = False
        lblTerminbis.Visible = False

        SetMyCustomFormat()

    End Sub
    Private Sub auslesen()
        Dim cmd As New MySqlCommand
        cmd.Connection = con
        con.ConnectionString = Nothing

        If con.ConnectionString = Nothing Then
            con.ConnectionString = verweis.cchhhConnectionString
        End If
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
            'MessageBox.Show(ex.Message & "auslesen")
        End Try

    End Sub
    Private Function update_kd()
        Dim err As Integer
        Dim cmd As New MySqlCommand
        Dim query As String
        con.ConnectionString = Nothing

        If con.ConnectionString = Nothing Then
            con.ConnectionString = verweis.cchhhConnectionString
        End If

        query = "UPDATE `adressen`SET `TerminJN` = 1, `Termin_von` = @dtpTerminVon.Value ,`Termin_bis` = @dtpTerminBis.Value, `Notiz` = @Notiz where AdressNr =  @int_AdressNr"

        Try
            With cmd
                .Connection = con
                .CommandText = query

                .Parameters.AddWithValue("@int_AdressNr", int_AdressNr)
                .Parameters.AddWithValue("@dtpTerminVon.Value", dtpTerminVon.Value)
                .Parameters.AddWithValue("@dtpTerminBis.Value", dtpTerminBis.Value)
                .Parameters.AddWithValue("@Notiz", Convert.ToString(rtbNotizen.Text))
            End With

            con.Open()
            cmd.ExecuteNonQuery()
            err = 0
        Catch ex As Exception
            'MsgBox("Fehler" & vbCrLf & ex.Message)
            err = 1

        Finally
            cmd = Nothing
            con.Close()
        End Try

        Return err

    End Function
    Private Sub Aktualisieren()

        Rep = Nothing
        Rep = New ReportViewer
        Rep.Adresse(int_AdressNr)
        Rep.Show()

    End Sub
    Private Function druckTabelle()
        Dim cmd As New MySqlCommand
        Dim err As Integer

        Dim query As String
        con.ConnectionString = Nothing

        If con.ConnectionString = Nothing Then
            con.ConnectionString = verweis.cchhhConnectionString
        End If


        query = "INSERT INTO `terminzetteldruck` (`AdressNr`,`Vorname`, `Nachname`, `Strasse`, `PLZ`, `ORT`,`Termin_von`,`Termin_bis`,`Notiz`,`Telefonnummer`,`Anwender`)" &
                "VALUES(@int_AdressNr, @Vorname,@Nachname,@Strasse,@PLZ,@ORT,@dtpTerminVon.Value,@dtpTerminBis.Value,@Notizen,@TelNr,@Anwender)"

        Try
            With cmd
                .Connection = con
                .CommandText = query

                .Parameters.AddWithValue("@int_AdressNr", int_AdressNr)
                .Parameters.AddWithValue("@dtpTerminVon.Value", dtpTerminVon.Value)
                .Parameters.AddWithValue("@dtpTerminBis.Value", dtpTerminBis.Value)
                .Parameters.AddWithValue("@Vorname", tbVorname.Text)
                .Parameters.AddWithValue("@Nachname", tbNachname.Text)
                .Parameters.AddWithValue("@Strasse", tbStraße.Text)
                .Parameters.AddWithValue("@PLZ", tbPLZ.Text)
                .Parameters.AddWithValue("@ORT", tbOrt.Text)
                .Parameters.AddWithValue("@TelNr", tbTelefon.Text)
                .Parameters.AddWithValue("@Notizen", Convert.ToString(rtbNotizen.Text))
                .Parameters.AddWithValue("@Anwender", CurrentDomainUser())
            End With

            con.Open()
            cmd.ExecuteNonQuery()
            err = 0
        Catch ex As Exception
            'MsgBox("Fehler" & vbCrLf & ex.Message & " drucktabelle")
            err = 1

        Finally
            con.Close()
            cmd = Nothing
        End Try


        Return err


    End Function
    Private Function termincheck()
        Dim anzahl As Integer
        Dim vdat As String
        Dim Stunde As Integer
        Dim Jahr As Integer
        Dim Monat As Integer
        Dim Tag As Integer
        Dim Min As Integer
        Dim err As Integer
        con.ConnectionString = Nothing

        err = 0
        anzahl = 0

        Stunde = dtpTerminVon.Value.Hour
        Jahr = dtpTerminVon.Value.Year
        Monat = dtpTerminVon.Value.Month
        Tag = dtpTerminVon.Value.Day
        Min = dtpTerminVon.Value.Minute

        vdat = CStr(Jahr & "-" & Monat & "-" & Tag & " " & Stunde & ":" & Min & ":00")


        If con.ConnectionString = Nothing Then
            con.ConnectionString = verweis.cchhhConnectionString
        End If

        cmd.Connection = con

        cmd.CommandText = "Select count(*) from `termine` where `Termin_von`= " & Chr(34) & vdat & Chr(34)

        Try
            con.Open()
            reader = cmd.ExecuteReader()
            reader.Read()
            anzahl = reader("count(*)")
            reader.Close()
            con.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message & " nxtkd")
        Finally
            con.Close()
            cmd.Connection = Nothing

            If anzahl <> 0 Then
                err = 1
                ' MsgBox("Termin " & dtpTerminVon.Value & " ist schon vergeben!" & vbCrLf & "Termin wurde um 1 Stunde verschoben")
            Else
                err = 0
            End If
        End Try

        Return err

    End Function
    Sub terminkalender()
        Dim cmd As New MySqlCommand
        Dim query As String
        Dim titel As String
        Dim description As String
        Dim venue As String
        Dim EID As Integer

        query = Nothing
        titel = Nothing
        description = Nothing
        venue = Nothing
        EID = Nothing
        con.ConnectionString = Nothing
        con.ConnectionString = verweis.TerminplanerConnection


        titel = tbPLZ.Text & "," & tbNachname.Text & ", TelefonNr:" & tbTelefon.Text
        description = "Kundennummer: " & CStr(int_AdressNr)
        venue = "Ort:" & tbOrt.Text & "," & tbStraße.Text

        If con.ConnectionString = Nothing Then
            con.ConnectionString = verweis.TerminplanerConnection
        End If

        query = "INSERT INTO `events`(`title`,`description`,`venue`,user_id,not_mail)
                        VALUES(@Titel,@description,@venue,1,' ');"

        Try
            With cmd
                .Connection = con
                .CommandText = query

                .Parameters.AddWithValue("@Titel", titel)
                .Parameters.AddWithValue("@description", description)
                .Parameters.AddWithValue("@venue", venue)
                con.Open()
                cmd.ExecuteNonQuery()
            End With
        Catch ex As Exception
            'MessageBox.Show(ex.Message & " nxtkd")
        Finally
            con.Close()
            query = Nothing

        End Try

        cmd.Connection = con

        cmd.CommandText = "Select event_id from `events` order by event_id desc limit 1;"

        Try
            con.Open()
            reader = cmd.ExecuteReader()
            reader.Read()
            EID = reader("event_id")
            reader.Close()
            con.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message & " nxtkd")
        Finally
            con.Close()
        End Try

        Dim vdat As String
        Dim vtime As String
        Dim vStunde As Integer
        Dim vJahr As Integer
        Dim vMonat As Integer
        Dim vTag As Integer

        Dim bdat As String
        Dim btime As String
        Dim bStunde As Integer
        Dim bJahr As Integer
        Dim bMonat As Integer
        Dim bTag As Integer



        vStunde = dtpTerminVon.Value.Hour
        vJahr = dtpTerminVon.Value.Year
        vMonat = dtpTerminVon.Value.Month
        vTag = dtpTerminVon.Value.Day

        bStunde = dtpTerminBis.Value.Hour
        bJahr = dtpTerminBis.Value.Year
        bMonat = dtpTerminBis.Value.Month
        bTag = dtpTerminBis.Value.Day

        vdat = CStr(vJahr & "-" & vMonat & "-" & vTag)
        vtime = CStr(vStunde & ":00:00")


        bdat = CStr(bJahr & "-" & bMonat & "-" & bTag)
        btime = CStr(bStunde & ":00:00")




        query = "INSERT INTO `dates` (`event_id`,`s_date`,`e_date`,`s_time`,`e_time`,`a_date`,`m_date`,`adress_id`)
                 VALUES
                (@EID,@vdat,@bdat,@vtime,@btime,@vdat,@vdat,@AdressNr);"

        Try
            With cmd
                .Connection = con
                .CommandText = query

                .Parameters.AddWithValue("@EID", EID)
                .Parameters.AddWithValue("@vdat", vdat)
                .Parameters.AddWithValue("@bdat", bdat)
                .Parameters.AddWithValue("@vtime", vtime)
                .Parameters.AddWithValue("@btime", btime)
                .Parameters.AddWithValue("@AdressNr", int_AdressNr)
                con.Open()
                cmd.ExecuteNonQuery()
            End With
        Catch ex As Exception
            'MessageBox.Show(ex.Message & " nxtkd")
        Finally
            con.Close()
            query = Nothing

        End Try


    End Sub
    Private Sub termine()
        Dim cmd As New MySqlCommand
        Dim query As String
        con.ConnectionString = Nothing

        If con.ConnectionString = Nothing Then
            con.ConnectionString = verweis.cchhhConnectionString
        End If

        query = "INSERT INTO `termine` (`AdressNr`,`Termin_von`,`Termin_bis`,`Telefonnummer`,`Anwender`)" &
                    "VALUES(@int_AdressNr, @dtpTerminVon.Value,@dtpTerminBis.Value,@TelNr,@Anwender);"
        Try
            With cmd
                .Connection = con
                .CommandText = query

                .Parameters.AddWithValue("@int_AdressNr", int_AdressNr)
                .Parameters.AddWithValue("@dtpTerminVon.Value", dtpTerminVon.Value)
                .Parameters.AddWithValue("@dtpTerminBis.Value", dtpTerminBis.Value)
                .Parameters.AddWithValue("@TelNr", tbTelefon.Text)
                .Parameters.AddWithValue("@Anwender", CurrentDomainUser())
            End With

            con.Open()
            cmd.ExecuteNonQuery()
            Err = 0
        Catch ex As Exception
            'MsgBox("Fehler" & vbCrLf & ex.Message & " drucktabelle")
            Err = 1

        Finally
            con.Close()
            cmd = Nothing

        End Try
    End Sub

End Class