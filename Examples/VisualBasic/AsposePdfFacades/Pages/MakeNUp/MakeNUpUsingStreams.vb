Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Pages.MakeNUp
    Public Class MakeNUpUsingStreams
        Public Shared Sub Run()
            ' ExStart:MakeNUpUsingStreams
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()

            ' Create PdfFileEditor object
            Dim pdfEditor As New PdfFileEditor()
            ' Create streams
            Dim inputStream1 As New FileStream(dataDir & Convert.ToString("input.pdf"), FileMode.Open)
            Dim inputStream2 As New FileStream(dataDir & Convert.ToString("input2.pdf"), FileMode.Open)
            Dim outputStream As New FileStream(dataDir & Convert.ToString("MakeNUpUsingStreams_out_.pdf"), FileMode.Create)
            ' Make NUp
            pdfEditor.MakeNUp(inputStream1, inputStream2, outputStream)
            ' ExEnd:MakeNUpUsingStreams
        End Sub
    End Class
End Namespace
