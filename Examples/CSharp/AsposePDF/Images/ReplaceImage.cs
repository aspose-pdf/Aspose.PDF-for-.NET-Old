//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace CSharp.AsposePdf.Images
{
    public class ReplaceImage
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Images();

            //open document
            Document pdfDocument = new Document(dataDir+ "ReplaceImage.pdf");

            //replace a particular image
            pdfDocument.Pages[1].Resources.Images.Replace(1, new FileStream(dataDir + "aspose-logo.jpg", FileMode.Open));

            //save updated PDF file
            pdfDocument.Save(dataDir + "ReplaceImage_out.pdf");
            
            
        }
    }
}