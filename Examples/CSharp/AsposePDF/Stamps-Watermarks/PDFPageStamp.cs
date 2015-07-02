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
    public class PDFPageStamp
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_StampsWatermarks();

            //open document
            Document pdfDocument = new Document(dataDir+ "PDFPageStamp.pdf");

            //create page stamp
            PdfPageStamp pageStamp = new PdfPageStamp(pdfDocument.Pages[1]);
            pageStamp.Background = true;
            pageStamp.XIndent = 100;
            pageStamp.YIndent = 100;
            pageStamp.Rotate = Rotation.on180;


            //add stamp to particular page
            pdfDocument.Pages[1].AddStamp(pageStamp);

            //save output document
            pdfDocument.Save(dataDir+ "PDFPageStamp_out.pdf");
            
        }
    }
}