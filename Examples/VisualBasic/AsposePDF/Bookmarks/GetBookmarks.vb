Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.Bookmarks
    Public Class GetBookmarks
        Public Shared Sub Run()
            ' ExStart:GetBookmarks
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Bookmarks()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("GetBookmarks.pdf"))

            ' Loop through all the bookmarks
            For Each outlineItem As OutlineItemCollection In pdfDocument.Outlines
                Console.WriteLine(outlineItem.Title)
                Console.WriteLine(outlineItem.Italic)
                Console.WriteLine(outlineItem.Bold)
                Console.WriteLine(outlineItem.Color)
            Next
            ' ExEnd:GetBookmarks
        End Sub
    End Class
End Namespace
