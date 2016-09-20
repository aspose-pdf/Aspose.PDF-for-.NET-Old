using System;
using System.IO;
using Aspose.Pdf;
using System.Drawing;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.TechnicalArticles
{
    public class SetPageOrientation
    {
        public static void Run()
        {
            // ExStart:SetPageOrientation
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_TechnicalArticles();

            // Instantiate a Pdf object by calling its empty constructor
            Aspose.Pdf.Generator.Pdf pdf = new Aspose.Pdf.Generator.Pdf();

            // Retrieve names of all the Pdf files in a particular Directory
            string[] fileEntries = Directory.GetFiles(dataDir, "*.JPG");

            int counter;
            for (counter = 0; counter < fileEntries.Length - 1; counter++)
            {
                // Create a section object
                Aspose.Pdf.Generator.Section section1 = pdf.Sections.Add();

                // Creat an image object
                Aspose.Pdf.Generator.Image image1 = new Aspose.Pdf.Generator.Image(section1);
                image1.ImageInfo.File = fileEntries[counter];
                image1.ImageInfo.ImageFileType = Aspose.Pdf.Generator.ImageFileType.Jpeg;

                // Create a BitMap object in order to get the information of image file
                Bitmap myimage = new Bitmap(fileEntries[counter]);
                // Check if the width of the image file is greater than Page width or not
                if (myimage.Width > section1.PageInfo.PageWidth)
                    // If the Image width is greater than page width, then set the page orientation to Landscape
                    section1.IsLandscape = true;
                else
                    // If the Image width is less than page width, then set the page orientation to Portrait
                    section1.IsLandscape = false;
                // Add the image to paragraphs collection of the PDF document 
                section1.Paragraphs.Add(image1);
            }
            // Save the Pdf file
            pdf.Save(dataDir + "SetPageOrientation_out_.pdf");
            // ExEnd:SetPageOrientation           
        }
    }
}