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

namespace ReplaceTextOnParticularPageExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");
            //open input PDF
            PdfContentEditor pdfContentEditor = new PdfContentEditor();
            pdfContentEditor.BindPdf(dataDir+ "input.pdf");
            //replace text on all pages
            pdfContentEditor.ReplaceText("Hello", 1, "World");
            //save output PDF
            pdfContentEditor.Save(dataDir+ "ReplaceText.pdf");
            
            
        }
    }
}