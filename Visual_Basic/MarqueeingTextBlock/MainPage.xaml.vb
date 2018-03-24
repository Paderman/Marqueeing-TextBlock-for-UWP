Public NotInheritable Class MainPage
    Inherits Page

    Protected Overrides Sub OnNavigatedTo(e As NavigationEventArgs)
        Storyboard1.Begin()
    End Sub
End Class
