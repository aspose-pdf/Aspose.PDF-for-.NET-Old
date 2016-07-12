Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Attachments
    Public Class AddAttachment
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Attachments()
            'open document
            Dim contentEditor As New PdfContentEditor()
            contentEditor.BindPdf(dataDir & "AddAttachment.pdf")

            'add attachment
            contentEditor.AddDocumentAttachment(dataDir & "test.txt", "Attachment Description")

            'save updated PDF
            contentEditor.Save(dataDir & "AddAttachment_out.pdf")

        End Sub
    End Class
End Namespace