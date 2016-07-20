Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Bookmarks
    Public Class CreateBookmarksPagesProperties
        Public Shared Sub Run()
            ' ExStart:CreateBookmarksPagesProperties
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Bookmarks()
            ' Open document
            Dim bookmarkEditor As New PdfBookmarkEditor()
            bookmarkEditor.BindPdf(dataDir & Convert.ToString("CreateBookmarks-PagesProperties.pdf"))
            ' Create bookmark of all pages
            bookmarkEditor.CreateBookmarks(System.Drawing.Color.Green, True, True)
            ' Save updated PDF file
            bookmarkEditor.Save(dataDir & Convert.ToString("CreateBookmarks-PagesProperties_out.pdf"))
            ' ExEnd:CreateBookmarksPagesProperties

        End Sub
    End Class
End Namespace
