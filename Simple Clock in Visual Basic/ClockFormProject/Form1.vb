Public Class Form1

    Dim NewPoint As New System.Drawing.Point
    Dim X, Y As Integer
    
    Private Sub lblclose_Click(sender As System.Object, e As System.EventArgs) Handles lblclose.Click
        '' Closes Program
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        '' Set labels to Current Date and Time
        lblTime.Text = Format(Now, "hh:mm:ss tt")
        lblDate.Text = Date.Now.ToString("ddd MMMM d yyyy ")
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ''Starts time on load
        Timer1.Start()
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        ''For Form Panel Movement
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        ''For Form Panel Movement
        If e.Button = Windows.Forms.MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.X -= (X)
            NewPoint.Y -= (Y)
            Me.Location = NewPoint
        End If
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click
        '' Time Label text to speech
        Dim SAPI As Object
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak(lblTime.Text)
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click
        '' Date Label to speech
        Dim SAPI As Object
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak(lblDate.Text)
    End Sub

    
End Class
