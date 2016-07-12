using System.IO;
using Aspose.Pdf;
namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Conversion
{
    public class PCLToPDF
    {
        public static void Run()
        {
            // ExStart:PCLToPDF
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Conversion();

            // Instantiate Pdf object
            Aspose.Pdf.Generator.Pdf pdf = new Aspose.Pdf.Generator.Pdf();
            // Bind the source PCL file
            pdf.BindPCL( dataDir + "hidetext.pcl");
            // Save the resultant PDF document
            pdf.Save(dataDir + "PCLToPDF_out_.pdf");
            // ExEnd:PCLToPDF
        }
    }
}