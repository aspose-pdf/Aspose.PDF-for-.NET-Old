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
    public class AddFooter
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_StampsWatermarks();
            //open document
            PdfFileStamp fileStamp = new PdfFileStamp(dataDir+ "AddFooter.pdf", dataDir+ "AddFooter_out.pdf");

            //create formatted text for page number
            FormattedText formattedText = new FormattedText("Aspose - Your File Format Experts!", System.Drawing.Color.Blue, System.Drawing.Color.Gray, Aspose.Pdf.Facades.FontStyle.Courier, EncodingType.Winansi, false, 14);

            //add footer
            fileStamp.AddFooter(formattedText, 10);

            //save updated PDF file
            fileStamp.Close();
 
            
            
        }
    }
}