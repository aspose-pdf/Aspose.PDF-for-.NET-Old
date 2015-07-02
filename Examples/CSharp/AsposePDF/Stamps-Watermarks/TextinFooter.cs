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
    public class TextinFooter
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_StampsWatermarks();


            //open document
            Document pdfDocument = new Document(dataDir+ "TextinFooter.pdf");
            //create footer
            TextStamp textStamp = new TextStamp("Footer Text");
            //set properties of the stamp
            textStamp.BottomMargin = 10;
            textStamp.HorizontalAlignment = HorizontalAlignment.Center;
            textStamp.VerticalAlignment = VerticalAlignment.Bottom;
            //add footer on all pages
            foreach (Page page in pdfDocument.Pages)
            {
                page.AddStamp(textStamp);
            }

            //save updated PDF file
            pdfDocument.Save(dataDir+ "TextinFooter_out.pdf");
            
        }
    }
}