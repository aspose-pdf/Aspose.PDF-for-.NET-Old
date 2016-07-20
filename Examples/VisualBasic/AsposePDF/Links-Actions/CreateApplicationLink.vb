Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf.Annotations
Imports Aspose.Pdf

Namespace AsposePDF.LinksActions
    Public Class CreateApplicationLink
        Public Shared Sub Run()
            ' ExStart:CreateApplicationLink
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_LinksActions()

            ' Open document
            Dim document As New Document(dataDir & Convert.ToString("CreateApplicationLink.pdf"))

            ' Create link
            Dim page As Page = document.Pages(1)
            Dim link As New LinkAnnotation(page, New Rectangle(100, 100, 300, 300))
            link.Color = Color.FromRgb(System.Drawing.Color.Green)
            link.Action = New LaunchAction(document, dataDir & Convert.ToString("CreateApplicationLink.pdf"))
            page.Annotations.Add(link)

            dataDir = dataDir & Convert.ToString("CreateApplicationLink_out_.pdf")
            ' Save updated document
            document.Save(dataDir)
            ' ExEnd:CreateApplicationLink
            Console.WriteLine(Convert.ToString(vbLf & "Application link created successfully." & vbLf & "File saved at ") & dataDir)

        End Sub
    End Class
End Namespace
