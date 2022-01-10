<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xml_info
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.filename_txtbx = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.md5_hash_txtbx = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.webloc_txtbx = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.filesize_txtbx = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.localfolder_txtbx = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.locfile_txtbx = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "file_name"
        '
        'filename_txtbx
        '
        Me.filename_txtbx.Location = New System.Drawing.Point(28, 31)
        Me.filename_txtbx.Name = "filename_txtbx"
        Me.filename_txtbx.Size = New System.Drawing.Size(180, 20)
        Me.filename_txtbx.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Md5 Hash"
        '
        'md5_hash_txtbx
        '
        Me.md5_hash_txtbx.Location = New System.Drawing.Point(27, 115)
        Me.md5_hash_txtbx.Name = "md5_hash_txtbx"
        Me.md5_hash_txtbx.Size = New System.Drawing.Size(378, 20)
        Me.md5_hash_txtbx.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "web location"
        '
        'webloc_txtbx
        '
        Me.webloc_txtbx.Location = New System.Drawing.Point(27, 203)
        Me.webloc_txtbx.Name = "webloc_txtbx"
        Me.webloc_txtbx.Size = New System.Drawing.Size(378, 20)
        Me.webloc_txtbx.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "file size"
        '
        'filesize_txtbx
        '
        Me.filesize_txtbx.Location = New System.Drawing.Point(27, 154)
        Me.filesize_txtbx.Name = "filesize_txtbx"
        Me.filesize_txtbx.Size = New System.Drawing.Size(274, 20)
        Me.filesize_txtbx.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "local folder"
        '
        'localfolder_txtbx
        '
        Me.localfolder_txtbx.Location = New System.Drawing.Point(27, 70)
        Me.localfolder_txtbx.Name = "localfolder_txtbx"
        Me.localfolder_txtbx.Size = New System.Drawing.Size(179, 20)
        Me.localfolder_txtbx.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 226)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "local file location"
        '
        'locfile_txtbx
        '
        Me.locfile_txtbx.Location = New System.Drawing.Point(27, 242)
        Me.locfile_txtbx.Name = "locfile_txtbx"
        Me.locfile_txtbx.Size = New System.Drawing.Size(581, 20)
        Me.locfile_txtbx.TabIndex = 11
        '
        'xml_info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 531)
        Me.Controls.Add(Me.locfile_txtbx)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.localfolder_txtbx)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.filesize_txtbx)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.webloc_txtbx)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.md5_hash_txtbx)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.filename_txtbx)
        Me.Controls.Add(Me.Label1)
        Me.Name = "xml_info"
        Me.Text = "xml_info"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents filename_txtbx As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents md5_hash_txtbx As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents webloc_txtbx As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents filesize_txtbx As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents localfolder_txtbx As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents locfile_txtbx As System.Windows.Forms.TextBox
End Class
