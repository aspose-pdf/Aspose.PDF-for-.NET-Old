using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Generator;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Conversion
{
    public class SVGToPDF
    {
        public static void Run()
        {
            // ExStart:SVGToPDF
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Conversion();

            // Instantiate Pdf object
            Aspose.Pdf.Generator.Pdf pdf = new Aspose.Pdf.Generator.Pdf();
            // Bind the source SVG file
            pdf.BindSvg( dataDir + "SVGToPDF.svg");
            // Save the resultant PDF document
            pdf.Save(dataDir + @"SVGToPDF_out.pdf");
            // ExEnd:SVGToPDF
        }
    }
}