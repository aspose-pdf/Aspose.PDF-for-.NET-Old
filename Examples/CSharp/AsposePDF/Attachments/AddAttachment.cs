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
    public class AddAttachment
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Attachments();

            //open document
            Document pdfDocument = new Document(dataDir + "AddAttachment.pdf");

            //setup new file to be added as attachment
            FileSpecification fileSpecification = new FileSpecification(dataDir + "test.txt", "Sample text file");

            //add attachment to document's attachment collection
            pdfDocument.EmbeddedFiles.Add(fileSpecification);

            //save new output
            pdfDocument.Save(dataDir + "AddAttachment_out.pdf");

        }
    }
}