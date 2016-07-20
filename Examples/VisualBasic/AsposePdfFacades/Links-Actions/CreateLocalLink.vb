Imports System.IO
Imports System
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.LinksActions
    Public Class CreateLocalLink
        Public Shared Sub Run()
            ' ExStart:CreateLocalLink
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_LinksActions()

            ' Open document
            Dim contentEditor As New PdfContentEditor()
            contentEditor.BindPdf(dataDir & Convert.ToString("CreateApplicationLink.pdf"))

            Dim rectangle As New System.Drawing.Rectangle(100, 100, 200, 200)

            ' Create application link
            contentEditor.CreateLocalLink(rectangle, 3, 1, System.Drawing.Color.Red)

            ' Save updated PDF
            contentEditor.Save(dataDir & "CreateLocalLink_out_.pdf")
            ' ExEnd:CreateLocalLink                                 
        End Sub
    End Class
End Namespace
