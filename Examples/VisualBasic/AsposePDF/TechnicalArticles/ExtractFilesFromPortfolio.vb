Imports System.IO
Imports System
Imports Aspose.Pdf

Namespace AsposePDF.TechnicalArticles
    Public Class ExtractFilesFromPortfolio
        Public Shared Sub Run()
            ' ExStart:ExtractFilesFromPortfolio
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_TechnicalArticles()

            ' Load source PDF Portfolio
            Dim pdfDocument As New Aspose.Pdf.Document(dataDir & Convert.ToString("PDFPortfolio.pdf"))
            ' Get collection of embedded files
            Dim embeddedFiles As EmbeddedFileCollection = pdfDocument.EmbeddedFiles
            ' Itterate through individual file of Portfolio
            For Each fileSpecification As FileSpecification In embeddedFiles
                ' Get the attachment and write to file or stream
                Dim fileContent As Byte() = New Byte(Convert.ToInt32(fileSpecification.Contents.Length - 1)) {}
                fileSpecification.Contents.Read(fileContent, 0, fileContent.Length)
                Dim filename As String = Path.GetFileName(fileSpecification.Name)
                ' Save the extracted file to some location
                Dim fileStream As New FileStream(Convert.ToString(dataDir & Convert.ToString("_out")) & filename, FileMode.Create)
                fileStream.Write(fileContent, 0, fileContent.Length)
                ' Close the stream object
                fileStream.Close()
            Next
            ' ExEnd:ExtractFilesFromPortfolio                      
        End Sub
    End Class
End Namespace
