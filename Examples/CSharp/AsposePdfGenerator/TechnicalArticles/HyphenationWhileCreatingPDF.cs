using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.TechnicalArticles
{
    public class HyphenationWhileCreatingPDF
    {
        public static void Run()
        {
            try
            {
                // ExStart:HyphenationWhileCreatingPDF
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_TechnicalArticles();

                // Create pdf document
                Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

                // Instantiate License class and call its SetLicense method to use the license
                Aspose.Pdf.License license = new Aspose.Pdf.License();
                license.SetLicense("Aspose.Pdf.lic");

                // Bind XML into the document
                pdf1.BindXML(dataDir + "Hyphen-test.xml", null);

                // Enable hyphenation function. Default value is false.
                pdf1.IsAutoHyphenated = true;

                // Set the hyphenation dictionary path.
                pdf1.HyphenationDictionaryPath = dataDir + "Hyphen.xml";

                // Set the hyphenation area width. Default value is 12 points.
                pdf1.HyphenationZoneWidth = 0;

                // Set the maximum number of consecutive hyphenations. Default value is zero that means no // Limits.
                pdf1.ConsecutiveHyphensLimits = 0;

                // Save the Pdf file
                pdf1.Save(dataDir + "Hyphen-test_out.pdf");
                // ExEnd:HyphenationWhileCreatingPDF     
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}