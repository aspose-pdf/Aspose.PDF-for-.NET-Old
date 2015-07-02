//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace CSharp.AsposePdf.DocumentConversion
{
    public class PDFToHTML
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();

            //open the source PDF document
            Document pdfDocument = new Document(dataDir + "PDFToHTML.pdf");

            // save the file into MS document format
            pdfDocument.Save(dataDir + "output.html", SaveFormat.Html);
        }
    }
}