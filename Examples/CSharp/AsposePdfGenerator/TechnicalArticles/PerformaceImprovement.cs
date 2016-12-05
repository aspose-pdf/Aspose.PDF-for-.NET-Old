using System;
using System.IO;
using Aspose.Pdf;
using System.Drawing;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.TechnicalArticles
{
    public class PerformaceImprovement
    {
        public static void Run()
        {
            // ExStart:PerformaceImprovement
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_TechnicalArticles();

            // Get a list of tiff image files
            string[] files = System.IO.Directory.GetFiles(dataDir);

            // Instantiate a Pdf object
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Navigate through the files and them in the pdf file
            foreach (string myFile in files)
            {

                // Load all tiff files in byte array
                FileStream fs = new FileStream(myFile, FileMode.Open, FileAccess.Read);
                byte[] tmpBytes = new byte[fs.Length];
                fs.Read(tmpBytes, 0, Convert.ToInt32(fs.Length));

                MemoryStream mystream = new MemoryStream(tmpBytes);
                Bitmap b = new Bitmap(mystream);
                // Create a new section in the Pdf document
                Aspose.Pdf.Generator.Section sec1 = new Aspose.Pdf.Generator.Section(pdf1);

                // Set margins so image will fit, etc.
                sec1.PageInfo.Margin.Top = 5;
                sec1.PageInfo.Margin.Bottom = 5;
                sec1.PageInfo.Margin.Left = 5;
                sec1.PageInfo.Margin.Right = 5;

                sec1.PageInfo.PageWidth = (b.Width / b.HorizontalResolution) * 72;
                sec1.PageInfo.PageHeight = (b.Height / b.VerticalResolution) * 72;

                // Add the section in the sections collection of the Pdf document
                pdf1.Sections.Add(sec1);

                // Create an image object
                Aspose.Pdf.Generator.Image image1 = new Aspose.Pdf.Generator.Image(sec1);

                // Add the image into paragraphs collection of the section
                sec1.Paragraphs.Add(image1);
                image1.ImageInfo.ImageFileType = Aspose.Pdf.Generator.ImageFileType.Tiff;

                // Set IsBlackWhite property to true for performance improvement
                image1.ImageInfo.IsBlackWhite = true;
                // Set the ImageStream to a MemoryStream object
                image1.ImageInfo.ImageStream = mystream;
                // Set desired image scale
                image1.ImageScale = 0.95F;
            }

            // Save the Pdf
            pdf1.Save(dataDir + "PerformaceImprovement_out.pdf");
            // ExEnd:PerformaceImprovement           
        }
    }
}