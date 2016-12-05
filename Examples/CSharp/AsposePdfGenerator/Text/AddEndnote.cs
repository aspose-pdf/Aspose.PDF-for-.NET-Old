using System.IO;
using System;
using Aspose.Pdf;
using System.Text;
using System.Xml;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Text
{
    public class AddEndnote
    {
        public static void Run()
        {
            try
            {
                // ExStart:AddEndnote
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

                // Create EndNote and Assign an EndNote property of Segment to its object
                Aspose.Pdf.Generator.EndNote endnote1 = new Aspose.Pdf.Generator.EndNote("Endnotes for First Segment");
                segment.EndNote = endnote1;

                // Add Segment in Text Paragraph
                text.Segments.Add(segment);

                // Add Text in Section
                sec.Paragraphs.Add(text);

                // Save the document
                pdf.Save(dataDir + "AddEndnote_out.pdf");
                // ExEnd:AddEndnote
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

