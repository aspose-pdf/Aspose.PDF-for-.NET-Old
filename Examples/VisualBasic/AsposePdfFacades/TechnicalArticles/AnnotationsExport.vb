Imports System.IO
Imports System
Imports Aspose.Pdf.Facades
Imports Aspose.Pdf.Annotations

Namespace AsposePDFFacades.TechnicalArticles
    Public Class AnnotationsExport
        Public Shared Sub Run()
            ' ExStart:AnnotationsExport
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles()

            ' Create an object of PdfAnnotationEditor class
            Dim editor As New PdfAnnotationEditor()
            ' Bind input PDF file
            editor.BindPdf(dataDir & Convert.ToString("inFile.pdf"))
            ' Create a file stream for output XFDF file to export annotations
            Dim fileStream As New FileStream(dataDir & Convert.ToString("exportannotations.xfdf"), FileMode.Create, FileAccess.Write)
            ' Create an enumeration of all the annotation types which you want to export
            Dim annoType As [Enum]() = {AnnotationType.Text}
            ' Export annotations of specified type(s) to XFDF file
            editor.ExportAnnotationsXfdf(fileStream, 1, 5, annoType)
            ' ExEnd:AnnotationsExport                      
        End Sub
    End Class
End Namespace
