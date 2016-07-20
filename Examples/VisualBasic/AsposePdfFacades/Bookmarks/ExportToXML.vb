Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Bookmarks
    Public Class ExportToXML
        Public Shared Sub Run()
            ' ExStart:ExportToXML
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Bookmarks()
            ' Create PdfBookmarkEditor object
            Dim bookmarkEditor As New PdfBookmarkEditor()
            ' Open PDF file
            bookmarkEditor.BindPdf(dataDir & Convert.ToString("ExportToXML.pdf"))
            ' Export bookmarks
            bookmarkEditor.ExportBookmarksToXML(dataDir & Convert.ToString("bookmarks.xml"))
            ' Save updated PDF
            bookmarkEditor.Save(dataDir & Convert.ToString("ExportToXML_out_.pdf"))
            ' ExEnd:ExportToXML            
        End Sub
    End Class
End Namespace
