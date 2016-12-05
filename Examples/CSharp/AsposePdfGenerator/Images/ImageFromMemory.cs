using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.General
{
    public class ImageFromMemory
    {
        public static void Run()
        {
            try
            {
                // ExStart:ImageFromMemory
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_General();

                // Set the license for Aspose.Pdf
                Aspose.Pdf.License license = new Aspose.Pdf.License();
                license.SetLicense("Aspose.Custom.lic");

                // Create a memory stream object
                System.IO.MemoryStream mstream = new System.IO.MemoryStream(); 

                // Instantiate a Pdf object
                Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

                // Create a new section in the Pdf document
                Aspose.Pdf.Generator.Section sec1 = new Aspose.Pdf.Generator.Section(pdf1); 

                // Add the section in the sections collection of the Pdf document
                pdf1.Sections.Add(sec1); 

                // Create an image object
                Aspose.Pdf.Generator.Image image1 = new Aspose.Pdf.Generator.Image(sec1); 

                // Add the image into paragraphs collection of the section
                sec1.Paragraphs.Add(image1); 

                image1.ImageInfo.ImageFileType = Aspose.Pdf.Generator.ImageFileType.Bmp; 

                // Set the ImageStream to a MemoryStream object
                image1.ImageInfo.ImageStream = mstream ; 

                // Set desired the image scale
                image1.ImageScale = 0.5F; 

                // Save the Pdf
                pdf1.Save(dataDir + "ImageFromMemory_out.pdf"); 
                // ExEnd:ImageFromMemory
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");
            }
            
        }
    }
}