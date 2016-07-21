Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Pages.MakeBooklet
    Public Class MakeBookletUsingPageSizeAndPaths
        Public Shared Sub Run()
            ' ExStart:MakeBookletUsingPageSizeAndPaths
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()

            ' Create PdfFileEditor object
            Dim pdfEditor As New PdfFileEditor()
            ' Make booklet
            pdfEditor.MakeBooklet(dataDir & Convert.ToString("input.pdf"), dataDir & Convert.ToString("MakeBookletUsingPageSizeAndPaths_out_.pdf"), PageSize.A5)
            ' ExEnd:MakeBookletUsingPageSizeAndPaths
        End Sub
    End Class
End Namespace
