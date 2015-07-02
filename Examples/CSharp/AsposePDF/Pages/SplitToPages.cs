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
    public class SplitToPages
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Pages();
            
            //open document
            Document pdfDocument = new Document(dataDir + "SplitToPages.pdf");

            int pageCount = 1;

            //loop through all the pages
            foreach (Page pdfPage in pdfDocument.Pages)
            {
                Document newDocument = new Document();
                newDocument.Pages.Add(pdfPage);
                newDocument.Save(dataDir + "page_" + pageCount + ".pdf");
                pageCount++;
            }

            
        }
    }
}