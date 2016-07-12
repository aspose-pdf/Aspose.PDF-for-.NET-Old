Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Text
Imports Aspose.Pdf.Text.TextOptions
Imports Aspose.Pdf.Annotations
Namespace AsposePDF.LinksActions
    Public Class UpdateLinkTextColor
        Public Shared Sub Run()
            Try
                ' ExStart:UpdateLinkTextColor
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_LinksActions()
                ' Load the PDF file
                Dim doc As New Document(dataDir & Convert.ToString("UpdateLinks.pdf"))
                For Each annotation As Annotation In doc.Pages(1).Annotations
                    If TypeOf annotation Is LinkAnnotation Then
                        ' Search the text under the annotation
                        Dim ta As New TextFragmentAbsorber()
                        Dim rect As Rectangle = annotation.Rect
                        rect.LLX -= 10
                        rect.LLY -= 10
                        rect.URX += 10
                        rect.URY += 10
                        ta.TextSearchOptions = New TextSearchOptions(rect)
                        ta.Visit(doc.Pages(1))
                        ' Change color of the text.
                        For Each tf As TextFragment In ta.TextFragments
                            tf.TextState.ForegroundColor = Color.Red
                        Next

                    End If
                Next
                dataDir = dataDir & Convert.ToString("UpdateLinkTextColor_out_.pdf")
                ' Save the document with updated link
                doc.Save(dataDir)
                ' ExEnd:UpdateLinkTextColor
                Console.WriteLine(Convert.ToString(vbLf & "LinkAnnotation text color updated successfully." & vbLf & "File saved at ") & dataDir)
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
    End Class
End Namespace
