Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports System.Net
Imports Aspose.Pdf

Namespace AsposePDF.DocumentConversion
    Public Class WebPageToPDF
        Public Shared Sub Run()
            Try
                ' ExStart:WebPageToPDF
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion()
                ' Create a request for the URL.
                Dim request As WebRequest = WebRequest.Create("https://en.wikipedia.org/wiki/Main_Page")
                ' If required by the server, set the credentials.
                request.Credentials = CredentialCache.DefaultCredentials
                ' Time out in miliseconds before the request times out
                ' Request.Timeout = 100;

                ' Get the response.
                Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)

                ' Get the stream containing content returned by the server.
                Dim dataStream As Stream = response.GetResponseStream()
                ' Open the stream using a StreamReader for easy access.
                Dim reader As New StreamReader(dataStream)
                ' Read the content.
                Dim responseFromServer As String = reader.ReadToEnd()
                reader.Close()
                dataStream.Close()
                response.Close()

                Dim stream As New MemoryStream(System.Text.Encoding.UTF8.GetBytes(responseFromServer))
                Dim options As New HtmlLoadOptions("https://en.wikipedia.org/wiki/")


                ' Load HTML file
                Dim pdfDocument As New Document(stream, options)

                options.PageInfo.IsLandscape = True

                ' Save output as PDF format
                pdfDocument.Save(dataDir & Convert.ToString("WebPageToPDF_out_.pdf"))
                ' ExEnd:WebPageToPDF
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
    End Class
End Namespace