using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Sections
{
    public class SetPageMargin
    {
        public static void Run()
        {
            
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Sections();
            
            // Instantiate a PDF Object 
            Aspose.Pdf.Generator.Pdf pdf = new Aspose.Pdf.Generator.Pdf();

            // Add a section into the pdf document
            Aspose.Pdf.Generator.Section section1 = pdf.Sections.Add();
            // ExStart:SetPageMargin
            // Instantiate the MarginInfo instance
            Aspose.Pdf.Generator.MarginInfo marginInfo = new Aspose.Pdf.Generator.MarginInfo();

            // Set the margin Top. This value is in points but other units like
            // Inches and centi meters can also be used as 12inch or 12cm
            marginInfo.Top = 72;

            // Set the margin Bottom. This value is in points but other units like
            // Inches and centi meters can also be used as 12inch or 12cm
            marginInfo.Bottom = 72;

            // Set the margin Left. This value is in points but other units like
            // Inches and centi meters can also be used as 12inch or 12cm
            marginInfo.Left = 90;

            // Set the margin Right. This value is in points but other units like
            // Inches and centi meters can also be used as 12inch or 12cm
            marginInfo.Right = 90;

            // Assign the marginInfo instance to Margin property of sec1.PageInfo
            section1.PageInfo.Margin = marginInfo;
            // ExEnd:SetPageMargin
            dataDir = dataDir + "SetPageMargin_out_.pdf";

            //Save Pdf Document
            pdf.Save(dataDir);
            
            Console.WriteLine("\nPage margin setup successfully.\nFile saved at " + dataDir);
        }
    }
}