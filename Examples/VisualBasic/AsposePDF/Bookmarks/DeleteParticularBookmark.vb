Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePDF.Bookmarks
    Public Class DeleteParticularBookmark
        Public Shared Sub Run()
            ' ExStart:DeleteParticularBookmark
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Bookmarks()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("DeleteParticularBookmark.pdf"))

            ' Delete particular outline by Title
            pdfDocument.Outlines.Delete("Child Outline")

            dataDir = dataDir & Convert.ToString("DeleteParticularBookmark_out_.pdf")
            ' Save updated file
            pdfDocument.Save(dataDir)
            ' ExEnd:DeleteParticularBookmark
            Console.WriteLine(Convert.ToString(vbLf & "Particular bookmark deleted successfully." & vbLf & "File saved at ") & dataDir)

        End Sub
    End Class
End Namespace