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

namespace SetXMPMetadata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //open document
            Document pdfDocument = new Document(dataDir + "input.pdf");

            //set properties
            pdfDocument.Metadata["xmp:CreateDate"] = DateTime.Now;
            pdfDocument.Metadata["xmp:Nickname"] = "Nickname";
            pdfDocument.Metadata["xmp:CustomProperty"] = "Custom Value";

            //save document
            pdfDocument.Save(dataDir + "output.pdf");

        }
    }
}