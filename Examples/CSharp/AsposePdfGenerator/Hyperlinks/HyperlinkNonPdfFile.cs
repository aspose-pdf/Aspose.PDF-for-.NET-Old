using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Hyperlinks
{
    public class HyperlinkNonPdfFile
    {
        public static void Run()
        {
            // ExStart:HyperlinkNonPdfFile
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Hyperlinks();

            // Instantiate Pdf document object 
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();
            // Create a section in the Pdf
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            // Create text paragraph with the reference of a section
            Aspose.Pdf.Generator.Text text1 = new Aspose.Pdf.Generator.Text(sec1);

            // Add the text paragraph in the paragraphs collection of the section
            sec1.Paragraphs.Add(text1);

            // Add a text segment in the text paragraph
            Aspose.Pdf.Generator.Segment segment1 = text1.Segments.Add("this is a external file link");

            // Assign a new instance of hyperlink to hyperlink property of segment
            segment1.Hyperlink = new Aspose.Pdf.Generator.Hyperlink();

            // Set the link type of the text segment to File
            segment1.Hyperlink.LinkType = Aspose.Pdf.Generator.HyperlinkType.File;

            // Set the path of the external Non-Pdf file
            segment1.Hyperlink.LinkFile = dataDir + "aspose-logo.jpg";

            dataDir = dataDir + "HyperlinkNonPdfFile_out.pdf";
            // Save the Pdf
            pdf1.Save(dataDir);
            // ExEnd:HyperlinkNonPdfFile           
        }
    }
}