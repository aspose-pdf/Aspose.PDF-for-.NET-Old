using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.TechnicalArticles
{
    public class CreateMultiLayerPdf
    {
        public static void Run()
        {
            // ExStart:CreateMultiLayerPdf
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_TechnicalArticles();

            // Create a PDF object
            Aspose.Pdf.Generator.Pdf pdf = new Aspose.Pdf.Generator.Pdf();

            Aspose.Pdf.Generator.Section sec1 = pdf.Sections.Add();
            // Create a text object 
            Aspose.Pdf.Generator.Text t1 = new Aspose.Pdf.Generator.Text(sec1);
            // Add the text object to Paragraphs collection of section
            sec1.Paragraphs.Add(t1);

            Aspose.Pdf.Generator.Segment seg1 = new Aspose.Pdf.Generator.Segment(t1);
            // Add the contents for Segment1
            seg1.Content = "paragraph 3 segment 1";
            // Specify the Font fore color for segement1
            seg1.TextInfo.Color = new Aspose.Pdf.Generator.Color("red");
            // Specify the font size information for segment1
            seg1.TextInfo.FontSize = 12;
            // Specify the value for Opacity of text. Default is 1.0. Use it for multilayer effect
            t1.Opacity = 0F;
            // Add the segment to segments collection of Text1
            t1.Segments.Add(seg1);

            // Jpg image cover the underlayer text
            Aspose.Pdf.Generator.Image image1 = new Aspose.Pdf.Generator.Image(sec1);
            image1.ImageInfo.File = dataDir + "aspose-logo.jpg";
            image1.ImageInfo.ImageFileType = Aspose.Pdf.Generator.ImageFileType.Jpeg;

            // Create a Floating Box object that will hold image file
            Aspose.Pdf.Generator.FloatingBox box1 = new Aspose.Pdf.Generator.FloatingBox(117, 21);
            // Add Floating box to paragraphs collection of Section1
            sec1.Paragraphs.Add(box1);

            // Specify the left margin of FloatingBox1
            box1.Left = -4;
            // Specify the Top margin of FloatingBox1
            box1.Top = -4;
            // Add the image file to paragraphs collection of FloatingBox
            box1.Paragraphs.Add(image1);

            // Save the reusltant PDF document
            pdf.Save(dataDir + "CreateMultiLayerPdf_out_.pdf");
            // ExEnd:CreateMultiLayerPdf           
        }
        public static void SecondApproach()
        {
            // ExStart:SecondApproach
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_TechnicalArticles();

            // Create a PDF object
            Aspose.Pdf.Generator.Pdf pdf = new Aspose.Pdf.Generator.Pdf();

            Aspose.Pdf.Generator.Section sec1 = pdf.Sections.Add();
            // Create a text object 
            Aspose.Pdf.Generator.Text t1 = new Aspose.Pdf.Generator.Text(sec1);
            // Create a Floating Box object that will hold image file
            Aspose.Pdf.Generator.FloatingBox TextFloatingBox1 = new Aspose.Pdf.Generator.FloatingBox(117, 21);
            // Specify the ZIndex value for TextFloatingBox
            TextFloatingBox1.ZIndex = 1;
            TextFloatingBox1.Left = -4;
            TextFloatingBox1.Top = -4;
            // Add Floating box to paragraphs collection of Section1
            sec1.Paragraphs.Add(TextFloatingBox1);

            // Add the text object to Paragraphs collection of FloatingBox
            TextFloatingBox1.Paragraphs.Add(t1);

            Aspose.Pdf.Generator.Segment seg1 = new Aspose.Pdf.Generator.Segment(t1);
            // Add the contents for Segment1
            seg1.Content = "paragraph 3 segment 1";
            // Specify the Font fore color for segement1
            seg1.TextInfo.Color = new Aspose.Pdf.Generator.Color("red");
            // Specify the font size information for segment1
            seg1.TextInfo.FontSize = 12;
            // Specify the value for Opacity of text. Default is 1.0. Use it for multilayer effect
            t1.Opacity = 0F;
            // Add the segment to segments collection of Text1
            t1.Segments.Add(seg1);

            // JPeg image cover the underlayer text
            Aspose.Pdf.Generator.Image image1 = new Aspose.Pdf.Generator.Image(sec1);
            image1.ImageInfo.File = dataDir + "aspose-logo.jpg";
            image1.ImageInfo.ImageFileType = Aspose.Pdf.Generator.ImageFileType.Jpeg;

            // Create a Floating Box object that will hold image file
            Aspose.Pdf.Generator.FloatingBox ImageFloatingBox = new Aspose.Pdf.Generator.FloatingBox(117, 21);
            // Add Floating box to paragraphs collection of Section1
            sec1.Paragraphs.Add(ImageFloatingBox);

            // Specify the left margin of FloatingBox1
            ImageFloatingBox.Left = -4;
            // Specify the Top margin of FloatingBox1
            ImageFloatingBox.Top = -4;
            // Specify the ZIndex of ImageFloatingBox
            ImageFloatingBox.ZIndex = 2;
            // Add the image file to paragraphs collection of FloatingBox
            ImageFloatingBox.Paragraphs.Add(image1);

            // Save the reusltant PDF document
            pdf.Save(dataDir + @"Multilayer-2ndApproach_out_.pdf");
            // ExEnd:SecondApproach
        }
    }
}