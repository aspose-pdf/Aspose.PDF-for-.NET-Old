Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades
Namespace AsposePDFFacades.Pages.ConcatenateDocuments
    Public Class ConcatenateUsingPath
        Public Shared Sub Run()
            ' ExStart:ConcatenateUsingPath
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()
            ' Create PdfFileEditor object
            Dim pdfEditor As New PdfFileEditor()
            ' Concatenate files
            pdfEditor.Concatenate(dataDir & Convert.ToString("input.pdf"), dataDir & Convert.ToString("input2.pdf"), dataDir & Convert.ToString("ConcatenateUsingPath_out_.pdf"))
            ' ExEnd:ConcatenateUsingPath
        End Sub
        Public Shared Sub CopyOutline()
            ' ExStart:CopyOutline
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Pages()

            Dim pfe As New PdfFileEditor()
            Dim files As String() = Directory.GetFiles(dataDir)
            pfe.CopyOutlines = False
            pfe.Concatenate(files, dataDir & Convert.ToString("CopyOutline_out_.pdf"))
            ' ExEnd:CopyOutline
        End Sub
    End Class
End Namespace
