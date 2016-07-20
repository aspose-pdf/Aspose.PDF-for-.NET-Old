Imports System.IO
Imports System
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.LinksActions
    Public Class RemoveAction
        Public Shared Sub Run()
            ' ExStart:RemoveAction
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_LinksActions()

            ' Open document
            Dim contentEditor As New PdfContentEditor()
            contentEditor.BindPdf(dataDir & Convert.ToString("RemoveOpenAction.pdf"))

            Dim rectangle As New System.Drawing.Rectangle(100, 100, 200, 200)

            ' Create application link
            contentEditor.RemoveDocumentOpenAction()

            ' Save updated PDF
            contentEditor.Save(dataDir & "RemoveOpenAction_out_.pdf")
            ' ExEnd:RemoveAction                        
        End Sub
    End Class
End Namespace
