Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Pages.SplitPages
    Public Class SplitPagesToBulkUsingPaths
        Public Shared Sub Run()
            ' ExStart:SplitPagesToBulkUsingPaths
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()

            ' Create PdfFileEditor object
            Dim pdfEditor As New PdfFileEditor()
            Dim fileNumber As Integer = 1
            ' Create array of pages to split
            Dim numberOfPages As Integer()() = New Integer()() {New Integer() {1, 2}, New Integer() {3, 4}}
            ' Split to bulk
            Dim outBuffer As MemoryStream() = pdfEditor.SplitToBulks(dataDir & Convert.ToString("MultiplePages.pdf"), numberOfPages)
            ' Save individual files
            For Each aStream As MemoryStream In outBuffer
                Dim outStream As New FileStream((dataDir & Convert.ToString("File_")) + fileNumber.ToString() + "_out_.pdf", FileMode.Create)
                aStream.WriteTo(outStream)
                outStream.Close()
                fileNumber += 1
            Next
            ' ExEnd:SplitPagesToBulkUsingPaths
        End Sub
    End Class
End Namespace
