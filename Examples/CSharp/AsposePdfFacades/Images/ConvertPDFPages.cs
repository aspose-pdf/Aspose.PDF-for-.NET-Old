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
using System;

namespace CSharp.AsposePDFFacades.Images
{
    public class ConvertPDFPages
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Images();
            //create PdfConverter object
            PdfConverter objConverter = new PdfConverter();

            //bind input pdf file
            objConverter.BindPdf(dataDir+ "ConvertPDFPages.pdf");

            //initialize the converting process
            objConverter.DoConvert();
            objConverter.ShowHiddenAreas = true;

            //check if pages exist and then convert to image one by one
            while (objConverter.HasNextImage())
                objConverter.GetNextImage(dataDir+ DateTime.Now.Ticks.ToString() + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            //close the PdfConverter object
            objConverter.Close();
 
            
        }
    }
}