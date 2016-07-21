Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Pages.InsertPages
    Public Class InsertArrayOfPages
        Public Shared Sub Run()
            ' ExStart:InsertArrayOfPages
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()

            ' Create PdfFileEditor object
            Dim pdfEditor As New PdfFileEditor()
            Dim pagesToInsert As Integer() = New Integer() {2, 3}
            ' Insert pages
            pdfEditor.Insert(dataDir & Convert.ToString("MultiplePages.pdf"), 1, dataDir & Convert.ToString("InsertPages.pdf"), pagesToInsert, dataDir & Convert.ToString("InsertArrayOfPages_out_.pdf"))
            ' ExEnd:InsertArrayOfPages
        End Sub
    End Class
End Namespace
