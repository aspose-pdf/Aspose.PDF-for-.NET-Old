Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf.Annotations
Imports Aspose.Pdf

Namespace AsposePDF.Annotations
    Public Class GetAllAnnotationsFromPage
        Public Shared Sub Run()
            ' ExStart:GetAllAnnotationsFromPage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Annotations()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("GetAllAnnotationsFromPage.pdf"))

            ' Loop through all the annotations
            For Each annotation As MarkupAnnotation In pdfDocument.Pages(1).Annotations
                ' Get annotation properties
                Console.WriteLine("Title : {0} ", annotation.Title)
                Console.WriteLine("Subject : {0} ", annotation.Subject)
                Console.WriteLine("Contents : {0} ", annotation.Contents)
            Next
            ' ExEnd:GetAllAnnotationsFromPage
        End Sub
    End Class
End Namespace
