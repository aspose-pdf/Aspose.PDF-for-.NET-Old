Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Pages.MakeBooklet
    Public Class MakeBookletUsingPageSizeAndStreams
        Public Shared Sub Run()
            ' ExStart:MakeBookletUsingPageSizeAndStreams
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()

            ' Create PdfFileEditor object
            Dim pdfEditor As New PdfFileEditor()
            ' Create streams
            Dim inputStream As New FileStream(dataDir & Convert.ToString("test.pdf"), FileMode.Open)
            Dim outputStream As New FileStream(dataDir & Convert.ToString("MakeBookletUsingPageSizeAndStreams_out_.pdf"), FileMode.Create)
            ' Make booklet
            pdfEditor.MakeBooklet(inputStream, outputStream, PageSize.A5)
            inputStream.Flush()
            inputStream.Close()
            ' ExEnd:MakeBookletUsingPageSizeAndStreams
        End Sub
    End Class
End Namespace
