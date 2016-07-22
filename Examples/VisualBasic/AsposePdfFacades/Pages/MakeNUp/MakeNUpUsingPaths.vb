Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Pages.MakeNUp
    Public Class MakeNUpUsingPaths
        Public Shared Sub Run()
            ' ExStart:MakeNUpUsingPaths
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()

            ' Create PdfFileEditor object
            Dim pdfEditor As New PdfFileEditor()
            ' Make NUp
            pdfEditor.MakeNUp(dataDir & Convert.ToString("input.pdf"), dataDir & Convert.ToString("input2.pdf"), "MakeNUpUsingPaths_out_.pdf")
            ' ExEnd:MakeNUpUsingPaths
        End Sub
    End Class
End Namespace

