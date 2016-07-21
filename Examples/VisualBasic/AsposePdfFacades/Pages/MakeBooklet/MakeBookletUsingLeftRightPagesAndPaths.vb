Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Pages.MakeBooklet
    Public Class MakeBookletUsingLeftRightPagesAndPaths
        Public Shared Sub Run()
            ' ExStart:MakeBookletUsingLeftRightPagesAndPaths
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()

            ' Create PdfFileEditor object
            Dim pdfEditor As New PdfFileEditor()
            ' Set left and right pages
            Dim leftPages As Integer() = New Integer() {1, 5}
            Dim rightPages As Integer() = New Integer() {2, 3}
            ' Make booklet
            pdfEditor.MakeBooklet(dataDir & Convert.ToString("MultiplePages.pdf"), dataDir & Convert.ToString("MakeBookletUsingLeftRightPagesAndPaths_out_.pdf"), leftPages, rightPages)
            ' ExEnd:MakeBookletUsingLeftRightPagesAndPaths
        End Sub
    End Class
End Namespace