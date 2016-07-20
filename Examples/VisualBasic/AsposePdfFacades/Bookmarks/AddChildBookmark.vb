Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Bookmarks
    Public Class AddChildBookmark
        Public Shared Sub Run()
            ' ExStart:AddChildBookmark
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Bookmarks()
            ' Create bookmarks
            Dim bookmarks As New Aspose.Pdf.Facades.Bookmarks()
            Dim childBookmark1 As New Bookmark()
            childBookmark1.PageNumber = 1
            childBookmark1.Title = "First Child"
            Dim childBookmark2 As New Bookmark()
            childBookmark2.PageNumber = 2
            childBookmark2.Title = "Second Child"

            bookmarks.Add(childBookmark1)
            bookmarks.Add(childBookmark2)

            Dim bookmark As New Bookmark()
            bookmark.Action = "GoTo"
            bookmark.PageNumber = 1
            bookmark.Title = "Parent"

            bookmark.ChildItems = bookmarks

            ' Create PdfBookmarkEditor class
            Dim bookmarkEditor As New PdfBookmarkEditor()
            ' Bind PDF document
            bookmarkEditor.BindPdf(dataDir & Convert.ToString("AddChildBookmark.pdf"))
            ' Create bookmarks
            bookmarkEditor.CreateBookmarks(bookmark)
            ' Save updated document
            bookmarkEditor.Save(dataDir & Convert.ToString("AddChildBookmark_out_.pdf"))
            ' ExEnd:AddChildBookmark
        End Sub
    End Class
End Namespace
