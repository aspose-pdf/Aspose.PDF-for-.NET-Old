Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Pages.MakeBooklet
    Public Class MakeBookletUsingPageSizeLeftRightPagesAndStreams
        Public Shared Sub Run()
            ' ExStart:MakeBookletUsingPageSizeLeftRightPagesAndStreams
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()

            ' Create PdfFileEditor object
            Dim pdfEditor As New PdfFileEditor()
            ' Create streams
            Dim inputStream As New FileStream(dataDir & Convert.ToString("MultiplePages.pdf"), FileMode.Open)
            Dim outputStream As New FileStream(dataDir & Convert.ToString("MakeBookletUsingPageSizeLeftRightPagesAndStreams_out_.pdf"), FileMode.Create)
            ' Set left and right pages
            Dim leftPages As Integer() = New Integer() {1, 5}
            Dim rightPages As Integer() = New Integer() {2, 3}
            'make booklet
            pdfEditor.MakeBooklet(inputStream, outputStream, PageSize.A5, leftPages, rightPages)
            ' ExEnd:MakeBookletUsingPageSizeLeftRightPagesAndStreams
        End Sub
    End Class
End Namespace

