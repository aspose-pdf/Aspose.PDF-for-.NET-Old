//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace CSharp.AsposePdf.StampsWatermarks
{
    public class ImageInFooter
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_StampsWatermarks();


            //open document
            Document pdfDocument = new Document(dataDir+ "ImageInFooter.pdf");
            //create footer
            ImageStamp imageStamp = new ImageStamp(dataDir+ "aspose-logo.jpg");
            //set properties of the stamp
            imageStamp.BottomMargin = 10;
            imageStamp.HorizontalAlignment = HorizontalAlignment.Center;
            imageStamp.VerticalAlignment = VerticalAlignment.Bottom;
            //add footer on all pages
            foreach (Page page in pdfDocument.Pages)
            {
                page.AddStamp(imageStamp);
            }

            //save updated PDF file
            pdfDocument.Save(dataDir+ "ImageInFooter_out.pdf");
        }
    }
}