Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports System.Text
Imports System.Xml

Namespace AsposePdfGenerator.Text
    Public Class InlineRadioButton
        Public Shared Sub Run()
            Try
                ' ExStart:InlineRadioButton
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Text()

                ' Create Pdf Instance
                Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

                ' Add A Section
                Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

                ' Add Text Paragraph
                Dim text1 As New Aspose.Pdf.Generator.Text()
                ' Add Text Paragraph to paragraphs collection of section
                sec1.Paragraphs.Add(text1)
                ' Add a segment with sample text to segments collection of Text Paragraph
                text1.Segments.Add("This is a test for inline radiobutton:    ")

                ' Specify Inline Radio button field name
                text1.InlineRadioButtonFieldName = "inlineradio"
                ' Specify the checked index for inline radio button
                text1.InlineRadioButtonCheckedIndex = 1

                ' Add segments
                Dim seg1 As Aspose.Pdf.Generator.Segment = text1.Segments.Add()

                ' 1st Radio Button and set the Inline Paragraph property of segment equal to radioButton  
                Dim radio1 As New Aspose.Pdf.Generator.RadioButton()
                seg1.InlineParagraph = radio1

                Dim seg11 As Aspose.Pdf.Generator.Segment = text1.Segments.Add("radio1  ")
                Dim seg2 As Aspose.Pdf.Generator.Segment = text1.Segments.Add()

                Dim radio2 As New Aspose.Pdf.Generator.RadioButton()
                radio2.ID = "radio2"
                seg2.InlineParagraph = radio2

                Dim seg22 As Aspose.Pdf.Generator.Segment = text1.Segments.Add("radio2  ")
                Dim seg3 As Aspose.Pdf.Generator.Segment = text1.Segments.Add()
                Dim radio3 As New Aspose.Pdf.Generator.RadioButton()
                seg3.InlineParagraph = radio3

                Dim seg33 As Aspose.Pdf.Generator.Segment = text1.Segments.Add("radio3  ")

                ' Save the document
                ' ExEnd:InlineRadioButton
                pdf1.Save(dataDir & Convert.ToString("InlineRadioButton_out_.pdf"))
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
    End Class
End Namespace