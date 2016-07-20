Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.Bookmarks
    Public Class ExpandBookmarks
        Public Shared Sub Run()
            ' ExStart:ExpandBookmarks
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Bookmarks()

            ' Open document
            Dim doc As New Document(dataDir & Convert.ToString("input.pdf"))

            ' Set page view mode i.e. show thumbnails, full-screen, show attachment panel
            doc.PageMode = PageMode.UseOutlines
            ' Traverse through each Ouline item in outlines collection of PDF file
            For Each item As OutlineItemCollection In doc.Outlines
                ' Set open status for outline item
                item.Open = True
            Next

            dataDir = dataDir & Convert.ToString("ExpandBookmarks_out_.pdf")
            ' Save output
            doc.Save(dataDir)
            ' ExEnd:ExpandBookmarks
            Console.WriteLine(Convert.ToString(vbLf & "Bookmarks expanded successfully." & vbLf & "File saved at ") & dataDir)

        End Sub
    End Class
End Namespace
