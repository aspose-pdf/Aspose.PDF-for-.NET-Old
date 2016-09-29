Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Pages.ExtractPages
    Public Class ExtractArrayOfPagesUsingStreams
        Public Shared Sub Run()
            ' ExStart:ExtractArrayOfPagesUsingStreams
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()

            ' Create PdfFileEditor object
            Dim pdfEditor As New PdfFileEditor()
            ' Create streams
            Dim inputStream As New FileStream(dataDir & Convert.ToString("MultiplePagesvb.pdf"), FileMode.Open)
            Dim outputStream As New FileStream(dataDir & Convert.ToString("ExtractArrayOfPagesUsingStreams_out_.pdf"), FileMode.Create)
            Dim pagesToExtract As Integer() = New Integer() {1, 2}
            ' Extract pages
            pdfEditor.Extract(inputStream, pagesToExtract, outputStream)
            inputStream.Flush()
            inputStream.Close()
            ' ExEnd:ExtractArrayOfPagesUsingStreams
        End Sub
    End Class
End Namespace
