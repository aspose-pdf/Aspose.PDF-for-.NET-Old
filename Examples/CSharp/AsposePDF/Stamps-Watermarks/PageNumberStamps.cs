//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;
using Aspose.Pdf.Text;

namespace CSharp.AsposePdf.StampsWatermarks
{
    public class PageNumberStamps
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_StampsWatermarks();

            //open document
            Document pdfDocument = new Document(dataDir+ "PageNumberStamp.pdf");

            //create page number stamp
            PageNumberStamp pageNumberStamp = new PageNumberStamp();
            //whether the stamp is background
            pageNumberStamp.Background = false;
            pageNumberStamp.Format = "Page # of " + pdfDocument.Pages.Count;
            pageNumberStamp.BottomMargin = 10;
            pageNumberStamp.HorizontalAlignment = HorizontalAlignment.Center;
            pageNumberStamp.StartingNumber = 1;
            //set text properties
            pageNumberStamp.TextState.Font = FontRepository.FindFont("Arial");
            pageNumberStamp.TextState.FontSize = 14.0F;
            pageNumberStamp.TextState.FontStyle = FontStyles.Bold;
            pageNumberStamp.TextState.FontStyle = FontStyles.Italic;
            pageNumberStamp.TextState.ForegroundColor = Color.Aqua;

            //add stamp to particular page
            pdfDocument.Pages[1].AddStamp(pageNumberStamp);

            //save output document
            pdfDocument.Save(dataDir+ "PageNumberStamp_out.pdf");
 
            
            
        }
    }
}