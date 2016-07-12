using System.IO;
using Aspose.Pdf;
namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Text
{
    public class TextLayout
    {
        public static void Run()
        {
            // ExStart:TextLayout
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Text();

            // Instantiate Pdf pbject by calling its empty constructor
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Create a new section in the Pdf object
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            // Set the left margin of the section
            sec1.PageInfo.Margin.Left = 110;

            // Set the right margin of the section
            sec1.PageInfo.Margin.Right = 120;

            // Create a new text paragraph and pass the text to its constructor as argument
            Aspose.Pdf.Generator.Text t2 = new Aspose.Pdf.Generator.Text("A bool value that indicates" +
                                       "whether the TrueType font is bold. " +
                                       "This attribute is valid for TrueType fonts only.");

            // Set the font size of the text in a text segment
            t2.Segments[0].TextInfo.FontSize = 16;

            // Set the left margin of the text paragraph
            t2.Margin.Left = 60;

            // Set the first line indentation of the text paragraph to a negative value for
            // producing the effect of left hanging text paragraph
            t2.FirstLineIndent = -6;

            // Add this left hanging text paragraph to the section
            sec1.Paragraphs.Add(t2);
            dataDir = dataDir + "LeftHangingTextParagraph_out_.pdf";
            // Save the pdf file
            pdf1.Save(dataDir);
            // ExEnd:TextLayout            
        }
    }
}