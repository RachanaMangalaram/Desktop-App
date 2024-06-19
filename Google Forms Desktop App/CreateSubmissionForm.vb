Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()
    Private Sub btnToogleStopWatch_Click(sender As Object, e As EventArgs) Handles btnToogleStopWatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
        Else
            stopwatch.Start()
        End If
        UpdateStopwatchLabel()
    End Sub

    Private Sub UpdateStopwatchLabel()
        txttogglestopwatch.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim labelname As String = txtName.Text
        Dim lblemail As String = txtemail.Text
        Dim lblphone As String = txtphone.Text
        Dim lblgithublink As String = txtgithublink.Text
        Dim btnToogleStopWatch As String = txttogglestopwatch.Text

        ' API call to submit data
        ' Example: SubmitData(name, email, phone, githubLink, stopwatchTime)
    End Sub
End Class