//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace CSharp.AsposePdf.Bookmarks
{
    public class DeleteParticularBookmark
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Bookmarks();

            //open document
            Document pdfDocument = new Document(dataDir + "DeleteParticularBookmark.pdf");

            //delete particular outline by Title
            pdfDocument.Outlines.Delete("Child Outline");
            
            //save updated file
            pdfDocument.Save(dataDir + "DeleteParticularBookmark_out.pdf");

        }
    }
}