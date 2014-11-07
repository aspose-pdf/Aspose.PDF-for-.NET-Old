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
using System;
using Aspose.Pdf.InteractiveFeatures.Annotations;

namespace ImportAnnotationsExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");
            //create PdfAnnotationEditor object
            PdfAnnotationEditor AnnotationEditor = new PdfAnnotationEditor();
            //open PDF document
            AnnotationEditor.BindPdf(dataDir+ "input.pdf");
            //import annotations
            FileStream fileStream = new System.IO.FileStream(dataDir+ "annotations.xfdf", System.IO.FileMode.Open, System.IO.FileAccess.Read);
            Enum[] annotType = { AnnotationType.FreeText, AnnotationType.Line };
            AnnotationEditor.ImportAnnotationFromXfdf(fileStream, annotType);
            //save output PDF
            AnnotationEditor.Save(dataDir + "output.pdf");
 
            
        }
    }
}