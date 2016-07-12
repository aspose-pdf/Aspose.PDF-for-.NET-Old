using System;
using System.IO;
using Aspose.Pdf;
namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Hyperlinks
{
    public class HyperlinkOtherPdf
    {
        public static void Run()
        {
            // ExStart:HyperlinkOtherPdf
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

            // Create a text segment
            Aspose.Pdf.Generator.Segment segment1 = new Aspose.Pdf.Generator.Segment();

            // Add a text segment in the text paragraph
            segment1 = text1.Segments.Add("this is a pdf link"); 

            // Set the text in the segment to be underlined
            segment1.TextInfo.IsUnderline = true; 

            // Set the link type of the text segment to Pdf
            segment1.Hyperlink.LinkType = Aspose.Pdf.Generator.HyperlinkType.Pdf; 

            // Set the path of the external document
            segment1.Hyperlink.LinkFile =  dataDir + "input.pdf";

            // Set the page number of the document to which the link is to be created
            segment1.Hyperlink.LinkPageNumber = 2;
   
            dataDir = dataDir + "HyperlinkOtherPdf_out_.pdf";
            // Save the Pdf
            pdf1.Save(dataDir);
            // ExEnd:HyperlinkOtherPdf           
        }
    }
}