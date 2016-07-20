Imports Microsoft.VisualBasic
Imports System.IO
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Bookmarks
    Public Class AddBookmark
        Public Shared Sub Run()
            ' ExStart:AddBookmark
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Bookmarks()
            ' Create bookmark
            Dim boomark As New Bookmark()
            boomark.PageNumber = 1
            boomark.Title = "New Bookmark"
            ' Create PdfBookmarkEditor class
            Dim bookmarkEditor As New PdfBookmarkEditor()
            ' Bind PDF document
            bookmarkEditor.BindPdf(dataDir & "AddBookmark.pdf")
            ' Create bookmarks
            bookmarkEditor.CreateBookmarks(boomark)
            ' Save updated document
            bookmarkEditor.Save(dataDir & "AddBookmark_out_.pdf")
            ' ExEnd:AddBookmark
        End Sub
    End Class
End Namespace