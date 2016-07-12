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

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Images
{
    public class ConvertPageRegion
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Images();
            // instantiate PdfPageEditor class to get particular page region
            Aspose.Pdf.Facades.PdfPageEditor editor = new Aspose.Pdf.Facades.PdfPageEditor();
            // bind the source PDF file
            editor.BindPdf(dataDir + "SampleInput.pdf");
            // move the origin of PDF file to particular point
            editor.MovePosition(0, 700);
            // create a memory stream object
            MemoryStream ms = new MemoryStream();
            // save the updated document to stream object
            editor.Save(ms);
            //create PdfConverter object
            PdfConverter objConverter = new PdfConverter();
            //bind input pdf file
            objConverter.BindPdf(ms);
            //set StartPage and EndPage properties to the page number to
            //you want to convert images from
            objConverter.StartPage = 1;
            objConverter.EndPage = 1;
            //Counter
            int page = 1;
            //initialize the converting process
            objConverter.DoConvert();
            //check if pages exist and then convert to image one by one
            while (objConverter.HasNextImage())
                objConverter.GetNextImage(dataDir+ "Specific_Region-Image" + page++ + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
            //close the PdfConverter object
            objConverter.Close();
            // close MemoryStream object holding the updated document
            ms.Close();
            
            
        }
    }
}