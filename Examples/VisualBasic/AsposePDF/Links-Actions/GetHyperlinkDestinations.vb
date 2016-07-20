Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports System.Collections
Imports Aspose.Pdf.Annotations

Namespace AsposePDF.LinksActions
    Public Class GetHyperlinkDestinations
        Public Shared Sub Run()
            Try
                ' ExStart:GetHyperlinkDestinations
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_LinksActions()
                ' Load the PDF file
                Dim document As New Document(dataDir & Convert.ToString("input.pdf"))

                ' Traverse through all the page of PDF
                For Each page As Page In document.Pages
                    ' Get the link annotations from particular page
                    Dim selector As New AnnotationSelector(New LinkAnnotation(page, Rectangle.Trivial))

                    page.Accept(selector)
                    ' Create list holding all the links
                    Dim list As IList = selector.Selected
                    ' Iterate through invidiaul item inside list
                    For Each a As LinkAnnotation In list
                        ' Print the destination URL
                        Console.WriteLine(vbLf & "Destination: " + TryCast(a.Action, GoToURIAction).URI + vbLf)
                    Next
                    ' ExEnd:GetHyperlinkDestinations               
                Next
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
    End Class
End Namespace
