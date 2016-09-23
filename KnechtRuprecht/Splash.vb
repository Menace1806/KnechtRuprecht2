

Public NotInheritable Class Splash

    Private Sub Splash_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        Show()

        If My.Computer.Network.Ping("192.168.1.42", 5000) = False Then
            MsgBox("Datenbank nicht erreichbar")
        Else
            System.Threading.Thread.Sleep(2000)

            Dim cc As New KnechtRuprecht.CallCenter
            cc.Show()
            Close()
        End If



    End Sub


End Class
