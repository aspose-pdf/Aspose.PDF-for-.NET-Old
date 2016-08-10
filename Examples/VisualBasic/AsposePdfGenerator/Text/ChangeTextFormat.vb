Imports Microsoft.VisualBasic
Imports System.IO
Imports System
Imports Aspose.Pdf

Namespace AsposePdfGenerator.Text
    Public Class ChangeTextFormat
        Public Shared Sub Run()
            ' ExStart:ChangeTextFormat
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Text()

            ' Create directory if it is not already present.
            Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
            If (Not IsExists) Then
                System.IO.Directory.CreateDirectory(dataDir)
            End If

            ' Instantiate Pdf instance by calling its empty constructor
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

            ' Create a new section in the Pdf object
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

            ' Set text color to blue in the whole section 
            sec1.TextInfo.Color = New Aspose.Pdf.Generator.Color("Blue")

            ' Add 1st paragraph (inheriting the text format settings from the section)
            ' to the section 
            sec1.Paragraphs.Add(New Aspose.Pdf.Generator.Text(sec1, "paragraph 1 "))

            ' Add 2nd paragraph (inheriting the text format settings from the section)
            ' to the section
            sec1.Paragraphs.Add(New Aspose.Pdf.Generator.Text(sec1, "paragraph 2"))

            ' Create 3rd paragraph (inheriting the text format settings from the section) 
            Dim t3 As New Aspose.Pdf.Generator.Text(sec1)

            ' Create a segment "seg1" in the paragraph "t3"
            Dim seg1 As New Aspose.Pdf.Generator.Segment(t3)

            ' Assign some content to the segment
            seg1.Content = "paragraph 3 segment 1"

            ' Set the color of the segment to red
            seg1.TextInfo.Color = New Aspose.Pdf.Generator.Color("Red")

            ' Add segment (with red text color) to the paragraph
            t3.Segments.Add(seg1)

            ' Create a new segment "seg2" in the paragraph "t3"
            Dim seg2 As New Aspose.Pdf.Generator.Segment(t3)

            ' Assign some content to the segment
            seg2.Content = "paragraph 3 segment 2"

            ' Set the color of the segment to green
            seg2.TextInfo.Color = New Aspose.Pdf.Generator.Color("Green")

            ' Add segment (with green text color) to the paragraph
            t3.Segments.Add(seg2)

            ' Add 3rd text paragraph to the section with overridden text format settings
            sec1.Paragraphs.Add(t3)

            ' Add 4th paragraph (inheriting the text format settings from the section)
            ' to the section
            sec1.Paragraphs.Add(New Aspose.Pdf.Generator.Text(sec1, "paragraph 4"))

            Dim info1 As Aspose.Pdf.Generator.TextInfo = TryCast(t3.TextInfo.Clone(), Aspose.Pdf.Generator.TextInfo)

            ' Modify the font side to 16 pt
            info1.FontSize = 16

            ' Set TextInfo property of the text paragraph to newly cloned instance "info1"
            t3.TextInfo = info1

            ' Save the document
            pdf1.Save(dataDir & "ChangeTextFormat_out_.pdf")
            ' ExEnd:ChangeTextFormat
        End Sub
    End Class
End Namespace