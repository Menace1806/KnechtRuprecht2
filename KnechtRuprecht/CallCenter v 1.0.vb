﻿
Imports MySql.Data.MySqlClient
Imports Ozeki.VoIP
Imports Ozeki.Media
Imports System.Net

Public Class CallCenter
    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim reader As MySqlDataReader
    Dim verweis As New My.MySettings
    Dim loCallTo As New CallTo
    Dim newKunde As New NeuerKunde
    Dim Rep As New ReportViewer
    Dim verwaltung As New Admin
    Dim word As New Word_Oeffnen
    Dim maps As New googlemaps
    Dim wv As New Wiedervorlage
    Dim Random As Integer
    Dim int_AdressNr As Integer
    Dim str_TelNumber As String
    Dim str_Strasse As String
    Dim str_Hausnummer As String
    Dim str_PLZ As String
    Dim str_Nachname As String
    Dim str_Vorname As String
    Dim str_Ort As String
    Dim int_InteresseJN As Integer = 0
    Dim int_TotJN As Integer
    Dim int_Anwalt As Integer = 0
    Dim int_FlyerJN As Integer = 0
    Dim int_TerminJN As Integer = 0
    Dim str_Notizen As String
    Dim int_ErreichtJN As Integer = 0
    Dim dat_LastCall As Date
    Dim dat_TerminVon As Date
    Dim dat_TerminBis As Date
    Dim str_query As String
    Dim URL As String
    Dim PoolPlz As String
    Dim SIPID As String
    Dim SIPPassword As String
    Dim Proxy As String
    Dim Anzeigename As String


    Public Shared ReadOnly Property CurrentDomainUser() As String
        Get
            Dim name As String
            name = System.Windows.Forms.SystemInformation.UserName
            CurrentDomainUser = name

        End Get
    End Property

    Public Function Adresse() As Integer

        Adresse = int_AdressNr

        Return int_AdressNr

    End Function

    Private Sub CallCenter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim verweis As New My.MySettings

        Anrufen.Enabled = loCallTo.Enabled
        Text = verweis.ApplicationName & " || User: " & CurrentDomainUser
        con.ConnectionString = verweis.cchhhConnectionString
        If con.ConnectionString = Nothing Then
            con.ConnectionString = verweis.cchhhConnectionString
        End If

        dtpTerminBis.Visible = False
        dtpTerminVon.Visible = False
        lblTerminbis.Visible = False
        lblTerminvon.Visible = False
        btnTerminZettel.Visible = False
        btnKdSuche.Enabled = False
        btnKdSuche.Visible = False



        'If CurrentDomainUser = "Dennis" Then
        '    btnAdmin.Enabled = True
        '    btnAdmin.Visible = True
        'ElseIf CurrentDomainUser = "Anne" Then
        '    btnAdmin.Enabled = True
        '    btnAdmin.Visible = True
        'ElseIf CurrentDomainUser = "ekolloczek" Then
        '    btnAdmin.Enabled = True
        '    btnAdmin.Visible = True
        'Else
        '    btnAdmin.Enabled = False
        '    btnAdmin.Visible = False
        'End If

        cbGoogle.Checked = False
        Call nextKd()
        Call SetMyCustomFormat()


    End Sub

    Private Sub Anrufen_Click(sender As Object, e As EventArgs) Handles Anrufen.Click

        loCallTo.DoCall(str_TelNumber)

        str_query = Nothing

        str_query = "UPDATE `adressen`SET `LastCall` = @DateTime.Now , `Anwender` = @CurrentDomainUser  Where AdressNr = @int_AdressNr"
        update_kd(str_query, 4)



    End Sub

    Private Sub NaechsterKunde_Click(sender As Object, e As EventArgs) Handles NaechsterKunde.Click

        dtpTerminBis.Visible = False
        dtpTerminVon.Visible = False
        lblTerminbis.Visible = False
        lblTerminvon.Visible = False
        btnTerminZettel.Visible = False
        rtbNotizen.Visible = True
        Label1.Visible = True
        txtKunde.BackColor = SystemColors.Control
        txtKunde.ReadOnly = True
        btnKdSuche.Visible = False
        btnKdSuche.Enabled = False

        If rtbNotizen.Text <> Nothing Then
            str_query = Nothing

            str_query = "UPDATE `adressen`SET `Notiz` = @rtbNotizen.Text where AdressNr = @int_AdressNr"
            update_kd(str_query, 3)

        End If

        Call nextKd()

    End Sub

    Private Sub Termin_Click(sender As Object, e As EventArgs) Handles Termin.Click

        dtpTerminBis.Visible = True
        dtpTerminVon.Visible = True
        lblTerminbis.Visible = True
        lblTerminvon.Visible = True
        btnTerminZettel.Visible = True
        btnTerminZettel.Enabled = True



    End Sub

    Private Sub NichtErreicht_Click(sender As Object, e As EventArgs) Handles NichtErreicht.Click
        str_query = Nothing

        str_query = "UPDATE `adressen` SET `ErreichtJN` = 1 ,`ErreichtAM` = @now ,`Notiz` = @Notiz , `Anwender` = @Anwender where AdressNr =  @int_AdressNr"
        update_kd(str_query, 1)


        NichtErreicht.Enabled = False
    End Sub

    Private Sub ToteNummer_Click(sender As Object, e As EventArgs) Handles ToteNummer.Click
        str_query = Nothing

        str_query = "Update `adressen` Set `TotJN` = 1, `TotAm` = @now, `Notiz` = @Notiz , `Anwender` = @Anwender where AdressNr = @int_AdressNr"

        update_kd(str_query, 1)

        str_query = "Delete from `adressen_pool` where AdressNr = @int_AdressNr"

        update_kd(str_query, 1)

        deaktivieren()


    End Sub

    Private Sub keininteresse_Click(sender As Object, e As EventArgs) Handles keininteresse.Click
        str_query = Nothing

        str_query = "UPDATE `adressen`SET `InteresseJN` = 1 , `InteresseAM` = @now, `Notiz` = @Notiz , `Anwender` = @Anwender  where AdressNr = @int_AdressNr"
        update_kd(str_query, 1)

        str_query = "DELETE FROM `adressen_pool` where AdressNr = @int_AdressNr"
        update_kd(str_query, 1)

        keininteresse.Enabled = False
    End Sub

    Public Function zufall()

        Dim zahl As Integer
        Dim anzahl As Integer
        Dim gibtes As Integer
        Dim vorhanden As Integer
        Dim adr As Integer
        Dim diff As DateTime
        Dim diffJN As Integer

        gibtes = 0


        anzahl = 0
        zahl = 0

        con.ConnectionString = Nothing

        If con.ConnectionString = Nothing Then
            con.ConnectionString = verweis.cchhhConnectionString
        End If


        Try
            cmd.CommandText = Nothing

            cmd.Connection = con
            'cmd.CommandText = "Select plz from `adressen_pool` order by plz limit 1"
            'con.Open()
            'reader = cmd.ExecuteReader()
            'reader.Read()
            'If PoolPlz <> reader("plz") Then
            '    PoolPlz = reader("plz")
            'End If
            'reader.Close()
            'con.Close()

            Do Until gibtes = 1

                Do Until vorhanden = 1
                    cmd.CommandText = Nothing

                    cmd.CommandText = "Select count(*) from `adressen_pool`" 'where plz = " & PoolPlz
                    con.Open()
                    reader = cmd.ExecuteReader()
                    reader.Read()
                    anzahl = reader("count(*)")
                    reader.Close()
                    con.Close()

                    Randomize()
                    zahl = CInt(Int((anzahl * Rnd()) + 1))

                    cmd.CommandText = Nothing
                    cmd.CommandText = "Select count(*) from `adressen_pool` where `Index`= " & zahl
                    con.Open()
                    reader = cmd.ExecuteReader()
                    reader.Read()
                    vorhanden = reader("count(*)")
                    reader.Close()
                    con.Close()
                Loop

                cmd.CommandText = Nothing
                cmd.CommandText = "Select `AdressNr` from `adressen_pool` where `Index`= " & zahl
                con.Open()
                reader = cmd.ExecuteReader()
                reader.Read()
                adr = reader("AdressNr")
                reader.Close()
                con.Close()


                cmd.CommandText = Nothing
                cmd.CommandText = "Select `LastCall` from `adressen` where `AdressNr`= " & adr
                con.Open()
                reader = cmd.ExecuteReader()
                reader.Read()
                diff = If(IsDBNull(reader("LastCall")), "02:00:00", reader("LastCall"))
                reader.Close()
                con.Close()

                If Now >= diff Then
                    diffJN = 1
                End If
                'cmd.CommandText = Nothing
                'cmd.CommandText = "Select if((select timediff(now()," & diff & " )) >= '02:00:00',1,0)"

                'con.Open()
                '    reader = cmd.ExecuteReader()
                '    reader.Read()
                '    diffJN = reader("Zeit")
                '    reader.Close()
                '    con.Close()

                If diffJN = 1 And vorhanden = 1 Then
                    gibtes = 1
                End If
            Loop

            cmd.CommandText = Nothing
            cmd.CommandText = "Select `AdressNr` from `adressen_pool` where `Index`= " & zahl
            con.Open()
            reader = cmd.ExecuteReader()
            reader.Read()
            adr = reader("AdressNr")
            reader.Close()
            con.Close()

        Catch ex As Exception

        Finally
            con.Close()
            cmd.Connection = Nothing
        End Try

        Return adr

    End Function

    Private Function nextKd()
        Dim idx As Integer
        idx = zufall()
        con.ConnectionString = verweis.cchhhConnectionString

        cmd.Connection = con

        cmd.CommandText = "Select * from `adressen` where `AdressNr`= " & idx


        Try
            con.Open()
            reader = cmd.ExecuteReader()
            txtKunde.Clear()
            Do While reader.Read()
                txtKunde.Text = (
                      reader("Vorname") & " " &
                      reader("Nachname") & " | " &
                      reader("Strasse") & " | " &
                      reader("PLZ") & " " &
                      reader("ORT") & " || " &
                      reader("Telefon"))
                lblLetzterAnruf.Text = If(IsDBNull(reader("LastCall")), " ", reader("LastCall"))
                str_TelNumber = reader("Telefon")
                int_AdressNr = reader("AdressNr")
                rtbNotizen.Text = reader("Notiz")
                str_Vorname = reader("Vorname")
                str_Nachname = reader("Nachname")
                str_Strasse = reader("Strasse")
                str_PLZ = reader("PLZ")
                str_Ort = reader("ORT")
                int_Anwalt = reader("AnwaltJN")
                int_ErreichtJN = reader("ErreichtJN")
                int_FlyerJN = reader("FlyerJN")
                int_InteresseJN = reader("InteresseJN")
            Loop
            reader.Close()
            con.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message & " nxtkd")
        Finally
            con.Close()
            cmd.Connection = Nothing
            SetMyCustomFormat()
            aktivieren()
            urlbauen()
        End Try

        Return 0

    End Function

    Public Sub SetMyCustomFormat()
        Dim vdat As String
        Dim bdat As String

        dtpTerminVon.Format = DateTimePickerFormat.Custom
        dtpTerminVon.CustomFormat = "dd.MM.yyyy HH:mm"
        dtpTerminBis.Format = DateTimePickerFormat.Custom
        dtpTerminBis.CustomFormat = "dd.MM.yyyy HH:mm"
        vdat = Date.Now.Day & "." & Date.Now.Month & "." & Date.Now.Year & " " & Date.Now.Hour & ":00"
        bdat = Date.Now.Day & "." & Date.Now.Month & "." & Date.Now.Year & " " & Date.Now.Hour + 1 & ":00"
        dtpTerminVon.Value = vdat
        dtpTerminBis.Value = bdat

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

            str_query = Nothing

            str_query = "UPDATE `adressen`SET `TerminJN` = 1, `Termin_von` = @dtpTerminVon.Value ,`Termin_bis` = @dtpTerminBis.Value ,`Notiz` = @rtbNotizen.Text where AdressNr =  @int_AdressNr"
            update_kd(str_query, 2)

            druckTabelle()

            str_query = "INSERT INTO `termine` (`AdressNr`,`Termin_von`,`Termin_bis`,`Telefonnummer`,`Anwender`)" &
                    "VALUES(@int_AdressNr, @dtpTerminVon.Value,@dtpTerminBis.Value,@TelNr,@Anwender);"
            update_kd(str_query, 2)

            terminkalender()

            Aktualisieren()
            deaktivieren()

        End If
    End Sub

    Private Sub btnFlyer_Click(sender As Object, e As EventArgs) Handles btnFlyer.Click

        str_query = Nothing

        str_query = "UPDATE `adressen` SET `FlyerJN` = 1 , `FlyerAm` = @now , `Anwender` = @Anwender where AdressNr = @int_AdressNr"
        update_kd(str_query, 1)


        word = Nothing
        word = New Word_Oeffnen
        word.oeffnen()


    End Sub

    Private Sub btnNeuerKunde_Click(sender As Object, e As EventArgs) Handles btnNeuerKunde.Click
        newKunde = Nothing
        newKunde = New NeuerKunde
        newKunde.Show()
    End Sub

    Private Function update_kd(ByVal query As String, ByVal entscheider As Integer)
        Dim err As Integer
        Dim cmd As New MySqlCommand
        con.ConnectionString = Nothing

        If con.ConnectionString = Nothing Then
            con.ConnectionString = verweis.cchhhConnectionString
        End If

        Try
            With cmd
                .Connection = con
                .CommandText = query

                .Parameters.AddWithValue("@int_AdressNr", int_AdressNr)
                .Parameters.AddWithValue("@Now", DateTime.Now)
                .Parameters.AddWithValue("@Notiz", Convert.ToString(rtbNotizen.Text))
                .Parameters.AddWithValue("@Anwender", CurrentDomainUser())

                If entscheider = 2 Then ' Termin in Terminzetteldrucken
                    .Parameters.AddWithValue("@dtpTerminVon.Value", dtpTerminVon.Value)
                    .Parameters.AddWithValue("@dtpTerminBis.Value", dtpTerminBis.Value)
                    .Parameters.AddWithValue("@rtbNotizen.Text", Convert.ToString(rtbNotizen.Text))
                    .Parameters.AddWithValue("@TelNr", str_TelNumber)
                    .Parameters.AddWithValue("@Anwender", CurrentDomainUser())


                ElseIf entscheider = 3 Then ' Notizen in nxtKD
                    .Parameters.AddWithValue("@rtbNotizen.Text", Convert.ToString(rtbNotizen.Text))
                ElseIf entscheider = 4 Then 'Anwender / Last Call in Anrufen
                    .Parameters.AddWithValue("@DateTime.Now", DateTime.Now)
                    .Parameters.AddWithValue("@CurrentDomainUser", CurrentDomainUser())
                End If
            End With

            con.Open()
            cmd.ExecuteNonQuery()
            err = 0
        Catch ex As Exception
            'MsgBox("Fehler" & vbCrLf & ex.Message & " updateKD")
            err = 1

        Finally
            con.Close()
            cmd.Connection = Nothing

        End Try

        Return err

    End Function

    Private Function druckTabelle()
        Dim cmd As New MySqlCommand
        Dim err As Integer
        con.ConnectionString = Nothing

        Dim query As String

        If con.ConnectionString = Nothing Then
            con.ConnectionString = verweis.cchhhConnectionString
        End If


        query = "INSERT INTO `terminzetteldruck` (`AdressNr`,`Vorname`, `Nachname`, `Strasse`, `PLZ`, `ORT`,`Termin_von`,`Termin_bis`,`Notiz`,`Telefonnummer`,`Anwender`)" &
                "VALUES(@int_AdressNr, @Vorname,@Nachname,@Strasse,@PLZ,@ORT,@dtpTerminVon.Value,@dtpTerminBis.Value,@Notizen,@TelNr,@Anwender);"

        Try
            With cmd
                .Connection = con
                .CommandText = query

                .Parameters.AddWithValue("@int_AdressNr", int_AdressNr)
                .Parameters.AddWithValue("@dtpTerminVon.Value", dtpTerminVon.Value)
                .Parameters.AddWithValue("@dtpTerminBis.Value", dtpTerminBis.Value)
                .Parameters.AddWithValue("@Vorname", str_Vorname)
                .Parameters.AddWithValue("@Nachname", str_Nachname)
                .Parameters.AddWithValue("@Strasse", str_Strasse)
                .Parameters.AddWithValue("@PLZ", str_PLZ)
                .Parameters.AddWithValue("@ORT", str_Ort)
                .Parameters.AddWithValue("@TelNr", str_TelNumber)
                .Parameters.AddWithValue("@Notizen", Convert.ToString(rtbNotizen.Text))
                .Parameters.AddWithValue("@Anwender", CurrentDomainUser())
            End With

            con.Open()
            cmd.ExecuteNonQuery()
            err = 0
        Catch ex As Exception
            'MsgBox("Fehler" & vbCrLf & ex.Message & " durcktabelle")
            err = 1

        Finally
            con.Close()
            cmd = Nothing

        End Try


        Return err


    End Function

    Private Sub aktivieren()
        Anrufen.Enabled = True
        NichtErreicht.Enabled = True
        keininteresse.Enabled = True
        ToteNummer.Enabled = True
        btnFlyer.Enabled = True
        Termin.Enabled = True
        btnWiedervorlage.Visible = True
    End Sub

    Private Sub deaktivieren()
        Anrufen.Enabled = False
        NichtErreicht.Enabled = False
        keininteresse.Enabled = False
        ToteNummer.Enabled = False
        btnFlyer.Enabled = False
        Termin.Enabled = False
    End Sub

    Private Sub Aktualisieren()

        Rep = Nothing
        Rep = New ReportViewer
        Rep.Adresse(int_AdressNr)
        Rep.Show()

    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        rtbNotizen.Visible = True
        Label1.Visible = True
        txtKunde.BackColor = SystemColors.Control
        txtKunde.ReadOnly = True
        btnKdSuche.Visible = False
        btnKdSuche.Enabled = False
        verwaltung = Nothing
        verwaltung = New Admin
        verwaltung.Show()
    End Sub

    Private Sub btnSuche_Click(sender As Object, e As EventArgs) Handles btnSuche.Click
        rtbNotizen.Visible = False
        txtKunde.Text = Nothing
        Label1.Visible = False
        txtKunde.BackColor = Color.White
        txtKunde.ReadOnly = False
        txtKunde.Select()
        deaktivieren()
        btnKdSuche.Enabled = True
        btnKdSuche.Visible = True
        lblLetzterAnruf.Visible = False
        lblLastCall.Visible = False
        btnWiedervorlage.Visible = False
        dtpTerminBis.Visible = False
        dtpTerminVon.Visible = False
        lblTerminbis.Visible = False
        lblTerminvon.Visible = False
        btnTerminZettel.Visible = False


    End Sub

    Private Sub btnKdSuche_Click(sender As Object, e As EventArgs) Handles btnKdSuche.Click

        If txtKunde.Text = Nothing Then
            MsgBox("Bitte eine AdressNr eingeben")
        Else

            int_AdressNr = CInt(txtKunde.Text)
            txtKunde.Text = " "

            con.ConnectionString = Nothing

            If con.ConnectionString = Nothing Then
                con.ConnectionString = verweis.cchhhConnectionString
            End If

            cmd.Connection = con

            cmd.CommandText = "Select * from `adressen` where `AdressNr`= " & int_AdressNr

            Try
                con.Open()
                reader = cmd.ExecuteReader()
                txtKunde.Clear()
                Do While reader.Read()
                    txtKunde.Text = (
                      reader("Vorname") & " " &
                      reader("Nachname") & " | " &
                      reader("Strasse") & " | " &
                      reader("PLZ") & " " &
                      reader("ORT") & " || " &
                      reader("Telefon"))
                    lblLetzterAnruf.Text = If(IsDBNull(reader("LastCall")), " ", reader("LastCall"))
                    str_TelNumber = reader("Telefon")
                    int_AdressNr = reader("AdressNr")
                    rtbNotizen.Text = reader("Notiz")
                    str_Vorname = reader("Vorname")
                    str_Nachname = reader("Nachname")
                    str_Strasse = reader("Strasse")
                    str_PLZ = reader("PLZ")
                    str_Ort = reader("ORT")
                    int_ErreichtJN = reader("ErreichtJN")
                    int_FlyerJN = reader("FlyerJN")
                    int_InteresseJN = reader("InteresseJN")
                Loop
                reader.Close()
                con.Close()
                rtbNotizen.Visible = True
                Label1.Visible = True
                txtKunde.BackColor = SystemColors.Control
                txtKunde.ReadOnly = True
                btnKdSuche.Visible = False
                btnKdSuche.Enabled = False
                lblLastCall.Visible = True
                lblLetzterAnruf.Visible = True
                btnWiedervorlage.Visible = True
            Catch ex As Exception
                ' MessageBox.Show(ex.Message & " nxtkd")
            Finally
                con.Close()
                cmd.Connection = Nothing
                SetMyCustomFormat()
                aktivieren()
            End Try

            btnTerminZettel.Visible = False
            dtpTerminVon.Visible = False
            dtpTerminBis.Visible = False
        End If
    End Sub

    Private Function termincheck()
        Dim anzahl As Integer
        Dim vdat As String
        Dim Stunde As Integer
        Dim Jahr As Integer
        Dim Monat As Integer
        Dim Tag As Integer
        Dim Min As Integer
        Dim err As Integer

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


        titel = str_PLZ & "," & str_Nachname & ", TelefonNr:" & str_TelNumber
        description = "Kundennummer: " & CStr(int_AdressNr)
        venue = "Ort:" & str_Ort & "," & str_Strasse

        If con.ConnectionString = Nothing Then
            con.ConnectionString = verweis.TerminplanerConnection
        End If

        query = "INSERT INTO `events`(`title`,`description`,`venue`,`user_id`,`not_mail`)
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

    Sub urlbauen()
        Try
            Dim street As String = String.Empty
            Dim city As String = String.Empty
            Dim state As String = String.Empty
            Dim zip As String = String.Empty

            Dim queryAddress As String
            queryAddress = ("http://maps.google.com/maps?q=")

            ' build street part of query string
            If str_Strasse <> String.Empty Then
                street = str_Strasse.Replace(" ", "+")
                queryAddress = queryAddress & street + "," & "+"
            End If

            ' build city part of query string
            If str_Ort <> String.Empty Then
                city = str_Ort.Replace(" ", "+")
                queryAddress = queryAddress & city + "," & "+"
            End If


            ' build zip code part of query string
            If str_PLZ <> String.Empty Then
                zip = str_PLZ.ToString()
                queryAddress = queryAddress & zip
            End If

            URL = queryAddress

        Catch ex As Exception

            MessageBox.Show(ex.Message.ToString(), "Unable to Retrieve Map")

        Finally
            googlecheck()
        End Try
    End Sub

    Sub URLOeffnen()

        maps = Nothing
        maps = New googlemaps
        maps.url(URL)

    End Sub

    Private Sub googlecheck()
        If cbGoogle.Checked = True Then
            URLOeffnen()
        End If
    End Sub

    Private Sub btnWiedervorlage_Click(sender As Object, e As EventArgs) Handles btnWiedervorlage.Click
        str_query = "DELETE FROM `adressen_pool` where AdressNr = @int_AdressNr"
        update_kd(str_query, 1)

        keininteresse.Enabled = False

        wiedervorlage()
    End Sub

    Private Sub wiedervorlage()

        wv = Nothing
        wv = New Wiedervorlage
        wv.Adresse(int_AdressNr)
        wv.Show()

    End Sub


