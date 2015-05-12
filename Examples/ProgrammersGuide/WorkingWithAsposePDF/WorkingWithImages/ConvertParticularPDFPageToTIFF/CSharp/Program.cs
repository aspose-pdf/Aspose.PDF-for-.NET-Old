//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;
using Aspose.Pdf.Devices;

namespace ConvertParticularPDFPageToTIFF
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //Open document
            Document pdfDocument = new Document(dataDir+ "input.pdf");

            //Create Resolution object
            Resolution resolution = new Resolution(300);

            //Create TiffSettings object
            TiffSettings tiffSettings = new TiffSettings();
            tiffSettings.Compression = CompressionType.None;
            tiffSettings.Depth = ColorDepth.Default;
            tiffSettings.Shape = ShapeType.Landscape;
            tiffSettings.SkipBlankPages = false;

            //Create TIFF device
            TiffDevice tiffDevice = new TiffDevice(resolution, tiffSettings);


            //Convert a particular page and save the image to stream
            tiffDevice.Process(pdfDocument, 1, 1, dataDir + "output.tif");
            
        }
    }
}