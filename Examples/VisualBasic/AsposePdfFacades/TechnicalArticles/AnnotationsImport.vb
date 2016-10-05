Imports System.IO
Imports System
Imports Aspose.Pdf.Facades
Imports Aspose.Pdf.Annotations

Namespace AsposePDFFacades.TechnicalArticles
    Public Class AnnotationsImport
        Public Shared Sub Run()
            ' ExStart:AnnotationsImport
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles()

            ' Create an object of PdfAnnotationEditor class
            Dim editor As New PdfAnnotationEditor()
            ' Bind input PDF file
            editor.BindPdf(dataDir & Convert.ToString("inFile.pdf"))
            ' Create a file stream for input XFDF file to import annotations
            Dim fileStream As New FileStream(dataDir & Convert.ToString("exportannotations.xfdf"), FileMode.Open, FileAccess.Read)
            ' Create an enumeration of all the annotation types which you want to import
            Dim annType As [Enum]() = {AnnotationType.Text}
            ' Import annotations of specified type(s) from XFDF file
            editor.ImportAnnotationFromXfdf(fileStream, annType)
            ' Save output pdf file
            editor.Save(dataDir & Convert.ToString("ImportAnnotations_out_.pdf"))
            ' ExEnd:AnnotationsImport                      
        End Sub
    End Class
End Namespace
