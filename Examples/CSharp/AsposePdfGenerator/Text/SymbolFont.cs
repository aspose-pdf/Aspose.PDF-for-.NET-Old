using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Text
{
    public class SymbolFont
    {
        public static void Run()
        {
            // ExStart:SymbolFont
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Text();

            // Instantiate Pdf instance by calling it empty constructor
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Create a section in the Pdf object
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            // Create a text paragraph inheriting text format settings from the section
            Aspose.Pdf.Generator.Text text1 = new Aspose.Pdf.Generator.Text(sec1);

            // Add the text paragraph to the section
            sec1.Paragraphs.Add(text1);

            // Create 1st text segment
            Aspose.Pdf.Generator.Segment s1 = new Aspose.Pdf.Generator.Segment(((char)183).ToString());

            // Set the font name to the TextInfo.FontName property of segment
            s1.TextInfo.FontName = "Symbol";

            // Add 1st text segment to the text paragraph
            text1.Segments.Add(s1);

            // Create 2nd text segment
            Aspose.Pdf.Generator.Segment s2 = new Aspose.Pdf.Generator.Segment(" the first item");

            // Add 2nd text segment to the text paragraph
            text1.Segments.Add(s2);
 
            dataDir = dataDir + "SymbolFont_out.pdf";
            // Create the result PDF Document
            pdf1.Save(dataDir);
            // ExEnd:SymbolFont
        }
    }
}