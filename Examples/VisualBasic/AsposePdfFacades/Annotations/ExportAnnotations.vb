Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades
Imports Aspose.Pdf.Annotations

Namespace AsposePDFFacades.Annotations
    Public Class ExportAnnotations
        Public Shared Sub Run()
            ' ExStart:ExportAnnotations
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Annotations()
            ' Create PdfAnnotationEditor object
            Dim AnnotationEditor As New PdfAnnotationEditor()
            ' Open PDF document
            AnnotationEditor.BindPdf(dataDir & Convert.ToString("ExportAnnotations.pdf"))
            ' Export annotations
            Dim fileStream As FileStream = New System.IO.FileStream(dataDir & Convert.ToString("annotations.xfdf"), System.IO.FileMode.Create)
            Dim annotType As [Enum]() = {AnnotationType.FreeText, AnnotationType.Line}
            AnnotationEditor.ExportAnnotationsXfdf(fileStream, 1, 5, annotType)
            ' Save output PDF
            AnnotationEditor.Save(dataDir & Convert.ToString("ExportAnnotations_out_.pdf"))
            ' ExEnd:ExportAnnotations
        End Sub
    End Class
End Namespace