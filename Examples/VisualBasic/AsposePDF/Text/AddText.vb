Imports System.IO
Imports System
Imports Aspose.Pdf
Imports Aspose.Pdf.Text
Imports Aspose.Pdf.Facades
Imports Aspose.Pdf.Text.TextOptions
Imports Microsoft.VisualBasic
Namespace AsposePDF.Text
    Public Class AddText
        Public Shared Sub Run()
            ' ExStart:AddText
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Text()

            ' Open document
            Dim pdfDocument As New Document(dataDir & "input.pdf")

            ' Get particular page
            Dim pdfPage As Page = DirectCast(pdfDocument.Pages(1), Page)

            ' Create text fragment
            Dim textFragment As New TextFragment("main text")
            textFragment.Position = New Position(100, 600)

            ' Set text properties
            textFragment.TextState.FontSize = 12
            textFragment.TextState.Font = FontRepository.FindFont("TimesNewRoman")
            textFragment.TextState.BackgroundColor = Color.FromRgb(System.Drawing.Color.LightGray)
            textFragment.TextState.ForegroundColor = Color.FromRgb(System.Drawing.Color.Red)

            ' Create TextBuilder object
            Dim textBuilder As New TextBuilder(pdfPage)

            ' Append the text fragment to the PDF page
            textBuilder.AppendText(textFragment)

            dataDir = dataDir & "AddText_out_.pdf"

            ' Save resulting PDF document.
            pdfDocument.Save(dataDir)
            ' ExEnd:AddText
            Console.WriteLine(Convert.ToString(vbLf & "Text added successfully." & vbLf & "File saved at ") & dataDir)

            AddUnderlineText()
            AddingBorderAroundAddedText()
            AddTextUsingTextParagraph()
            AddHyperlinkToTextSegment()
            OTFFont()
            AddStrikeOutText()
        End Sub
        Public Shared Sub AddUnderlineText()
            ' ExStart:AddUnderlineText
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Text()

            ' Create documentation object
            Dim pdfDocument As New Document()
            ' Add age page to PDF document
            pdfDocument.Pages.Add()
            ' Create TextBuilder for first page
            Dim tb As New TextBuilder(pdfDocument.Pages(1))
            ' TextFragment with sample text
            Dim fragment As New TextFragment("Test message")
            ' Set the font for TextFragment
            fragment.TextState.Font = FontRepository.FindFont("Arial")
            fragment.TextState.FontSize = 10
            ' Set the formatting of text as Underline
            fragment.TextState.Underline = True
            ' Specify the position where TextFragment needs to be placed
            fragment.Position = New Position(10, 800)
            ' Append TextFragment to PDF file
            tb.AppendText(fragment)

            dataDir = dataDir & Convert.ToString("AddUnderlineText_out_.pdf")

            ' Save resulting PDF document.
            pdfDocument.Save(dataDir)
            ' ExEnd:AddUnderlineText
            Console.WriteLine(Convert.ToString(vbLf & "Underline text added successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
        Public Shared Sub AddingBorderAroundAddedText()
            ' ExStart:AddingBorderAroundAddedText
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Text()

            Dim editor As New PdfContentEditor()
            editor.BindPdf(dataDir & Convert.ToString("input.pdf"))
            Dim lineInfo As New LineInfo()
            lineInfo.LineWidth = 2
            lineInfo.VerticeCoordinate = New Single() {0, 0, 100, 100, 50, 100}
            lineInfo.Visibility = True
            editor.CreatePolygon(lineInfo, 1, New System.Drawing.Rectangle(0, 0, 0, 0), "")

            dataDir = dataDir & Convert.ToString("AddingBorderAroundAddedText_out_.pdf")

            ' Save resulting PDF document.
            editor.Save(dataDir)
            ' ExEnd:AddingBorderAroundAddedText
            Console.WriteLine(Convert.ToString(vbLf & "Border around text added successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
        Public Shared Sub LoadingFontFromStream()
            ' ExStart:LoadingFontFromStream
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Text()
            Dim fontFile As String = ""

            ' Load input PDF file
            Dim doc As New Document(dataDir & Convert.ToString("input.pdf"))
            ' Create text builder object for first page of document
            Dim textBuilder As New TextBuilder(doc.Pages(1))
            ' Create text fragment with sample string
            Dim textFragment As New TextFragment("Hello world")

            If fontFile <> "" Then
                ' Load the TrueType font into stream object
                Using fontStream As FileStream = File.OpenRead(fontFile)
                    ' Set the font name for text string
                    textFragment.TextState.Font = FontRepository.OpenFont(fontStream, FontTypes.TTF)
                    ' Specify the position for Text Fragment
                    textFragment.Position = New Position(10, 10)
                    ' Add the text to TextBuilder so that it can be placed over the PDF file
                    textBuilder.AppendText(textFragment)
                End Using

                dataDir = dataDir & Convert.ToString("LoadingFontFromStream_out_.pdf")

                ' Save resulting PDF document.
                doc.Save(dataDir)
            End If
            ' ExEnd:LoadingFontFromStream
            Console.WriteLine(Convert.ToString(vbLf & "Font from stream loaded successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
        Public Shared Sub AddTextUsingTextParagraph()
            ' ExStart:AddTextUsingTextParagraph
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Text()
            ' Open document
            Dim doc As New Document()
            ' Add page to pages collection of Document object
            Dim page As Page = doc.Pages.Add()
            Dim builder As New TextBuilder(page)
            ' Create text paragraph
            Dim paragraph As New TextParagraph()
            ' Set subsequent lines indent
            paragraph.SubsequentLinesIndent = 20
            ' Specify the location to add TextParagraph
            paragraph.Rectangle = New Rectangle(100, 300, 200, 700)
            ' Specify word wraping mode
            paragraph.FormattingOptions.WrapMode = TextFormattingOptions.WordWrapMode.ByWords
            ' Create text fragment
            Dim fragment1 As New TextFragment("the quick brown fox jumps over the lazy dog")
            fragment1.TextState.Font = FontRepository.FindFont("Times New Roman")
            fragment1.TextState.FontSize = 12
            ' Add fragment to paragraph
            paragraph.AppendLine(fragment1)
            ' Add paragraph
            builder.AppendParagraph(paragraph)

            dataDir = dataDir & Convert.ToString("AddTextUsingTextParagraph_out_.pdf")

            ' Save resulting PDF document.
            doc.Save(dataDir)

            ' ExEnd:AddTextUsingTextParagraph
            Console.WriteLine(Convert.ToString(vbLf & "Text using text paragraph added successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
        Public Shared Sub AddHyperlinkToTextSegment()
            ' ExStart:AddHyperlinkToTextSegment
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Text()
            ' Create document instance
            Dim doc As New Document()
            ' Add page to pages collection of PDF file
            Dim page1 As Page = doc.Pages.Add()
            ' Create TextFragment instance
            Dim tf As New TextFragment("Sample Text Fragment")
            ' Set horizontal alignment for TextFragment
            tf.HorizontalAlignment = HorizontalAlignment.Right
            ' Create a textsegment with sample text
            Dim segment As New TextSegment(" ... Text Segment 1...")
            ' Add segment to segments collection of TextFragment
            tf.Segments.Add(segment)
            ' Create a new TextSegment 
            segment = New TextSegment("Link to Google")
            ' Add segment to segments collection of TextFragment
            tf.Segments.Add(segment)
            ' Set hyperlink for TextSegment
            segment.Hyperlink = New WebHyperlink("www.google.com")
            ' Set forground color for text segment
            segment.TextState.ForegroundColor = Color.Blue
            ' Set text formatting as italic
            segment.TextState.FontStyle = FontStyles.Italic
            ' Create another TextSegment object
            segment = New TextSegment("TextSegment without hyperlink")
            ' Add segment to segments collection of TextFragment
            tf.Segments.Add(segment)
            ' Add TextFragment to paragraphs collection of page object
            page1.Paragraphs.Add(tf)

            dataDir = dataDir & Convert.ToString("AddHyperlinkToTextSegment_out_.pdf")

            ' Save resulting PDF document.
            doc.Save(dataDir)

            ' ExEnd:AddHyperlinkToTextSegment
            Console.WriteLine(Convert.ToString(vbLf & "Hyperlink to text segment added successfully." & vbLf & "File saved at ") & dataDir)
        End Sub

        Public Shared Sub OTFFont()
            ' ExStart:OTFFont
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Text()
            ' Create new document instance
            Dim pdfDocument As New Document()
            ' Add page to pages collection of PDF file
            Dim page As Page = pdfDocument.Pages.Add()
            ' Create TextFragment instnace with sample text
            Dim fragment As New TextFragment("Sample Text in OTF font")
            ' Find font inside system font directory
            ' Fragment.TextState.Font = FontRepository.FindFont("HelveticaNeueLT Pro 45 Lt");
            ' or you can even specify the path of OTF font in system directory
            fragment.TextState.Font = FontRepository.OpenFont(dataDir & Convert.ToString("space age.otf"))
            ' Specify to emend font inside PDF file, so that its displayed properly,
            ' Even if specific font is not installed/present over target machine
            fragment.TextState.Font.IsEmbedded = True
            ' Add TextFragment to paragraphs collection of Page instance
            page.Paragraphs.Add(fragment)

            dataDir = dataDir & Convert.ToString("OTFFont_out_.pdf")

            ' Save resulting PDF document.
            pdfDocument.Save(dataDir)

            ' ExEnd:OTFFont
            Console.WriteLine(Convert.ToString(vbLf & "OTF font used successfully." & vbLf & "File saved at ") & dataDir)
        End Sub

        Public Shared Sub AddNewLineFeed()
            Try
                ' ExStart:AddNewLineFeed
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Text()
                Dim pdfApplicationDoc As New Document()
                Dim applicationFirstPage As Page = DirectCast(pdfApplicationDoc.Pages.Add(), Page)

                ' Initialize new TextFragment with text containing required newline markers
                Dim textFragment As New TextFragment("Applicant Name: " + Environment.NewLine + " Joe Smoe")

                ' Set text fragment properties if necessary
                textFragment.TextState.FontSize = 12
                textFragment.TextState.Font = FontRepository.FindFont("TimesNewRoman")
                textFragment.TextState.BackgroundColor = Color.LightGray
                textFragment.TextState.ForegroundColor = Color.Red

                ' Create TextParagraph object
                Dim par As New TextParagraph()

                ' Add new TextFragment to paragraph
                par.AppendLine(textFragment)

                ' Set paragraph position
                par.Position = New Position(100, 600)

                ' Create TextBuilder object
                Dim textBuilder As New TextBuilder(applicationFirstPage)
                ' Add the TextParagraph using TextBuilder
                textBuilder.AppendParagraph(par)


                dataDir = dataDir & Convert.ToString("AddNewLineFeed_out_.pdf")

                ' Save resulting PDF document.
                pdfApplicationDoc.Save(dataDir)
                ' ExEnd:AddNewLineFeed
                Console.WriteLine(Convert.ToString(vbLf & "New line feed added successfully." & vbLf & "File saved at ") & dataDir)
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub

        Public Shared Sub AddStrikeOutText()
            Try
                ' ExStart:AddStrikeOutText
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Text()
                ' Open document
                Dim pdfDocument As New Document()
                ' Get particular page
                Dim pdfPage As Page = DirectCast(pdfDocument.Pages.Add(), Page)

                ' Create text fragment
                Dim textFragment As New TextFragment("main text")
                textFragment.Position = New Position(100, 600)

                ' Set text properties
                textFragment.TextState.FontSize = 12
                textFragment.TextState.Font = FontRepository.FindFont("TimesNewRoman")
                textFragment.TextState.BackgroundColor = Color.LightGray
                textFragment.TextState.ForegroundColor = Color.Red
                ' Set StrikeOut property
                textFragment.TextState.StrikeOut = True
                ' Mark text as Bold
                textFragment.TextState.FontStyle = FontStyles.Bold

                ' Create TextBuilder object
                Dim textBuilder As New TextBuilder(pdfPage)
                ' Append the text fragment to the PDF page
                textBuilder.AppendText(textFragment)


                dataDir = dataDir & Convert.ToString("AddStrikeOutText_out_.pdf")

                ' Save resulting PDF document.
                pdfDocument.Save(dataDir)
                ' ExEnd:AddStrikeOutText
                Console.WriteLine(Convert.ToString(vbLf & "StrikeOut text added successfully." & vbLf & "File saved at ") & dataDir)
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
    End Class
End Namespace