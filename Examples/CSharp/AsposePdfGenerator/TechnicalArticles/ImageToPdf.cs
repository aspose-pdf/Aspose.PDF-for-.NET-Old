using System;
using System.IO;
using Aspose.Pdf;
using System.Drawing;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.TechnicalArticles
{
    public class ImageToPdf
    {
        public static void Run()
        {
            // ExStart:ImageToPdf
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_TechnicalArticles();

            // Instantiate a Pdf object by calling its empty constructor
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Create a section in the Pdf object
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            // Create an image object in the section
            Aspose.Pdf.Generator.Image image1 = new Aspose.Pdf.Generator.Image(sec1);

            // Add image object into the Paragraphs collection of the section
            sec1.Paragraphs.Add(image1);

            // Set the path of image file
            image1.ImageInfo.File = dataDir + "aspose-logo.jpg";

            // Set the type of image using ImageFileType enumeration
            image1.ImageInfo.ImageFileType = Aspose.Pdf.Generator.ImageFileType.Jpeg;

            // Set image title
            image1.ImageInfo.Title = "JPEG image";            

            // Save the Pdf file
            pdf1.Save(dataDir + "JPGImageToPdf_out.pdf");
            // ExEnd:ImageToPdf           
        }
        public static void ConvertBMPImageToPdf()
        {
            // ExStart:ConvertBMPImageToPdf
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_TechnicalArticles();

            // Create a PDF object
            Aspose.Pdf.Generator.Pdf pdf = new Aspose.Pdf.Generator.Pdf();
            // Create a section and add it to pdf document
            Aspose.Pdf.Generator.Section MainSection = pdf.Sections.Add();            
            // Create an image object
            Aspose.Pdf.Generator.Image sample_image = new Aspose.Pdf.Generator.Image();
            // Specify the image file path information
            sample_image.ImageInfo.File = dataDir +  "barbara_gray.bmp";
            // Specify the image file type
            sample_image.ImageInfo.ImageFileType = Aspose.Pdf.Generator.ImageFileType.Bmp;
            // Specify the image width information equal to page width 
            sample_image.ImageInfo.FixWidth = MainSection.PageInfo.PageWidth - MainSection.PageInfo.Margin.Left - MainSection.PageInfo.Margin.Right;
            // Specify the image Height information equal to page Height
            sample_image.ImageInfo.FixWidth = MainSection.PageInfo.PageHeight - MainSection.PageInfo.Margin.Top - MainSection.PageInfo.Margin.Bottom;

            // Create bitmap image object to load image information
            Bitmap myimage = new Bitmap( dataDir + "barbara_gray.bmp");
            // Check if the width of the image file is greater than Page width or not
            if (myimage.Width > MainSection.PageInfo.PageWidth)
                // If the Image width is greater than page width, then set the page orientation to Landscape
                MainSection.IsLandscape = true;
            else
                // If the Image width is less than page width, then set the page orientation to Portrait
                MainSection.IsLandscape = false;

            // Add image to paragraphs collection of section
            MainSection.Paragraphs.Add(sample_image);
            // Save the resultant PDF
            pdf.Save(dataDir + "ConvertBMPImageToPdf_out.pdf");
            // ExEnd:ConvertBMPImageToPdf
        }
    }
}