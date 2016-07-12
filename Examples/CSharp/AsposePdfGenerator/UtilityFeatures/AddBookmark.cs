using System;
using System.IO;
using Aspose.Pdf;
namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.UtilityFeatures
{
    public class AddBookmark
    {
        public static void Run()
        {
            // ExStart:AddBookmark
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_UtilityFeatures();

            // Instantiate the Pdf instance 
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Set the value that PDF document will be Bookmarked
            pdf1.IsBookmarked = true;
            // Specify bookmark level
            pdf1.BookmarkLevel = 1;

            // Create Section object and add it to PDF 
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();
            Aspose.Pdf.Generator.Heading heading1 = new Aspose.Pdf.Generator.Heading(pdf1, sec1, 1);
            Aspose.Pdf.Generator.Segment segment1 = new Aspose.Pdf.Generator.Segment(heading1);
            heading1.Segments.Add(segment1);
            heading1.IsAutoSequence = true;
            segment1.Content = "this is heading of level 1";
            sec1.Paragraphs.Add(heading1);
            Aspose.Pdf.Generator.Heading heading2 = new Aspose.Pdf.Generator.Heading(pdf1, sec1, 2);
            Aspose.Pdf.Generator.Segment segment2 = new Aspose.Pdf.Generator.Segment(heading2);
            heading2.Segments.Add(segment2);
            heading2.IsAutoSequence = true;
            segment2.Content = "this is heading of level 2";
            sec1.Paragraphs.Add(heading2);
            Aspose.Pdf.Generator.Heading heading3 = new Aspose.Pdf.Generator.Heading(pdf1, sec1, 1);
            Aspose.Pdf.Generator.Segment segment3 = new Aspose.Pdf.Generator.Segment(heading3);
            heading3.Segments.Add(segment3);
            heading3.IsAutoSequence = false;
            heading3.LabelWidth = 60;
            heading3.UserLabel = "bullet1";
            segment3.Content = "this is bullet style 1";
            sec1.Paragraphs.Add(heading3);
            dataDir = dataDir + "AddBookmark_out_.pdf";
            pdf1.Save(dataDir); 
            // ExEnd:AddBookmark           
        }        
    }
}