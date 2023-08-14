<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadingScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ProgLoad1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblprog = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblstatus = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ProgLoad1
        '
        Me.ProgLoad1.Location = New System.Drawing.Point(-1, 471)
        Me.ProgLoad1.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgLoad1.Name = "ProgLoad1"
        Me.ProgLoad1.Size = New System.Drawing.Size(1069, 28)
        Me.ProgLoad1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Goudy Stout", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Thistle
        Me.Label1.Location = New System.Drawing.Point(436, 516)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "WELCOME"
        '
        'lblprog
        '
        Me.lblprog.AutoSize = True
        Me.lblprog.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprog.ForeColor = System.Drawing.Color.Thistle
        Me.lblprog.Location = New System.Drawing.Point(997, 437)
        Me.lblprog.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblprog.Name = "lblprog"
        Me.lblprog.Size = New System.Drawing.Size(51, 20)
        Me.lblprog.TabIndex = 2
        Me.lblprog.Text = "000%"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 20
        '
        'lblstatus
        '
        Me.lblstatus.AutoSize = True
        Me.lblstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstatus.ForeColor = System.Drawing.Color.Thistle
        Me.lblstatus.Location = New System.Drawing.Point(16, 437)
        Me.lblstatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(68, 20)
        Me.lblstatus.TabIndex = 3
        Me.lblstatus.Text = "Loading"
        '
        'LoadingScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = Global.WonderPrints_Project.My.Resources.Resources.wonderprints_logo3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.lblstatus)
        Me.Controls.Add(Me.lblprog)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgLoad1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "LoadingScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoadingScreen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProgLoad1 As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents lblprog As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblstatus As Label
End Class
