using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.General
{
    public class HelloWorldUsingAPI
    {
        public static void Run()
        {
            try
            {
                // ExStart:HelloWorldUsingAPI
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_General();

                // Create pdf document
                Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

                // Instantiate License class and call its SetLicense method to use the license
                Aspose.Pdf.License license = new Aspose.Pdf.License();
                license.SetLicense("Aspose.Pdf.lic");

                // Add a section into the pdf document
                Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

                // Add a text paragraph into the section
                sec1.Paragraphs.Add(new Aspose.Pdf.Generator.Text("Hello World"));           

                dataDir = dataDir + "HelloWorldUsingAPI_out.pdf";
                // Save the document
                pdf1.Save(dataDir);
                // ExEnd:HelloWorldUsingAPI
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");
            }
            
        }
    }
}