Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Pages.MakeBooklet
    Public Class MakeBookletUsingPaths
        Public Shared Sub Run()
            ' ExStart:MakeBookletUsingPaths
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()

            ' Create PdfFileEditor object
            Dim pdfEditor As New PdfFileEditor()
            ' Make booklet
            pdfEditor.MakeBooklet(dataDir & Convert.ToString("input.pdf"), dataDir & Convert.ToString("MakeBookletUsingPaths_out_.pdf"))
            ' ExEnd:MakeBookletUsingPaths
        End Sub
    End Class
End Namespace
