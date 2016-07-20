Imports System.IO
Imports System
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.LinksActions
    Public Class CreateDocLink
        Public Shared Sub Run()
            ' ExStart:CreateDocLink
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_LinksActions()

            ' Open document
            Dim contentEditor As New PdfContentEditor()
            contentEditor.BindPdf(dataDir & Convert.ToString("CreateDocumentLink.pdf"))

            Dim rectangle As New System.Drawing.Rectangle(100, 100, 200, 200)

            ' Create application link
            contentEditor.CreatePdfDocumentLink(rectangle, dataDir & Convert.ToString("RemoveOpenAction.pdf"), 1, 4)

            ' Save updated PDF
            contentEditor.Save(dataDir & "CreateDocLink_out_.pdf")
            ' ExEnd:CreateDocLink
        End Sub
    End Class
End Namespace
