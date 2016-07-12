using System.IO;
using System;
using Aspose.Pdf;
using System.Text;
using System.Xml;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Text
{
    public class HyperlinkTags
    {
        public static void Run()
        {
            try
            {
                // ExStart:HyperlinkTags
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Text();

                // Instantiate a pdf document
                Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

                // Create a section in the pdf document
                Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

                // Create a string variable with text containing hyperlink tag
                string string1 = "<a href=\"http://www.aspose.com/\">This is a test</a>";

                // Create text paragraph containing HTML hyperlink tag
                Aspose.Pdf.Generator.Text text1 = new Aspose.Pdf.Generator.Text(string1);
                text1.IsHtmlTagSupported = true;

                // Add the text paragraph containing HTML text to the section
                sec1.Paragraphs.Add(text1);

                // Save the document
                pdf1.Save(dataDir + "HyperlinkTags_out_.pdf");
                // ExEnd:HyperlinkTags
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

