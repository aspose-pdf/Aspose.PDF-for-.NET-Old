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

namespace AddImageInFooterOfExistingPDFExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");
            //open document
            PdfFileStamp fileStamp = new PdfFileStamp(dataDir+ "input.pdf", dataDir+ "output.pdf");

            //add footer
            fileStamp.AddFooter(new FileStream(dataDir+ "aspose-logo.jpg", FileMode.Open), 10);

            //save updated PDF file
            fileStamp.Close();
 
            
        }
    }
}