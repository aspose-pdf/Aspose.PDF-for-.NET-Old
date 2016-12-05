Imports System.IO
Imports System
Imports System.Collections
Imports Aspose.Pdf.Facades

Namespace AsposePDFFacades.TechnicalArticles
    Public Class PdfAnnotationEditorFeatures
        Public Shared Sub Run()
            ' ExStart:PdfAnnotationEditorFeatures
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles()

            ' Create an object of PdfAnnotationEditor class
            Dim editor As New PdfAnnotationEditor()
            ' Bind input PDF file
            editor.BindPdf(dataDir & Convert.ToString("inFile.pdf"))

            ' Create a new object of type Annotation to modify annotation attributes
            Dim annotation As New Aspose.Pdf.Annotations.FreeTextAnnotation(editor.Document.Pages(1), New Aspose.Pdf.Rectangle(200, 400, 400, 600), New Aspose.Pdf.Annotations.DefaultAppearance("TimesNewRoman", 14, System.Drawing.Color.Orange))

            ' Set new annotation attributees
            annotation.Subject = "technical article"

            ' Modify annotations in the PDF file
            editor.ModifyAnnotations(1, 5, annotation)

            ' Delete all the annotations of type Stamp
            editor.DeleteAnnotation("Stamp")

            ' Extract annotations to an array list
            ' String[] annType = { "Text" };
            Dim annotType As [Enum]() = {Aspose.Pdf.Annotations.AnnotationType.FreeText, Aspose.Pdf.Annotations.AnnotationType.Line}
            Dim list As ArrayList = DirectCast(editor.ExtractAnnotations(1, 5, annotType), ArrayList)
            For index As Integer = 0 To list.Count - 1
                Dim list_annotation As Aspose.Pdf.Annotations.Annotation = DirectCast(list(index), Aspose.Pdf.Annotations.Annotation)
                Console.WriteLine(list_annotation.Contents)
            Next

            ' Import annotations from another PDF file
            Dim importFrom As String() = New String(0) {}
            importFrom(0) = dataDir & Convert.ToString("inFile2.pdf")
            editor.ImportAnnotations(importFrom)

            ' Finally save the output PDF file
            editor.Save(dataDir & Convert.ToString("PdfAnnotationEditorFeatures_out_.pdf"))
            ' ExEnd:PdfAnnotationEditorFeatures                      
        End Sub
    End Class
End Namespace