#Region "Softphone"

    Private phoneCall As IPhoneCall
    Private phoneLine As IPhoneLine
    Private phoneLineInformation As RegState
    Private softPhone As ISoftPhone
    Private microphone As Microphone = Microphone.GetDefaultDevice()
    Private speaker As Speaker = Speaker.GetDefaultDevice()
    Private connector As MediaConnector = New MediaConnector
    Private mediaReceiver As PhoneCallAudioReceiver = New PhoneCallAudioReceiver
    Private mediaSender As PhoneCallAudioSender = New PhoneCallAudioSender
    Private inComingCall As Boolean

    Private Sub softPhone_IncommingCall(ByVal sender As Object, ByVal e As VoIPEventArgs(Of IPhoneCall))
        InvokeGUIThread(Sub()
                            labelCallStateInfo.Text = "Incoming call"
                            labelDialingNumber.Text = String.Format("from {0}", e.Item.DialInfo)
                            phoneCall = e.Item
                            WireUpCallEvents()
                            inComingCall = True
                        End Sub)
    End Sub

    Private Sub phoneLine_PhoneLineInformation(ByVal sender As Object, ByVal e As RegistrationStateChangedArgs)
        phoneLineInformation = e.State
        InvokeGUIThread(Sub()
                            labelIdentifier.Text = (TryCast(sender, IPhoneLine)).SIPAccount.DisplayName
                            If (DirectCast(e.State, RegState) = RegState.RegistrationSucceeded) Then
                                labelRegStatus.Text = "Online"
                                labelCallStateInfo.Text = "Registration succeeded"
                            Else
                                labelCallStateInfo.Text = e.State.ToString
                            End If
                        End Sub)
    End Sub

    Private Sub phoneCall_DtmfReceived(ByVal sender As Object, ByVal e As VoIPEventArgs(Of DtmfInfo))
        InvokeGUIThread(Sub()
                            Me.labelCallStateInfo.Text = String.Format("DTMF signal received: {0} ", e.Item.Signal.Signal)
                        End Sub)
    End Sub

    Private Sub WireUpCallEvents()
        AddHandler phoneCall.CallStateChanged, New EventHandler(Of CallStateChangedArgs)(AddressOf phoneCall_CallStateChanged)
        AddHandler phoneCall.DtmfReceived, New EventHandler(Of VoIPEventArgs(Of DtmfInfo))(AddressOf phoneCall_DtmfReceived)
    End Sub
    Private Sub WireDownCallEvents()
        If (Not phoneCall Is Nothing) Then
            RemoveHandler phoneCall.CallStateChanged, New EventHandler(Of CallStateChangedArgs)(AddressOf phoneCall_CallStateChanged)
            RemoveHandler phoneCall.DtmfReceived, New EventHandler(Of VoIPEventArgs(Of DtmfInfo))(AddressOf phoneCall_DtmfReceived)
        End If
    End Sub

    Private Sub InvokeGUIThread(ByVal action As Action)
        MyBase.Invoke(action)
    End Sub

    Private Sub phoneCall_CallStateChanged(ByVal sender As Object, ByVal e As CallStateChangedArgs)
        InvokeGUIThread(Sub()
                            labelCallStateInfo.Text = e.State.ToString
                        End Sub)
        Select Case e.State
            Case CallState.Answered
                microphone.Start()
                connector.Connect(microphone, mediaSender)
                speaker.Start()
                connector.Connect(mediaReceiver, speaker)
                mediaSender.AttachToCall(phoneCall)
                mediaReceiver.AttachToCall(phoneCall)

                Return
            Case CallState.Completed
                microphone.Stop()
                connector.Disconnect(microphone, mediaSender)
                speaker.Stop()
                connector.Disconnect(mediaReceiver, speaker)
                mediaSender.Detach()
                mediaReceiver.Detach()
                WireDownCallEvents()

                phoneCall = Nothing
                InvokeGUIThread(Sub()
                                    labelDialingNumber.Text = String.Empty
                                End Sub)
                Return
            Case CallState.Rejected
                Exit Select
            Case CallState.Cancelled
                WireDownCallEvents()
                phoneCall = Nothing
                Exit Select
            Case Else
                Return
        End Select
    End Sub

    ''' <summary>
    ''' It starts a call with the dialed number or in case of an incoming call it accepts, picks up the call.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub buttonPickUp_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonPickUp.Click
        If inComingCall Then
            inComingCall = False
            phoneCall.Answer()
        ElseIf ((phoneCall Is Nothing) AndAlso Not String.IsNullOrEmpty(labelDialingNumber.Text)) Then
            If (phoneLineInformation <> RegState.RegistrationSucceeded) Then
                MessageBox.Show("Phone line state is not valid!")
            Else
                phoneCall = Me.softPhone.CreateCallObject(phoneLine, labelDialingNumber.Text)
                WireUpCallEvents()
                phoneCall.Start()
            End If
        End If
    End Sub

    ''' <summary>
    ''' In case a call is in progress, it breaks the call.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub buttonHangUp_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonHangUp.Click
        If (Not phoneCall Is Nothing) Then
            If (phoneCall.CallState = CallState.Ringing AndAlso inComingCall) Then
                phoneCall.Reject()
            Else
                phoneCall.HangUp()
            End If
            inComingCall = False
            phoneCall = Nothing
        End If
        labelDialingNumber.Text = String.Empty
    End Sub

    ''' <summary>
    ''' It makes the dialing number.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub buttonKeyPadButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button9.Click, button8.Click, button7.Click, button6.Click, button5.Click, button4.Click, button3.Click, button2.Click, button12.Click, button11.Click, button10.Click, Button13.Click
        Dim btn As Button = TryCast(sender, Button)
        If (Not btn Is Nothing) Then
            If (btn.Text = "0/+") Then
                labelDialingNumber.Text = (labelDialingNumber.Text & "0")
            Else
                labelDialingNumber.Text = (labelDialingNumber.Text & btn.Text.Trim)
            End If
        End If
    End Sub

    ''' <summary>
    ''' It sends a DTMF signal according to the RFC 2833 standard.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub buttonKeyPad_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles button9.MouseUp, button8.MouseUp, button7.MouseUp, button6.MouseUp, button5.MouseUp, button4.MouseUp, button3.MouseUp, button2.MouseUp, button12.MouseUp, button11.MouseUp, button10.MouseUp, Button1.MouseUp
        If ((Not phoneCall Is Nothing) AndAlso (phoneCall.CallState = CallState.InCall)) Then
            Dim id As Integer
            Dim btn As Button = TryCast(sender, Button)
            If (((Not btn Is Nothing) AndAlso (Not btn.Tag Is Nothing)) AndAlso Integer.TryParse(btn.Tag.ToString, id)) Then
                phoneCall.StopDTMFSignal(Ozeki.Media.MediaType.Audio)
            End If
        End If
    End Sub

    ''' <summary>
    ''' It stops sending the given DTMF signal. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub buttonKeyPad_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles button9.MouseDown, button8.MouseDown, button7.MouseDown, button6.MouseDown, button5.MouseDown, button4.MouseDown, button3.MouseDown, button2.MouseDown, button12.MouseDown, button11.MouseDown, button10.MouseDown, Button1.MouseDown
        If ((Not phoneCall Is Nothing) AndAlso (phoneCall.CallState = CallState.InCall)) Then
            Dim id As Integer
            Dim btn As Button = TryCast(sender, Button)
            If (((Not btn Is Nothing) AndAlso (Not btn.Tag Is Nothing)) AndAlso Integer.TryParse(btn.Tag.ToString, id)) Then
                phoneCall.StartDTMFSignal(Ozeki.Media.MediaType.Audio, id)
            End If
        End If
    End Sub


    Private Sub InitializeSoftPhone()
        Try
            Dim ip As IPAddress = SoftPhoneFactory.GetLocalIP()
            softPhone = SoftPhoneFactory.CreateSoftPhone(ip, 5700, 5750)
            AddHandler softPhone.IncomingCall, New EventHandler(Of VoIPEventArgs(Of IPhoneCall))(AddressOf softPhone_IncommingCall)
            phoneLine = softPhone.CreatePhoneLine(New SIPAccount(True, "oz878", "oz878", "oz878", "oz878", "192.168.115.103", 5060))
            AddHandler phoneLine.RegistrationStateChanged, New EventHandler(Of RegistrationStateChangedArgs)(AddressOf phoneLine_PhoneLineInformation)
            softPhone.RegisterPhoneLine(phoneLine)
        Catch ex As Exception
            MessageBox.Show("You didn't give your local IP adress, so the program won't run properly.")
        End Try
    End Sub

    Private Sub MicrophoneVolumeTrackbar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MicrophoneVolumeTrackbar.Scroll
        Dim volume As Single
        volume = MicrophoneVolumeTrackbar.Value / 100
        microphone.Volume = volume
    End Sub

    Private Sub SpeakerVolumeTrackbar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpeakerVolumeTrackbar.Scroll
        Dim volume As Single
        volume = SpeakerVolumeTrackbar.Value / 100
        speaker.Volume = volume
    End Sub

#End Region


    Private Sub getSipAccount()

        con.ConnectionString = Nothing

        If con.ConnectionString = Nothing Then
                con.ConnectionString = verweis.cchhhConnectionString
            End If

            cmd.Connection = con

        cmd.CommandText = "Select * from `sip_account` where `Anwendername`= " & CurrentDomainUser

        Try
            con.Open()
            reader = cmd.ExecuteReader()
            txtKunde.Clear()
            Do While reader.Read()
                SIPID = reader("SIP-ID")
                SIPPassword = reader("SIP-Passwort")
                Proxy = reader("Proxy")
                Anzeigename = reader("Anzeigename")
            Loop
            reader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & " GetSipAccount")
        Finally
                con.Close()
            cmd.Connection = Nothing
        End Try


    End Sub
End Class

