Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Namespace AsposePDF.DocumentConversion
    Public Class HTMLToPDF
        Public Shared Sub Run()
            Try
                ' ExStart:HTMLToPDF
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion()

                Dim options As New HtmlLoadOptions()
                options.CustomLoaderOfExternalResources = New LoadOptions.ResourceLoadingStrategy(AddressOf SamePictureLoader)

                Dim pdfDocument As New Document(dataDir & Convert.ToString("HTMLToPDF.html"), options)
                ' ExEnd:HTMLToPDF
                pdfDocument.Save("HTMLToPDF_out_.pdf")
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
        ' ExStart:HTMLToPDFHelper
        Private Shared Function SamePictureLoader(resourceURI As String) As LoadOptions.ResourceLoadingResult
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion()
            Dim resultBytes As Byte() = File.ReadAllBytes(dataDir & Convert.ToString("aspose-logo.jpg"))
            Dim result As New LoadOptions.ResourceLoadingResult(resultBytes)
            Return result
        End Function
        ' ExEnd:HTMLToPDFHelper
    End Class
End Namespace