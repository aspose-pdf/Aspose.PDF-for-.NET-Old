using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Text
{
    public class InlineParagraph
    {
        public static void Run()
        {
            // ExStart:InlineParagraph
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Text();

            // Instantiate Pdf instance by calling its empty constructor
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();
            // Create section object and add it to sections collection of PDF
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            // Create a text object
            Aspose.Pdf.Generator.Text text1 = new Aspose.Pdf.Generator.Text();
            // Add text object to paragraphs collection of section
            sec1.Paragraphs.Add(text1);
            // Add sample text to segments collection of text object
            text1.Segments.Add("This is a test for inline");
            // Create segment 2 and add it to segements collection of text object
            Aspose.Pdf.Generator.Segment seg2 = text1.Segments.Add();

            // Create a Image object to contain logo gif.
            Aspose.Pdf.Generator.Image img1 = new Aspose.Pdf.Generator.Image();
            // Specify the image file path
            img1.ImageInfo.File = dataDir + "aspose-logo.jpg";
            // Indicate seg2's InlineParagraph is a image.
            seg2.InlineParagraph = img1;
            dataDir = dataDir + "InlineImage_out_.pdf";
            // Create the result PDF Document
            pdf1.Save(dataDir);
            // ExEnd:InlineParagraph
        }
    }
}