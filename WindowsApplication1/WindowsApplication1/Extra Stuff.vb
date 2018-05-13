Public Class Shop

    Dim plusamount = My.Settings.AutoClickAmount
    Dim i = plusamount
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Shop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = i
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim readValue = My.Settings.ClickCount
        i = readValue

        If readValue >= 100 Then
            MsgBox("+1 Autoclicker!")
            readValue = readValue - 100
            Dim AutoClickCount = My.Settings.AutoClickAmount
            AutoClickCount = AutoClickCount + 1
        Else
            MsgBox("You do not have enough clicks to get item, please click more!")
        End If
    End Sub
End Class