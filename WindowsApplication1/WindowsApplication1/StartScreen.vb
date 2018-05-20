Public Class StartScreen
    Private Sub StartScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 20 Then
            Label3.Text = "Starting..."
        ElseIf ProgressBar1.Value = 40 Then
            Label3.Text = "Downloading fonts..."
        ElseIf ProgressBar1.Value = 60 Then
            Label3.Text = "Loading in Clicker Button..."
        ElseIf ProgressBar1.Value = 80 Then
            Label3.Text = "Loading In Clicker Counter and Store..."
        ElseIf ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Me.Hide()
            Form1.Show()
        End If
    End Sub
End Class