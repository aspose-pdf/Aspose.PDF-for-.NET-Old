Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Namespace AsposePDF.Bookmarks
    Public Class DeleteAllBookmarks
        Public Shared Sub Run()
            ' ExStart:DeleteAllBookmarks
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Bookmarks()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("DeleteAllBookmarks.pdf"))

            ' Delete all bookmarks
            pdfDocument.Outlines.Delete()

            dataDir = dataDir & Convert.ToString("DeleteAllBookmarks_out_.pdf")
            ' Save updated file
            pdfDocument.Save(dataDir)
            ' ExEnd:DeleteAllBookmarks
            Console.WriteLine(Convert.ToString(vbLf & "All bookmarks deleted successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace