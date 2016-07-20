Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf.Annotations
Imports Aspose.Pdf

Namespace AsposePDF.Bookmarks
    Public Class InheritZoom
        Public Shared Sub Run()
            ' ExStart:InheritZoom
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Bookmarks()

            ' Open document
            Dim doc As New Document(dataDir & Convert.ToString("input.pdf"))

            ' get outlines/bookmarks collection of PDF file
            Dim item As New OutlineItemCollection(doc.Outlines)
            ' set zoom level as 0
            Dim dest As New XYZExplicitDestination(2, 100, 100, 0)
            ' Add XYZExplicitDestination as action to outlines collection of PDF
            item.Action = New GoToAction(dest)
            ' Add item to outlines collection of PDF file
            doc.Outlines.Add(item)

            dataDir = dataDir & Convert.ToString("InheritZoom_out_.pdf")
            ' Save output
            doc.Save(dataDir)
            ' ExEnd:InheritZoom
            Console.WriteLine(Convert.ToString(vbLf & "Bookmarks updated successfully." & vbLf & "File saved at ") & dataDir)

        End Sub
    End Class
End Namespace