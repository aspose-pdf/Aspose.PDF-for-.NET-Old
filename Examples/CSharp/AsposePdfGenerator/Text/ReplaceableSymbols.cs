using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Text
{
    public class ReplaceableSymbols
    {
        public static void Run()
        {
            // ExStart:ReplaceableSymbols
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Text();

            // Instantiate Pdf instance by calling it empty constructor
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Create a section in the pdf object
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            // Create a HeaderFooter object for the section
            Aspose.Pdf.Generator.HeaderFooter hf = new Aspose.Pdf.Generator.HeaderFooter(sec1);

            // Set the HeaderFooter object to odd and even footers
            sec1.OddFooter = sec1.EvenFooter = hf;

            // Add a text paragraph containing current page number of total number of pages
            hf.Paragraphs.Add(new Aspose.Pdf.Generator.Text(hf, "page $p of $P"));

            dataDir = dataDir + "ReplaceableSymbols_out.pdf";
            // Create the result PDF Document
            pdf1.Save(dataDir);
            // ExEnd:ReplaceableSymbols
        }
        public static void  SpecifiedParagraph()
        {
            // ExStart:SpecifiedParagraph
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Text();

            // Instantiate Pdf instance by calling it empty constructor
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Create a section in the Pdf object
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();
            // Create a sample text paragraph
            Aspose.Pdf.Generator.Text text1 = new Aspose.Pdf.Generator.Text("page 1");
            // Specify the ID for text paragraph
            text1.ID = "page1";
            // Add text to paragraphs collection of section
            sec1.Paragraphs.Add(text1);
            // Add a new text paragraph with symbol to print page number information for text paragraph with ID page4
            sec1.Paragraphs.Add(new Aspose.Pdf.Generator.Text("The last page is #$REFPAGE(page4)."));

            // Create a new Text paragraph with sample text
            Aspose.Pdf.Generator.Text text2 = new Aspose.Pdf.Generator.Text("page 2");
            // Specify the ID for text paragraph
            text2.ID = "page2";
            // Specify that text2 is first paragraph of section
            text2.IsFirstParagraph = true;
            // Add text paragraph to paragraphs collection of section object
            sec1.Paragraphs.Add(text2);

            Aspose.Pdf.Generator.Text text3 = new Aspose.Pdf.Generator.Text("page 3");
            text3.ID = "page3";
            text3.IsFirstParagraph = true;
            sec1.Paragraphs.Add(text3);

            Aspose.Pdf.Generator.Section sec2 = pdf1.Sections.Add();
            Aspose.Pdf.Generator.Text text4 = new Aspose.Pdf.Generator.Text("page 4");
            text4.ID = "page4";
            sec2.Paragraphs.Add(text4);

            pdf1.Save( dataDir + "test_out.pdf");

            // ExEnd:SpecifiedParagraph
        }

       
    }
}