Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf.Annotations
Imports Aspose.Pdf
Namespace AsposePDF.Annotations
    Public Class AddAnnotation
        Public Shared Sub Run()
            ' ExStart:AddAnnotation
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Annotations()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("AddAnnotation.pdf"))

            ' Create annotation
            Dim textAnnotation As New TextAnnotation(pdfDocument.Pages(1), New Rectangle(200, 400, 400, 600))
            textAnnotation.Title = "Sample Annotation Title"
            textAnnotation.Subject = "Sample Subject"
            textAnnotation.State = AnnotationState.Accepted
            textAnnotation.Contents = "Sample contents for the annotation"
            textAnnotation.Open = True
            textAnnotation.Icon = TextIcon.Key

            Dim border As New Border(textAnnotation)
            border.Width = 5
            border.Dash = New Dash(1, 1)
            textAnnotation.Border = border
            textAnnotation.Rect = New Rectangle(200, 400, 400, 600)

            ' Add annotation in the annotations collection of the page
            pdfDocument.Pages(1).Annotations.Add(textAnnotation)
            dataDir = dataDir & Convert.ToString("AddAnnotation_out_.pdf")
            ' Save output file
            pdfDocument.Save(dataDir)
            ' ExEnd:AddAnnotation
            Console.WriteLine(Convert.ToString(vbLf & "Annotation added successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
