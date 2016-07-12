using System.IO;
using Aspose.Pdf;
namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Text
{
    public class SetVerticalAlignment
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Text();

             // Create directory if it is not already present.
            bool IsExists = System.IO.Directory.Exists(dataDir);
            if (!IsExists)
                System.IO.Directory.CreateDirectory(dataDir);

            // Instantiate Pdf object by calling its empty constructor
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Create a section in the Pdf object
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            // Create a new text paragraph with an initial text segment "Aspose"
            Aspose.Pdf.Generator.Text text1 = new Aspose.Pdf.Generator.Text(sec1,"Aspose");

            // Add the text paragraph to the section
            sec1.Paragraphs.Add(text1);

            // Create a new text segment into the text paragraph
            Aspose.Pdf.Generator.Segment seg2 = text1.Segments.Add("TM");

            // Set the vertical alignment of text segment "seg2" to Topline by setting
            // IsBaseline property  ot seg2.TextInfo to true
            seg2.TextInfo.IsBaseline=false;
            // Set the font size information for the segment
            seg2.TextInfo.FontSize = 5;

            // Save the Pdf
            pdf1.Save(dataDir + "SetVerticalAlignment_out_.pdf");           
            
        }
    }
}