Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Annotations
Imports Aspose.Pdf.Facades
Namespace AsposePDFFacades.Annotations
    Public Class UpdateAnnotations
        Public Shared Sub Run()
            ' ExStart:UpdateAnnotations
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Annotations()

            ' Open document
            Dim annotationEditor As New Aspose.Pdf.Facades.PdfAnnotationEditor()
            annotationEditor.BindPdf(dataDir & Convert.ToString("input.pdf"))

            ' Create annotation
            Dim annotation As New FreeTextAnnotation(annotationEditor.Document.Pages(1), New Aspose.Pdf.Rectangle(200, 400, 400, 600), New DefaultAppearance("TimesNewRoman", 14, System.Drawing.Color.Orange))
            annotation.Modified = DateTime.Now
            annotation.Contents = "Contents..."
            annotation.Subject = "Subject"
            annotation.Color = Color.Green

            ' Modify annotation
            annotationEditor.ModifyAnnotations(1, 1, annotation)

            ' Save updated PDF file
            annotationEditor.Save("output_out_.pdf")
            ' ExEnd:UpdateAnnotations
        End Sub
    End Class
End Namespace
