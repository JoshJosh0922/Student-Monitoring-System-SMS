Public NotInheritable Class SplashScreen1
    Dim i As Integer = 100
    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        prog()
    End Sub
    Sub prog()
        i = i - 1
        If i = 0 Then
            main.Show()
            Me.Close()
        End If
        If ProgressBar2.Value <> 100 Then
            ProgressBar2.Value = ProgressBar2.Value + 1
            Label1.Text = ProgressBar2.Value + 1 & "%"
        End If
    End Sub
End Class
