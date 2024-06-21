Imports Newtonsoft.Json

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

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim submission As New Submission(txtName.Text, txtemail.Text, txtphone.Text, txtgithublink.Text, txttogglestopwatch.Text)

        Dim url As String = "http://localhost:3000/submit"
        Dim json As String = JsonConvert.SerializeObject(submission, Formatting.Indented)
        Await PostRequestAsync(url, json)
        MsgBox("Data Submitted Successfully!")
        Close()
    End Sub

    Private Sub HandleKeyDown(e As KeyEventArgs)
        If e.Control AndAlso e.KeyCode = Keys.T Then
            btnToogleStopWatch.PerformClick()
            e.Handled = True
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
            e.Handled = True
        End If
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        HandleKeyDown(e)
    End Sub

    Private Sub btnToogleStopWatch_KeyDown(sender As Object, e As KeyEventArgs) Handles btnToogleStopWatch.KeyDown
        HandleKeyDown(e)
    End Sub

    Private Sub btnSubmit_KeyDown(sender As Object, e As KeyEventArgs) Handles btnSubmit.KeyDown
        HandleKeyDown(e)
    End Sub

    Private Sub txtName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtName.KeyDown
        HandleKeyDown(e)
    End Sub

    Private Sub txtemail_KeyDown(sender As Object, e As KeyEventArgs) Handles txtemail.KeyDown
        HandleKeyDown(e)
    End Sub

    Private Sub txtphone_KeyDown(sender As Object, e As KeyEventArgs) Handles txtphone.KeyDown
        HandleKeyDown(e)
    End Sub

    Private Sub txtgithublink_KeyDown(sender As Object, e As KeyEventArgs) Handles txtgithublink.KeyDown
        HandleKeyDown(e)
    End Sub

    Private Sub txttogglestopwatch_KeyDown(sender As Object, e As KeyEventArgs) Handles txttogglestopwatch.KeyDown
        HandleKeyDown(e)
    End Sub
End Class