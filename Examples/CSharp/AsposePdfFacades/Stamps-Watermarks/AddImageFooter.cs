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

namespace CSharp.AsposePDFFacades.StampsWatermarks
{
    public class AddImageFooter
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_StampsWatermarks();

            //create PdfFileStamp object
            PdfFileStamp fileStamp = new PdfFileStamp();

            //Open Document
            fileStamp.BindPdf(dataDir + "AddImage-Footer.pdf");

            //add footer
            fileStamp.AddFooter(new FileStream(dataDir+ "aspose-logo.jpg", FileMode.Open), 10);

            //save updated PDF file
            fileStamp.Save(dataDir + "AddImage-Footer_out.pdf");

            //close fileStamp
            fileStamp.Close();
 
            
        }
    }
}