//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;
using System;

namespace CSharp.AsposePdf.WorkingDocuments
{
    public class GetXMPMetadata
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            //open document
            Document pdfDocument = new Document(dataDir + "GetXMPMetadata.pdf");

            //get properties
            Console.WriteLine(pdfDocument.Metadata["xmp:CreateDate"]);
            Console.WriteLine(pdfDocument.Metadata["xmp:Nickname"]);
            Console.WriteLine(pdfDocument.Metadata["xmp:CustomProperty"]);

        }
    }
}