Public NotInheritable Class Splash

    'TODO: Dieses Formular kann einfach als Begrüßungsbildschirm für die Anwendung festgelegt werden, indem Sie zur Registerkarte "Anwendung"
    '  des Projekt-Designers wechseln (Menü "Projekt", Option "Eigenschaften").


    Private Sub Splash_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.Show()
        Dim anwender As String

        anwender = System.Windows.Forms.SystemInformation.UserName


        System.Threading.Thread.Sleep(5000)

        If anwender = "Dennis" Then
            Dim Admin As New KnechtRuprecht.Admin
            Admin.Show()
            Me.Close()
        Else
            Dim cc As New KnechtRuprecht.CallCenter
            cc.Show()
            Me.Close()
        End If

    End Sub

End Class
