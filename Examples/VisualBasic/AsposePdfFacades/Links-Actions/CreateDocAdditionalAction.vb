Imports System.IO
Imports System
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.LinksActions
    Public Class CreateDocAdditionalAction
        Public Shared Sub Run()
            ' ExStart:CreateDocAdditionalAction
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_LinksActions()

            ' Open document
            Dim contentEditor As New PdfContentEditor()
            contentEditor.BindPdf(dataDir & Convert.ToString("CreateDocumentLink.pdf"))

            Dim rectangle As New System.Drawing.Rectangle(100, 100, 200, 200)

            ' Create application link
            contentEditor.AddDocumentAdditionalAction(PdfContentEditor.DocumentClose, "app.alert('Thank you for using Aspose products!');")

            ' Save updated PDF
            contentEditor.Save(dataDir & "CreateDocAdditionalAction_out_.pdf")
            ' ExEnd:CreateDocAdditionalAction

        End Sub
    End Class
End Namespace
