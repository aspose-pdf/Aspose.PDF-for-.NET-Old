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

namespace SearchAndGetImages
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            // Open document
            Aspose.Pdf.Document doc = new Aspose.Pdf.Document(dataDir+ @"input.pdf");

            // Create ImagePlacementAbsorber object to perform image placement search
            ImagePlacementAbsorber abs = new ImagePlacementAbsorber();

            // Accept the absorber for all the pages
            doc.Pages.Accept(abs);

            //Loop through all ImagePlacements, get image and ImagePlacement Properties
            foreach (ImagePlacement imagePlacement in abs.ImagePlacements)
            {
                //Get the image using ImagePlacement object
                XImage image = imagePlacement.Image;

                //Display image placement properties for all placements
                Console.Out.WriteLine("image width:" + imagePlacement.Rectangle.Width);
                Console.Out.WriteLine("image height:" + imagePlacement.Rectangle.Height);
                Console.Out.WriteLine("image LLX:" + imagePlacement.Rectangle.LLX);
                Console.Out.WriteLine("image LLY:" + imagePlacement.Rectangle.LLY);
                Console.Out.WriteLine("image horizontal resolution:" + imagePlacement.Resolution.X);
                Console.Out.WriteLine("image vertical resolution:" + imagePlacement.Resolution.Y);
            }
 
            
            
        }
    }
}