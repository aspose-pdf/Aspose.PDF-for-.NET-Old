Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.DocumentConversion
    Public Class PDFToPPT
        Public Shared Sub Run()
            ' ExStart:PDFToPPT
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_DocumentConversion()
            ' Load PDF document
            Dim doc As New Document(dataDir & Convert.ToString("input.pdf"))
            ' Instantiate PptxSaveOptions instance
            Dim pptx_save As New PptxSaveOptions()
            ' Save the output in PPTX format
            doc.Save(dataDir & Convert.ToString("PDFToPPT_out_.pptx"), pptx_save)
            ' ExEnd:PDFToPPT
        End Sub
    End Class
End Namespace
