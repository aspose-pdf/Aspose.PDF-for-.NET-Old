Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Pages.SplitPages
    Public Class SplitPagesUsingPaths
        Public Shared Sub Run()
            ' ExStart:SplitPagesUsingPaths
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()

            ' Create PdfFileEditor object
            Dim pdfEditor As New PdfFileEditor()
            ' Split pages
            pdfEditor.SplitFromFirst(dataDir & Convert.ToString("MultiplePages.pdf"), 3, dataDir & Convert.ToString("SplitPagesUsingPaths_out_.pdf"))
            ' ExEnd:SplitPagesUsingPaths
        End Sub
    End Class
End Namespace
