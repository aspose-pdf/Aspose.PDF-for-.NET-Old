using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.TechnicalArticles
{
    public class RemoveHyperlinksFromText
    {
        public static void Run()
        {
            // ExStart:RemoveHyperlinksFromText
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_TechnicalArticles();

            // Create an object of Pdf class
            Aspose.Pdf.Generator.Pdf pdf = new Aspose.Pdf.Generator.Pdf();
            // Bind the source HTML file with Pdf object
            pdf.BindHTML(File.ReadAllText(dataDir + "Sample.htm"));

            // Get traverse through each segment inside text paragraph
            foreach (Aspose.Pdf.Generator.Segment seg in (pdf.Sections[0].Paragraphs[0] as Aspose.Pdf.Generator.Text).Segments)
            {
                // Verify that the segment URL value is not null
                if (seg.Hyperlink.Url != null)
                {
                    // Specify the LinkType of Segment object as none
                    seg.Hyperlink.LinkType = Aspose.Pdf.Generator.HyperlinkType.None;
                    // Set the value of URL for segment object as blank
                    seg.Hyperlink.Url = "";
                    // Remove the Underline from segment
                    seg.TextInfo.IsUnderline = false;
                    // Change font color to black instread of default Blue for Hyperlinks, you may also comment the following line to display in blue
                    seg.TextInfo.Color = new Aspose.Pdf.Generator.Color("Black");
                }
            }
            // Save the resultant PDF
            pdf.Save(dataDir + "RemoveHyperlinksFromText_out_.pdf");
            // ExEnd:RemoveHyperlinksFromText           
        }
    }
}