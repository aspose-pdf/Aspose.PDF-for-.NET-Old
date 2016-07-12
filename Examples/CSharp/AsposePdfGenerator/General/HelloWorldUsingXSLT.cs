using System;
using System.IO;
using Aspose.Pdf;
namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.General
{
    public class HelloWorldUsingXSLT
    {
        public static void Run()
        {
            try
            {
                // ExStart:HelloWorldUsingXSLT
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_General();

                // Create pdf document
                Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

                // Instantiate License class and call its SetLicense method to use the license
                Aspose.Pdf.License license = new Aspose.Pdf.License();
                license.SetLicense("Aspose.Pdf.lic");

                // Bind XML and XSLT files to the document
                pdf1.BindXML(dataDir + "HelloWorldUsingXSLT.XML", dataDir + "HelloWorld.xslt");

                dataDir = dataDir + "HelloWorldUsingXSLT_out_.pdf";
                // Save the document
                pdf1.Save(dataDir);
                // ExEnd:HelloWorldUsingXSLT
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");
            }
            
        }
    }
}