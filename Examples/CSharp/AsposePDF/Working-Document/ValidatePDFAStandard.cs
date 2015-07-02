//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace CSharp.AsposePdf.WorkingDocuments
{
    public class ValidatePDFAStandard
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            //open document
            Document pdfDocument = new Document(dataDir + "ValidatePDFAStandard.pdf");

            //validate PDF for PDF/A-1a
            pdfDocument.Validate(dataDir + "validation-result-A1A.xml", PdfFormat.PDF_A_1A);

        }
    }
}