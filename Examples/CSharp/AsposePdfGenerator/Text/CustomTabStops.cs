using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Text
{
    public class CustomTabStops
    {
        public static void Run()
        {
            // ExStart:CustomTabStops
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Text();
           
            // Instantiate Pdf instance by calling it empty constructor
            Aspose.Pdf.Generator.Pdf pdf = new Aspose.Pdf.Generator.Pdf();

            // Create a text object 
            Aspose.Pdf.Generator.Text text1 = new Aspose.Pdf.Generator.Text("This #$TAB is a example for custom TAB stop positions.");

            // Assign an instance of TabStops to the TabStops property of text object
            text1.TabStops = new Aspose.Pdf.Generator.TabStops();

            // Call Add method of TabStops and pass a specified position as argument
            text1.TabStops.Add(150);

            // Call Add method with specified position and tab leader type as Dot
            text1.TabStops.Add(350, Aspose.Pdf.Generator.TabLeaderType.Dot);

            pdf.Save(dataDir + "CustomTabStops_out.pdf");
            // ExEnd:CustomTabStops
        }
    }
}