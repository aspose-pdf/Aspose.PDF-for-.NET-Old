Imports System.IO
Imports System
Imports Aspose.Pdf

Namespace AsposePdfGenerator.TechnicalArticles
    Public Class FontsEmbedding
        Public Shared Sub Run()
            ' ExStart:FontsEmbedding 
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_TechnicalArticles()

            ' Instantiate Pdf instance by calling it empty constructor
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

            ' Create a section in the Pdf object                       
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

            ' Create a text paragraph inheriting text format settings from the section
            Dim text1 As New Aspose.Pdf.Generator.Text(sec1)

            ' Add the text paragraph to the section
            sec1.Paragraphs.Add(text1)

            ' Create a text segment
            Dim s1 As New Aspose.Pdf.Generator.Segment(" This is a sample text using Custom font")

            ' Set the font name to the TextInfo.FontName property of segment, where ‘Almonto Snow’ is custom font name
            s1.TextInfo.FontName = "Almonte Snow"

            ' Set the value for property to include the font description into Pdf file
            s1.TextInfo.IsFontEmbedded = True

            ' ExStart:IsUnicode
            ' Set the value for property to include a subset of font into Pdf file
            s1.TextInfo.IsUnicode = True
            ' ExEnd:IsUnicode

            ' Add the text segment to the text paragraph
            text1.Segments.Add(s1)

            ' Save the Pdf
            pdf1.Save(dataDir & Convert.ToString("FontsEmbedding_out_.pdf"))
            ' ExEnd:FontsEmbedding            
        End Sub
        Public Shared Sub FontsEmbeddingUsingHTML()
            ' ExStart:FontsEmbeddingUsingHTML 
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_TechnicalArticles()

            ' Instantiate a pdf document
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

            ' Create a section in the pdf document
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

            ' Create string variables with text containing html tags
            Dim s As String = "<html><body><font isUnicode='true' face='Bete Noir NF' size=18><i>Sample text </i>with Custome font Embedded </font><br><font isUnicode='true' face='Courier New' size=10><s>Sample Text </s>in <u>Courier New</u> font</font></body></html>"

            ' Create text paragraphs containing HTML text
            Dim t1 As New Aspose.Pdf.Generator.Text(s)

            ' Enable the HTML tag support property
            t1.IsHtmlTagSupported = True

            ' Add the text paragraphs containing HTML text to the section
            sec1.Paragraphs.Add(t1)

            ' Save the pdf document
            pdf1.Save(dataDir & Convert.ToString("inLineFormated_HtmlSuported_out_.pdf"))
            ' ExEnd:FontsEmbeddingUsingHTML 
        End Sub
    End Class
End Namespace

