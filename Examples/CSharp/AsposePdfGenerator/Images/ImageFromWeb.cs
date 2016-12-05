using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Images
{
    public class ImageFromWeb
    {
        public static void Run()
        {
            // ExStart:ImageFromWeb
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Images();

            // Instantiate a Pdf object by calling its empty constructor
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Create a section in the Pdf object
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            // Create an image object in the section
            Aspose.Pdf.Generator.Image image1 = new Aspose.Pdf.Generator.Image(sec1);

            // Add image object into the Paragraphs collection of the section
            sec1.Paragraphs.Add(image1);

            // Set the path of image file
            image1.ImageInfo.File = "http:// Www.aspose.com/Images/Apple.jpg";

            // Set the type of image using ImageFileType enumeration
            image1.ImageInfo.ImageFileType = Aspose.Pdf.Generator.ImageFileType.Jpeg;

            // Set image title
            image1.ImageInfo.Title = "JPEG image";

            // Save the Pdf
            pdf1.Save(dataDir + "ImageFromLocalDisk_out.pdf");
            // ExEnd:ImageFromWeb         
        }
    }
}