Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf.Annotations
Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AsposePDF.Annotations
    Public Class RedactPage
        Public Shared Sub Run()

            ' ExStart:RedactPage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Annotations()

            ' Open document
            Dim doc As New Document(dataDir & Convert.ToString("input.pdf"))

            ' Create RedactionAnnotation instance for specific page region
            Dim annot As New RedactionAnnotation(doc.Pages(1), New Rectangle(200, 500, 300, 600))
            annot.FillColor = Color.Green
            annot.BorderColor = Color.Yellow
            annot.Color = Color.Blue
            ' Text to be printed on redact annotation
            annot.OverlayText = "REDACTED"
            annot.TextAlignment = HorizontalAlignment.Center
            ' Repat Overlay text over redact Annotation
            annot.Repeat = True
            ' Add annotation to annotations collection of first page
            doc.Pages(1).Annotations.Add(annot)
            ' Flattens annotation and redacts page contents (i.e. removes text and image
            ' under redacted annotation)
            annot.Redact()
            dataDir = dataDir & Convert.ToString("RedactPage_out_.pdf")
            doc.Save(dataDir)
            ' ExEnd:RedactPage
            Console.WriteLine(Convert.ToString(vbLf & "Certain page region with RedactionAnnotation redact successfully." & vbLf & "File saved at ") & dataDir)

        End Sub
        Public Shared Sub FacadesApproach()
            ' ExStart:FacadesApproach
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Annotations()

            Dim editor As New PdfAnnotationEditor()
            ' Redact certain page region
            editor.RedactArea(1, New Rectangle(100, 100, 20, 70), System.Drawing.Color.White)
            editor.BindPdf(dataDir & Convert.ToString("input.pdf"))
            editor.Save(dataDir & Convert.ToString("FacadesApproach_out_.pdf"))
            ' ExEnd:FacadesApproach

        End Sub
    End Class
End Namespace

