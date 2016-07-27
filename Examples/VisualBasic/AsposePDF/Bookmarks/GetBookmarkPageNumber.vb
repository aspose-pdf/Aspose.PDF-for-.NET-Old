Imports System.IO
Imports System
Imports Aspose.Pdf.Facades

Namespace AsposePDF.Bookmarks
    Public Class GetBookmarkPageNumber
        Public Shared Sub Run()
            ' ExStart:GetBookmarkPageNumber
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Bookmarks()

            ' Create PdfBookmarkEditor
            Dim bookmarkEditor As New PdfBookmarkEditor()
            ' Open PDF file
            bookmarkEditor.BindPdf(dataDir & Convert.ToString("GetBookmarks.pdf"))
            ' Extract bookmarks
            Dim bookmarks As Aspose.Pdf.Facades.Bookmarks = bookmarkEditor.ExtractBookmarks()
            For Each bookmark As Aspose.Pdf.Facades.Bookmark In bookmarks
                Dim strLevelSeprator As String = String.Empty
                For i As Integer = 1 To bookmark.Level - 1
                    strLevelSeprator += "----"
                Next

                Console.WriteLine("{0}Title: {1}", strLevelSeprator, bookmark.Title)
                Console.WriteLine("{0}Page Number: {1}", strLevelSeprator, bookmark.PageNumber)
                Console.WriteLine("{0}Page Action: {1}", strLevelSeprator, bookmark.Action)
            Next
            ' ExEnd:GetBookmarkPageNumber
        End Sub
    End Class
End Namespace
