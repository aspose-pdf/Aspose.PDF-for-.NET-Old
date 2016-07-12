Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf.Annotations
Imports Aspose.Pdf
Namespace AsposePDF.LinksActions
    Public Class CreateDocumentLink
        Public Shared Sub Run()
            ' ExStart:CreateDocumentLink
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_LinksActions()
            ' Open document
            Dim document As New Document(dataDir & Convert.ToString("CreateDocumentLink.pdf"))
            ' Create link
            Dim page As Page = document.Pages(1)
            Dim link As New LinkAnnotation(page, New Rectangle(100, 100, 300, 300))
            link.Color = Color.FromRgb(System.Drawing.Color.Green)
            link.Action = New GoToRemoteAction(dataDir & Convert.ToString("CreateDocumentLink.pdf"), 1)
            page.Annotations.Add(link)
            dataDir = dataDir & Convert.ToString("CreateDocumentLink_out_.pdf")
            ' Save updated document
            document.Save(dataDir)
            ' ExEnd:CreateDocumentLink
            Console.WriteLine(Convert.ToString(vbLf & "Document link created successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
