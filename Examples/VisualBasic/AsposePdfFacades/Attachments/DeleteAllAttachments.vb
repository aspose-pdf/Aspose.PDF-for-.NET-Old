Imports Microsoft.VisualBasic
Imports System.IO
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Attachments
    Public Class DeleteAllAttachments
        Public Shared Sub Run()
            ' ExStart:DeleteAllAttachments
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Attachments()
            ' Open document
            Dim contentEditor As New PdfContentEditor()
            contentEditor.BindPdf(dataDir & "DeleteAllAttachments.pdf")

            ' Delete attachments
            contentEditor.DeleteAttachments()

            ' Save updated PDF
            contentEditor.Save(dataDir & "DeleteAllAttachments_out.pdf")
            ' ExEnd:DeleteAllAttachments
        End Sub
    End Class
End Namespace