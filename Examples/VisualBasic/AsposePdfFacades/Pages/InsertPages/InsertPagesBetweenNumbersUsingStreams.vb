Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Pages.InsertPages
    Public Class InsertPagesBetweenNumbersUsingStreams
        Public Shared Sub Run()
            ' ExStart:InsertPagesBetweenNumbersUsingStreams
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()

            ' Create PdfFileEditor object
            Dim pdfEditor As New PdfFileEditor()
            ' Create streams
            Dim inputStream As New FileStream(dataDir & Convert.ToString("MultiplePages.pdf"), FileMode.Open)
            Dim portStream As New FileStream(dataDir & Convert.ToString("InsertPages.pdf"), FileMode.Open)
            Dim outputStream As New FileStream(dataDir & Convert.ToString("InsertPagesBetweenNumbersUsingStreams_out_.pdf"), FileMode.Create)
            ' Insert pages
            pdfEditor.Insert(inputStream, 1, portStream, 1, 4, outputStream)
            ' ExEnd:InsertPagesBetweenNumbersUsingStreams
        End Sub
    End Class
End Namespace
