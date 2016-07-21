Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Pages.MakeBooklet
    Public Class MakeBookletUsingLeftRightPagesAndStreams
        Public Shared Sub Run()
            ' ExStart:MakeBookletUsingLeftRightPagesAndStreams
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()

            ' Create PdfFileEditor object
            Dim pdfEditor As New PdfFileEditor()
            ' Create streams
            Dim inputStream As New FileStream(dataDir & Convert.ToString("MultiplePages.pdf"), FileMode.Open)
            Dim outputStream As New FileStream(dataDir & Convert.ToString("MakeBookletUsingLeftRightPagesAndStreams_out_.pdf"), FileMode.Create)
            ' Set left and right pages
            Dim leftPages As Integer() = New Integer() {1, 5}
            Dim rightPages As Integer() = New Integer() {2, 3}
            ' Make booklet
            pdfEditor.MakeBooklet(inputStream, outputStream, leftPages, rightPages)
            ' ExEnd:MakeBookletUsingLeftRightPagesAndStreams
        End Sub
    End Class
End Namespace

