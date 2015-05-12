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

namespace GetPDFFileInformation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //open document
            Document pdfDocument = new Document(dataDir + "input.pdf");
            //get document information
            DocumentInfo docInfo = pdfDocument.Info;
            //show document information
            Console.WriteLine("Author: {0}", docInfo.Author);
            Console.WriteLine("Creation Date: {0}", docInfo.CreationDate);
            Console.WriteLine("Keywords: {0}", docInfo.Keywords);
            Console.WriteLine("Modify Date: {0}", docInfo.ModDate);
            Console.WriteLine("Subject: {0}", docInfo.Subject);
            Console.WriteLine("Title: {0}", docInfo.Title);

        }
    }
}