Public Class Form1

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim savepoints = My.Settings.ClickCount
    Dim i = savepoints
    Dim itemautoclick = My.Settings.AutoClickAmount
    Dim itemclickpower = My.Settings.ClickPowerAmount
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Text = i
        i = i + itemclickpower
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        My.Settings.ClickCount = i
        My.Settings.ClickPowerAmount = itemclickpower

        My.Settings.Save()
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Shop.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.FirstRun = True Then
            MsgBox("Welcome to Wierdio Clicker!")
            MsgBox("It's clicking time!")
        End If


        My.Settings.FirstRun = False
        My.Settings.Save()
        My.Settings.Reload()
        Label2.Text = i
        IntervalBetweenClicks.Start()
    End Sub

    Private Sub BuyAutoClicker1_Click(sender As Object, e As EventArgs) Handles BuyAutoClicker1.Click
        If i >= 100 Then
            itemautoclick = itemautoclick + 1
            i = i - 100
            My.Settings.AutoClickAmount = itemautoclick
            Label2.Text = i
            My.Settings.Save()
            MsgBox("+1 Autoclicker!")
        Else
            MsgBox("Click a little more!")
        End If
    End Sub

    Private Sub IntervalBetweenClicks_Tick(sender As Object, e As EventArgs) Handles IntervalBetweenClicks.Tick
        i = i + itemautoclick
        Label2.Text = i
    End Sub

    Private Sub BuyClickPower1_Click(sender As Object, e As EventArgs) Handles BuyClickPower1.Click
        If i >= 1000 Then
            itemclickpower = itemclickpower + 1
            i = i - 1000
            My.Settings.ClickPowerAmount = itemclickpower
            Label2.Text = i
            My.Settings.Save()
            MsgBox("+1 Click Power!")
        Else
            MsgBox("Click a little more!")
        End If
    End Sub
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If (MouseButtons = MouseButtons.Left) Then
            drag = True
        End If
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub
End Class