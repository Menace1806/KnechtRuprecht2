

Imports Microsoft.Win32
'''This class allows for making callto calls

Public Class CallTo

    Public ReadOnly Property Enabled() As Boolean
        Get
            Try
                Dim loReg As RegistryKey = Registry.ClassesRoot.OpenSubKey("callto", False)
                loReg.Close()
            Catch
                Return False
            End Try
            Return True
        End Get
    End Property

    ''' Does the call.
    Public Sub DoCall(ByVal destination As String)

        If Not Enabled Then Throw New ApplicationException("Callto is not enabled")
        Process.Start("callto://" & destination)

    End Sub

End Class
