using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.UtilityFeatures
{
    public class SpecifyListItem
    {
        public static void Run()
        {
            // ExStart:SpecifyListItem
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_UtilityFeatures();

            // Instantiate Pdf instance by calling its empty constructor
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Create a section in the Pdf document
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            // Add four headings in the section
            for (int Level = 1; Level != 5; Level++)
            {
                Aspose.Pdf.Generator.Heading heading2 = new Aspose.Pdf.Generator.Heading(pdf1, sec1, Level);
                Aspose.Pdf.Generator.Segment segment2 = new Aspose.Pdf.Generator.Segment(heading2);
                heading2.Segments.Add(segment2);
                heading2.IsAutoSequence = true;
                segment2.Content = "this is heading of level ";
                segment2.Content += Level.ToString();

                // Add the heading into Table Of Contents. 
                heading2.IsInList = true;
                sec1.Paragraphs.Add(heading2);
            }

            // Create a graph and add a curve shape to its shapes collection
            Aspose.Pdf.Generator.Graph graph1 = new Aspose.Pdf.Generator.Graph(sec1, 100, 400);
            sec1.Paragraphs.Add(graph1);
            float[] posArr = new float[] { 0, 0, 200, 80, 300, 40, 350, 90 };
            Aspose.Pdf.Generator.Curve curve1 = new Aspose.Pdf.Generator.Curve(graph1, posArr);
            graph1.Shapes.Add(curve1);

            // Add the Graph to the List of Figures
            graph1.IsInList = true;

            dataDir = dataDir + "SpecifyListItem_out.pdf";
            // Save the Pdf
            pdf1.Save(dataDir);
            // ExEnd:SpecifyListItem           
        }
       
    }
}