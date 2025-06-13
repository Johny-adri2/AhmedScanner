Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Imports Newtonsoft.Json.Linq

Module VirusTotalAPI

    Const VT_API_URL As String = "https://www.virustotal.com/api/v3/"

    Public Function ComputeFileSHA256(filePath As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Using fileStream As FileStream = File.OpenRead(filePath)
                Dim hashBytes As Byte() = sha256.ComputeHash(fileStream)
                Return BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant()
            End Using
        End Using
    End Function

    Public Function GetFileReportByHash(fileHash As String, API_KEY As String) As JObject
        Dim webClient As New WebClient()
        webClient.Headers.Add("x-apikey", API_KEY)
        Dim requestUrl As String = VT_API_URL & "files/" & fileHash
        Try
            Dim response As String = webClient.DownloadString(requestUrl)
            Dim jsonResponse As JObject = JObject.Parse(response)
            Return jsonResponse
        Catch ex As WebException
            Dim resp As HttpWebResponse = TryCast(ex.Response, HttpWebResponse)
            If resp IsNot Nothing AndAlso resp.StatusCode = HttpStatusCode.NotFound Then
                Return Nothing
            Else
                Throw
            End If
        End Try
    End Function

    Public Function AnalyzeFile(filePath As String, API_KEY As String, phr As String) As String
        Dim fileHash As String = ComputeFileSHA256(filePath)

        Try
            Dim reportJson As JObject = GetFileReportByHash(fileHash, API_KEY)
            If reportJson IsNot Nothing Then
                Return ExtractFileAnalysisReport(reportJson, phr)
            Else
                Dim analysisId As String = UploadFile(filePath, API_KEY)
                If String.IsNullOrEmpty(analysisId) Then
                    Return "Error uploading file."
                End If

                Dim analysisJson As JObject = PollAnalysisStatus(analysisId, API_KEY)
                If analysisJson Is Nothing Then
                    Return "Timeout waiting for analysis to complete."
                End If

                Return ExtractAnalysisReport(analysisJson, phr)
            End If
        Catch ex As Exception
            Return "Error during analysis: " & ex.Message
        End Try
    End Function

    Private Function ExtractFileAnalysisReport(reportJson As JObject, phr As String) As String
        Try
            Dim attributes As JObject = CType(reportJson("data")("attributes"), JObject)
            Dim stats As JObject = CType(attributes("last_analysis_stats"), JObject)
            Dim harmless As Integer = stats("harmless")
            Dim malicious As Integer = stats("malicious")
            Dim suspicious As Integer = stats("suspicious")
            Dim undetected As Integer = stats("undetected")
            Dim timeout As Integer = stats("timeout")

            Dim report As String
            If malicious + suspicious > 0 Then
                If phr Then
                    report = "haram"
                Else
                    report = "not good"
                End If

            Else
                If phr Then
                    report = "halal"
                Else
                    report = "looks fine bro"
                End If
            End If

            Return report
        Catch ex As Exception
            Return "Error extracting file analysis report: " & ex.Message
        End Try
    End Function

    Private Function UploadFile(ByVal filePath As String, API_KEY As String) As String
        Try
            Dim webClient As New WebClient()
            webClient.Headers.Add("x-apikey", API_KEY)

            Dim uploadUrl As String = VT_API_URL & "files"
            Dim responseBytes As Byte() = webClient.UploadFile(uploadUrl, "POST", filePath)
            Dim response As String = Encoding.UTF8.GetString(responseBytes)
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

    Private Function PollAnalysisStatus(ByVal analysisID As String, API_KEY As String) As JObject
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
                If jsonResponse("data") IsNot Nothing AndAlso
                   jsonResponse("data")("attributes") IsNot Nothing AndAlso
                   jsonResponse("data")("attributes")("status") IsNot Nothing Then
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

                elapsedTime += pollIntervalMs \ 1000
            End While
        Catch ex As Exception
            Console.WriteLine("Error polling analysis status: " & ex.Message)
        End Try

        Return Nothing
    End Function

    Private Function ExtractAnalysisReport(ByVal analysisJson As JObject, phr As String) As String
        Try
            If analysisJson("data") IsNot Nothing AndAlso
               analysisJson("data")("attributes") IsNot Nothing AndAlso
               analysisJson("data")("attributes")("stats") IsNot Nothing Then

                Dim stats As JObject = CType(analysisJson("data")("attributes")("stats"), JObject)

                Dim harmless As Integer = stats("harmless")
                Dim malicious As Integer = stats("malicious")
                Dim suspicious As Integer = stats("suspicious")
                Dim undetected As Integer = stats("undetected")
                Dim timeout As Integer = stats("timeout")

                Dim report As String
                If malicious + suspicious > 0 Then
                    If phr Then
                        report = "haram"
                    Else
                        report = "not good"
                    End If

                Else
                    If phr Then
                        report = "halal"
                    Else
                        report = "looks fine bro"
                    End If
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






Public Class Ahmed
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
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        CheckBox3.Visible = False
        TextBox1.Visible = False
        TextBox2.Visible = False
        Button1.Visible = False
        Button2.Visible = False

        Label5.Text = "let me think 
bro"
        Label6.Visible = False
        Label5.Text = VirusTotalAPI.AnalyzeFile(TextBox2.Text, TextBox1.Text, CheckBox3.Checked)
        Button3.Visible = True
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        CheckBox3.Visible = True
        TextBox1.Visible = True
        TextBox2.Visible = True
        Button1.Visible = True
        Button2.Visible = True
        Button3.Visible = False
        Label5.Text = "scan more if 
you want"
    End Sub
End Class
