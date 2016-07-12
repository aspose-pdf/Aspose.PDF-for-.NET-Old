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
using Aspose.Pdf.Annotations;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Annotations
{
    public class ExportAnnotations
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Annotations();
            //create PdfAnnotationEditor object
            PdfAnnotationEditor AnnotationEditor = new PdfAnnotationEditor();
            //open PDF document
            AnnotationEditor.BindPdf(dataDir+ "ExportAnnotations.pdf");
            //import annotations
            FileStream fileStream = new System.IO.FileStream(dataDir+ "annotations.xfdf", System.IO.FileMode.Create);
            Enum[] annotType = { AnnotationType.FreeText, AnnotationType.Line };
            AnnotationEditor.ExportAnnotationsXfdf(fileStream, 1, 5, annotType);
            //save output PDF
            AnnotationEditor.Save(dataDir+ "ExportAnnotations_out.pdf");
 
            
        }
    }
}