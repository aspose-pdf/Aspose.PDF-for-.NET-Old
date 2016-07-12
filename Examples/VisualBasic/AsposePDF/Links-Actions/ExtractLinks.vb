Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Annotations
Imports System.Collections

Namespace AsposePDF.LinksActions
    Public Class ExtractLinks
        Public Shared Sub Run()
            ' ExStart:ExtractLinks
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_LinksActions()
            ' Open document
            Dim document As New Document(dataDir & Convert.ToString("ExtractLinks.pdf"))
            ' Extract actions
            Dim page As Page = document.Pages(1)
            Dim selector As New AnnotationSelector(New LinkAnnotation(page, Rectangle.Trivial))
            page.Accept(selector)
            Dim list As IList = selector.Selected
            Dim annotation As Annotation = DirectCast(list(0), Annotation)
            dataDir = dataDir & Convert.ToString("ExtractLinks_out_.pdf")
            ' Save updated document
            document.Save(dataDir)
            ' ExEnd:ExtractLinks
            Console.WriteLine(Convert.ToString(vbLf & "Links extracted successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
