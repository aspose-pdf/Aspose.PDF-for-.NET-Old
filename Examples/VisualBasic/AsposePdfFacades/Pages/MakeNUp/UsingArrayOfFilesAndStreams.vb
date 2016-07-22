Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Pages.MakeNUp
    Public Class UsingArrayOfFilesAndStreams
        Public Shared Sub Run()
            ' ExStart:UsingArrayOfFilesAndStreams
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()

            ' Create PdfFileEditor object
            Dim pdfEditor As New PdfFileEditor()
            ' Create streams
            Dim fileStreams As FileStream() = New FileStream(1) {}
            fileStreams(0) = New FileStream(dataDir & Convert.ToString("input.pdf"), FileMode.Open)
            fileStreams(1) = New FileStream(dataDir & Convert.ToString("input2.pdf"), FileMode.Open)
            Dim outputStream As New FileStream(dataDir & Convert.ToString("UsingArrayOfFilesAndStreams_out_.pdf"), FileMode.Create)
            ' Make NUp
            pdfEditor.MakeNUp(fileStreams, outputStream, True)
            ' ExEnd:UsingArrayOfFilesAndStreams
        End Sub
    End Class
End Namespace
