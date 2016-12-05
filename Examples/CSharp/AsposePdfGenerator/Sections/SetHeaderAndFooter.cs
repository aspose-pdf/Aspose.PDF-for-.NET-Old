using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Sections
{
    public class SetHeaderAndFooter
    {
        public static void Run()
        {
            
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Sections();
            
            // Instantiate a PDF Object 
            Aspose.Pdf.Generator.Pdf pdf = new Aspose.Pdf.Generator.Pdf();

            // Add a section into the pdf document
            Aspose.Pdf.Generator.Section section1 = pdf.Sections.Add();
            // ExStart:SetHeaderAndFooter
            // Instantiate HeaderFooter object and pass the Section reference in which
            // The header or footer is to be added
            Aspose.Pdf.Generator.HeaderFooter hf1 = new Aspose.Pdf.Generator.HeaderFooter(section1);

            // Set the header of odd pages of the PDF document
            section1.OddHeader = hf1;

            // Set the header of even pages of the PDF document
            section1.EvenHeader = hf1;

            // Instantiate a Text paragraph that will store the content to show as header
            Aspose.Pdf.Generator.Text text = new Aspose.Pdf.Generator.Text(hf1, "header");

            // Add the text object to the Paragraphs collection of HeaderFooter object to
            // Display header on the pages of PDF document
            hf1.Paragraphs.Add(text);
            // ExEnd:SetHeaderAndFooter
            dataDir = dataDir + "SetHeaderAndFooter_out.pdf";

            // Save Pdf Document
            pdf.Save(dataDir);
            
            Console.WriteLine("\nHeader and footer setup successfully.\nFile saved at " + dataDir);
        }
    }
}