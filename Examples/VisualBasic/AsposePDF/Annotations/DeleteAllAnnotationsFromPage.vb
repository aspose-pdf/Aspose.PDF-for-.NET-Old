Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Namespace AsposePDF.Annotations
    Public Class DeleteAllAnnotationsFromPage
        Public Shared Sub Run()
            ' ExStart:DeleteAllAnnotationsFromPage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Annotations()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("DeleteAllAnnotationsFromPage.pdf"))

            ' Delete particular annotation
            pdfDocument.Pages(1).Annotations.Delete()

            dataDir = dataDir & Convert.ToString("DeleteAllAnnotationsFromPage_out_.pdf")
            ' Save updated document
            pdfDocument.Save(dataDir)
            ' ExEnd:DeleteAllAnnotationsFromPage
            Console.WriteLine(Convert.ToString(vbLf & "All annotation from a page deleted successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
