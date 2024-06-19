Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0
    Private submissions As List(Of Submission)

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Load submissions from backend
        LoadSubmissions()
        ' Show the first submission
        ShowSubmission()
    End Sub

    Private Sub LoadSubmissions()
        ' API call to load submissions
        ' Populate the submissions list
    End Sub

    Private Sub ShowSubmission()
        If submissions.Count > 0 AndAlso currentIndex >= 0 AndAlso currentIndex < submissions.Count Then
            Dim submission = submissions(currentIndex)
            ' Display submission details
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            ShowSubmission()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            ShowSubmission()
        End If
    End Sub
End Class
