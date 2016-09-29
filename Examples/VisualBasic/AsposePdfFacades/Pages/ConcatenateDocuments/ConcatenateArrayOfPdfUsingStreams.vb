Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Pages.ConcatenateDocuments
    Public Class ConcatenateArrayOfPdfUsingStreams
        Public Shared Sub Run()
            ' ExStart:ConcatenateArrayOfPdfUsingStreams
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()

            ' Create PdfFileEditor object
            Dim pdfEditor As New PdfFileEditor()
            ' Output stream
            Dim outputStream As New FileStream(dataDir & Convert.ToString("ConcatenateArrayOfPdfUsingStreams_out_.pdf"), FileMode.Create)
            ' Array of streams
            Dim inputStreams As FileStream() = New FileStream(1) {}
            inputStreams(0) = New FileStream(dataDir & Convert.ToString("test.pdf"), FileMode.Open)
            inputStreams(1) = New FileStream(dataDir & Convert.ToString("input5.pdf"), FileMode.Open)
            ' Concatenate file
            pdfEditor.Concatenate(inputStreams, outputStream)
            inputStreams(0).Flush()
            inputStreams(0).Close()
            inputStreams(1).Flush()
            inputStreams(1).Close()
            ' ExEnd:ConcatenateArrayOfPdfUsingStreams
        End Sub

    End Class
End Namespace

