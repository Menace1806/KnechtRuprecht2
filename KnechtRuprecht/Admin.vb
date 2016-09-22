
Imports MySql.Data.MySqlClient

Public Class Admin
    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim reader As MySqlDataReader
    Dim verweis As New My.MySettings
    Dim regio As Integer
    Dim stat As Integer

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbPoolIndex.MaxLength = 2
        con.ConnectionString = verweis.cchhhConnectionString
        update_uebrig()
        auslesen(5)
        lblInsgesamt.Text = CStr(auslesen(1))
        lblImPool.Text = CStr(auslesen(2))
        lblRest.Text = CStr(auslesen(3))
        lblWelcherPool.Text = CStr(auslesen(4))
        regionen()

    End Sub
    Private Function auslesen(ByVal entscheider As Integer)
        Dim cmd As New MySqlCommand
        Dim anzahl As Integer
        anzahl = 0
        con.ConnectionString = Nothing

        If con.ConnectionString = Nothing Then
            con.ConnectionString = verweis.cchhhConnectionString
        End If

        If entscheider = 1 Then
            cmd.Connection = con
            cmd.CommandText = "Select count(*) from `adressen`"

            con.Open()
            reader = cmd.ExecuteReader()
            reader.Read()
            anzahl = reader("count(*)")
            reader.Close()

            con.Close()
        ElseIf entscheider = 2 Then
            cmd.Connection = con
            cmd.CommandText = "Select Insgesamt from `statistik_pool` where Nr = " & stat
            con.Open()
            reader = cmd.ExecuteReader()
            reader.Read()
            anzahl = reader("Insgesamt")
            reader.Close()
            con.Close()
        ElseIf entscheider = 3 Then
            cmd.Connection = con
            cmd.CommandText = "Select Übrig from `statistik_pool` where Nr = " & stat
            con.Open()
            reader = cmd.ExecuteReader()
            reader.Read()
            anzahl = reader("Übrig")
            reader.Close()

            con.Close()
        ElseIf entscheider = 4 Then
            cmd.Connection = con
            cmd.CommandText = "Select Regio_code from `adressen_pool`"

            con.Open()
            reader = cmd.ExecuteReader()
            reader.Read()
            anzahl = reader("Regio_code")
            regio = reader("Regio_code")
            reader.Close()

            con.Close()
        ElseIf entscheider = 5 Then
            cmd.Connection = con
            cmd.CommandText = "Select Stat_Nr from `adressen_pool`"

            con.Open()
            reader = cmd.ExecuteReader()
            reader.Read()
            stat = reader("Stat_Nr")
            reader.Close()

            con.Close()
        End If

        Return anzahl

    End Function
    Private Sub btnVerteilen_Click(sender As Object, e As EventArgs) Handles btnVerteilen.Click

        Try
            update_stat()
            Dim cmd As New MySqlCommand
            con.ConnectionString = Nothing

            If con.ConnectionString = Nothing Then
                con.ConnectionString = verweis.cchhhConnectionString
            End If

            con.Open()
            cmd.Connection = con

            cmd.CommandText = "SP_Adressen_in_Pool"
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("idx", CInt(tbPoolIndex.Text))
            cmd.Parameters("idx").Direction = ParameterDirection.Input

            cmd.ExecuteNonQuery()


        Catch ex As MySql.Data.MySqlClient.MySqlException

        Finally
            con.Close()
            cmd = Nothing
            lblImPool.Text = CStr(auslesen(2))
        End Try
        Close()

    End Sub
    Private Sub update_stat()
        Dim cmd As New MySqlCommand
        con.ConnectionString = Nothing
        If con.ConnectionString = Nothing Then
            con.ConnectionString = verweis.cchhhConnectionString
        End If
        auslesen(4)
        auslesen(5)

        Try
            With cmd
                .Connection = con
                .CommandText = "UPDATE `statistik_pool` SET `Deaktiviert_AM` = @Jetzt where Nr = @Stat and Regio_code = @Regio"

                .Parameters.AddWithValue("@Jetzt", DateTime.Now)
                .Parameters.AddWithValue("@Stat", stat)
                .Parameters.AddWithValue("@Regio", regio)


            End With

            con.Open()
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Fehler" & vbCrLf & ex.Message & " update_statistik")


        Finally
            con.Close()
            cmd.Connection = Nothing

        End Try

    End Sub
    Private Sub regionen()
        auslesen(4)
        con.ConnectionString = Nothing

        If con.ConnectionString = Nothing Then
            con.ConnectionString = verweis.cchhhConnectionString
        End If
        Try
            cmd.Connection = con
            cmd.CommandText = "Select * from `plz_regiocode` where regionidx = " & regio
            con.Open()
            reader = cmd.ExecuteReader()
            Do While reader.Read()
                lstRegionen.Items.Add(
                      reader("PLZ") & "|" &
                      reader("Stadtteil")
                      )
            Loop
            reader.Close()
        Catch ex As Exception

        Finally
            con.Close()
            cmd = Nothing
        End Try

        con.Close()
    End Sub
    Private Sub update_uebrig()
        Dim cmd As New MySqlCommand
        con.ConnectionString = Nothing

        If con.ConnectionString = Nothing Then
            con.ConnectionString = verweis.cchhhConnectionString
        End If
        auslesen(4)
        auslesen(5)

        Try
            With cmd
                .Connection = con
                .CommandText = "UPDATE `statistik_pool` SET `Übrig` = (select count(*) from adressen_pool) where Nr = @Stat and Regio_code = @Regio "

                .Parameters.AddWithValue("@Jetzt", DateTime.Now)
                .Parameters.AddWithValue("@Stat", stat)
                .Parameters.AddWithValue("@Regio", regio)


            End With

            con.Open()
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            'MsgBox("Fehler" & vbCrLf & ex.Message & " update_statistik")


        Finally
            con.Close()
            cmd.Connection = Nothing

        End Try

    End Sub

End Class