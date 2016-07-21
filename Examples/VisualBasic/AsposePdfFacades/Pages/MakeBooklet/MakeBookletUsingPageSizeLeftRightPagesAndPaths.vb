Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Pages.MakeBooklet
    Public Class MakeBookletUsingPageSizeLeftRightPagesAndPaths
        Public Shared Sub Run()
            ' ExStart:MakeBookletUsingPageSizeLeftRightPagesAndPaths
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()

            ' Create PdfFileEditor object
            Dim pdfEditor As New PdfFileEditor()
            ' Set left and right pages
            Dim leftPages As Integer() = New Integer() {1, 5}
            Dim rightPages As Integer() = New Integer() {2, 3}
            ' Make booklet
            pdfEditor.MakeBooklet(dataDir & Convert.ToString("MultiplePages.pdf"), dataDir & Convert.ToString("MakeBookletUsingPageSizeLeftRightPagesAndPaths_out_.pdf"), PageSize.A5, leftPages, rightPages)
            ' ExEnd:MakeBookletUsingPageSizeLeftRightPagesAndPaths
        End Sub
    End Class
End Namespace

