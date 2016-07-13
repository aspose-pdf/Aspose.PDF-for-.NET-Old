Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades
Imports Aspose.Pdf.Annotations
Namespace AsposePDFFacades.Annotations
    Public Class ImportAnnotations
        Public Shared Sub Run()
            ' ExStart:ImportAnnotations
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Annotations()
            ' Create PdfAnnotationEditor object
            Dim AnnotationEditor As New PdfAnnotationEditor()
            ' Open PDF document
            AnnotationEditor.BindPdf(dataDir & Convert.ToString("ImportAnnotations.pdf"))
            ' Import annotations
            Dim fileStream As FileStream = New System.IO.FileStream(dataDir & Convert.ToString("annotations.xfdf"), System.IO.FileMode.Open, System.IO.FileAccess.Read)
            Dim annotType As [Enum]() = {AnnotationType.FreeText, AnnotationType.Line}
            AnnotationEditor.ImportAnnotationFromXfdf(fileStream, annotType)
            ' Save output PDF
            AnnotationEditor.Save(dataDir & Convert.ToString("ImportAnnotations_out_.pdf"))
            ' ExEnd:ImportAnnotations            
        End Sub
    End Class
End Namespace