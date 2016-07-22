Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Pages.SplitPages
    Public Class SplitPagesToEndUsingPaths
        Public Shared Sub Run()
            ' ExStart:SplitPagesToEndUsingPaths
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()

            ' Create PdfFileEditor object
            Dim pdfEditor As New PdfFileEditor()
            ' Split pages
            pdfEditor.SplitToEnd(dataDir & Convert.ToString("MultiplePages.pdf"), 3, dataDir & Convert.ToString("SplitPagesToEndUsingPaths_out_.pdf"))
            ' ExEnd:SplitPagesToEndUsingPaths
        End Sub
    End Class
End Namespace
