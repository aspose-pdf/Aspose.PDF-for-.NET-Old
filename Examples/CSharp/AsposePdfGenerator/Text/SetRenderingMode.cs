using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Text
{
    public class SetRenderingMode
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Text();
                         
            // Instantiate Pdf instance by calling its empty constructor
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Create a section in the Pdf object
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            // Create 1st text paragraph
            Aspose.Pdf.Generator.Text text1 = new Aspose.Pdf.Generator.Text(sec1,"FillText mode");

            // Set rendering mode to FillText
            text1.TextInfo.RenderingMode= Aspose.Pdf.Generator.RenderingMode.FillText;

            // Create 2nd text paragraph
            Aspose.Pdf.Generator.Text text2 = new Aspose.Pdf.Generator.Text(sec1,"StrokeText mode (outline)");

            // Set rendering mode to StrokeText
            text2.TextInfo.RenderingMode= Aspose.Pdf.Generator.RenderingMode.StrokeText;

            // Create 3rd text paragraph
            Aspose.Pdf.Generator.Text text3 = new Aspose.Pdf.Generator.Text(sec1,"FillStrokeText mode");

            // Set rendering mode to FillStrokeText
            text3.TextInfo.RenderingMode= Aspose.Pdf.Generator.RenderingMode.FillStrokeText;

            // Create 4th text paragraph
            Aspose.Pdf.Generator.Text text4 = new Aspose.Pdf.Generator.Text(sec1,"InvisibleText mode");

            // Set rendering mode to InvisibleText
            text4.TextInfo.RenderingMode= Aspose.Pdf.Generator.RenderingMode.InvisibleText;

            // Add 1st, 2nd, 3rd and 4th text paragraphs to the section
            sec1.Paragraphs.Add(text1);
            sec1.Paragraphs.Add(text2);
            sec1.Paragraphs.Add(text3);
            sec1.Paragraphs.Add(text4);

            // Save the Pdf
            pdf1.Save(dataDir + "SetRenderingMode_out_.pdf"); 
        }
            
        }
    }
