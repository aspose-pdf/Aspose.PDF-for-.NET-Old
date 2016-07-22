Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Pages.SplitPages
    Public Class SplitPagesToBulkUsingStreams
        Public Shared Sub Run()
            ' ExStart:SplitPagesToBulkUsingStreams
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()

            ' Create PdfFileEditor object
            Dim pdfEditor As New PdfFileEditor()
            ' Create input stream
            Dim inputStream As New FileStream(dataDir & Convert.ToString("MultiplePages.pdf"), FileMode.Open)
            Dim fileNumber As Integer = 1
            ' Create array of pages to split
            Dim numberOfPages As Integer()() = New Integer()() {New Integer() {1, 2}, New Integer() {3, 4}}
            ' Split to bulk
            Dim outBuffer As MemoryStream() = pdfEditor.SplitToBulks(inputStream, numberOfPages)
            ' Save individual files
            For Each aStream As MemoryStream In outBuffer
                Dim outStream As New FileStream((dataDir & Convert.ToString("File_")) + fileNumber.ToString() + "_out_.pdf", FileMode.Create)
                aStream.WriteTo(outStream)
                outStream.Close()
                fileNumber += 1
            Next
            ' ExEnd:SplitPagesToBulkUsingStreams
        End Sub
    End Class
End Namespace
