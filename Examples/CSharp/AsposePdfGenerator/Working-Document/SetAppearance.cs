using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.WorkingDocuments
{
    public class SetAppearance
    {
        public static void Run()
        {
            // ExStart:SetAppearance
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_WorkingDocuments();

            // Instantiate Pdf instance
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Set OpenType property of Pdf instance to any pre-defined value
            pdf1.OpenType = Aspose.Pdf.Generator.OpenType.Thumbnails;

            dataDir = dataDir + "SetAppearance_out.pdf";
            pdf1.Save(dataDir);
            // ExEnd:SetAppearance
            Console.WriteLine("\nAppearance setup successfully.\nFile saved at " + dataDir);
        }
    }
}