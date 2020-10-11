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
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnSelectFolder = New System.Windows.Forms.Button()
        Me.imgList = New System.Windows.Forms.ListBox()
        Me.bgw = New System.ComponentModel.BackgroundWorker()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSelectFolder
        '
        Me.btnSelectFolder.Location = New System.Drawing.Point(12, 12)
        Me.btnSelectFolder.Name = "btnSelectFolder"
        Me.btnSelectFolder.Size = New System.Drawing.Size(88, 23)
        Me.btnSelectFolder.TabIndex = 0
        Me.btnSelectFolder.Text = "Select Folder"
        Me.btnSelectFolder.UseVisualStyleBackColor = True
        '
        'imgList
        '
        Me.imgList.FormattingEnabled = True
        Me.imgList.Location = New System.Drawing.Point(12, 44)
        Me.imgList.Name = "imgList"
        Me.imgList.Size = New System.Drawing.Size(776, 381)
        Me.imgList.TabIndex = 1
        '
        'bgw
        '
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(187, 12)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(601, 23)
        Me.ProgressBar1.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(106, 12)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Copy"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 450)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.imgList)
        Me.Controls.Add(Me.btnSelectFolder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Multi Image Copier For KroyBikroy.com"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents btnSelectFolder As Button
    Friend WithEvents imgList As ListBox
    Friend WithEvents bgw As System.ComponentModel.BackgroundWorker
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents btnSave As Button
End Class
