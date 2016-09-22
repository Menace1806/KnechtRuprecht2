
Imports MySql.Data.MySqlClient

Public Class CallCenter
    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim reader As MySqlDataReader
    Dim verweis As New My.MySettings
    Dim loCallTo As New CallTo
    Dim druck As New Word_Oeffnen
    Dim newKunde As New NeuerKunde

    Dim Random As Integer
    Dim int_AdressNr As Integer
    Dim str_TelNumber As String
    Dim str_Strasse As String
    Dim str_Hausnummer As String
    Dim str_PLZ As String
    Dim str_Nachname As String
    Dim str_Vorname As String
    Dim str_Ort As String
    Dim int_InteresseJN As Integer
    Dim int_TotJN As Integer
    Dim int_Anwalt As Integer
    Dim int_FlyerJN As Integer
    Dim int_TerminJN As Integer
    Dim str_Notizen As String
    Dim int_ErreichtJN As Integer
    Dim dat_LastCall As Date
    Dim dat_TerminVon As Date
    Dim dat_TerminBis As Date
    Dim str_query As String



    Public Shared ReadOnly Property CurrentDomainUser() As String
        Get
            Dim name As String
            name = System.Windows.Forms.SystemInformation.UserName
            CurrentDomainUser = name

        End Get
    End Property



    Private Sub CallCenter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim verweis As New My.MySettings

        Anrufen.Enabled = loCallTo.Enabled
        Text = verweis.ApplicationName & " || User: " & CurrentDomainUser
        con.ConnectionString = verweis.cchhhConnectionString

        dtpTerminBis.Visible = False
        dtpTerminVon.Visible = False
        lblTerminbis.Visible = False
        lblTerminvon.Visible = False
        btnTerminZettel.Visible = False

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

    End Sub

    Private Sub NichtErreicht_Click(sender As Object, e As EventArgs) Handles NichtErreicht.Click
        str_query = Nothing

        str_query = "UPDATE `adressen`SET `ErreichtJN` = 1 where AdressNr =  @int_AdressNr"

        update_kd(str_query, 1)
    End Sub

    Private Sub ToteNummer_Click(sender As Object, e As EventArgs) Handles ToteNummer.Click
        str_query = Nothing

        str_query = "UPDATE `adressen`SET `TotJN` = 1 where AdressNr = @int_AdressNr"

        update_kd(str_query, 1)
    End Sub

    Private Sub Anwalt_Click(sender As Object, e As EventArgs) Handles Anwalt.Click
        str_query = Nothing

        str_query = "UPDATE `adressen`SET `AnwaltJN` = 1 where AdressNr = @int_AdressNr"

        update_kd(str_query, 1)
    End Sub

    Private Sub keininteresse_Click(sender As Object, e As EventArgs) Handles keininteresse.Click
        str_query = Nothing

        str_query = "UPDATE `adressen`SET `InteresseJN` = 1 where AdressNr = @int_AdressNr"

        update_kd(str_query, 1)
    End Sub

    Public Function zufall()

        Dim zahl As Integer
        Dim anzahl As Integer

        anzahl = 0
        zahl = 0


        cmd.Connection = con
        cmd.CommandText = "Select count(*) from `adressen_pool`"
        Try
            con.Open()
            reader = cmd.ExecuteReader()
            reader.Read()
            anzahl = reader("count(*)")
            reader.Close()
        Catch ex As Exception

        Finally
            con.Close()
            Randomize()
            zahl = CInt(Int((anzahl * Rnd()) + 1))
            cmd.Connection = Nothing
        End Try

        Return zahl

    End Function

    Private Function nextKd()
        Dim idx As Integer
        idx = zufall()

        If con.ConnectionString = Nothing Then
            con.ConnectionString = verweis.cchhhConnectionString
        End If

        cmd.Connection = con

        cmd.CommandText = "Select * from `adressen_pool` where `Index`= " & idx

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
                      reader("ORT"))
                str_TelNumber = reader("Telefon")
                int_AdressNr = reader("AdressNr")
                rtbNotizen.Text = reader("Notiz")
                str_Vorname = reader("Vorname")
                str_Nachname = reader("Nachname")
                str_Strasse = reader("Strasse")
                str_PLZ = reader("PLZ")
                str_Ort = reader("ORT")
            Loop
            reader.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & " nxtkd")
        Finally
            con.Close()
            cmd.Connection = Nothing
        End Try

        Return 0

    End Function


    Public Sub SetMyCustomFormat()
        dtpTerminVon.Format = DateTimePickerFormat.Custom
        dtpTerminVon.CustomFormat = "dd.MM.yyyy HH:00"
        dtpTerminBis.Format = DateTimePickerFormat.Custom
        dtpTerminBis.CustomFormat = "dd.MM.yyyy HH:00"
        dtpTerminVon.Value = DateTime.Now
        dtpTerminBis.Value = DateTime.Now.AddHours(1)

    End Sub

    Private Sub dtpTerminVon_ValueChanged(sender As Object, e As EventArgs) Handles dtpTerminVon.ValueChanged
        dtpTerminBis.Value = dtpTerminVon.Value.AddHours(1)

    End Sub

    Private Sub dtpTerminBis_ValueChanged(sender As Object, e As EventArgs) Handles dtpTerminBis.ValueChanged
        dtpTerminVon.Value = dtpTerminBis.Value.AddHours(-1)

    End Sub

    Private Sub btnTerminZettel_Click(sender As Object, e As EventArgs) Handles btnTerminZettel.Click
        str_query = Nothing

        str_query = "UPDATE `adressen`SET `TerminJN` = 1, `Termin_von` = @dtpTerminVon.Value ,`Termin_bis` = @dtpTerminBis.Value ,`Notiz` = @rtbNotizen.Text where AdressNr =  @int_AdressNr"

        update_kd(str_query, 2)

        druckTabelle()

        drucken(1)

    End Sub

    Private Sub btnFlyer_Click(sender As Object, e As EventArgs) Handles btnFlyer.Click

        str_query = Nothing

        str_query = "UPDATE `adressen`SET `FlyerJN` = 1 where AdressNr = @int_AdressNr"

        update_kd(str_query, 1)

        drucken(2)
    End Sub

    Private Sub drucken(ByVal art As Integer)
        druck.oeffnen(art, int_AdressNr)
    End Sub

    Private Sub btnNeuerKunde_Click(sender As Object, e As EventArgs) Handles btnNeuerKunde.Click
        newKunde = Nothing
        newKunde = New NeuerKunde
        newKunde.Show()
    End Sub


    Private Function update_kd(ByVal query As String, ByVal entscheider As Integer)
        Dim err As Integer
        Dim cmd As New MySqlCommand

        Try
            With cmd
                .Connection = con
                .CommandText = query

                .Parameters.AddWithValue("@int_AdressNr", int_AdressNr)

                If entscheider = 2 Then ' Termin in Terminzetteldrucken
                    .Parameters.AddWithValue("@dtpTerminVon.Value", dtpTerminVon.Value)
                    .Parameters.AddWithValue("@dtpTerminBis.Value", dtpTerminBis.Value)
                    .Parameters.AddWithValue("@rtbNotizen.Text", Convert.ToString(rtbNotizen.Text))
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
            MsgBox("Fehler" & vbCrLf & ex.Message & " updateKD")
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

        Dim query As String

        If con.ConnectionString = Nothing Then
            con.ConnectionString = verweis.cchhhConnectionString
        End If


        query = "INSERT INTO `terminzetteldruck` (`AdressNr`,`Vorname`, `Nachname`, `Strasse`, `PLZ`, `ORT`,`Termin_von`,`Termin_bis`)" &
                "VALUES(@int_AdressNr, @Vorname,@Nachname,@Strasse,@PLZ,@ORT,@dtpTerminVon.Value,@dtpTerminBis.Value);"

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

            End With

            con.Open()
            cmd.ExecuteNonQuery()
            err = 0
        Catch ex As Exception
            MsgBox("Fehler" & vbCrLf & ex.Message & " durcktabelle")
            err = 1

        Finally
            con.Close()
            cmd = Nothing

        End Try


        Return err


    End Function





End Class

