using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.TechnicalArticles
{
    public class ConvertMemoryStreamImageToPdf
    {
        public static void Run()
        {
            // ExStart:ConvertMemoryStreamImageToPdf
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_TechnicalArticles();

            // Instantiate Pdf instance by calling its empty constructor
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();
            // Add a section into the pdf document
            Aspose.Pdf.Generator.Section sec = pdf1.Sections.Add();

            // Create a FileStream object to read the imag file
            FileStream fs = File.OpenRead(dataDir + "aspose-logo.jpg");
            // Read the image into Byte array
            byte[] data = new byte[fs.Length];
            fs.Read(data, 0, data.Length);

            // Create a MemoryStream object from image Byte array
            MemoryStream ms = new MemoryStream(data);
            // Create an image object in the section 
            Aspose.Pdf.Generator.Image imageht = new Aspose.Pdf.Generator.Image(sec);
            // Set the type of image using ImageFileType enumeration
            imageht.ImageInfo.ImageFileType = Aspose.Pdf.Generator.ImageFileType.Jpeg;

            // Specify the image source as MemoryStream
            imageht.ImageInfo.ImageStream = ms;
            // Add image object into the Paragraphs collection of the section
            sec.Paragraphs.Add(imageht);

            // Save the Pdf
            pdf1.Save(dataDir + "ConvertMemoryStreamImageToPdf_out_.pdf");
            // Close the MemoryStream Object
            ms.Close();
            // ExEnd:ConvertMemoryStreamImageToPdf           
        }
    }
}