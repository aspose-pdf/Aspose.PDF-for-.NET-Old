Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Pages.MakeNUp
    Public Class UsingPageSizeHorizontalAndVerticalValues
        Public Shared Sub Run()
            ' ExStart:UsingPageSizeHorizontalAndVerticalValues
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()

            ' Create PdfFileEditor object
            Dim pdfEditor As New PdfFileEditor()
            ' Make NUp
            pdfEditor.MakeNUp(dataDir & Convert.ToString("input.pdf"), "UsingPageSizeHorizontalAndVerticalValues_out_.pdf", 2, 3)
            ' ExEnd:UsingPageSizeHorizontalAndVerticalValues
        End Sub
    End Class
End Namespace
