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
    public class SetXMPMetadata
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            //open document
            Document pdfDocument = new Document(dataDir + "SetXMPMetadata.pdf");

            //set properties
            pdfDocument.Metadata["xmp:CreateDate"] = DateTime.Now;
            pdfDocument.Metadata["xmp:Nickname"] = "Nickname";
            pdfDocument.Metadata["xmp:CustomProperty"] = "Custom Value";

            //save document
            pdfDocument.Save(dataDir + "SetXMPMetadata_out.pdf");

        }
    }
}