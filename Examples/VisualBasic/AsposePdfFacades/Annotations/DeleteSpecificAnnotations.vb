Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Annotations
    Public Class DeleteSpecificAnnotations
        Public Shared Sub Run()
            ' ExStart:DeleteSpecificAnnotations
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Annotations()
            ' Open document
            Dim annotationEditor As New PdfAnnotationEditor()
            annotationEditor.BindPdf(dataDir & Convert.ToString("DeleteAllAnnotations.pdf"))
            ' Delete specific annoations
            annotationEditor.DeleteAnnotations("Text")
            ' Save updated PDF
            annotationEditor.Save(dataDir & Convert.ToString("DeleteSpecificAnnotations_out_.pdf"))
            ' ExEnd:DeleteSpecificAnnotations
        End Sub
    End Class
End Namespace