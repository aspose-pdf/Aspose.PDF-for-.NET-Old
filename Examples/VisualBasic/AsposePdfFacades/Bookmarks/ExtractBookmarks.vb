Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Bookmarks
    Public Class ExtractBookmarks
        Public Shared Sub Run()
            ' ExStart:ExtractBookmarks
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Bookmarks()
            ' Create PdfBookmarkEditor
            Dim bookmarkEditor As New PdfBookmarkEditor()
            ' Open PDF file
            bookmarkEditor.BindPdf(dataDir & Convert.ToString("ExtractBookmarks.pdf"))
            ' Extract bookmarks
            Dim bookmarks As Aspose.Pdf.Facades.Bookmarks = bookmarkEditor.ExtractBookmarks()

            For Each bookmark As Bookmark In bookmarks
                Console.WriteLine("Title: {0}", bookmark.Title)
                Console.WriteLine("Page Number: {0}", bookmark.PageNumber)
            Next
            ' ExEnd:ExtractBookmarks
        End Sub
    End Class
End Namespace
