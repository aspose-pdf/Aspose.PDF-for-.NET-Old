Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.Bookmarks
    Public Class UpdateChildBookmarks
        Public Shared Sub Run()
            ' ExStart:UpdateChildBookmarks
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Bookmarks()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("UpdateChildBookmarks.pdf"))

            ' Get a bookmark object
            Dim pdfOutline As OutlineItemCollection = pdfDocument.Outlines(1)

            ' Get child bookmark object
            Dim childOutline As OutlineItemCollection = pdfOutline(1)
            childOutline.Title = "Updated Outline"
            childOutline.Italic = True
            childOutline.Bold = True
            dataDir = dataDir & Convert.ToString("UpdateChildBookmarks_out_.pdf")
            ' Save output
            pdfDocument.Save(dataDir)
            ' ExEnd:UpdateChildBookmarks
            Console.WriteLine(Convert.ToString(vbLf & "Child bookmarks updated successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace