Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Bookmarks
    Public Class UpdateBookmark
        Public Shared Sub Run()
            ' ExStart:UpdateBookmark
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Bookmarks()
            ' Open document
            Dim bookmarkEditor As New PdfBookmarkEditor()
            bookmarkEditor.BindPdf(dataDir & Convert.ToString("UpdateBookmark.pdf"))
            ' Update bookmark
            bookmarkEditor.ModifyBookmarks("New Bookmark", "New Title")
            ' Save updated PDF file
            bookmarkEditor.Save(dataDir & Convert.ToString("UpdateBookmark_out_.pdf"))
            ' ExEnd:UpdateBookmark
        End Sub
    End Class
End Namespace

