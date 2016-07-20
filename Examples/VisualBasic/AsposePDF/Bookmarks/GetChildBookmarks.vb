Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.Bookmarks
    Public Class GetChildBookmarks
        Public Shared Sub Run()
            ' ExStart:GetChildBookmarks
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Bookmarks()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("GetChildBookmarks.pdf"))

            ' Loop through all the bookmarks
            For Each outlineItem As OutlineItemCollection In pdfDocument.Outlines
                Console.WriteLine(outlineItem.Title)
                Console.WriteLine(outlineItem.Italic)
                Console.WriteLine(outlineItem.Bold)
                Console.WriteLine(outlineItem.Color)

                If outlineItem.Count > 0 Then
                    Console.WriteLine("Child Bookmarks")
                    'there are child bookmarks then loop through that as well
                    For Each childOutline As OutlineItemCollection In outlineItem
                        Console.WriteLine(childOutline.Title)
                        Console.WriteLine(childOutline.Italic)
                        Console.WriteLine(childOutline.Bold)
                        Console.WriteLine(childOutline.Color)
                    Next
                End If
            Next
            ' ExEnd:GetChildBookmarks
        End Sub
    End Class
End Namespace