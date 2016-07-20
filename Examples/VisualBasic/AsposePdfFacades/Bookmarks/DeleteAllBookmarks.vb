Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Bookmarks
    Public Class DeleteAllBookmarks
        Public Shared Sub Run()
            ' ExStart:DeleteAllBookmarks
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Bookmarks()
            ' Open document
            Dim bookmarkEditor As New PdfBookmarkEditor()
            bookmarkEditor.BindPdf(dataDir & Convert.ToString("DeleteAllBookmarks.pdf"))
            ' Delete bookmark
            bookmarkEditor.DeleteBookmarks()
            ' Save updated PDF file
            bookmarkEditor.Save(dataDir & Convert.ToString("DeleteAllBookmarks_out_.pdf"))
            ' ExEnd:DeleteAllBookmarks

        End Sub
    End Class
End Namespace

