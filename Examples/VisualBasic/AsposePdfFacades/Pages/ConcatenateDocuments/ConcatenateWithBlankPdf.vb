Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Pages.ConcatenateDocuments
    Public Class ConcatenateWithBlankPdf
        Public Shared Sub Run()
            ' ExStart:ConcatenateWithBlankPdf
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()

            ' Create PdfFileEditor object
            Dim pdfEditor As New PdfFileEditor()
            ' Concatenate files
            pdfEditor.Concatenate(dataDir & Convert.ToString("input.pdf"), dataDir & Convert.ToString("input2.pdf"), dataDir & Convert.ToString("blank.pdf"), dataDir & Convert.ToString("ConcatenateWithBlankPdf_out_.pdf"))
            ' ExEnd:ConcatenateWithBlankPdf
        End Sub
    End Class
End Namespace
