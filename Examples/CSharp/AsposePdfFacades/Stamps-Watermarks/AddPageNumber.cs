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
using System.Drawing;

namespace CSharp.AsposePDFFacades.StampsWatermarks
{
    public class AddPageNumber
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_StampsWatermarks();

            //create PdfFileStamp object
            PdfFileStamp fileStamp = new PdfFileStamp();

            //Open Document
            fileStamp.BindPdf(dataDir + "Input_new.pdf");
            
            //get total number of pages
            int totalPages = new PdfFileInfo(dataDir+ "Input_new.pdf").NumberOfPages;

            //create formatted text for page number
            FormattedText formattedText = new FormattedText("Page # Of " + totalPages, System.Drawing.Color.Blue, System.Drawing.Color.Gray, Aspose.Pdf.Facades.FontStyle.Courier, EncodingType.Winansi, false, 14);

            //set starting number for first page; you might want to start from 2 or more
            fileStamp.StartingNumber = 1;

            //add page number
            fileStamp.AddPageNumber(formattedText, 0);

            //save updated PDF file
            fileStamp.Save(dataDir + "AddPageNumber_out.pdf");

            //close fileStamp
            fileStamp.Close();
            
        }
    }
}