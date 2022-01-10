<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.launchbtn1 = New System.Windows.Forms.Button()
        Me.launchbtn2 = New System.Windows.Forms.Button()
        Me.exitbtn = New System.Windows.Forms.Button()
        Me.verifybtn = New System.Windows.Forms.Button()
        Me.rebirth_splash_browser = New System.Windows.Forms.WebBrowser()
        Me.console_chxbx = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'launchbtn1
        '
        Me.launchbtn1.Location = New System.Drawing.Point(22, 37)
        Me.launchbtn1.Name = "launchbtn1"
        Me.launchbtn1.Size = New System.Drawing.Size(191, 42)
        Me.launchbtn1.TabIndex = 0
        Me.launchbtn1.UseVisualStyleBackColor = True
        Me.launchbtn1.Visible = False
        '
        'launchbtn2
        '
        Me.launchbtn2.Location = New System.Drawing.Point(24, 100)
        Me.launchbtn2.Name = "launchbtn2"
        Me.launchbtn2.Size = New System.Drawing.Size(189, 46)
        Me.launchbtn2.TabIndex = 1
        Me.launchbtn2.UseVisualStyleBackColor = True
        Me.launchbtn2.Visible = False
        '
        'exitbtn
        '
        Me.exitbtn.Location = New System.Drawing.Point(823, 530)
        Me.exitbtn.Name = "exitbtn"
        Me.exitbtn.Size = New System.Drawing.Size(102, 46)
        Me.exitbtn.TabIndex = 2
        Me.exitbtn.Text = "Exit"
        Me.exitbtn.UseVisualStyleBackColor = True
        '
        'verifybtn
        '
        Me.verifybtn.Location = New System.Drawing.Point(681, 530)
        Me.verifybtn.Name = "verifybtn"
        Me.verifybtn.Size = New System.Drawing.Size(120, 46)
        Me.verifybtn.TabIndex = 3
        Me.verifybtn.Text = "Verify Files"
        Me.verifybtn.UseVisualStyleBackColor = True
        '
        'rebirth_splash_browser
        '
        Me.rebirth_splash_browser.Location = New System.Drawing.Point(227, 11)
        Me.rebirth_splash_browser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.rebirth_splash_browser.Name = "rebirth_splash_browser"
        Me.rebirth_splash_browser.ScrollBarsEnabled = False
        Me.rebirth_splash_browser.Size = New System.Drawing.Size(698, 513)
        Me.rebirth_splash_browser.TabIndex = 4
        '
        'console_chxbx
        '
        Me.console_chxbx.AutoSize = True
        Me.console_chxbx.Location = New System.Drawing.Point(24, 165)
        Me.console_chxbx.Name = "console_chxbx"
        Me.console_chxbx.Size = New System.Drawing.Size(111, 17)
        Me.console_chxbx.TabIndex = 5
        Me.console_chxbx.Text = "Start with Console"
        Me.console_chxbx.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 588)
        Me.Controls.Add(Me.console_chxbx)
        Me.Controls.Add(Me.rebirth_splash_browser)
        Me.Controls.Add(Me.verifybtn)
        Me.Controls.Add(Me.exitbtn)
        Me.Controls.Add(Me.launchbtn2)
        Me.Controls.Add(Me.launchbtn1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.Text = "Play.CityofHeroesRebirth.com"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents launchbtn1 As System.Windows.Forms.Button
    Friend WithEvents launchbtn2 As System.Windows.Forms.Button
    Friend WithEvents exitbtn As System.Windows.Forms.Button
    Friend WithEvents verifybtn As System.Windows.Forms.Button
    Friend WithEvents rebirth_splash_browser As System.Windows.Forms.WebBrowser
    Friend WithEvents console_chxbx As System.Windows.Forms.CheckBox

End Class
