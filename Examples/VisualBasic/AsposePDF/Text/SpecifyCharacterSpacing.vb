Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Text
Imports Aspose.Pdf.Facades
Imports Aspose.Pdf.Text.TextOptions
Imports APG = Aspose.Pdf.Generator
Namespace AsposePDF.Text
    Public Class SpecifyCharacterSpacing
        Public Shared Sub Run()
            UsingTextBuilderAndFragment()
            UsingTextBuilderAndParagraph()
            UsingTextStamp()
            UsingAsposePdfGenerator()

        End Sub
        Public Shared Sub UsingTextBuilderAndFragment()
            ' ExStart:UsingTextBuilderAndFragment
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Text()

            ' Create Document instance
            Dim pdfDocument As New Document()
            ' Add page to pages collection of Document
            Dim page As Page = pdfDocument.Pages.Add()
            ' Create TextBuilder instance
            Dim builder As New TextBuilder(pdfDocument.Pages(1))
            ' Create text fragment instance with sample contents
            Dim wideFragment As New TextFragment("Text with increased character spacing")
            wideFragment.TextState.ApplyChangesFrom(New TextState("Arial", 12))
            ' Specify character spacing for TextFragment
            wideFragment.TextState.CharacterSpacing = 2.0F
            ' Specify the position of TextFragment
            wideFragment.Position = New Position(100, 650)
            ' Append TextFragment to TextBuilder instance
            builder.AppendText(wideFragment)
            dataDir = dataDir & Convert.ToString("CharacterSpacingUsingTextBuilderAndFragment_out_.pdf")
            ' Save resulting PDF document.
            pdfDocument.Save(dataDir)
            ' ExEnd:UsingTextBuilderAndFragment
            Console.WriteLine(Convert.ToString(vbLf & "Character spacing specified successfully using Text builder and fragment." & vbLf & "File saved at ") & dataDir)
        End Sub
        Public Shared Sub UsingTextBuilderAndParagraph()
            ' ExStart:UsingTextBuilderAndParagraph
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Text()

            ' Create Document instance
            Dim pdfDocument As New Document()
            ' Add page to pages collection of Document
            Dim page As Page = pdfDocument.Pages.Add()
            ' Create TextBuilder instance
            Dim builder As New TextBuilder(pdfDocument.Pages(1))
            ' Instantiate TextParagraph instance
            Dim paragraph As New TextParagraph()
            ' Create TextState instance to specify font name and size
            Dim state As New TextState("Arial", 12)
            ' Specify the character spacing
            state.CharacterSpacing = 1.5F
            ' Append text to TextParagraph object
            paragraph.AppendLine("This is paragraph with character spacing", state)
            ' Specify the position for TextParagraph
            paragraph.Position = New Position(100, 550)
            ' Append TextParagraph to TextBuilder instance
            builder.AppendParagraph(paragraph)

            dataDir = dataDir & Convert.ToString("CharacterSpacingUsingTextBuilderAndParagraph_out_.pdf")
            ' Save resulting PDF document.
            pdfDocument.Save(dataDir)
            ' ExEnd:UsingTextBuilderAndParagraph
            Console.WriteLine(Convert.ToString(vbLf & "Character spacing specified successfully using Text builder and paragraph." & vbLf & "File saved at ") & dataDir)
        End Sub
        Public Shared Sub UsingTextStamp()
            ' ExStart:UsingTextStamp
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Text()

            ' Create Document instance
            Dim pdfDocument As New Document()
            ' Add page to pages collection of Document
            Dim page As Page = pdfDocument.Pages.Add()
            ' Instantiate TextStamp instance with sample text
            Dim stamp As New TextStamp("This is text stamp with character spacing")
            ' Specify font name for Stamp object
            stamp.TextState.Font = FontRepository.FindFont("Arial")
            ' Specify Font size for TextStamp
            stamp.TextState.FontSize = 12
            ' Specify character specing as 1f
            stamp.TextState.CharacterSpacing = 1.0F
            ' Set the XIndent for Stamp
            stamp.XIndent = 100
            ' Set the YIndent for Stamp
            stamp.YIndent = 500
            ' Add textual stamp to page instance
            stamp.Put(page)
            dataDir = dataDir & Convert.ToString("CharacterSpacingUsingTextStamp_out_.pdf")
            ' Save resulting PDF document.
            pdfDocument.Save(dataDir)
            ' ExEnd:UsingTextStamp
            Console.WriteLine(Convert.ToString(vbLf & "Character spacing specified successfully using text stamp." & vbLf & "File saved at ") & dataDir)
        End Sub
        Public Shared Sub UsingAsposePdfGenerator()
            ' ExStart:UsingAsposePdfGenerator
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Text()

            ' Instantiate Pdf instance
            Dim pdf1 As New APG.Pdf()

            ' Create a new section in the Pdf object
            Dim sec1 As APG.Section = pdf1.Sections.Add()

            ' Add 1st paragraph (inheriting the text format settings from the section)
            ' to the section 
            sec1.Paragraphs.Add(New APG.Text(sec1, "This is generator text paragraph with default character spacing"))

            Dim sec2 As APG.Section = pdf1.Sections.Add()

            ' Create 2nd paragraph (inheriting the text format settings from the section) 
            Dim t2 As New APG.Text(sec1)

            ' Create a segment "seg1" in the paragraph "t2"
            Dim seg1 As New APG.Segment(t2)
            ' Assign some content to the segment
            seg1.Content = "This is generator text paragraph with increased character spacing"
            ' Set character spacing of the segment to 2.0
            seg1.TextInfo.CharSpace = 2.0F

            ' Add segment (with character spacing) to the paragraph
            t2.Segments.Add(seg1)
            ' Add 2nd text paragraph to the section with overridden text format settings
            sec1.Paragraphs.Add(t2)


            dataDir = dataDir & Convert.ToString("UsingAsposePdfGenerator_out_.pdf")
            ' Save resulting PDF document.
            pdf1.Save(dataDir)
            ' ExEnd:UsingAsposePdfGenerator
            Console.WriteLine(Convert.ToString(vbLf & "Character spacing specified successfully using Aspose Pdf Generator." & vbLf & "File saved at ") & dataDir)
        End Sub

    End Class
End Namespace