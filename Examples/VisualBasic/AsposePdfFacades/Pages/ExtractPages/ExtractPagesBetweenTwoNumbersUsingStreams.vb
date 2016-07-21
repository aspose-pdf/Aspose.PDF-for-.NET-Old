Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Pages.ExtractPages
    Public Class ExtractPagesBetweenTwoNumbersUsingStreams
        Public Shared Sub Run()
            ' ExStart:ExtractPagesBetweenTwoNumbersUsingStreams
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()

            ' Create PdfFileEditor object
            Dim pdfEditor As New PdfFileEditor()
            ' Create streams
            Dim inputStream As New FileStream(dataDir & Convert.ToString("MultiplePages.pdf"), FileMode.Open)
            Dim outputStream As New FileStream(dataDir & Convert.ToString("ExtractPagesBetweenTwoNumbers_out_.pdf"), FileMode.Create)
            ' Extract pages
            pdfEditor.Extract(inputStream, 1, 3, outputStream)
            ' ExEnd:ExtractPagesBetweenTwoNumbersUsingStreams
        End Sub
    End Class
End Namespace
