Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Pages.DeletePages
    Public Class DeletePagesUsingStream
        Public Shared Sub Run()
            ' ExStart:DeletePagesUsingStream
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()

            ' Create PdfFileEditor object
            Dim pdfEditor As New PdfFileEditor()
            ' Create streams
            Dim inputStream As New FileStream(dataDir & Convert.ToString("test.pdf"), FileMode.Open)
            Dim outputStream As New FileStream(dataDir & Convert.ToString("DeletePagesUsingStream_out_.pdf"), FileMode.Create)
            ' Array of pages to delete
            Dim pagesToDelete As Integer() = New Integer() {1, 3}
            ' Delete pages
            pdfEditor.Delete(inputStream, pagesToDelete, outputStream)
            inputStream.Flush()
            inputStream.Close()
            ' ExEnd:DeletePagesUsingStream
        End Sub
    End Class
End Namespace
