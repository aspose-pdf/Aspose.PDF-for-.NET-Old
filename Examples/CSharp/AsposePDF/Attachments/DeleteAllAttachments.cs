//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace CSharp.AsposePdf.Attachments
{
    public class DeleteAllAttachments
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Attachments();

            //open document
            Document pdfDocument = new Document(dataDir + "DeleteAllAttachments.pdf");

            //delete all attachments
            pdfDocument.EmbeddedFiles.Delete();

            //save updated file
            pdfDocument.Save(dataDir + "DeleteAllAttachments_out.pdf");

        }
    }
}