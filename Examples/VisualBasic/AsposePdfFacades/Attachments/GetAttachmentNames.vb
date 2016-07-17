Imports Microsoft.VisualBasic
Imports System.IO
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades
Imports System

Namespace AsposePDFFacades.Attachments
    Public Class GetAttachmentNames
        Public Shared Sub Run()
            ' ExStart:GetAttachmentNames
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Attachments()
            ' Open document
            Dim pdfExtractor As New PdfExtractor()
            pdfExtractor.BindPdf(dataDir & "GetAttachmentNames.pdf")

            ' Extract attachments
            pdfExtractor.ExtractAttachment()

            ' Get attachment names
            Dim attachmentNames As System.Collections.IList = CType(pdfExtractor.GetAttachNames(), System.Collections.IList)

            For Each attachmentName As String In attachmentNames
                Console.WriteLine("Name : {0}", attachmentName)
            Next attachmentName
            ' ExEnd:GetAttachmentNames
        End Sub
    End Class
End Namespace