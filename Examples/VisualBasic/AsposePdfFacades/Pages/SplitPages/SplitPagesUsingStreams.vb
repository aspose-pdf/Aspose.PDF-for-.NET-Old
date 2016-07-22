Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Pages.SplitPages
    Public Class SplitPagesUsingStreams
        Public Shared Sub Run()
            ' ExStart:SplitPagesUsingStreams
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()

            ' Create PdfFileEditor object
            Dim pdfEditor As New PdfFileEditor()
            ' Create streams
            Dim inputStream As New FileStream(dataDir & Convert.ToString("MultiplePages.pdf"), FileMode.Open)
            Dim outputStream As New FileStream(dataDir & Convert.ToString("SplitPagesUsingStreams_out_.pdf"), FileMode.Create)
            ' Split pages
            pdfEditor.SplitFromFirst(inputStream, 3, outputStream)
            ' ExEnd:SplitPagesUsingStreams
        End Sub
    End Class
End Namespace
