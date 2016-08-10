Imports Microsoft.VisualBasic
Imports System.IO
Imports System
Imports Aspose.Pdf

Namespace AsposePdfGenerator.Text
    Public Class UnderlineOverlineStrikeOut
        Public Shared Sub Run()
            ' ExStart:UnderlineOverlineStrikeOut
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Text()

            'Instantiate Pdf instance by calling its empty constructor
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

            ' Create a section in the Pdf object
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

            ' Create 1st text paragraph
            Dim text1 As New Aspose.Pdf.Generator.Text(sec1, "Text underline")

            ' Set IsUnderline property of Text.TextInfo to true
            text1.TextInfo.IsUnderline = True

            ' Create 2nd text paragraph
            Dim text2 As New Aspose.Pdf.Generator.Text(sec1, "Text overline")

            ' Set IsOverline property of Text.TextInfo to true
            text2.TextInfo.IsOverline = True

            ' Create 3rd text paragraph
            Dim text3 As New Aspose.Pdf.Generator.Text(sec1, "Text strike out")

            ' Set IsStrikeOut property of Text.TextInfo to true
            text3.TextInfo.IsStrikeOut = True

            ' Add 1st, 2nd and 3rd text paragraphs to the section
            sec1.Paragraphs.Add(text1)
            sec1.Paragraphs.Add(text2)
            sec1.Paragraphs.Add(text3)

            ' Save the Pdf
            pdf1.Save(dataDir & "UnderlineOverlineStrike_out_.pdf")
            ' ExEnd:UnderlineOverlineStrikeOut

        End Sub
    End Class
End Namespace