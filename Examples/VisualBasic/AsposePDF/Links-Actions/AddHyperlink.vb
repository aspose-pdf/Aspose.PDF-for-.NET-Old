Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Text
Imports Aspose.Pdf.Annotations

Namespace AsposePDF.LinksActions
    Public Class AddHyperlink
        Public Shared Sub Run()
            ' ExStart:AddHyperlink
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_LinksActions()

            ' Open document
            Dim document As New Document(dataDir & Convert.ToString("AddHyperlink.pdf"))
            ' Create link
            Dim page As Page = document.Pages(1)
            ' Create Link annotation object
            Dim link As New LinkAnnotation(page, New Rectangle(100, 100, 300, 300))
            ' Create border object for LinkAnnotation
            Dim border As New Border(link)
            ' Set the border width value as 0
            border.Width = 0
            ' Set the border for LinkAnnotation
            link.Border = border
            ' Specify the link type as remote URI
            link.Action = New GoToURIAction("www.aspose.com")
            ' Add link annotation to annotations collection of first page of PDF file
            page.Annotations.Add(link)

            ' Create Free Text annotation
            Dim textAnnotation As New FreeTextAnnotation(document.Pages(1), New Rectangle(100, 100, 300, 300), New DefaultAppearance(FontRepository.FindFont("TimesNewRoman"), 10, System.Drawing.Color.Blue))
            ' String to be added as Free text
            textAnnotation.Contents = "Link to Aspose website"
            ' Set the border for Free Text Annotation
            textAnnotation.Border = border
            ' Add FreeText annotation to annotations collection of first page of Document
            document.Pages(1).Annotations.Add(textAnnotation)
            dataDir = dataDir & Convert.ToString("AddHyperlink_out_.pdf")
            ' Save updated document
            document.Save(dataDir)
            ' ExEnd:AddHyperlink
            Console.WriteLine(Convert.ToString(vbLf & "Hyperlink added successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
