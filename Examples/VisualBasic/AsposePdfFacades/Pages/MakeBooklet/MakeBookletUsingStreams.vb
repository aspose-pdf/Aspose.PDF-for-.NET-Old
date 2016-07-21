Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Pages.MakeBooklet
    Public Class MakeBookletUsingStreams
        Public Shared Sub Run()
            ' ExStart:MakeBookletUsingStreams
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()

            ' Create PdfFileEditor object
            Dim pdfEditor As New PdfFileEditor()
            ' Create streams
            Dim inputStream As New FileStream(dataDir & Convert.ToString("input.pdf"), FileMode.Open)
            Dim outputStream As New FileStream(dataDir & Convert.ToString("MakeBookletUsingStreams_out_.pdf"), FileMode.Create)
            ' Make booklet
            pdfEditor.MakeBooklet(inputStream, outputStream)
            ' ExEnd:MakeBookletUsingStreams
        End Sub
    End Class
End Namespace
