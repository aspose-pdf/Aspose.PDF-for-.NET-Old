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

namespace CSharp.AsposePDFFacades.Attachments
{
    public class ExtractAllAttachments
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Attachments();
            //open document
            PdfExtractor pdfExtractor = new PdfExtractor();
            pdfExtractor.BindPdf(dataDir+ "ExtractAllAttachments.pdf");

            //extract attachments
            pdfExtractor.ExtractAttachment();

            //get extracted attachments
            pdfExtractor.GetAttachment(dataDir+ ".\\output");
            
            
        }
    }
}