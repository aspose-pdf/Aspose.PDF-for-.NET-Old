//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;
using System.Drawing;

namespace ConvertImageToPDF
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            // 1.
            //Instantiate a Pdf object by calling its empty constructor
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            //Create a section in the Pdf object
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            //Create an image object in the section
            Aspose.Pdf.Generator.Image image1 = new Aspose.Pdf.Generator.Image(sec1);

            //Add image object into the Paragraphs collection of the section
            sec1.Paragraphs.Add(image1);

            //Set the path of image file
            image1.ImageInfo.File = dataDir + "aspose.jpg";

            //Set the type of image using ImageFileType enumeration
            image1.ImageInfo.ImageFileType = Aspose.Pdf.Generator.ImageFileType.Jpeg;

            //Set image title
            image1.ImageInfo.Title = "JPEG image";

            //Save the Pdf
            pdf1.Save(dataDir + "jpegOutput.pdf");

            
            // 2.
            // create a PDF object
            Aspose.Pdf.Generator.Pdf pdf = new Aspose.Pdf.Generator.Pdf();
            
            // create a section and add it to pdf document
            Aspose.Pdf.Generator.Section MainSection = pdf.Sections.Add();
            
            //Add the radio form field to the paragraphs collection of the section
            // create an image object
            Aspose.Pdf.Generator.Image sample_image = new Aspose.Pdf.Generator.Image();
            
            // specify the image file path information
            sample_image.ImageInfo.File = dataDir + "aspose.bmp";

            // specify the image file type
            sample_image.ImageInfo.ImageFileType = Aspose.Pdf.Generator.ImageFileType.Bmp;
            
            // specify the image width information equal to page width 
            sample_image.ImageInfo.FixWidth = MainSection.PageInfo.PageWidth - MainSection.PageInfo.Margin.Left - MainSection.PageInfo.Margin.Right;
            
            // specify the image Height information equal to page Height
            sample_image.ImageInfo.FixWidth = MainSection.PageInfo.PageHeight - MainSection.PageInfo.Margin.Top - MainSection.PageInfo.Margin.Bottom;

            // create bitmap image object to load image information
            Bitmap myimage = new Bitmap(dataDir + "aspose.bmp");
            
            // check if the width of the image file is greater than Page width or not
            if (myimage.Width > MainSection.PageInfo.PageWidth)
                // if the Image width is greater than page width, then set the page orientation to Landscape
                MainSection.IsLandscape = true;
            else
                // if the Image width is less than page width, then set the page orientation to Portrait
                MainSection.IsLandscape = false;

            // add image to paragraphs collection of section
            MainSection.Paragraphs.Add(sample_image);
            
            // save the resultant PDF
            pdf.Save(dataDir + "resizedBmpOutput.pdf");


            // 3.
            //Instantiate Pdf instance by calling its empty constructor
            Aspose.Pdf.Generator.Pdf pdf3 = new Aspose.Pdf.Generator.Pdf();

            //Create a new section in the Pdf object
            Aspose.Pdf.Generator.Section sec3 = pdf1.Sections.Add();
            
            //Create an image object in the section
            Aspose.Pdf.Generator.Image image3 = new Aspose.Pdf.Generator.Image(sec1);
            
            //Add image object into the Paragraphs collection of the section
            sec3.Paragraphs.Add(image3);
            
            //Set the ImageStream information
            image3.ImageInfo.SystemImage = System.Drawing.Image.FromFile(dataDir + "aspose.tif");
            
            // set the value that all frames of tiff image need be added into PDF document
            image3.ImageInfo.TiffFrame = -1;

            image3.ImageInfo.ImageFileType = Aspose.Pdf.Generator.ImageFileType.Tiff;

            //Save the pdf document
            pdf3.Save(dataDir + "tifOutput.pdf");
        }
    }
}