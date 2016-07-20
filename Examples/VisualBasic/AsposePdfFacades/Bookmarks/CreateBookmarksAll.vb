Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Bookmarks
    Public Class CreateBookmarksAll
        Public Shared Sub Run()
            ' ExStart:CreateBookmarksAll
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Bookmarks()
            ' Open document
            Dim bookmarkEditor As New PdfBookmarkEditor()
            bookmarkEditor.BindPdf(dataDir & Convert.ToString("CreateBookmarksAll.pdf"))
            ' Create bookmark of all pages
            bookmarkEditor.CreateBookmarks()
            ' Save updated PDF file
            bookmarkEditor.Save(dataDir & Convert.ToString("Output_out_.pdf"))
            ' ExEnd:CreateBookmarksAll
        End Sub
    End Class
End Namespace
