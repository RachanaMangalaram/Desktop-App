Imports Newtonsoft.Json

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0


    Public Sub New()
        InitializeComponent()
        ' Load submissions from backend
        LoadSubmissions()
    End Sub

    Private Async Function LoadSubmissions() As Task(Of Boolean)
        Dim url As String = "http://localhost:3000/read?index=" & currentIndex
        Dim result As String = Await GetRequestAsync(url)
        If String.IsNullOrEmpty(result) Then
            MsgBox("End of Data")
            Return False
        End If
        Dim submission As Submission = JsonConvert.DeserializeObject(Of Submission)(result)
        If submission Is Nothing Then
            MsgBox("End of Data")
            Return False
        End If
        txtName.Text = submission.Name
        txtEmail.Text = submission.Email
        txtPhone.Text = submission.PhoneNumber
        txtGithubLink.Text = submission.GitHubLink
        txtStopwatch.Text = submission.StopwatchTime
        Return True
    End Function

    Private Async Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex = 0 Then
            MsgBox("End of Data")
            Return
        End If

        currentIndex -= 1
        Await LoadSubmissions()
    End Sub

    Private Async Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        currentIndex += 1
        If Await LoadSubmissions() = False Then
            currentIndex -= 1
        End If
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        HandleKeyDown(e)
    End Sub

    Private Sub HandleKeyDown(e As KeyEventArgs)
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
            e.Handled = True
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
            e.Handled = True
        End If
    End Sub

    Private Sub btnPrevious_KeyDown(sender As Object, e As KeyEventArgs) Handles btnPrevious.KeyDown
        HandleKeyDown(e)
    End Sub

    Private Sub btnNext_KeyDown(sender As Object, e As KeyEventArgs) Handles btnNext.KeyDown
        HandleKeyDown(e)
    End Sub

    Private Sub txtName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtName.KeyDown
        HandleKeyDown(e)
    End Sub

    Private Sub txtEmail_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmail.KeyDown
        HandleKeyDown(e)
    End Sub

    Private Sub txtPhone_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPhone.KeyDown
        HandleKeyDown(e)
    End Sub

    Private Sub txtGithubLink_KeyDown(sender As Object, e As KeyEventArgs) Handles txtGithubLink.KeyDown
        HandleKeyDown(e)
    End Sub

    Private Sub txtStopwatch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtStopwatch.KeyDown
        HandleKeyDown(e)
    End Sub
End Class
