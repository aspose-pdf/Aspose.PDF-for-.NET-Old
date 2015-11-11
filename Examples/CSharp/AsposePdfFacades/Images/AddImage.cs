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

namespace CSharp.AsposePDFFacades.Images
{
    public class AddImage
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Images();

            //open document
            PdfFileMend mender = new PdfFileMend();

            //create PdfFileMend object to add text
            mender.BindPdf(dataDir + "AddImage.pdf");

           //add image in the PDF file
            mender.AddImage(dataDir+ "aspose-logo.jpg", 1, 100, 600, 200, 700);

            //save changes
            mender.Save(dataDir + "AddImage_out.pdf");

            //close PdfFileMend object
            mender.Close();
        }
    }
}