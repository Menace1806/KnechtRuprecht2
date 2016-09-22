
Public Class googlemaps

    Public Function url(ByVal URI As String)

        Dim p() As Process

        p = Process.GetProcessesByName("Firefox")
        If p.Count > 0 Then
            Process.GetProcessesByName("Firefox")(0).CloseMainWindow()
            Threading.Thread.Sleep(2000)
            Process.GetProcessesByName("Firefox")(0).Start(URI)
        Else
            Process.GetProcessesByName("Firefox")(0).Start(URI)
        End If

        Return Nothing

    End Function


End Class
