using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Sections
{
    public class AdvancedHeaderAndFooter
    {
        public static void Run()
        {
            // ExStart:AdvancedHeaderAndFooter
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Sections();
            
            // Instantiate a PDF Object 
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Create a Section object by calling Add method of Sections collection of Pdf class
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            // Instantiate First HeaderFooter object and pass the Section reference in which
            // the header or footer is to be added
            Aspose.Pdf.Generator.HeaderFooter hf1 = new Aspose.Pdf.Generator.HeaderFooter(sec1);

            // Set the header of odd pages of the PDF document
            sec1.OddHeader = hf1;

            // Set the header of even pages of the PDF document
            sec1.EvenHeader = hf1;

            // Enable this header for first page only
            hf1.IsFirstPageOnly = true;

            // Add Distance From Edge Property to 80 unit Points
            hf1.DistanceFromEdge = 80;

            // Set the First HeaderFooter, top and bottom property respectively
            hf1.Margin.Bottom = 50;
            hf1.Margin.Top = 100;

            // Instantiate a Text paragraph that will store the content to show as header
            Aspose.Pdf.Generator.Text text = new Aspose.Pdf.Generator.Text(hf1, "header for first page");

            // Add the text object to the Paragraphs collection of HeaderFooter object to
            // display header on the pages of PDF document
            hf1.Paragraphs.Add(text);

            /*
             *Second Header "hf2" for odd subsequent pages only
             */

            // Instantiate Second HeaderFooter object and pass the Section reference in which
            // the header or footer is to be added
            Aspose.Pdf.Generator.HeaderFooter hf2 = new Aspose.Pdf.Generator.HeaderFooter(sec1);

            // Set the additional header of odd pages of the PDF document
            sec1.AdditionalOddHeader = hf2;

            // Enable this header for subsequent page only
            hf2.IsSubsequentPagesOnly = true;

            // Add Distance From Edge Property of header to 150 unit Points
            hf2.DistanceFromEdge = 150;
            hf2.Margin.Bottom = 70;

            // Instantiate a Text paragraph that will store the content to show as header
            text = new Aspose.Pdf.Generator.Text(hf2, "odd header for subsequent pages");

            // Add the text object to the Paragraphs collection of HeaderFooter object to
            // display header on the pages of PDF document
            hf2.Paragraphs.Add(text);

            /*
             *Third Header "hf3" for even subsequent pages only
             */

            // Instantiate Third HeaderFooter object and pass the Section reference in which
            // the header or footer is to be added
            Aspose.Pdf.Generator.HeaderFooter hf3 = new Aspose.Pdf.Generator.HeaderFooter(sec1);

            // Set the additional header of even pages of the PDF document
            sec1.AdditionalEvenHeader = hf3;

            // Enable this header for subsequent page only
            hf3.IsSubsequentPagesOnly = true;

            // Add the Distance from Edge for the third Header
            hf3.DistanceFromEdge = 180;
            hf3.Margin.Top = 90;

            // Instantiate a Text paragraph that will store the content to show as header
            text = new Aspose.Pdf.Generator.Text(hf3, "even header for subsequent pages");

            // Add the text object to the Paragraphs collection of HeaderFooter object to
            // display header on the pages of PDF document
            hf3.Paragraphs.Add(text);

            // ExEnd:SetHeaderAndFooter
            dataDir = dataDir + "AdvancedHeaderAndFooter_out_.pdf";

            //Save Pdf Document
            pdf1.Save(dataDir);
            // ExEnd:AdvancedHeaderAndFooter
            Console.WriteLine("\nAdvanced header and footer setup successfully.\nFile saved at " + dataDir);
        }
    }
}