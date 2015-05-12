//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;
using System;
using System.Drawing;

namespace WorkingWithImagePlacement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");


            // Load the source PDF document
            Aspose.Pdf.Document doc = new Aspose.Pdf.Document(dataDir+ "input.pdf");
            ImagePlacementAbsorber abs = new ImagePlacementAbsorber();
            // Load the contents of first page
            doc.Pages[1].Accept(abs);

            foreach (ImagePlacement imagePlacement in abs.ImagePlacements)
            {
                // Get image properties
                Console.Out.WriteLine("image width:" + imagePlacement.Rectangle.Width);
                Console.Out.WriteLine("image height:" + imagePlacement.Rectangle.Height);
                Console.Out.WriteLine("image LLX:" + imagePlacement.Rectangle.LLX);
                Console.Out.WriteLine("image LLY:" + imagePlacement.Rectangle.LLY);
                Console.Out.WriteLine("image horizontal resolution:" + imagePlacement.Resolution.X);
                Console.Out.WriteLine("image vertical resolution:" + imagePlacement.Resolution.Y);

                // Retrieve image with visible dimensions
                Bitmap scaledImage;
                using (MemoryStream imageStream = new MemoryStream())
                {
                    // Retrieve image from resources
                    imagePlacement.Image.Save(imageStream, System.Drawing.Imaging.ImageFormat.Png);
                    Bitmap resourceImage = (Bitmap)Bitmap.FromStream(imageStream);
                    // Create bitmap with actual dimensions
                    scaledImage = new Bitmap(resourceImage, (int)imagePlacement.Rectangle.Width, (int)imagePlacement.Rectangle.Height);
                }
            }
            
        }
    }
}