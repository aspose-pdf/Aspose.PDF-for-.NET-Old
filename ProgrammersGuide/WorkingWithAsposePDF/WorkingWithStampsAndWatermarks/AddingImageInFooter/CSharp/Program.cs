//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace AddingImageInFooter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");


            //open document
            Document pdfDocument = new Document(dataDir+ "input.pdf");
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
            pdfDocument.Save(dataDir+ "output.pdf");
        }
    }
}