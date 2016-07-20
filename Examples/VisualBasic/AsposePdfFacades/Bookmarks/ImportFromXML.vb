Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Bookmarks
    Public Class ImportFromXML
        Public Shared Sub Run()
            ' ExStart:ImportFromXML
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Bookmarks()
            ' Create PdfBookmarkEditor class
            Dim bookmarkEditor As New PdfBookmarkEditor()
            ' Open PDF file
            bookmarkEditor.BindPdf(dataDir & Convert.ToString("ImportFromXML.pdf"))
            ' Import bookmarks
            bookmarkEditor.ImportBookmarksWithXML(dataDir & Convert.ToString("bookmarks.xml"))
            ' Save updated PDF file
            bookmarkEditor.Save(dataDir & Convert.ToString("ImportFromXML_out_.pdf"))
            ' ExEnd:ImportFromXML        
        End Sub
    End Class
End Namespace

