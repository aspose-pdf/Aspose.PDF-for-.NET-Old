using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.TechnicalArticles
{
    public class CreatePdfA1
    {
        public static void Run()
        {
            try
            {
                // ExStart:CreatePdfA1
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_TechnicalArticles();

                // Create pdf document
                Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

                // Instantiate License class and call its SetLicense method to use the license
                Aspose.Pdf.License license = new Aspose.Pdf.License();
                license.SetLicense("Aspose.Custom.lic");

                // Set the conformance property of Pdf class to predefined value
                pdf1.Conformance = Aspose.Pdf.Generator.PdfConformance.PdfA1B;

                // Add a section into the pdf document
                Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

                // Save the document
                pdf1.Save(dataDir + "CreatePdfA1_out.pdf");
                // ExEnd:CreatePdfA1  
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}