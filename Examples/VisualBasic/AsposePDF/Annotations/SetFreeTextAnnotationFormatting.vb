Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf.Annotations
Imports Aspose.Pdf
Namespace AsposePDF.Annotations
    Public Class SetFreeTextAnnotationFormatting
        Public Shared Sub Run()
            ' ExStart:SetFreeTextAnnotationFormatting
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Annotations()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("SetFreeTextAnnotationFormatting.pdf"))

            ' Instantiate DefaultAppearance object
            Dim default_appearance As New DefaultAppearance("Arial", 28, System.Drawing.Color.Red)
            ' Create annotation
            Dim freetext As New FreeTextAnnotation(pdfDocument.Pages(1), New Rectangle(200, 400, 400, 600), default_appearance)
            ' Specify the contents of annotation
            freetext.Contents = "Free Text"
            ' Add anootation to annotations collection of page
            pdfDocument.Pages(1).Annotations.Add(freetext)
            dataDir = dataDir & Convert.ToString("SetFreeTextAnnotationFormatting_out_.pdf")
            ' Save the updated document
            pdfDocument.Save(dataDir)
            ' ExEnd:SetFreeTextAnnotationFormatting
            Console.WriteLine(Convert.ToString(vbLf & "Free TextAnnotation with specific text formatting added successfully." & vbLf & "File saved at ") & dataDir)

        End Sub
    End Class
End Namespace

