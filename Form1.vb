Imports System.IO
Public Class Form1
    Private Sub HasValidPaths()
        BtnRunSync.Enabled = Not String.IsNullOrWhiteSpace(TxtSource.Text) AndAlso Not String.IsNullOrWhiteSpace(TxtDestination.Text)
    End Sub
    Private Sub BtnSearchSource_Click(sender As Object, e As EventArgs) Handles BtnSearchSource.Click
        Dim sourcefolder As New FolderBrowserDialog
        If sourcefolder.ShowDialog = DialogResult.OK Then
            TxtSource.Text = sourcefolder.SelectedPath + "\"
        End If
        HasValidPaths()
    End Sub

    Private Sub BtnSeachnDestination_Click(sender As Object, e As EventArgs) Handles BtnSeachnDestination.Click
        Dim destinationfolder As New FolderBrowserDialog
        If destinationfolder.ShowDialog = DialogResult.OK Then
            TxtDestination.Text = destinationfolder.SelectedPath + "\"
        End If
        HasValidPaths()
    End Sub

    Private Sub BtnRunSync_Click(sender As Object, e As EventArgs) Handles BtnRunSync.Click
        Dim files As String() = Directory.GetFiles(TxtSource.Text)
        For Each file As String In files
            Dim fileinfo As String() = file.Replace(TxtSource.Text, "").Replace(" REV.", "").Replace(" ", ".").Split(".")
            Dim name As String = fileinfo(0)
            Dim rev As String = fileinfo(1)
            Dim extension As String = "." + fileinfo(2)
            Dim otherinfo As String() = name.Split("-")
            Dim type As Integer = otherinfo(0)
            Dim department As String = otherinfo(1).Substring(0, 2)
            Dim division As String = otherinfo(1).Substring(2, 2)
            Dim consecutive As String = otherinfo(2)
        Next
    End Sub
End Class
