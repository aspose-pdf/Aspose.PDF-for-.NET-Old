Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Pages.ExtractPages
    Public Class ExtractPagesBetweenNumbers
        Public Shared Sub Run()
            ' ExStart:ExtractPagesBetweenNumbers
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()

            ' Create PdfFileEditor object
            Dim pdfEditor As New PdfFileEditor()
            ' Extract pages
            pdfEditor.Extract(dataDir & Convert.ToString("MultiplePages.pdf"), 1, 3, dataDir & Convert.ToString("ExtractPagesBetweenNumbers_out_.pdf"))
            ' ExEnd:ExtractPagesBetweenNumbers
        End Sub
    End Class
End Namespace

