Imports System.IO
Imports System
Imports Aspose.Pdf

Namespace AsposePdfGenerator.TechnicalArticles
    Public Class ImageAndPageNumberInHeaderFooter
        Public Shared Sub Run()
            ' ExStart:ImageAndPageNumberInHeaderFooter
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_TechnicalArticles()

            ' Instantiate a Pdf object by calling its empty constructor
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()
            ' Create a section in the Pdf object
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

            '=====================================================//
            '	Header to show an Image
            '=====================================================//

            ' Create Header Section of the document
            Dim header As New Aspose.Pdf.Generator.HeaderFooter(sec1)
            ' Set the Odd header for the PDF file
            sec1.OddHeader = header
            ' Set the Even Header for the PDF file
            sec1.EvenHeader = header
            ' Create an image object in the section
            Dim image1 As New Aspose.Pdf.Generator.Image(sec1)
            ' Set the path of image file
            image1.ImageInfo.File = dataDir & Convert.ToString("aspose-logo.jpg")
            ' Set the type of image using ImageFileType enumeration
            image1.ImageInfo.ImageFileType = Aspose.Pdf.Generator.ImageFileType.Jpeg
            ' Add image to Header section of the Pdf file
            header.Paragraphs.Add(image1)

            '=====================================================//
            '	Footer to show Page Number
            '=====================================================//

            ' Create a Footer Section of the document
            Dim footer As New Aspose.Pdf.Generator.HeaderFooter(sec1)
            ' Set the Odd footer of the PDF file
            sec1.OddFooter = footer
            ' Set the Even footer of the PDF file
            sec1.EvenFooter = footer
            ' Create a Text object
            Dim txt As New Aspose.Pdf.Generator.Text("Page: ($p of $P ) ")
            ' Add text to Header section of the Pdf file
            footer.Paragraphs.Add(txt)
            ' Save the Pdf file
            pdf1.Save(dataDir & Convert.ToString("ImageAndPageNumberInHeaderFooter_out_.pdf"))
            ' ExEnd:ImageAndPageNumberInHeaderFooter           
        End Sub
        Public Shared Sub UsingInlineParagraph()
            ' ExStart:UsingInlineParagraph
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_TechnicalArticles()

            ' Instantiate a Pdf object by calling its empty constructor
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()
            ' Create a section in the Pdf object
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

            '=====================================================//
            '	Header to show an Image inline with text
            '=====================================================//

            ' Create Header Section of the document
            Dim header As New Aspose.Pdf.Generator.HeaderFooter(sec1)
            ' Set the Odd header for the PDF file
            sec1.OddHeader = header
            ' Set the Even Header for the PDF file
            sec1.EvenHeader = header

            ' Create a Text object
            Dim txt1 As New Aspose.Pdf.Generator.Text()
            ' Add text to Header section of the Pdf file
            header.Paragraphs.Add(txt1)

            ' Add the text string to Segment of text object
            txt1.Segments.Add("Aspose.Pdf is a Robust component by")
            ' Specify the color & Font information using TextInfo property
            txt1.TextInfo.Color = New Aspose.Pdf.Generator.Color("Blue")
            txt1.TextInfo.FontName = "Helvetica"
            ' Create a new segment to be added to text object
            Dim seg1 As Aspose.Pdf.Generator.Segment = txt1.Segments.Add()

            ' Create an image object in the section
            Dim image1 As New Aspose.Pdf.Generator.Image(sec1)
            ' Set the path of image file
            image1.ImageInfo.File = dataDir & Convert.ToString("aspose-logo.jpg")
            ' Set the type of image using ImageFileType enumeration
            image1.ImageInfo.ImageFileType = Aspose.Pdf.Generator.ImageFileType.Jpeg
            ' Set the image width Information
            image1.ImageInfo.FixWidth = 150
            ' Indicate seg1's InlineParagraph is a image.
            seg1.InlineParagraph = image1

            ' Create a new segment to be added to text object
            Dim seg2 As Aspose.Pdf.Generator.Segment = txt1.Segments.Add("Pty Ltd.")
            seg2.TextInfo.Color = New Aspose.Pdf.Generator.Color("Maroon")

            ' Save the Pdf
            pdf1.Save(dataDir & Convert.ToString("ImageAndPageNumberInHeaderFooter_UsingInlineParagraph_out_.pdf"))
            ' ExEnd:UsingInlineParagraph
        End Sub
        Public Shared Sub UsingFloatingBox()
            ' ExStart:UsingFloatingBox
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_TechnicalArticles()

            ' Instantiate Pdf instance
            Dim pdf As New Aspose.Pdf.Generator.Pdf()
            ' Add a section into the pdf document
            Dim section As Aspose.Pdf.Generator.Section = pdf.Sections.Add()

            ' Initializes a new instance of the FloatingBox class
            Dim box1 As New Aspose.Pdf.Generator.FloatingBox(140, 80)
            ' Indicate the horizontal positioning type of the floating box
            box1.BoxHorizontalPositioning = Aspose.Pdf.Generator.BoxHorizontalPositioningType.Margin
            ' Float value that indicates left position of the paragraph
            box1.Left = 2
            ' Indicate the vertical alignment type of the floating box
            box1.BoxVerticalPositioning = Aspose.Pdf.Generator.BoxVerticalPositioningType.Page
            ' Float value that indicates top position of the paragraph
            box1.Top = 10
            ' Add the macros to the paragraphs collection of the FloatingBox
            box1.Paragraphs.Add(New Aspose.Pdf.Generator.Text("Page: ($p/ $P )"))
            ' Add a floatingBox to the section
            section.Paragraphs.Add(box1)

            ' Save the document
            pdf.Save(dataDir & Convert.ToString("PageNumber_using_FloatingBox_out_.pdf"))
            ' ExEnd:UsingFloatingBox
        End Sub
    End Class
End Namespace
