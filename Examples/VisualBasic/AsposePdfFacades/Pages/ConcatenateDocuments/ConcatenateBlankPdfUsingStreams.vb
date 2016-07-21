Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades
Namespace AsposePDFFacades.Pages.ConcatenateDocuments
    Public Class ConcatenateBlankPdfUsingStreams
        Public Shared Sub Run()
            ' ExStart:ConcatenateBlankPdfUsingStreams
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()

            ' Create PdfFileEditor object
            Dim pdfEditor As New PdfFileEditor()
            ' Create streams
            Dim inputStream1 As New FileStream(dataDir & Convert.ToString("input.pdf"), FileMode.Open)
            Dim inputStream2 As New FileStream(dataDir & Convert.ToString("input2.pdf"), FileMode.Open)
            Dim blankStream As New FileStream(dataDir & Convert.ToString("blank.pdf"), FileMode.Open)
            Dim outputStream As New FileStream(dataDir & Convert.ToString("ConcatenateBlankPdfUsingStreams_out_.pdf"), FileMode.Create)
            ' Concatenate file
            pdfEditor.Concatenate(inputStream1, inputStream2, blankStream, outputStream)
            ' ExEnd:ConcatenateBlankPdfUsingStreams
        End Sub

    End Class
End Namespace

