using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Graphs
{
    public class GraphFormat
    {
        public static void Run()
        {
            // ExStart:GraphFormat
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Graphs();

            // Instantiate Pdf document by calling its empty constructor
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Create a section in the Pdf document
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            // Create a graph in the section with Width=100 and Height=400
            Aspose.Pdf.Generator.Graph graph1 = new Aspose.Pdf.Generator.Graph(sec1, 100, 400);

            // Add the graph object to paragraphs collection of the section
            sec1.Paragraphs.Add(graph1);

            // Create a circle shape in the graph with X=200, Y=50 and Radius=30
            Aspose.Pdf.Generator.Circle circle1 = new Aspose.Pdf.Generator.Circle(graph1, 200, 50, 30);

            // Add the circle in the shapes collection of the graph
            graph1.Shapes.Add(circle1);

            // Set fill color of the circle using GraphInfo property of circle object
            circle1.GraphInfo.FillColor = new Aspose.Pdf.Generator.Color("Green");

            // Enable the circle to be filled with the color specified above line
            circle1.GraphInfo.IsFilled = true;

            dataDir = dataDir + "GraphFormat_out_.pdf";

            // Save the Pdf
            pdf1.Save(dataDir);
            // ExEnd:GraphFormat         
        }
    }
}