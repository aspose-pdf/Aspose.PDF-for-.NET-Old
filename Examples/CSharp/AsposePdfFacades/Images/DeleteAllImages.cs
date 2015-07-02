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

namespace CSharp.AsposePDFFacades.Images
{
    public class DeleteAllImages
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Images();
            //open PDF file
            PdfContentEditor contentEditor = new PdfContentEditor();
            contentEditor.BindPdf(dataDir+ "DeleteAllImages.pdf");

            //delete the images from the particular page
            contentEditor.DeleteImage();

            //save output PDF
            contentEditor.Save(dataDir+ "DeleteAllImages_out.pdf");
 
            
        }
    }
}