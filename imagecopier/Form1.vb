Imports System.ComponentModel
Imports System.IO

Public Class Form1

    Private Delegate Sub UpdateListDelegate(ByVal itemName As String)
    Private Sub UpdateList(ByVal itemName As String)
        If Me.InvokeRequired Then
            Me.Invoke(New UpdateListDelegate(AddressOf UpdateList), itemName)
        Else
            imgList.Items.Add(itemName)
        End If
    End Sub
    Private Sub btnSelectFolder_Click(sender As Object, e As EventArgs) Handles btnSelectFolder.Click
        ' set up 
        bgw.WorkerReportsProgress = True

        bgw.WorkerSupportsCancellation = True

        ProgressBar1.Value = 0

        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            imgList.Items.Clear()
            bgw.RunWorkerAsync(10)
        End If

        If bgw.IsBusy = False Then
            bgw.RunWorkerAsync(10)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bgw_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgw.DoWork

        Dim filesListCount As Integer = New DirectoryInfo(FolderBrowserDialog1.SelectedPath).GetFiles("*", SearchOption.AllDirectories).Count

        Dim n As Integer = 1

        For Each fi As FileInfo In New DirectoryInfo(FolderBrowserDialog1.SelectedPath).GetFiles("*", SearchOption.AllDirectories)
            If Not {".jpg", ".png"}.Contains(fi.Extension) Then Continue For
            If (fi.FullName.Contains("_original")) Then Continue For
            If (fi.FullName.Contains("_preview")) Then Continue For
            If (fi.FullName.Contains("_thumbnail")) Then Continue For

            Call UpdateList(fi.FullName)
            'System.Threading.Thread.Sleep(5)
            bgw.ReportProgress((n * 100) / filesListCount)
            n = n + 1
        Next

    End Sub

    Public Sub UpdateProgress(pct As Integer)

        ' ToDo: Add error checking 
        ProgressBar1.Value = ProgressBar1.Maximum
        ProgressBar1.Value = pct

    End Sub

    Private Sub bgw_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgw.ProgressChanged

        ProgressBar1.Value = ProgressBar1.Maximum

        ProgressBar1.Value = e.ProgressPercentage

    End Sub

    Private Sub bgw_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgw.RunWorkerCompleted
        ProgressBar1.Value = 100
        MessageBox.Show("Work Complete!")
    End Sub

    Private Sub generTeImagesIndex(ByVal FolderBrowserDialog As FolderBrowserDialog)
        For Each fi As FileInfo In New DirectoryInfo(FolderBrowserDialog.SelectedPath).GetFiles("*", SearchOption.AllDirectories)
            If Not {".jpg", ".png"}.Contains(fi.Extension) Then Continue For
            imgList.Items.Add(fi.FullName)
        Next
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim DestPath As String = Application.StartupPath & "\filtered\"

        For i As Integer = 1 To imgList.Items.Count - 1

            Dim dir As String = DestPath & Split(imgList.Items(i), "\")(4)

            If Not Directory.Exists(dir) Then
                Directory.CreateDirectory(dir)
            End If

            Dim file = New FileInfo(imgList.Items(i))

            file.CopyTo(Path.Combine(dir, file.Name), True)

        Next

    End Sub

End Class
