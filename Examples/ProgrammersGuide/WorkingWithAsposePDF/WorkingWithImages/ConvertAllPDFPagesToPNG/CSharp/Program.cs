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

namespace ConvertAllPDFPagesToPNG
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //Open document
            Document pdfDocument = new Document(dataDir+ "input.pdf");


            for (int pageCount = 1; pageCount <= pdfDocument.Pages.Count; pageCount++)
            {
                using (FileStream imageStream = new FileStream(dataDir + "image" + pageCount + ".png", FileMode.Create))
                {
                    //create PNG device with specified attributes
                    //Width, Height, Resolution, Quality
                    //Quality [0-100], 100 is Maximum
                    //Create Resolution object
                    Resolution resolution = new Resolution(300);
                    PngDevice pngDevice = new PngDevice(resolution);

                    //Convert a particular page and save the image to stream
                    pngDevice.Process(pdfDocument.Pages[pageCount], imageStream);

                    //Close stream
                    imageStream.Close();

                }
            }
            
        }
    }
}