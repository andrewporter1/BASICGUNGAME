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
        Me.TmrTarget = New System.Windows.Forms.Timer(Me.components)
        Me.Bullet = New System.Windows.Forms.PictureBox()
        Me.Gun = New System.Windows.Forms.PictureBox()
        Me.Target = New System.Windows.Forms.PictureBox()
        Me.TmrBullet = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblAmmo = New System.Windows.Forms.Label()
        Me.LblAmmoText = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.Bullet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gun, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Target, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TmrTarget
        '
        Me.TmrTarget.Enabled = True
        Me.TmrTarget.Interval = 10
        '
        'Bullet
        '
        Me.Bullet.Image = Global.gungame.My.Resources.Resources.bullet1
        Me.Bullet.Location = New System.Drawing.Point(168, 403)
        Me.Bullet.Name = "Bullet"
        Me.Bullet.Size = New System.Drawing.Size(50, 25)
        Me.Bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Bullet.TabIndex = 3
        Me.Bullet.TabStop = False
        Me.Bullet.Visible = False
        '
        'Gun
        '
        Me.Gun.Image = Global.gungame.My.Resources.Resources.gun
        Me.Gun.Location = New System.Drawing.Point(12, 384)
        Me.Gun.Name = "Gun"
        Me.Gun.Size = New System.Drawing.Size(150, 100)
        Me.Gun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Gun.TabIndex = 1
        Me.Gun.TabStop = False
        '
        'Target
        '
        Me.Target.Image = Global.gungame.My.Resources.Resources.target
        Me.Target.Location = New System.Drawing.Point(872, 12)
        Me.Target.Name = "Target"
        Me.Target.Size = New System.Drawing.Size(100, 100)
        Me.Target.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Target.TabIndex = 0
        Me.Target.TabStop = False
        '
        'TmrBullet
        '
        Me.TmrBullet.Interval = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(877, 411)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 73)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "0"
        '
        'LblAmmo
        '
        Me.LblAmmo.AutoSize = True
        Me.LblAmmo.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAmmo.Location = New System.Drawing.Point(877, 479)
        Me.LblAmmo.Name = "LblAmmo"
        Me.LblAmmo.Size = New System.Drawing.Size(69, 73)
        Me.LblAmmo.TabIndex = 7
        Me.LblAmmo.Text = "9"
        '
        'LblAmmoText
        '
        Me.LblAmmoText.AutoSize = True
        Me.LblAmmoText.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAmmoText.Location = New System.Drawing.Point(392, 479)
        Me.LblAmmoText.Name = "LblAmmoText"
        Me.LblAmmoText.Size = New System.Drawing.Size(470, 73)
        Me.LblAmmoText.TabIndex = 8
        Me.LblAmmoText.Text = "AMMO LEFT ="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(541, 406)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(339, 73)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "SCORE = "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblAmmoText)
        Me.Controls.Add(Me.LblAmmo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Bullet)
        Me.Controls.Add(Me.Gun)
        Me.Controls.Add(Me.Target)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Bullet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gun, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Target, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Target As PictureBox
    Friend WithEvents TmrTarget As Timer
    Friend WithEvents Gun As PictureBox
    Friend WithEvents Bullet As PictureBox
    Friend WithEvents TmrBullet As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents LblAmmo As Label
    Friend WithEvents LblAmmoText As Label
    Friend WithEvents Label2 As Label
End Class
