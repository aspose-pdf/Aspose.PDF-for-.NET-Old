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
using System.Collections;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Annotations
{
    public class ExtractAnnotations
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Annotations();
            //create PdfAnnotationEditor
            PdfAnnotationEditor annotationEditor = new PdfAnnotationEditor();
            //open PDF document
            annotationEditor.BindPdf(dataDir+ "ExtractAnnotations.pdf");
            //extract annotations
            Enum[] annotType = { AnnotationType.FreeText, AnnotationType.Line };
            ArrayList annotList = (ArrayList)annotationEditor.ExtractAnnotations(1, 2, annotType);
            for (int index = 0; index < annotList.Count; index++)
            {
                Annotation annotation = (Annotation)annotList[index];
                Console.WriteLine(annotation.Contents);
            } 
            
        }
    }
}