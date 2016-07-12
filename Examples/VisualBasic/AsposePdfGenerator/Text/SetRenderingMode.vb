Imports System
Imports Microsoft.VisualBasic
Imports System.IO
Imports Aspose.Pdf

Namespace AsposePdfGenerator.Text
    Public Class SetRenderingMode
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Text()

            ' Instantiate Pdf instance by calling its empty constructor
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

            ' Create a section in the Pdf object
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

            ' Create 1st text paragraph
            Dim text1 As New Aspose.Pdf.Generator.Text(sec1, "FillText mode")

            ' Set rendering mode to FillText
            text1.TextInfo.RenderingMode = Aspose.Pdf.Generator.RenderingMode.FillText

            ' Create 2nd text paragraph
            Dim text2 As New Aspose.Pdf.Generator.Text(sec1, "StrokeText mode (outline)")

            ' Set rendering mode to StrokeText
            text2.TextInfo.RenderingMode = Aspose.Pdf.Generator.RenderingMode.StrokeText

            ' Create 3rd text paragraph
            Dim text3 As New Aspose.Pdf.Generator.Text(sec1, "FillStrokeText mode")

            ' Set rendering mode to FillStrokeText
            text3.TextInfo.RenderingMode = Aspose.Pdf.Generator.RenderingMode.FillStrokeText

            ' Create 4th text paragraph
            Dim text4 As New Aspose.Pdf.Generator.Text(sec1, "InvisibleText mode")

            ' Set rendering mode to InvisibleText
            text4.TextInfo.RenderingMode = Aspose.Pdf.Generator.RenderingMode.InvisibleText

            ' Add 1st, 2nd, 3rd and 4th text paragraphs to the section
            sec1.Paragraphs.Add(text1)
            sec1.Paragraphs.Add(text2)
            sec1.Paragraphs.Add(text3)
            sec1.Paragraphs.Add(text4)

            ' Save the Pdf
            pdf1.Save(dataDir & "SetRenderingMode_out_.pdf")

        End Sub

    End Class
End Namespace
