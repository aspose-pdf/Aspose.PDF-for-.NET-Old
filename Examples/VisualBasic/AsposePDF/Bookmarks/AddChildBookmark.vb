Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf.Annotations
Imports Aspose.Pdf

Namespace AsposePDF.Bookmarks
    Public Class AddChildBookmark
        Public Shared Sub Run()
            ' ExStart:AddChildBookmark
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Bookmarks()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("AddChildBookmark.pdf"))

            ' Create a parent bookmark object
            Dim pdfOutline As New OutlineItemCollection(pdfDocument.Outlines)
            pdfOutline.Title = "Parent Outline"
            pdfOutline.Italic = True
            pdfOutline.Bold = True

            ' Create a child bookmark object
            Dim pdfChildOutline As New OutlineItemCollection(pdfDocument.Outlines)
            pdfChildOutline.Title = "Child Outline"
            pdfChildOutline.Italic = True
            pdfChildOutline.Bold = True
         
            ' Add child bookmark in parent bookmark's collection
            pdfOutline.Add(pdfChildOutline)
            ' Add parent bookmark in the document's outline collection.
            pdfDocument.Outlines.Add(pdfOutline)

            dataDir = dataDir & Convert.ToString("AddChildBookmark_out_.pdf")
            ' Save output
            pdfDocument.Save(dataDir)
            ' ExEnd:AddChildBookmark
            Console.WriteLine(Convert.ToString(vbLf & "Child bookmark added successfully." & vbLf & "File saved at ") & dataDir)

        End Sub
    End Class
End Namespace