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
            //open document
            PdfFileStamp fileStamp = new PdfFileStamp(dataDir+ "AddImage-Footer.pdf", dataDir+ "AddImage-Footer_out.pdf");

            //add footer
            fileStamp.AddFooter(new FileStream(dataDir+ "aspose-logo.jpg", FileMode.Open), 10);

            //save updated PDF file
            fileStamp.Close();
 
            
        }
    }
}