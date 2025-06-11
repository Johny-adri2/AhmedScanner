Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json.Linq
Imports Windows.Win32.System

Module VirusTotalAPI


    Const VT_API_URL As String = "https://www.virustotal.com/api/v3/"


    Public Function AnalyzeFile(ByVal filePath As String, ByVal API_KEY As String) As String
        Dim fileID As String = UploadFile(filePath, API_KEY)

        If String.IsNullOrEmpty(fileID) Then
            Return "Error uploading file."
        End If

        System.Threading.Thread.Sleep(0) ' adjust as needed

        Return GetAnalysisReport(fileID, API_KEY)
    End Function


    Private Function UploadFile(ByVal filePath As String, ByVal API_KEY As String) As String
        Try
            Dim webClient As New WebClient()
            webClient.Headers.Add("x-apikey", API_KEY)

            Dim uploadUrl As String = VT_API_URL & "files"


            Dim responseBytes As Byte() = webClient.UploadFile(uploadUrl, "POST", filePath)


            Dim response As String = System.Text.Encoding.UTF8.GetString(responseBytes)

            Dim jsonResponse As JObject = JObject.Parse(response)

            If jsonResponse("data") IsNot Nothing AndAlso jsonResponse("data")("id") IsNot Nothing Then
                Return jsonResponse("data")("id").ToString()
            Else
                Console.WriteLine("Error uploading file: " & response)
                Return String.Empty
            End If

        Catch ex As Exception
            Console.WriteLine("Error uploading file: " & ex.Message)
            Return String.Empty
        End Try
    End Function


    Public Function GetAnalysisReport(ByVal fileID As String, ByVal API_KEY As String) As String
        Try
            Dim webClient As New WebClient()
            webClient.Headers.Add("x-apikey", API_KEY)

            Dim analysisUrl As String = VT_API_URL & "analyses/" & fileID

            Dim response As String = webClient.DownloadString(analysisUrl)

            Dim jsonResponse As JObject = JObject.Parse(response)

            If jsonResponse("data") IsNot Nothing AndAlso jsonResponse("data")("attributes") IsNot Nothing AndAlso jsonResponse("data")("attributes")("stats") IsNot Nothing Then
                Dim stats As JObject = DirectCast(jsonResponse("data")("attributes")("stats"), JObject)

                Dim report As String = stats.ToString()

                Return report
            Else
                Console.WriteLine("Error getting analysis report: " & response)
                Return "Error getting analysis report."
            End If

        Catch ex As Exception
            Console.WriteLine("Error getting analysis report: " & ex.Message)
            Return "Error getting analysis report."
        End Try
    End Function


    Public Function AnalyzeURL(ByVal urlToScan As String, ByVal API_KEY As String) As String
        Dim urlID As String = SubmitURL(urlToScan, API_KEY)

        If String.IsNullOrEmpty(urlID) Then
            Return "Error submitting URL."
        End If


        System.Threading.Thread.Sleep(0) ' adjust as needed

        Return GetURLAnalysisReport(urlID, API_KEY)
    End Function


    Private Function SubmitURL(ByVal urlToScan As String, ByVal API_KEY As String) As String
        Try
            Dim webClient As New WebClient()
            webClient.Headers.Add("x-apikey", API_KEY)
            webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

            Dim submitUr As String = VT_API_URL & "urls"
            Dim postData As String = "url=" & Uri.EscapeDataString(urlToScan)

            Dim response As String = webClient.UploadString(submitUr, "POST", postData)

            Dim jsonResponse As JObject = JObject.Parse(response)

            If jsonResponse("data") IsNot Nothing AndAlso jsonResponse("data")("id") IsNot Nothing Then
                Return jsonResponse("data")("id").ToString()
            Else
                Console.WriteLine("Error submitting URL: " & response)
                Return String.Empty
            End If

        Catch ex As Exception
            Console.WriteLine("Error submitting URL: " & ex.Message)
            Return String.Empty
        End Try
    End Function


    Public Function GetURLAnalysisReport(ByVal urlID As String, ByVal API_KEY As String) As String
        Try
            Dim webClient As New WebClient()
            webClient.Headers.Add("x-apikey", API_KEY)

            Dim analysisUrl As String = VT_API_URL & "analyses/" & urlID

            Dim response As String = webClient.DownloadString(analysisUrl)

            Dim jsonResponse As JObject = JObject.Parse(response)

            If jsonResponse("data") IsNot Nothing AndAlso jsonResponse("data")("attributes") IsNot Nothing AndAlso jsonResponse("data")("attributes")("stats") IsNot Nothing Then
                Dim stats As JObject = DirectCast(jsonResponse("data")("attributes")("stats"), JObject)

                Dim report As String = stats.ToString()

                Return report
            Else
                Console.WriteLine("Error getting URL analysis report: " & response)
                Return "Error getting URL analysis report."
            End If

        Catch ex As Exception
            Console.WriteLine("Error getting URL analysis report: " & ex.Message)
            Return "Error getting URL analysis report."
        End Try
    End Function

End Module


Public Class ahmed
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim openFileDialog As New OpenFileDialog()

        openFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        openFileDialog.Filter = "All files (*.*)|*.*"
        openFileDialog.Title = "Select a File"
        openFileDialog.Multiselect = False

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim selectedFilePath As String = openFileDialog.FileName
            TextBox2.Text = selectedFilePath
        Else
            MessageBox.Show("File selection cancelled.")
        End If

        openFileDialog.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label5.Text = "Here you go"
        Label6.Text = "..."
        If CheckBox1.Checked Then
            Label6.Text = VirusTotalAPI.AnalyzeURL(TextBox2.Text, TextBox1.Text)
        Else
            Label6.Text = VirusTotalAPI.AnalyzeFile(TextBox2.Text, TextBox1.Text)
        End If

    End Sub
End Class
