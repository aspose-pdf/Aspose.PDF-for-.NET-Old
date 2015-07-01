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

namespace CSharp.AsposePDFFacades.Annotations
{
    public class ImportAnnotations
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Annotations();
            //create PdfAnnotationEditor object
            PdfAnnotationEditor AnnotationEditor = new PdfAnnotationEditor();
            //open PDF document
            AnnotationEditor.BindPdf(dataDir+ "ImportAnnotations.pdf");
            //import annotations
            FileStream fileStream = new System.IO.FileStream(dataDir+ "annotations.xfdf", System.IO.FileMode.Open, System.IO.FileAccess.Read);
            Enum[] annotType = { AnnotationType.FreeText, AnnotationType.Line };
            AnnotationEditor.ImportAnnotationFromXfdf(fileStream, annotType);
            //save output PDF
            AnnotationEditor.Save(dataDir + "ImportAnnotations_out.pdf");
 
            
        }
    }
}