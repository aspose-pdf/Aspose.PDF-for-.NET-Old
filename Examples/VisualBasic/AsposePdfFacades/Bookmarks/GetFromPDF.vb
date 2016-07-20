Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Bookmarks
    Public Class GetFromPDF
        Public Shared Sub Run()
            ' ExStart:GetFromPDF
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Bookmarks()
            ' Create PdfBookmarkEditor
            Dim bookmarkEditor As New PdfBookmarkEditor()
            ' Open PDF file
            bookmarkEditor.BindPdf(dataDir & Convert.ToString("GetFromPDF.PDF"))
            ' Extract bookmarks
            Dim bookmarks As Aspose.Pdf.Facades.Bookmarks = bookmarkEditor.ExtractBookmarks()
            For Each bookmark As Aspose.Pdf.Facades.Bookmark In bookmarks
                ' Get the title information of bookmark item
                Console.WriteLine("Title: {0}", bookmark.Title)
                ' Get the destination page for bookmark
                Console.WriteLine("Page Number: {0}", bookmark.PageNumber)
                ' Get the information related to associated action with bookmark
                Console.WriteLine("Bookmark Action: " + bookmark.Action)
            Next
            ' ExEnd:GetFromPDF
        End Sub
    End Class
End Namespace
