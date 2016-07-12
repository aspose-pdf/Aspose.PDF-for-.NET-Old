using System.IO;
using System;
using Aspose.Pdf;
namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.WorkingDocuments
{
    public class AddingXMPMetaData
    {
        public static void Run()
        {
            // ExStart:AddingXMPMetaData
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_WorkingDocuments();
                       
            // Instantiate a PDF Object 
            Aspose.Pdf.Generator.Pdf pdf = new Aspose.Pdf.Generator.Pdf();

            // Add a section into the pdf document
            Aspose.Pdf.Generator.Section section1 = pdf.Sections.Add();

            // Create a sample text paragraph
            Aspose.Pdf.Generator.Text text1 = new Aspose.Pdf.Generator.Text("This is a test for XMP Metadata");
            // Add text paragraph to paragraphs collection of section object
            section1.Paragraphs.Add(text1);

            // Create XmpMetaData object
            pdf.XmpMetadata = new Aspose.Pdf.Generator.XmpMetadata();

            // Core properties
            pdf.XmpMetadata.AddCreationDate(System.DateTime.Now.ToString());

            // User properties
            pdf.XmpMetadata.AddUserProperty("xmlns:dc=\"http://purl.org/dc/elements/1.1/\"", "dc:contributor", "Aspose");

            dataDir = dataDir + "AddingXMPMetaData_out_.pdf";
            // Save Pdf Document
            pdf.Save(dataDir);
            // ExEnd:AddingXMPMetaData
            Console.WriteLine("\nXMP metadata setup successfully.\nFile saved at " + dataDir);
            
        }
    }
}