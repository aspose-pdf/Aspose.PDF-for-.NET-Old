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
    public class DeleteParticularPage
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Pages();

            //open document
            Document pdfDocument = new Document(dataDir + "DeleteParticularPage.pdf");

            //delete a particular page
            pdfDocument.Pages.Delete(2);

            //save updated PDF
            pdfDocument.Save(dataDir + "DeleteParticularPage_out.pdf");

        }
    }
}