using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Graphs
{
    public class RotationAndScaling
    {
        public static void Run()
        {
            // ExStart:RotationAndScaling
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Graphs();

            // Instantiate Pdf instance by calling its empty constructor
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Create a section in the Pdf document
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            // Create 1st graph in the section with width=100 and height=400
            Aspose.Pdf.Generator.Graph graph1 = new Aspose.Pdf.Generator.Graph(sec1, 100, 400);

            // Add 1st graph into the paragraphs collection of the section
            sec1.Paragraphs.Add(graph1);

            // Create a rectangle shape with specified coordinates
            Aspose.Pdf.Generator.Rectangle rect1 = new Aspose.Pdf.Generator.Rectangle(graph1, 85, 100, 100, 50);

            // Add the rectangle into the shapes collection of the 1st graph
            graph1.Shapes.Add(rect1);

            // Create 2nd graph in the section with width=100 and height=400
            Aspose.Pdf.Generator.Graph graph2 = new Aspose.Pdf.Generator.Graph(sec1, 100, 400);

            // Add 2nd graph into the paragraphs collection of the section
            sec1.Paragraphs.Add(graph2);

            // Create a rectangle shape with specified coordinates  
            Aspose.Pdf.Generator.Rectangle rect2 = new Aspose.Pdf.Generator.Rectangle(graph2, 85, 100, 100, 50);

            // Add the rectangle into the shapes collection of the 2nd graph
            graph2.Shapes.Add(rect2);

            // Rotate the 2nd graph to 30 degree using RotationAngle property
            graph2.GraphInfo.RotationAngle = 30;

            // Create 3rd graph in the section with width=100 and height=400                
            Aspose.Pdf.Generator.Graph graph3 = new Aspose.Pdf.Generator.Graph(sec1, 100, 400);

            // Add 3rd graph into the paragraphs collection of the section
            sec1.Paragraphs.Add(graph3);

            // Create a rectangle shape with specified coordinates
            Aspose.Pdf.Generator.Rectangle rect3 = new Aspose.Pdf.Generator.Rectangle(graph3, 85, 100, 100, 50);

            // Add the rectangle into the shapes collection of the 3rd graph
            graph3.Shapes.Add(rect3);

            // Adjust the horizontal size of the 3rd graph using ScalingRateX property
            graph3.GraphInfo.ScalingRateX = 1.5f;     

            dataDir = dataDir + "RotationAndScaling_out.pdf";

            // Save the Pdf
            pdf1.Save(dataDir);
            // ExEnd:RotationAndScaling         
        }
    }
}