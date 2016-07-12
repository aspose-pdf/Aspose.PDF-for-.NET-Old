Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports AP = Aspose.Pdf
Namespace AsposePdfGenerator.Text
    Public Class TextLayout
        Public Shared Sub Run()
            ' ExStart:TextLayout
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Text()

            ' Instantiate Pdf pbject by calling its empty constructor
            Dim pdf1 As New AP.Generator.Pdf()

            ' Create a new section in the Pdf object
            Dim sec1 As AP.Generator.Section = pdf1.Sections.Add()

            ' Set the left margin of the section
            sec1.PageInfo.Margin.Left = 110

            ' Set the right margin of the section
            sec1.PageInfo.Margin.Right = 120

            ' Create a new text paragraph and pass the text to its constructor as argument
            Dim t2 As New AP.Generator.Text("A bool value that indicates" + "whether the TrueType font is bold. " + "This attribute is valid for TrueType fonts only.")

            ' Set the font size of the text in a text segment
            t2.Segments(0).TextInfo.FontSize = 16

            ' Set the left margin of the text paragraph
            t2.Margin.Left = 60

            ' Set the first line indentation of the text paragraph to a negative value for
            ' producing the effect of left hanging text paragraph
            t2.FirstLineIndent = -6

            ' Add this left hanging text paragraph to the section
            sec1.Paragraphs.Add(t2)
            dataDir = dataDir & Convert.ToString("LeftHangingTextParagraph_out_.pdf")
            ' Save the pdf file
            pdf1.Save(dataDir)
            ' ExEnd:TextLayout            
        End Sub
    End Class
End Namespace