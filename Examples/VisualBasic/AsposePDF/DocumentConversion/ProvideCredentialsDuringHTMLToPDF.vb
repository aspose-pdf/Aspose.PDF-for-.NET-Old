Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports System.Net

Namespace AsposePDF.DocumentConversion
    Public Class ProvideCredentialsDuringHTMLToPDF
        Public Shared Sub Run()
            Try
                ' ExStart:ProvideCredentialsDuringHTMLToPDF
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion()

                ' Create a request for the URL.
                Dim request As WebRequest = WebRequest.Create("http://my.signchart.com/Report/PrintBook.asp?ProjectGuid=6FB9DBB0-")
                ' If required by the server, set the credentials.
                request.Credentials = CredentialCache.DefaultCredentials
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

                Dim options As New HtmlLoadOptions("http://my.signchart.com/")
                options.ExternalResourcesCredentials = CredentialCache.DefaultCredentials

                ' load HTML file
                Dim pdfDocument As New Document(stream, options)
                ' save resultant file
                pdfDocument.Save("ProvideCredentialsDuringHTMLToPDF_out_.pdf")
                ' ExEnd:ProvideCredentialsDuringHTMLToPDF
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
    End Class
End Namespace
