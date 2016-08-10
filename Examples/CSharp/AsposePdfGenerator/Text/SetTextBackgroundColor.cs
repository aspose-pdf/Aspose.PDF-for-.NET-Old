using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Text
{
    public class SetTextBackgroundColor
    {
        public static void Run()
        {
            // ExStart:SetTextBackgroundColor
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Text();
         
            // Instantiate Pdf instance by calling its empty constructor
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Create a section in the Pdf object
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();


            // Create a text paragraph
            Aspose.Pdf.Generator.Text text1 = new Aspose.Pdf.Generator.Text(sec1,"Hello Aspose.Pdf");

            // Set the BackgroundColor of the text paragraph to Red
            text1.TextInfo.BackgroundColor=new Aspose.Pdf.Generator.Color("Red");

            // Add the text paragraph to the section
            sec1.Paragraphs.Add(text1);

            // Save the Pdf
            pdf1.Save(dataDir + "SetTextBackgroundColor_out_.pdf");
            // ExEnd:SetTextBackgroundColor
        }
    }
}