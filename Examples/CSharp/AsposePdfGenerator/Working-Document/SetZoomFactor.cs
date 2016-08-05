using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.WorkingDocuments
{
    public class SetZoomFactor
    {
        public static void Run()
        {
            // ExStart:SetZoomFactor
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_WorkingDocuments();

            // Instantiate Pdf instance
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf(); 

            // Set the DestinationType property of Pdf instance to any pre-defined value
            pdf1.DestinationType = Aspose.Pdf.Generator.DestinationType.FitPage;
            dataDir = dataDir + "ZoomFactor_out_.pdf";
            pdf1.Save(dataDir);
            // ExEnd:SetZoomFactor
            Console.WriteLine("\nZoom factor setup successfully.\nFile saved at " + dataDir);

        }
    }
}