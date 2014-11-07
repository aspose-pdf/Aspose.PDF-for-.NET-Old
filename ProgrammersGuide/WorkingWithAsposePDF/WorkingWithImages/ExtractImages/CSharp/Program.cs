//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;
using System.Drawing.Imaging;

namespace ExtractImages
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //open document
            Document pdfDocument = new Document(dataDir+ "input.pdf");

            //extract a particular image
            XImage xImage = pdfDocument.Pages[1].Resources.Images[1];

            FileStream outputImage = new FileStream(dataDir + "output.jpg", FileMode.Create);

            //save output image
            xImage.Save(outputImage, ImageFormat.Jpeg);
            outputImage.Close();

            //save updated PDF file
            pdfDocument.Save(dataDir + "output.pdf");
            
        }
    }
}