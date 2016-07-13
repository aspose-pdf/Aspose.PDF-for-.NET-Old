Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades
Imports Aspose.Pdf.Annotations
Imports System.Collections
Namespace AsposePDFFacades.Annotations
    Public Class ExtractAnnotations
        Public Shared Sub Run()
            Try
                ' ExStart:ExtractAnnotations
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Annotations()
                ' Create PdfAnnotationEditor
                Dim annotationEditor As New PdfAnnotationEditor()
                ' Open PDF document
                annotationEditor.BindPdf(dataDir & Convert.ToString("ExtractAnnotations.pdf"))
                ' Extract annotations
                Dim annotType As [Enum]() = {AnnotationType.FreeText, AnnotationType.Line}
                Dim annotList As ArrayList = DirectCast(annotationEditor.ExtractAnnotations(1, 2, annotType), ArrayList)
                For index As Integer = 0 To annotList.Count - 1
                    Dim annotation As Annotation = DirectCast(annotList(index), Annotation)
                    Console.WriteLine(annotation.Contents)
                    ' ExEnd:ExtractAnnotations
                Next
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
    End Class
End Namespace