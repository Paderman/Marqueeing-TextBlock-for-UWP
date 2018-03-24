NotInheritable Class App
    Inherits Application

    Protected Overrides Sub OnLaunched(e As LaunchActivatedEventArgs)
        Dim rootFrame = TryCast(Window.Current.Content, Frame)


        If rootFrame Is Nothing Then
            rootFrame = New Frame()

            AddHandler rootFrame.NavigationFailed, AddressOf OnNavigationFailed

            If e.PreviousExecutionState = ApplicationExecutionState.Terminated Then
            End If
            Window.Current.Content = rootFrame
        End If

        Select Case e.PrelaunchActivated
            Case False
                If rootFrame.Content Is Nothing Then

                    rootFrame.Navigate(GetType(MainPage), e.Arguments)
                End If

                Window.Current.Activate()
        End Select
    End Sub


    Private Shared Sub OnNavigationFailed(sender As Object, e As NavigationFailedEventArgs)
        Throw New Exception("Failed to load Page " + e.SourcePageType.FullName)
    End Sub


    Private Sub OnSuspending(sender As Object, e As SuspendingEventArgs) Handles Me.Suspending
        Dim deferral As SuspendingDeferral = e.SuspendingOperation.GetDeferral()
        deferral.Complete()
    End Sub
End Class
