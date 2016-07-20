Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.Annotations
    Public Class DeleteAllAnnotations
        Public Shared Sub Run()
            ' ExStart:DeleteAllAnnotations
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Annotations()
            ' Open document
            Dim annotationEditor As New PdfAnnotationEditor()
            annotationEditor.BindPdf(dataDir & Convert.ToString("DeleteAllAnnotations.pdf"))
            ' Delete all annoations
            annotationEditor.DeleteAnnotations()
            ' Save updated PDF
            annotationEditor.Save(dataDir & Convert.ToString("DeleteAllAnnotations_out_.pdf"))
            ' ExEnd:DeleteAllAnnotations
        End Sub
    End Class
End Namespace
