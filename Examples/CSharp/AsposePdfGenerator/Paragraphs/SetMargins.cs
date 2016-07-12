using System;
using System.IO;
using Aspose.Pdf;
namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Paragraphs
{
    public class SetMargins
    {
        public static void Run()
        {
            // ExStart:SetMargins
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Paragraphs();
                        
            // Instantiate Pdf object by calling its empty constructor
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Add a new section to the Pdf object
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            // Instantiate a graph object, associate it with a section and pass the height
            // & width of the graph
            Aspose.Pdf.Generator.Graph g1 = new Aspose.Pdf.Generator.Graph(sec1, 100, 100);

            // Add a graph object to the paragraphs collection of the section
            sec1.Paragraphs.Add(g1);

            // Add a circle object to the shapes collection of graph object
            g1.Shapes.Add(new Aspose.Pdf.Generator.Circle(g1, 50, 50, 30));

            // Instantiate another Graph object, associate it with a section and pass the height
            // & width of the graph
            Aspose.Pdf.Generator.Graph g2 = new Aspose.Pdf.Generator.Graph(sec1, 100, 100);

            // Set the value of left margin
            g2.Margin.Left = 150;

            // Set the value of top margin and assign a negative value to it
            g2.Margin.Top = -100;

            // Add the paragraph object "g2" to paragraphs collection of the section
            sec1.Paragraphs.Add(g2);

            // Add a rectangle to the graph object (g2) in its shapes collection
            g2.Shapes.Add(new Aspose.Pdf.Generator.Rectangle(g2, 20, 20, 60, 60));

            dataDir = dataDir + "SetMargins_out_.pdf";
            // Save the resultant PDF
            pdf1.Save(dataDir);
            // ExEnd:SetMargins
            Console.WriteLine("\nParagraph margins setup successfully.\nFile saved at " + dataDir);
            
        }
    }
}