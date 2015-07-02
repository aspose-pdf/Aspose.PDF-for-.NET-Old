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
    public class AddPageStampAll
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_StampsWatermarks();
            //open document
            PdfFileStamp fileStamp = new PdfFileStamp(dataDir+ "AddPageStampAll.pdf", dataDir+ "AddPageStampAll_out.pdf");

            //create stamp
            Aspose.Pdf.Facades.Stamp stamp = new Aspose.Pdf.Facades.Stamp();
            stamp.BindPdf(dataDir+ "temp.pdf", 1);
            stamp.SetOrigin(200, 200);
            stamp.Rotation = 90.0F;
            stamp.IsBackground = true;

            //add stamp to PDF file
            fileStamp.AddStamp(stamp);

            //save updated PDF file
            fileStamp.Close();
 
            
        }
    }
}