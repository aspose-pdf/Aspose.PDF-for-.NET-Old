Imports System
Imports Microsoft.VisualBasic
Imports System.IO
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Attachments
    Public Class ExtractAllAttachments
        Public Shared Sub Run()
            ' ExStart:ExtractAllAttachments
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Attachments()
            ' Open document
            Dim pdfExtractor As New PdfExtractor()
            pdfExtractor.BindPdf(dataDir & "ExtractAllAttachments.pdf")

            ' Extract attachments
            pdfExtractor.ExtractAttachment()

            ' Get extracted attachments
            pdfExtractor.GetAttachment(dataDir)
            ' ExEnd:ExtractAllAttachments
        End Sub
    End Class
End Namespace