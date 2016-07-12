Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Text
Imports Aspose.Pdf.Annotations
Namespace AsposePDF.StampsWatermarks
    Public Class AddDateTimeStamp
        Public Shared Sub Run()
            ' ExStart:AddDateTimeStamp
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_StampsWatermarks()

            ' Open document
            Dim pdfDocument As New Document(dataDir & Convert.ToString("AddTextStamp.pdf"))
            Dim annotationText As String = String.Empty

            annotationText = DateTime.Now.ToString("MM/dd/yy hh:mm:ss tt ")
            ' Create text stamp
            Dim textStamp As New TextStamp(annotationText)
            ' Set properties of the stamp
            textStamp.BottomMargin = 10
            textStamp.RightMargin = 20
            textStamp.HorizontalAlignment = HorizontalAlignment.Right
            textStamp.VerticalAlignment = VerticalAlignment.Bottom
            ' Adding stamp on stamp collection
            pdfDocument.Pages(1).AddStamp(textStamp)

            Dim default_appearance As New DefaultAppearance("Arial", 6, System.Drawing.Color.Black)

            Dim textAnnotation As New FreeTextAnnotation(pdfDocument.Pages(1), New Rectangle(0, 0, 0, 0), default_appearance)
            textAnnotation.Name = "Stamp"
            textAnnotation.Accept(New AnnotationSelector(textAnnotation))

            textAnnotation.Contents = textStamp.Value
            ' TextAnnotation.Open = true;
            ' TextAnnotation.Icon = Aspose.Pdf.InteractiveFeatures.Annotations.TextIcon.Key;
            Dim border As New Border(textAnnotation)
            border.Width = 0
            border.Dash = New Dash(1, 1)
            textAnnotation.Border = border
            textAnnotation.Rect = New Rectangle(0, 0, 0, 0)
            pdfDocument.Pages(1).Annotations.Add(textAnnotation)

            dataDir = dataDir & Convert.ToString("AddDateTimeStamp_out_.pdf")
            ' Save output document
            pdfDocument.Save(dataDir)
            ' ExEnd:AddDateTimeStamp
            Console.WriteLine(Convert.ToString(vbLf & "Date time stamp added successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
