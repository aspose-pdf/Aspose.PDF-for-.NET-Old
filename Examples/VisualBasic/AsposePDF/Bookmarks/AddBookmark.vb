Imports Aspose.Pdf.Annotations
Imports Aspose.Pdf
Imports System
Imports Microsoft.VisualBasic
Namespace AsposePDF.Bookmarks
    Public Class AddBookmark
        Public Shared Sub Run()
            ' ExStart:AddBookmark
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Bookmarks()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("AddBookmark.pdf"))

            ' Create a bookmark object
            Dim pdfOutline As New OutlineItemCollection(pdfDocument.Outlines)
            pdfOutline.Title = "Test Outline"
            pdfOutline.Italic = True
            pdfOutline.Bold = True
            ' Set the destination page number
            pdfOutline.Action = New GoToAction(pdfDocument.Pages(1))
            ' Add bookmark in the document's outline collection.
            pdfDocument.Outlines.Add(pdfOutline)

            dataDir = dataDir & Convert.ToString("AddBookmark_out_.pdf")
            ' Save output
            pdfDocument.Save(dataDir)
            ' ExEnd:AddBookmark
            Console.WriteLine(Convert.ToString(vbLf & "Bookmark added successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace