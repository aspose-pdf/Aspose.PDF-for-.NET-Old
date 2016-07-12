using System;
using System.IO;
using Aspose.Pdf;
namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.General
{
    public class HelloWorldUsingXMLAndAPI
    {
        public static void Run()
        {
            try
            {
                // ExStart:HelloWorldUsingXMLAndAPI
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_General();

                // Create pdf document
                Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

                // Instantiate License class and call its SetLicense method to use the license
                Aspose.Pdf.License license = new Aspose.Pdf.License();
                license.SetLicense("Aspose.Pdf.lic");

                // Bind XML into the document
                pdf1.BindXML(dataDir + "HelloWorldUsingAPI.XML", null);

                // Get the first Section from the PDF document
                Aspose.Pdf.Generator.Section sec1 = pdf1.Sections[0];

                // Get the Text paragraph (whose ID is Text1) from the section
                Aspose.Pdf.Generator.Text text1 = sec1.Paragraphs["Text1"] as Aspose.Pdf.Generator.Text;

                // Add a text Segment to the text paragraph
                text1.Segments.Add("Hello World");

                dataDir = dataDir + "HelloWorldUsingXMLAndAPI_out_.pdf";
                // Save the document
                pdf1.Save(dataDir);
                // ExEnd:HelloWorldUsingXMLAndAPI
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");
            }
            
        }
    }
}