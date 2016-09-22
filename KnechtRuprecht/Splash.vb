

Public NotInheritable Class Splash

    Private Sub Splash_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        Show()




        System.Threading.Thread.Sleep(2000)

        Dim cc As New KnechtRuprecht.CallCenter
        cc.Show()
        Close()

    End Sub


End Class
