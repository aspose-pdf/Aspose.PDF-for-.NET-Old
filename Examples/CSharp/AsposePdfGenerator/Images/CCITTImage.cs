using System;
using System.IO;
using Aspose.Pdf;
namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Images
{
    public class CCITTImage
    {
        public static void Run()
        {
                // ExStart:CCITTImage
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Images();
                string faxImageFile = "";
                if (faxImageFile != "")
                {
                    // Instantiate a Pdf object by calling its empty constructor
                    Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

                    // Create a section in the Pdf object
                    Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

                    // Instantiate an image object
                    Aspose.Pdf.Generator.Image img1 = new Aspose.Pdf.Generator.Image(sec1);

                    // Add image object into the Paragraphs collection of the section
                    sec1.Paragraphs.Add(img1);

                    // Set the path of image file
                    img1.ImageInfo.File = faxImageFile;

                    // Set the file type of the image
                    img1.ImageInfo.ImageFileType = Aspose.Pdf.Generator.ImageFileType.Ccitt;

                    // Set the image width
                    img1.ImageInfo.CcittImageWidth = 2560;

                    // Set the image height
                    img1.ImageInfo.CcittImageHeight = 1779;

                    // Set the sub-format of the ccitt image
                    img1.ImageInfo.CcittSubFormat = Aspose.Pdf.Generator.CcittSubFormat.Group31D;

                    // Set the desired scaling of the image
                    img1.ImageScale = 0.1F;

                    pdf1.Save( dataDir + "CCITTImage_out_.pdf");
                    // ExEnd:CCITTImage   
                }
                else
                {
                    Console.WriteLine("\nPlease set valid fax image file path.");
                }
        }
    }
}