using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Text
{
    public class TextFormattingTags
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Text();

            // Create directory if it is not already present.
            bool IsExists = System.IO.Directory.Exists(dataDir);
            if (!IsExists)
                System.IO.Directory.CreateDirectory(dataDir);

            // Instantiate a pdf document
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Create a section in the pdf document
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            // Create string variables with text containing html tags
            string s = "<font face=\"Times New Roman\" size=18><u>" +
                "This is a test </u><i> for <strong> HTML </<strong> support </i>" +
                "<s> in Text paragraph. </s></font>";

            string s1 = "<font color=\"#800080\">This is a test for <b>HTML</b>" +
                "with colored text.</font>";

            string s2 = "<p><font face=\"Verdana\" color=\"#0033ff\"> This is a test for" +
                "<strong>HTML</strong> in text paragraph.</font></p>";

            // Create text paragraphs containing HTML text
            Aspose.Pdf.Generator.Text text1 = new Aspose.Pdf.Generator.Text(s);
            text1.IsHtmlTagSupported = true;
            Aspose.Pdf.Generator.Text text2 = new Aspose.Pdf.Generator.Text(s1);
            text2.IsHtmlTagSupported = true;
            Aspose.Pdf.Generator.Text text3 = new Aspose.Pdf.Generator.Text(s2);
            text3.IsHtmlTagSupported = true;

            // Add the text paragraphs containing HTML text to the section
            sec1.Paragraphs.Add(text1);
            sec1.Paragraphs.Add(text2);
            sec1.Paragraphs.Add(text3);

            // Save the pdf document
            pdf1.Save(dataDir + "TestHtml_out_.pdf");
        }
    }
}
            
 

