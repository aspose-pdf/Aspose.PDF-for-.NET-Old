Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Text
Imports System.Collections
Imports Aspose.Pdf.Annotations
Namespace AsposePDF.LinksActions
    Public Class GetHyperlinkText
        Public Shared Sub Run()
            Try
                ' ExStart:GetHyperlinkText
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_LinksActions()
                ' Load the PDF file
                Dim document As New Document(dataDir & Convert.ToString("input.pdf"))
                ' Iterate through each page of PDF
                For Each page As Page In document.Pages
                    ' Show link annotation
                    ShowLinkAnnotations(page)
                    ' ExEnd:GetHyperlinkText               
                Next
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
        ' ExStart:ShowLinkAnnotations
        Public Shared Sub ShowLinkAnnotations(page As Page)
            For Each annot As Annotation In page.Annotations
                If TypeOf annot Is LinkAnnotation Then
                    ' Print the URL of each Link Annotation
                    Console.WriteLine("URI: " + TryCast(TryCast(annot, LinkAnnotation).Action, GoToURIAction).URI)
                    Dim absorber As New TextAbsorber()
                    absorber.TextSearchOptions.LimitToPageBounds = True
                    absorber.TextSearchOptions.Rectangle = annot.Rect
                    page.Accept(absorber)
                    Dim extractedText As String = absorber.Text
                    ' Print the text associated with hyperlink
                    Console.WriteLine(extractedText)

                End If
            Next
        End Sub
        ' ExEnd:ShowLinkAnnotations
    End Class
End Namespace
