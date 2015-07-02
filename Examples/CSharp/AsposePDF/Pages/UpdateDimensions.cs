//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace CSharp.AsposePdf.Pages
{
    public class UpdateDimensions
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Pages();

            //open document
            Document pdfDocument = new Document(dataDir + "UpdateDimensions.pdf");

            //get page collection
            PageCollection pageCollection = pdfDocument.Pages;

            //get particular page
            Page pdfPage = pageCollection[1];

            // set the page size as A4 (11.7 x 8.3 in) and in Aspose.Pdf, 1 inch = 72 points
            // so A4 dimensions in points will be (842.4, 597.6)
            pdfPage.SetPageSize(597.6, 842.4);

            // save the updated document
            pdfDocument.Save(dataDir + "UpdateDimensions_out.pdf");

        }
    }
}