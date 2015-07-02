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
    public class InsertEmptyPage
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Pages();

            //open document
            Document pdfDocument1 = new Document(dataDir + "InsertEmptyPage.pdf");

            //insert a empty page in a PDF
            pdfDocument1.Pages.Insert(2);

            //save output file
            pdfDocument1.Save(dataDir + "InsertEmptyPage_out.pdf");

        }
    }
}