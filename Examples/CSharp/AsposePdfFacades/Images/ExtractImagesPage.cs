//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;
using Aspose.Pdf.Facades;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Images
{
    public class ExtractImagesPage
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Images();

            //open input PDF
            PdfExtractor pdfExtractor = new PdfExtractor();
            pdfExtractor.BindPdf(dataDir+ "ExtractImages-Page.pdf");

            //set StartPage and EndPage properties to the page number to
            //you want to extract images from
            pdfExtractor.StartPage = 2;
            pdfExtractor.EndPage = 2;

            //extract images
            pdfExtractor.ExtractImage();
            //get extracted images
            while (pdfExtractor.HasNextImage())
            {
                //read image into memory stream
                MemoryStream memoryStream = new MemoryStream();
                pdfExtractor.GetNextImage(memoryStream);

                //write to disk, if you like, or use it otherwise.
                FileStream fileStream = new
                FileStream(dataDir+ DateTime.Now.Ticks.ToString() + ".jpg", FileMode.Create);
                memoryStream.WriteTo(fileStream);
                fileStream.Close();
            }
            
            
        }
    }
}