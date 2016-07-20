Imports System.IO
Imports System
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.LinksActions
    Public Class CreateAppLinkWithColor
        Public Shared Sub Run()
            ' ExStart:CreateAppLinkWithColor
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_LinksActions()

            ' Open document
            Dim contentEditor As New PdfContentEditor()
            contentEditor.BindPdf(dataDir & Convert.ToString("CreateApplicationLink.pdf"))

            Dim rectangle As New System.Drawing.Rectangle(100, 100, 200, 200)

            ' Create application link
            contentEditor.CreateApplicationLink(rectangle, dataDir & Convert.ToString("test.txt"), 1, System.Drawing.Color.Red)

            ' Save updated PDF
            contentEditor.Save(dataDir & "CreateAppLinkWithColor_out_.pdf")
            ' ExEnd:CreateAppLinkWithColor                                 
        End Sub
    End Class
End Namespace
