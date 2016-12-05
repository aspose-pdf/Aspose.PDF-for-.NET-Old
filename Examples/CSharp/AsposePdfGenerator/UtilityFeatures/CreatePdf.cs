using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.UtilityFeatures
{
    public class CreatePdf
    {
        public static void Run()
        {
            // ExStart:CreatePdf
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_UtilityFeatures();

            // Create a file stream to create the PDF document
            FileStream fs = new FileStream( dataDir +  "SingleSeg-d_out.pdf", FileMode.Create);

            // Instantiate the Pdf instance and pass the file stream object to its constructor
            Aspose.Pdf.Generator.Pdf pdf = new Aspose.Pdf.Generator.Pdf(fs);

            // Add a section to the PDF document
            Aspose.Pdf.Generator.Section sec1 = pdf.Sections.Add();

            // Add 1000 text paragraphs to the section
            for (int i = 0; i < 1000; i++)
            {
                Aspose.Pdf.Generator.Text t = new Aspose.Pdf.Generator.Text("hello world hello world hello " + i.ToString());
                sec1.AddParagraph(t);
            }

            // Close the Pdf. This method is used only for direct file mode
            pdf.Close(); 
            // ExEnd:CreatePdf           
        }
        public static void UsingXML()
        {
            // ExStart:UsingXML
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_UtilityFeatures();
            // Create a file stream to create the PDF document
            FileStream fs = new FileStream( dataDir +  "CreatePdfUsingXML_out", FileMode.Create);

            // Instantiate the Pdf instance and pass the file stream object to its constructor
            Aspose.Pdf.Generator.Pdf pdf = new Aspose.Pdf.Generator.Pdf(fs);

            // Bind the XML file to the Pdf and leave the XSL file parameter as Nothing
            pdf.BindXML( dataDir +  "log.xml", null);

            // Close the Pdf. This method is used only for direct file mode
            pdf.Close();
            // ExEnd:UsingXML
        }
       
    }
}