using System.IO;
using System;
using Aspose.Pdf;
using System.Text;
using System.Xml;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Text
{
    public class AddFootnotes
    {
        public static void Run()
        {
            try
            {
                // ExStart:AddFootnotes
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Text();

                // Instantiate a pdf document
                Aspose.Pdf.Generator.Pdf pdf = new Aspose.Pdf.Generator.Pdf();

                // Create Section
                Aspose.Pdf.Generator.Section sec = pdf.Sections.Add();

                // Create Text Paragraph
                Aspose.Pdf.Generator.Text text = new Aspose.Pdf.Generator.Text();

                // Create Segment
                Aspose.Pdf.Generator.Segment segment = new Aspose.Pdf.Generator.Segment("This is the First Segment");

                // Create FootNote and Assign FootNote property of Segment to its object
                segment.FootNote = new Aspose.Pdf.Generator.FootNote("Footnotes for First Segment");

                // Add Segment in Text Paragraph
                text.Segments.Add(segment);

                // Add Text in Section
                sec.Paragraphs.Add(text);

                // Save the document
                pdf.Save(dataDir + "AddFootnotes_out_.pdf");
                // ExEnd:AddFootnotes
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

