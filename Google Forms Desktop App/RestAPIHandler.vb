Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks

Module RestAPIHandler
    Public Async Function GetRequestAsync(url As String) As Task(Of String)
        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await client.GetAsync(url)
                response.EnsureSuccessStatusCode()
                Dim responseBody As String = Await response.Content.ReadAsStringAsync()
                Return responseBody
            Catch ex As HttpRequestException
                Console.WriteLine($"Request exception: {ex.Message}")
                Return Nothing
            End Try
        End Using
    End Function

    Public Async Function PostRequestAsync(url As String, jsonData As String) As Task(Of String)
        Using client As New HttpClient()
            Try
                Dim content As New StringContent(jsonData, Encoding.UTF8, "application/json")
                Dim response As HttpResponseMessage = Await client.PostAsync(url, content)
                response.EnsureSuccessStatusCode()
                Dim responseBody As String = Await response.Content.ReadAsStringAsync()
                Return responseBody
            Catch ex As HttpRequestException
                Console.WriteLine($"Request exception: {ex.Message}")
                Return Nothing
            End Try
        End Using
    End Function

    'Async Sub Main()
    '    ' GET request example
    '    Dim getUrl As String = "https://api.example.com/data"
    '    Dim getResult As String = Await GetRequestAsync(getUrl)
    '    Console.WriteLine("GET request result:")
    '    Console.WriteLine(getResult)

    '    ' POST request example
    '    Dim postUrl As String = "https://api.example.com/data"
    '    Dim jsonData As String = "{""key"":""value""}"
    '    Dim postResult As String = Await PostRequestAsync(postUrl, jsonData)
    '    Console.WriteLine("POST request result:")
    '    Console.WriteLine(postResult)
    'End Sub
End Module
