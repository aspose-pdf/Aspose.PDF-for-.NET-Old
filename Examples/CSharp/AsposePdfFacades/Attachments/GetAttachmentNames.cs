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

namespace CSharp.AsposePDFFacades.Attachments
{
    public class GetAttachmentNames
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Attachments();
            //open document
            PdfExtractor pdfExtractor = new PdfExtractor();
            pdfExtractor.BindPdf(dataDir+ "GetAttachmentNames.pdf");

            //extract attachments
            pdfExtractor.ExtractAttachment();

            //get attachment names
            System.Collections.IList attachmentNames = (System.Collections.IList)pdfExtractor.GetAttachNames();

            foreach (string attachmentName in attachmentNames)
                Console.WriteLine("Name : {0}", attachmentName);
            
        }
    }
}