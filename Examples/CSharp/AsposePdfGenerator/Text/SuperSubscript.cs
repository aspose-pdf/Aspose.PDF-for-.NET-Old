using System.IO;
using System;
using Aspose.Pdf;
using System.Text;
using System.Xml;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Text
{
    public class SuperSubscript
    {
        public static void Run()
        {
            try
            {
                // ExStart:SuperSubscript
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Text();

                // Instantiate a pdf document
                Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

                // Create a section in the pdf document
                Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

                // Create a string variable with html text containing Sub & Sup tags
                string string1 = "<FONT face=\"Times New Roman\" size=18>HARBIN<sup>[1234]</sup> : An unexpected stoppage of water<sub>[abcd]</sub>  supply sparked <sup> rumours of a contaminated river</sup> and led to a run on city <sub>supermarkets storing bottled water</sub> yesterday.</FONT>";

                // Create text paragraph containing HTML text
                Aspose.Pdf.Generator.Text text1 = new Aspose.Pdf.Generator.Text(string1);
                text1.IsHtmlTagSupported = true;

                // Add the text paragraph containing HTML text to the section
                sec1.Paragraphs.Add(text1);

                // Save the document
                pdf1.Save(dataDir + "SuperSubscript_out_.pdf");
                // ExEnd:SuperSubscript
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

