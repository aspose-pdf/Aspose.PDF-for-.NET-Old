using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Hyperlinks
{
    public class HyperlinkToWeb
    {
        public static void Run()
        {
            // ExStart:HyperlinkToWeb
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Hyperlinks();
            // Instantiate Pdf document object 
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();
            // Create a section in the Pdf
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add(); 
            // Create text paragraph with the reference of a section
            Aspose.Pdf.Generator.Text text2 = new Aspose.Pdf.Generator.Text(sec1);

            // Add the text paragraph in the paragraphs collection of the section
            sec1.Paragraphs.Add(text2);

            // Add a text segment in the text paragraph
            Aspose.Pdf.Generator.Segment segment2 = text2.Segments.Add("this is a web link");

            // Assign a new instance of hyperlink to hyperlink property of segment
            segment2.Hyperlink = new Aspose.Pdf.Generator.Hyperlink();

            // Set the link type of the text segment to Web
            segment2.Hyperlink.LinkType = Aspose.Pdf.Generator.HyperlinkType.Web;

            // Set the URL of the web location to create a web link for the segment
            segment2.Hyperlink.Url = "http://localhost/popup.htm";

            dataDir = dataDir + "HyperlinkToWeb_out_.pdf";
            // Save the Pdf
            pdf1.Save(dataDir);
            // ExEnd:HyperlinkToWeb           
        }
    }
}