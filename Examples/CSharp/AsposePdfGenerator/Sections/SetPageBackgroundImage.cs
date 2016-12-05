using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Sections
{
    public class SetPageBackgroundImage
    {
        public static void Run()
        {
            // ExStart:SetPageBackgroundImage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Sections();
            
            // Instantiate a PDF Object 
            Aspose.Pdf.Generator.Pdf pdf = new Aspose.Pdf.Generator.Pdf();

            // Add a section into the pdf document
            Aspose.Pdf.Generator.Section section1 = pdf.Sections.Add();

            // Assign the image file path to BackgroundImageFile property of section
            section1.BackgroundImageFile = dataDir+ "aspose-logo.jpg";

            // Set the image type using ImageFileType enumeration
            section1.BackgroundImageType = Aspose.Pdf.Generator.ImageFileType.Jpeg;

            dataDir = dataDir + "SetPageBackgroundImage_out.pdf";

            // Save Pdf Document
            pdf.Save(dataDir);
            // ExEnd:SetPageBackgroundImage
            Console.WriteLine("\nPage background image setup successfully.\nFile saved at " + dataDir);
        }
    }
}