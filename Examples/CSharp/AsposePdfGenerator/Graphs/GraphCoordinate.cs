using System;
using System.IO;
using Aspose.Pdf;
namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Graphs
{
    public class GraphCoordinate
    {
        public static void Run()
        {
            // ExStart:GraphCoordinate
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Graphs();

            // Instantiate a Pdf document object
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Add a section to the Pdf document
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            // Create a graph object in the section with Width=100 and Height=400
            Aspose.Pdf.Generator.Graph graph1 = new Aspose.Pdf.Generator.Graph(sec1,100,400);

            // Add the graph object to the paragraphs collection of the section
            sec1.Paragraphs.Add(graph1);

            // Create an array containing the (X,Y) values of 4 control points
            // required to position a curve
            float[] posArr = new float[]{0,0,200,80,300,40,350,90};

            // Create a curve in the graph with the coordinates given as an array to
            // the constructor of curve class
            Aspose.Pdf.Generator.Curve curve1 = new Aspose.Pdf.Generator.Curve(graph1,posArr);

            // Add the curve shape into the shapes collection of the graph
            graph1.Shapes.Add(curve1);

            dataDir = dataDir + "GraphCoordinate_out_.pdf";

            // Save the Pdf
            pdf1.Save(dataDir);   
            // ExEnd:GraphCoordinate         
        }
    }
}