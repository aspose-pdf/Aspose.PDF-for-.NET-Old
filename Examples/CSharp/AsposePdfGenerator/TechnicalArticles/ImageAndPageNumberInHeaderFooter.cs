using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.TechnicalArticles
{
    public class ImageAndPageNumberInHeaderFooter
    {
        public static void Run()
        {
            // ExStart:ImageAndPageNumberInHeaderFooter
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_TechnicalArticles();

            // Instantiate a Pdf object by calling its empty constructor
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();
            // Create a section in the Pdf object
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            //=====================================================//
            //	Header to show an Image
            //=====================================================//

            // Create Header Section of the document
            Aspose.Pdf.Generator.HeaderFooter header = new Aspose.Pdf.Generator.HeaderFooter(sec1);
            // Set the Odd header for the PDF file
            sec1.OddHeader = header;
            // Set the Even Header for the PDF file
            sec1.EvenHeader = header;
            // Create an image object in the section
            Aspose.Pdf.Generator.Image image1 = new Aspose.Pdf.Generator.Image(sec1);
            // Set the path of image file
            image1.ImageInfo.File = dataDir + "aspose-logo.jpg";
            // Set the type of image using ImageFileType enumeration
            image1.ImageInfo.ImageFileType = Aspose.Pdf.Generator.ImageFileType.Jpeg;
            // Add image to Header section of the Pdf file
            header.Paragraphs.Add(image1);

            //=====================================================//
            //	Footer to show Page Number
            //=====================================================//

            // Create a Footer Section of the document
            Aspose.Pdf.Generator.HeaderFooter footer = new Aspose.Pdf.Generator.HeaderFooter(sec1);
            // Set the Odd footer of the PDF file
            sec1.OddFooter = footer;
            // Set the Even footer of the PDF file
            sec1.EvenFooter = footer;
            // Create a Text object
            Aspose.Pdf.Generator.Text txt = new Aspose.Pdf.Generator.Text("Page: ($p of $P ) ");
            // Add text to Header section of the Pdf file
            footer.Paragraphs.Add(txt);
            // Save the Pdf file
            pdf1.Save(dataDir + "ImageAndPageNumberInHeaderFooter_out.pdf");
            // ExEnd:ImageAndPageNumberInHeaderFooter           
        }
        public static void UsingInlineParagraph()
        {
            // ExStart:UsingInlineParagraph
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_TechnicalArticles();

            // Instantiate a Pdf object by calling its empty constructor
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();
            // Create a section in the Pdf object
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            //=====================================================//
            //	Header to show an Image inline with text
            //=====================================================//

            // Create Header Section of the document
            Aspose.Pdf.Generator.HeaderFooter header = new Aspose.Pdf.Generator.HeaderFooter(sec1);
            // Set the Odd header for the PDF file
            sec1.OddHeader = header;
            // Set the Even Header for the PDF file
            sec1.EvenHeader = header;

            // Create a Text object
            Aspose.Pdf.Generator.Text txt1 = new Aspose.Pdf.Generator.Text();
            // Add text to Header section of the Pdf file
            header.Paragraphs.Add(txt1);

            // Add the text string to Segment of text object
            txt1.Segments.Add("Aspose.Pdf is a Robust component by");
            // Specify the color & Font information using TextInfo property
            txt1.TextInfo.Color = new Aspose.Pdf.Generator.Color("Blue");
            txt1.TextInfo.FontName = "Helvetica";
            // Create a new segment to be added to text object
            Aspose.Pdf.Generator.Segment seg1 = txt1.Segments.Add();

            // Create an image object in the section
            Aspose.Pdf.Generator.Image image1 = new Aspose.Pdf.Generator.Image(sec1);
            // Set the path of image file
            image1.ImageInfo.File = dataDir + "aspose-logo.jpg";
            // Set the type of image using ImageFileType enumeration
            image1.ImageInfo.ImageFileType = Aspose.Pdf.Generator.ImageFileType.Jpeg;
            // Set the image width Information
            image1.ImageInfo.FixWidth = 150;
            // Indicate seg1's InlineParagraph is a image.
            seg1.InlineParagraph = image1;

            // Create a new segment to be added to text object
            Aspose.Pdf.Generator.Segment seg2 = txt1.Segments.Add("Pty Ltd.");
            seg2.TextInfo.Color = new Aspose.Pdf.Generator.Color("Maroon");

            // Save the Pdf
            pdf1.Save( dataDir + "ImageAndPageNumberInHeaderFooter_UsingInlineParagraph_out.pdf");
            // ExEnd:UsingInlineParagraph
        }
        public static void UsingFloatingBox()
        {
            // ExStart:UsingFloatingBox
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_TechnicalArticles();

            // Instantiate Pdf instance
            Aspose.Pdf.Generator.Pdf pdf = new Aspose.Pdf.Generator.Pdf();
            // Add a section into the pdf document
            Aspose.Pdf.Generator.Section section = pdf.Sections.Add();

            // Initializes a new instance of the FloatingBox class
            Aspose.Pdf.Generator.FloatingBox box1 = new Aspose.Pdf.Generator.FloatingBox(140, 80);
            // Indicate the horizontal positioning type of the floating box
            box1.BoxHorizontalPositioning = Aspose.Pdf.Generator.BoxHorizontalPositioningType.Margin;
            // Float value that indicates left position of the paragraph
            box1.Left = 2;
            // Indicate the vertical alignment type of the floating box
            box1.BoxVerticalPositioning = Aspose.Pdf.Generator.BoxVerticalPositioningType.Page;
            // Float value that indicates top position of the paragraph
            box1.Top = 10;
            // Add the macros to the paragraphs collection of the FloatingBox
            box1.Paragraphs.Add(new Aspose.Pdf.Generator.Text("Page: ($p/ $P )"));
            // Add a floatingBox to the section
            section.Paragraphs.Add(box1);

            // Save the document
            pdf.Save( dataDir + "PageNumber_using_FloatingBox_out.pdf");
            // ExEnd:UsingFloatingBox
        }
    }
}