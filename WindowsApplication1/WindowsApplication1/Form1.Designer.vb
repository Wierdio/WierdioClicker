<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextPartThing = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BuyAutoClicker1 = New System.Windows.Forms.Button()
        Me.IntervalBetweenClicks = New System.Windows.Forms.Timer(Me.components)
        Me.BuyClickPower1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.WierdioClicker.My.Resources.Resources.wierdio_clicker_logo
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("ObelixPro", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(252, 323)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 90)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextPartThing
        '
        Me.TextPartThing.AutoSize = True
        Me.TextPartThing.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextPartThing.Location = New System.Drawing.Point(213, 45)
        Me.TextPartThing.Name = "TextPartThing"
        Me.TextPartThing.Size = New System.Drawing.Size(154, 31)
        Me.TextPartThing.TabIndex = 1
        Me.TextPartThing.Text = "Click Count"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(292, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 31)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "0"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonClose
        '
        Me.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonClose.FlatAppearance.BorderSize = 0
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Location = New System.Drawing.Point(590, -1)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(16, 21)
        Me.ButtonClose.TabIndex = 3
        Me.ButtonClose.Text = "X"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(498, 390)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Shop"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'BuyAutoClicker1
        '
        Me.BuyAutoClicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuyAutoClicker1.Location = New System.Drawing.Point(12, 149)
        Me.BuyAutoClicker1.Name = "BuyAutoClicker1"
        Me.BuyAutoClicker1.Size = New System.Drawing.Size(140, 93)
        Me.BuyAutoClicker1.TabIndex = 5
        Me.BuyAutoClicker1.Text = "Buy +1 Autoclicker (1cps) - 100 clicks"
        Me.BuyAutoClicker1.UseVisualStyleBackColor = True
        '
        'IntervalBetweenClicks
        '
        Me.IntervalBetweenClicks.Enabled = True
        Me.IntervalBetweenClicks.Interval = 1000
        '
        'BuyClickPower1
        '
        Me.BuyClickPower1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuyClickPower1.Location = New System.Drawing.Point(454, 149)
        Me.BuyClickPower1.Name = "BuyClickPower1"
        Me.BuyClickPower1.Size = New System.Drawing.Size(140, 93)
        Me.BuyClickPower1.TabIndex = 6
        Me.BuyClickPower1.Text = "Add Click Power (+1) - 1000 clicks"
        Me.BuyClickPower1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.ClientSize = New System.Drawing.Size(606, 455)
        Me.Controls.Add(Me.BuyClickPower1)
        Me.Controls.Add(Me.BuyAutoClicker1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextPartThing)
        Me.Controls.Add(Me.Button1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextPartThing As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonClose As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents BuyAutoClicker1 As Button
    Friend WithEvents IntervalBetweenClicks As Timer
    Friend WithEvents BuyClickPower1 As Button
End Class
