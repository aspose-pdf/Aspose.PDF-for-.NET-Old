using System;
using System.IO;
using Aspose.Pdf;
namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.WorkingDocuments
{
    public class SetPageTransitionEffect
    {
        public static void Run()
        {
            // ExStart:SetPageTransitionEffect
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_WorkingDocuments();
                        
            // Instantiate Pdf instance
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // You may set OpenType poperty to full screen
            pdf1.OpenType = Aspose.Pdf.Generator.OpenType.FullScreen;

            // Set PageTransitionType poperty of Pdf instance to a pre-defined desired value
            pdf1.PageTransitionType = Aspose.Pdf.Generator.PageTransitionType.Dissolve;

            dataDir = dataDir + "PageTransition_out_.pdf";
            pdf1.Save(dataDir);
            // ExEnd:SetPageTransitionEffect
            Console.WriteLine("\nPage transition effect setup successfully.\nFile saved at " + dataDir);
            
        }
    }
}