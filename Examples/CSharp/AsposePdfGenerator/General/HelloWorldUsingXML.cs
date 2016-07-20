using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.General
{
    public class HelloWorldUsingXML
    {
        public static void Run()
        {
            try
            {
                // ExStart:HelloWorldUsingXML
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_General();

                // Create pdf document
                Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

                // Instantiate License class and call its SetLicense method to use the license
                Aspose.Pdf.License license = new Aspose.Pdf.License();
                license.SetLicense("Aspose.Pdf.lic");

                // Bind XML into the document
                pdf1.BindXML(dataDir + "HelloWorld.XML", null);

                dataDir = dataDir + "HelloWorldUsingXML_out_.pdf";
                // Save the document
                pdf1.Save(dataDir);
                // ExEnd:HelloWorldUsingXML
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");
            }
            
        }
    }
}