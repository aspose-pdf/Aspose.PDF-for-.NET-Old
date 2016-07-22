Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Pages.MakeNUp
    Public Class MakeNUpUsingPageSizeAndPaths
        Public Shared Sub Run()
            ' ExStart:MakeNUpUsingPageSizeAndPaths
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()

            ' Create PdfFileEditor object
            Dim pdfEditor As New PdfFileEditor()
            ' Make NUp
            pdfEditor.MakeNUp(dataDir & Convert.ToString("MultiplePages.pdf"), dataDir & Convert.ToString("MakeNUpUsingPageSizeAndPaths_out_.pdf"), 2, 3, PageSize.A5)
            ' ExEnd:MakeNUpUsingPageSizeAndPaths
        End Sub
    End Class
End Namespace
