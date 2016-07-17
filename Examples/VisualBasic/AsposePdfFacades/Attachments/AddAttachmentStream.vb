Imports Microsoft.VisualBasic
Imports System.IO
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Attachments
    Public Class AddAttachmentStream
        Public Shared Sub Run()
            ' ExStart:AddAttachmentStream
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Attachments()
            ' Open document
            Dim contentEditor As New PdfContentEditor()
            contentEditor.BindPdf(dataDir & "AddAttachment-Stream.pdf")

            ' Read file into stream (FileStream or MemoryStream)
            Dim fileStream As New FileStream(dataDir & "test.txt", FileMode.Open)
            ' Add attachment
            contentEditor.AddDocumentAttachment(fileStream, "Attachment Name", "Attachment Description")

            ' Save updated PDF
            contentEditor.Save(dataDir & "AddAttachment-Stream_out_.pdf")
            ' ExEnd:AddAttachmentStream

        End Sub
    End Class
End Namespace