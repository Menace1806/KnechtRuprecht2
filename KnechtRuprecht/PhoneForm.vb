Imports System
Imports System.Net
Imports Ozeki.Media
Imports Ozeki.VoIP


Public Class PhoneForm

    ' Fields
    Private phoneCall As IPhoneCall
    Private phoneLine As IPhoneLine
    Private phoneLineInformation As RegState
    Private softPhone As ISoftPhone
    Private microphone As Microphone = microphone.GetDefaultDevice()
    Private speaker As Speaker = speaker.GetDefaultDevice()
    Private connector As MediaConnector = New MediaConnector
    Private mediaReceiver As PhoneCallAudioReceiver = New PhoneCallAudioReceiver
    Private mediaSender As PhoneCallAudioSender = New PhoneCallAudioSender
    Private inComingCall As Boolean

    Private Sub PhoneMain_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'statusbLabel_Ozeki.Text = String.Format("© Copyright {0}, Ozeki Informatics Ltd.", DateTime.Now.Year)
        InitializeSoftPhone()
    End Sub

#Region "Ozeki VoIP-SIP SDK's events"

    ''' <summary>
    '''  Occurs when an incoming call request has received.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub softPhone_IncommingCall(ByVal sender As Object, ByVal e As VoIPEventArgs(Of IPhoneCall))
        InvokeGUIThread(Sub()
                            labelCallStateInfo.Text = "Incoming call"
                            labelDialingNumber.Text = String.Format("from {0}", e.Item.DialInfo)
                            phoneCall = e.Item
                            WireUpCallEvents()
                            inComingCall = True
                        End Sub)
        End Sub
    ''' <summary>
    ''' Occurs when phone line state has changed.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
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
    ''' <summary>
    ''' Occurs when the phone call state has changed.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
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
    ''' Displays DTMF signals.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub phoneCall_DtmfReceived(ByVal sender As Object, ByVal e As VoIPEventArgs(Of DtmfInfo))
        InvokeGUIThread(Sub()
                            Me.labelCallStateInfo.Text = String.Format("DTMF signal received: {0} ", e.Item.Signal.Signal)
                        End Sub)
    End Sub

#End Region

#Region "Keypad events"

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
    Private Sub buttonKeyPadButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button9.Click, button8.Click, button7.Click, button6.Click, button5.Click, button4.Click, button3.Click, button2.Click, button12.Click, button11.Click, button10.Click, button1.Click
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
    Private Sub buttonKeyPad_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles button9.MouseUp, button8.MouseUp, button7.MouseUp, button6.MouseUp, button5.MouseUp, button4.MouseUp, button3.MouseUp, button2.MouseUp, button12.MouseUp, button11.MouseUp, button10.MouseUp, button1.MouseUp
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
    Private Sub buttonKeyPad_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles button9.MouseDown, button8.MouseDown, button7.MouseDown, button6.MouseDown, button5.MouseDown, button4.MouseDown, button3.MouseDown, button2.MouseDown, button12.MouseDown, button11.MouseDown, button10.MouseDown, button1.MouseDown
        If ((Not phoneCall Is Nothing) AndAlso (phoneCall.CallState = CallState.InCall)) Then
            Dim id As Integer
            Dim btn As Button = TryCast(sender, Button)
            If (((Not btn Is Nothing) AndAlso (Not btn.Tag Is Nothing)) AndAlso Integer.TryParse(btn.Tag.ToString, id)) Then
                phoneCall.StartDTMFSignal(Ozeki.Media.MediaType.Audio, id)
            End If
        End If
    End Sub

#End Region

#Region "Helper funcions"

    ''' <summary>
    ''' It initializes a softphone object with a SIP BPX, and it is for requisiting a SIP account that is nedded for a SIP PBX service. It registers this SIP
    ''' account to the SIP PBX through an ’IphoneLine’ object which represents the telephoneline. 
    ''' If the telephone registration is successful we have a call ready softphone. In this example the softphone can be reached by dialing the number 891.
    ''' </summary>
    ''' <remarks></remarks>
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

    ''' <summary>
    ''' It signs up to the necessary events of a call transact.
    ''' </summary>
    ''' <remarks></remarks>
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


    ''' <summary>
    ''' The controls of the Windows Form applications can only be modified on the GUI thread. This method grants access to the GUI thread.
    ''' </summary>
    ''' <param name="action"></param>
    ''' <remarks></remarks>
    Private Sub InvokeGUIThread(ByVal action As Action)
        MyBase.Invoke(action)
    End Sub

#End Region

#Region "Menu events"

    Private Sub exitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    'Private Sub aboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aboutToolStripMenuItem.Click
    '    Dim aboutForm As New AboutForm()
    '    aboutForm.ShowDialog(Me)
    'End Sub

    Private Sub Tsmi_HelpPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tsmi_HelpPage.Click
        Try
            Process.Start("http://www.voip-sip-sdk.com/p_179-vb-net-windows-forms-softphone-voip.html")
        Catch exception As Exception
            Debug.WriteLine(exception)
        End Try
    End Sub

#End Region


    Private Sub PhoneForm_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        softPhone.Close()
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
End Class
