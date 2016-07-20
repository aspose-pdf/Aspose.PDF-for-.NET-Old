Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Bookmarks
    Public Class DeleteABookmark
        Public Shared Sub Run()
            ' ExStart:DeleteABookmark
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Bookmarks()
            ' Open document
            Dim bookmarkEditor As New PdfBookmarkEditor()
            bookmarkEditor.BindPdf(dataDir & Convert.ToString("DeleteABookmark.pdf"))
            ' Delete bookmark
            bookmarkEditor.DeleteBookmarks("Page2")
            ' Save updated PDF file
            bookmarkEditor.Save(dataDir & Convert.ToString("DeleteABookmark_out_.pdf"))
            ' ExEnd:DeleteABookmark

        End Sub
    End Class
End Namespace

