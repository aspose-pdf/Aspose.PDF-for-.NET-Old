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
using System.Drawing;

namespace CSharp.AsposePDFFacades.Annotations
{
    public class AddFreeTextAnnotation
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Annotations();
            //open document
            PdfContentEditor contentEditor = new PdfContentEditor();
            contentEditor.BindPdf(dataDir+ "AddFreeTextAnnotation.pdf");
            //crate rectangle
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(50, 50, 100, 100);
            //create annotation
            contentEditor.CreateFreeText(rect, "Sample content", 1);
            //save updated PDF file
            contentEditor.Save(dataDir+ "AddFreeTextAnnotation_out.pdf");
            
            
        }
    }
}