using System;
using System.IO;
using Aspose.Pdf;
namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Paragraphs
{
    public class Render
    {
        public static void Run()
        {
            // ExStart:Render
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Paragraphs();
           
            // Instantiate Pdf instance by calling its empty constructor
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Create a section in the Pdf document
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            // Add a text paragraph in the section
            sec1.Paragraphs.Add(new Aspose.Pdf.Generator.Text("page 1"));

            // Create another text paragraph that has to be rendered
            Aspose.Pdf.Generator.Text t2 = new Aspose.Pdf.Generator.Text("page2");

            // Set the IsFirstParagraph property of the text paragraph to true
            // to render it to a new page
            t2.IsFirstParagraph = true;

            // Add the text paragraph to be rendered to the section
            sec1.Paragraphs.Add(t2);

            dataDir = dataDir + "RenderParagraph_out_.pdf";
            // Save the Pdf document
            pdf1.Save(dataDir);
            // ExEnd:Render   
            Console.WriteLine("\nParagraph renders successfully.\nFile saved at " + dataDir);
        }
    }
}