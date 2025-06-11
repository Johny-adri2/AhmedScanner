Imports System.Net
Imports System.IO
Imports System.Text
Imports Newtonsoft.Json.Linq

Module VirusTotalAPI


    Const VT_API_URL As String = "https://www.virustotal.com/api/v3/"


    Public Function AnalyzeFile(ByVal filePath As String, ByVal API_KEY As String) As String
        Dim fileID As String = UploadFile(filePath, API_KEY)
        If String.IsNullOrEmpty(fileID) Then
            Return "Error uploading file."
        End If


        Dim analysisJson As JObject = PollAnalysisStatus(fileID, API_KEY)
        If analysisJson Is Nothing Then
            Return "Timeout waiting for analysis to complete."
        End If

        Return ExtractAnalysisReport(analysisJson, isUrl:=False)
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


    Public Function AnalyzeURL(ByVal urlToScan As String, ByVal API_KEY As String) As String
        Dim urlID As String = SubmitURL(urlToScan, API_KEY)
        If String.IsNullOrEmpty(urlID) Then
            Return "Error submitting URL."
        End If


        Dim analysisJson As JObject = PollAnalysisStatus(urlID, API_KEY)
        If analysisJson Is Nothing Then
            Return "Timeout waiting for URL analysis to complete."
        End If

        Return ExtractAnalysisReport(analysisJson, isUrl:=True)
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


    Private Function PollAnalysisStatus(ByVal analysisID As String, ByVal API_KEY As String) As JObject
        Const maxWaitSeconds As Integer = 120
        Const pollIntervalMs As Integer = 3000

        Dim elapsedTime As Integer = 0

        Try
            Dim webClient As New WebClient()
            webClient.Headers.Add("x-apikey", API_KEY)

            While elapsedTime < maxWaitSeconds
                Dim analysisUrl As String = VT_API_URL & "analyses/" & analysisID
                Dim response As String = webClient.DownloadString(analysisUrl)
                Dim jsonResponse As JObject = JObject.Parse(response)

                Dim status As String = String.Empty

                If jsonResponse("data") IsNot Nothing AndAlso jsonResponse("data")("attributes") IsNot Nothing AndAlso jsonResponse("data")("attributes")("status") IsNot Nothing Then
                    status = jsonResponse("data")("attributes")("status").ToString()
                End If

                If String.Equals(status, "completed", StringComparison.OrdinalIgnoreCase) Then
                    Return jsonResponse
                End If


                Dim waitInterval As Integer = pollIntervalMs
                Do While waitInterval > 0
                    System.Threading.Thread.Sleep(100)
                    waitInterval -= 100

                Loop

                elapsedTime += pollIntervalMs / 1000
            End While
        Catch ex As Exception
            Console.WriteLine("Error polling analysis status: " & ex.Message)
        End Try

        Return Nothing
    End Function


    Private Function ExtractAnalysisReport(ByVal analysisJson As JObject, ByVal isUrl As Boolean) As String
        Try
            If analysisJson("data") IsNot Nothing AndAlso analysisJson("data")("attributes") IsNot Nothing AndAlso analysisJson("data")("attributes")("stats") IsNot Nothing Then
                Dim stats As JObject = DirectCast(analysisJson("data")("attributes")("stats"), JObject)

                Dim harmless As String = stats("harmless").ToString()
                Dim malicious As String = stats("malicious").ToString()
                Dim suspicious As String = stats("suspicious").ToString()
                Dim undetected As String = stats("undetected").ToString()
                Dim timeout As String = stats("timeout").ToString()
                Dim report As String
                If malicious + suspicious > 0 Then
                    report = "not good"
                Else
                    report = "looks fine bro"
                End If

                Return report
            Else
                Return "Analysis data is incomplete or unavailable."
            End If
        Catch ex As Exception
            Return "Error extracting analysis report: " & ex.Message
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
        Label5.Text = "I'm thinking, 
brother"
        Label6.Text = ""
        If CheckBox1.Checked Then
            Label5.Text = VirusTotalAPI.AnalyzeURL(TextBox2.Text, TextBox1.Text)
        Else
            Label5.Text = VirusTotalAPI.AnalyzeFile(TextBox2.Text, TextBox1.Text)
        End If

    End Sub
End Class
