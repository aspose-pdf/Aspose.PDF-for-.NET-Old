//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace CSharp.AsposePdf.Annotations
{
    public class DeleteAllAnnotationsFromPage
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Annotations();

            //open document
            Document pdfDocument = new Document(dataDir + "DeleteAllAnnotationsFromPage.pdf");

            //delete particular annotation
            pdfDocument.Pages[1].Annotations.Delete();

            //save updated document
            pdfDocument.Save(dataDir + "DeleteAllAnnotationsFromPage_out.pdf");

        }
    }
}