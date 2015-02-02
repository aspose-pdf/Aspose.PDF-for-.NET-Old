//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace AddAttachmentFromStreamExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");
            //open document
            PdfContentEditor contentEditor = new PdfContentEditor();
            contentEditor.BindPdf(dataDir+ "input.pdf");

            //read file into stream (FileStream or MemoryStream)
            FileStream fileStream = new FileStream(dataDir+ "test.txt", FileMode.Open);
            //add attachment
            contentEditor.AddDocumentAttachment(fileStream, "Attachment Name", "Attachment Description");

            //save updated PDF
            contentEditor.Save(dataDir+ "output.pdf");
            
            
        }
    }
}