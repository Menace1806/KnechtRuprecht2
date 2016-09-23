

Public NotInheritable Class Splash

    Private Sub Splash_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        Show()

        If My.Computer.Network.Ping("192.168.1.42", 5000) = True Then
            System.Threading.Thread.Sleep(2000)

            Dim cc As New KnechtRuprecht.CallCenter
            cc.Show()
            Close()
        Else
            MsgBox("Datenbank nicht erreichbar")
            Close()
        End If



    End Sub


End Class
