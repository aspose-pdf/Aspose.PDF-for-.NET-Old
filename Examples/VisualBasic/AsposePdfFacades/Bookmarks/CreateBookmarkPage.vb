Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Bookmarks
    Public Class CreateBookmarkPage
        Public Shared Sub Run()
            ' ExStart:CreateBookmarkPage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Bookmarks()
            ' Open document
            Dim bookmarkEditor As New PdfBookmarkEditor()
            bookmarkEditor.BindPdf(dataDir & Convert.ToString("CreateBookmark-Page.pdf"))
            ' Create bookmark of a particular page
            bookmarkEditor.CreateBookmarkOfPage("Bookmark Name", 2)
            ' Save updated PDF file
            bookmarkEditor.Save(dataDir & Convert.ToString("CreateBookmark-Page_out_.pdf"))
            ' ExEnd:CreateBookmarkPage
        End Sub
    End Class
End Namespace

