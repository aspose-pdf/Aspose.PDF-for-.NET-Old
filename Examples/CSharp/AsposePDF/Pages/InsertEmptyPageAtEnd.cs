//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace CSharp.AsposePdf.Pages
{
    public class InsertEmptyPageAtEnd
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Pages();

            //open document
            Document pdfDocument1 = new Document(dataDir + "InsertEmptyPageAtEnd.pdf");

            //insert an empty page at the end of a PDF file
            pdfDocument1.Pages.Add();

            //save output file
            pdfDocument1.Save(dataDir + "InsertEmptyPageAtEnd_out.pdf");

        }
    }
}