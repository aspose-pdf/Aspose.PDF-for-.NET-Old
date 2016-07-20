Imports System.IO
Imports System
Imports Aspose.Pdf

Namespace AsposePdfGenerator.UtilityFeatures
    Public Class CustomizingWatermark
        Public Shared Sub Run()
            ' ExStart:CustomizingWatermark
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_UtilityFeatures()

            ' Instantiate the Pdf object
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

            ' Add a section to the Pdf object
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

            Dim text1 As New Aspose.Pdf.Generator.Text(sec1, "This is text in section1.")
            text1.Left = 30
            text1.Top = 100
            sec1.Paragraphs.Add(text1)
            Dim sec2 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()
            Dim text2 As New Aspose.Pdf.Generator.Text(sec2, "This is text in section2.")
            text2.Left = 30
            text2.Top = 100
            sec2.Paragraphs.Add(text2)


            ' Setting image watermark
            Dim image1 As New Aspose.Pdf.Generator.Image()
            image1.ImageInfo.File = dataDir & Convert.ToString("aspose-logo.jpg")
            image1.ImageInfo.ImageFileType = Aspose.Pdf.Generator.ImageFileType.Jpeg
            image1.ImageScale = 0.1F
            Dim watermark1 As New Aspose.Pdf.Generator.FloatingBox(108, 80)
            watermark1.BoxHorizontalPositioning = Aspose.Pdf.Generator.BoxHorizontalPositioningType.Page
            watermark1.BoxHorizontalAlignment = Aspose.Pdf.Generator.BoxHorizontalAlignmentType.Center
            watermark1.BoxVerticalPositioning = Aspose.Pdf.Generator.BoxVerticalPositioningType.Page
            watermark1.BoxVerticalAlignment = Aspose.Pdf.Generator.BoxVerticalAlignmentType.Center
            watermark1.Paragraphs.Add(image1)


            ' Graph watermark
            Dim graph1 As New Aspose.Pdf.Generator.Graph(100, 400)
            Dim posArr As Single() = New Single() {0, 0, 200, 80, 300, 40, _
                350, 90}
            Dim curve1 As New Aspose.Pdf.Generator.Curve(graph1, posArr)
            graph1.Shapes.Add(curve1)
            Dim watermark2 As New Aspose.Pdf.Generator.FloatingBox(108, 80)
            watermark2.Paragraphs.Add(graph1)


            ' Text watermark
            Dim text3 As New Aspose.Pdf.Generator.Text("Text Watermark")
            Dim watermark3 As New Aspose.Pdf.Generator.FloatingBox(108, 80)
            watermark3.Left = 50
            watermark3.Top = 500
            watermark3.Paragraphs.Add(text3)


            pdf1.Watermarks.Add(watermark1)
            pdf1.Watermarks.Add(watermark2)
            pdf1.Watermarks.Add(watermark3)

            dataDir = dataDir & Convert.ToString("CustomizingWatermark_out_.pdf")
            ' Save the Pdf
            pdf1.Save(dataDir)
            ' ExEnd:CustomizingWatermark           
        End Sub

    End Class
End Namespace
