Public Class Form1
    Dim target_top As Single = 2
    Dim gun_y As Single
    Dim speed As Single
    Dim gravity As Single
    Dim startspeed As Single
    Private Sub TmrTarget_Tick(sender As Object, e As EventArgs) Handles TmrTarget.Tick
        Target.Top -= target_top
        If Target.Top <= 2 Then
            target_top = -target_top
        End If
        If Target.Top >= 450 Then
            target_top = -target_top
        End If
    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                Gun.Top -= 40
            Case Keys.Down
                Gun.Top += 40
            Case Keys.Space
                If Bullet.Visible = False Then
                    If LblAmmo.Text > 0 Then
                        Bullet.Visible = True
                        Bullet.Location = Gun.Location
                        TmrBullet.Enabled = True
                        gravity = 0
                        speed = 10
                        If Bullet.Left >= 900 Then
                            Bullet.Left = 160
                        End If
                        LblAmmo.Text -= 1
                        speed = startspeed
                    End If
                End If
            Case Keys.R
                LblAmmo.Text = 9
        End Select
    End Sub
    Private Sub TmrBullet_Tick(sender As Object, e As EventArgs) Handles TmrBullet.Tick
        Bullet.Left += speed
        If Bullet.Left >= 950 Then
            TmrBullet.Enabled = False
            Bullet.Visible = False
        End If
        Bullet.Top += 1
        If Bullet.Bounds.IntersectsWith(Target.Bounds) Then
            startspeed -= 1
            Label1.Text += 1
            Bullet.Location = Gun.Location
            TmrBullet.Enabled = False
            Bullet.Visible = False
        End If
        gravity += 0.1
        Bullet.Top += gravity
        speed -= 0.2
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        startspeed = 30
    End Sub
End Class