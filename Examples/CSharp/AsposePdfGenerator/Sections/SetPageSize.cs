using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Sections
{
    public class SetPageSize
    {
        public static void Run()
        {
            
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Sections();
            
            // Instantiate a PDF Object 
            Aspose.Pdf.Generator.Pdf pdf = new Aspose.Pdf.Generator.Pdf();

            // Add a section into the pdf document
            Aspose.Pdf.Generator.Section section1 = pdf.Sections.Add();

            // ExStart:SetPageSize
            section1.PageInfo.PageWidth = Aspose.Pdf.Generator.PageSize.A3Width;
            section1.PageInfo.PageHeight = Aspose.Pdf.Generator.PageSize.A3Height;
            // ExEnd:SetPageSize
            // OR 
            // ExStart:SetPageSize-1
            section1.PageInfo.PageWidth = 576;
            section1.PageInfo.PageHeight = 707.5F;
            // ExEnd:SetPageSize-1
 
            dataDir = dataDir + "SetPageSize_out.pdf";

            // Save Pdf Document
            pdf.Save(dataDir);
            
            Console.WriteLine("\nPage size setup successfully.\nFile saved at " + dataDir);
        }
    }
}