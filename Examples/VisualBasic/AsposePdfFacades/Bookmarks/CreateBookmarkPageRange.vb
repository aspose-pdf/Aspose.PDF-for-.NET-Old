Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Bookmarks
    Public Class CreateBookmarkPageRange
        Public Shared Sub Run()
            ' ExStart:CreateBookmarkPageRange
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Bookmarks()

            ' Open document
            Dim bookmarkEditor As New PdfBookmarkEditor()
            bookmarkEditor.BindPdf(dataDir & Convert.ToString("CreateBookmark-Page.pdf"))
            ' Bookmark name list
            Dim bookmarkList As String() = {"First"}
            ' Page list
            Dim pageList As Integer() = {1}
            ' Create bookmark of a range of pages
            bookmarkEditor.CreateBookmarkOfPage(bookmarkList, pageList)
            ' Save updated PDF file
            bookmarkEditor.Save(dataDir & "CreateBookmarkPageRange_out_.pdf")
            ' ExEnd:CreateBookmarkPageRange
        End Sub
    End Class
End Namespace
