
Imports KnechtRuprecht.CallCenter
Imports MySql.Data.MySqlClient



Public Class Admin
    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim reader As MySqlDataReader
    Dim cc As New CallCenter
    Dim verweis As New My.MySettings

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbPoolIndex.MaxLength = 2
        con.ConnectionString = verweis.cchhhConnectionString

        lblInsgesamt.Text = CStr(auslesen(1))
        lblImPool.Text = CStr(auslesen(2))



    End Sub

    Private Sub btnCallCenter_Click(sender As Object, e As EventArgs) Handles btnCallCenter.Click
        con = Nothing
        cmd = Nothing
        reader = Nothing
        verweis = Nothing
        cc = Nothing
        cc = New CallCenter
        cc.Show()
        Me.Close()


    End Sub


    Private Function auslesen(ByVal entscheider As Integer)
        Dim cmd As New MySqlCommand
        Dim anzahl As Integer
        anzahl = 0

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
            cmd.CommandText = "Select count(*) from `adressen_pool`"

            con.Open()
            reader = cmd.ExecuteReader()
            reader.Read()
            anzahl = reader("count(*)")
            reader.Close()

            con.Close()
        End If



        Return anzahl

    End Function

    Private Sub btnVerteilen_Click(sender As Object, e As EventArgs) Handles btnVerteilen.Click


        Try
            Dim cmd As New MySqlCommand

            If con.ConnectionString = Nothing Then
                con.ConnectionString = verweis.cchhhConnectionString
            End If

            con.Open()
            cmd.Connection = con

            cmd.CommandText = "SP_Adressen_in_Pool"
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("idx", CInt(tbPoolIndex.Text))
            cmd.Parameters("idx").Direction = ParameterDirection.Input


            cmd.Parameters.AddWithValue("err", MySqlDbType.Int16)
            cmd.Parameters("err").Direction = ParameterDirection.Output

            cmd.ExecuteNonQuery()


        Catch ex As MySql.Data.MySqlClient.MySqlException

        Finally
            con.Close()
            cmd = Nothing
            lblImPool.Text = CStr(auslesen(2))
        End Try

    End Sub
End Class