Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Annotations
Namespace AsposePDF.Annotations
    Public Class GetParticularAnnotation
        Public Shared Sub Run()
            ' ExStart:GetParticularAnnotation
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Annotations()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("GetParticularAnnotation.pdf"))

            ' Get particular annotation
            Dim textAnnotation As TextAnnotation = DirectCast(pdfDocument.Pages(1).Annotations(1), TextAnnotation)

            ' Get annotation properties
            Console.WriteLine("Title : {0} ", textAnnotation.Title)
            Console.WriteLine("Subject : {0} ", textAnnotation.Subject)
            Console.WriteLine("Contents : {0} ", textAnnotation.Contents)
            ' ExEnd:GetParticularAnnotation
        End Sub
    End Class
End Namespace
