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

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.StampsWatermarks
{
    public class ExtractImageImageStamp
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_StampsWatermarks();
            //Instantiate PdfContentEditor Object
            PdfContentEditor pdfContentEditor = new PdfContentEditor();

            ////bind input PDF file
            pdfContentEditor.BindPdf(dataDir+ "ExtractImage-ImageStamp.pdf");

            //Get Stamp info for the first stamp
            StampInfo[] infos = pdfContentEditor.GetStamps(1);

            //Get the image from Stamp Info
           
            System.Drawing.Image image = infos[0].Image;

            //Save the extracted image
            image.Save(dataDir+ "image.jpg");
 
            
            
        }
    }
}