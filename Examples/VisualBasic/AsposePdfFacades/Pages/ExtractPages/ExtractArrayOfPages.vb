Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Pages.ExtractPages
    Public Class ExtractArrayOfPages
        Public Shared Sub Run()
            ' ExStart:ExtractArrayOfPages
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()

            ' Create PdfFileEditor object
            Dim pdfEditor As New PdfFileEditor()
            Dim pagesToExtract As Integer() = New Integer() {1, 2}
            ' Extract pages
            pdfEditor.Extract(dataDir & Convert.ToString("Extract.pdf"), pagesToExtract, dataDir & Convert.ToString("ExtractArrayOfPages_out_.pdf"))
            ' ExEnd:ExtractArrayOfPages
        End Sub
    End Class
End Namespace
