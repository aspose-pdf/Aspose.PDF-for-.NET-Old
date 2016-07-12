Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Namespace AsposePDF.Bookmarks
    Public Class UpdateBookmarks
        Public Shared Sub Run()
            ' ExStart:UpdateBookmarks
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Bookmarks()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("UpdateBookmarks.pdf"))

            ' Get a bookmark object
            Dim pdfOutline As OutlineItemCollection = pdfDocument.Outlines(1)
            pdfOutline.Title = "Updated Outline"
            pdfOutline.Italic = True
            pdfOutline.Bold = True

            dataDir = dataDir & Convert.ToString("UpdateBookmarks_out_.pdf")
            ' Save output
            pdfDocument.Save(dataDir)
            ' ExEnd:UpdateBookmarks
            Console.WriteLine(Convert.ToString(vbLf & "Bookmarks updated successfully." & vbLf & "File saved at ") & dataDir)

        End Sub
    End Class
End Namespace