Imports Microsoft.VisualBasic
Imports System.IO
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Attachments
    Public Class AddAttachment
        Public Shared Sub Run()
            ' ExStart:AddAttachment
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Attachments()
            ' Open document
            Dim contentEditor As New PdfContentEditor()
            contentEditor.BindPdf(dataDir & "AddAttachment.pdf")

            ' Add attachment
            contentEditor.AddDocumentAttachment(dataDir & "test.txt", "Attachment Description")

            ' Save updated PDF
            contentEditor.Save(dataDir & "AddAttachment_out_.pdf")
            ' ExEnd:AddAttachment
        End Sub
    End Class
End Namespace