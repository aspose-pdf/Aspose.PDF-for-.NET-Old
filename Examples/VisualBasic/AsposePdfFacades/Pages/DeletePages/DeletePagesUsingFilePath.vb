Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Pages.DeletePages
    Public Class DeletePagesUsingFilePath
        Public Shared Sub Run()
            ' ExStart:DeletePagesUsingFilePath
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()

            ' Create PdfFileEditor object
            Dim pdfEditor As New PdfFileEditor()
            ' Array of pages to delete
            Dim pagesToDelete As Integer() = New Integer() {1, 2}
            ' Delete pages
            pdfEditor.Delete(dataDir & Convert.ToString("input.pdf"), pagesToDelete, dataDir & Convert.ToString("DeletePagesUsingFilePath_out_.pdf"))
            ' ExEnd:DeletePagesUsingFilePath
        End Sub
    End Class
End Namespace
