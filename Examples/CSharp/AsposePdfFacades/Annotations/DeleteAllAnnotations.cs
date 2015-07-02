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

namespace CSharp.AsposePDFFacades.Annotations
{
    public class DeleteAllAnnotations
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Annotations();
            //open document
            PdfAnnotationEditor annotationEditor = new PdfAnnotationEditor();
            annotationEditor.BindPdf(dataDir+ "DeleteAllAnnotations.pdf");
            //delete all annoations
            annotationEditor.DeleteAnnotations("Text");
            //save updated PDF
            annotationEditor.Save(dataDir+ "DeleteAllAnnotations_out.pdf");
            
        }
    }
}