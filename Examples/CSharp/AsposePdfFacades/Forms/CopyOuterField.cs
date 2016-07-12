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

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Forms
{
    public class CopyOuterField
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Forms();

            //open document
            FormEditor formEditor = new FormEditor();
           
            //open the document and create a FormEditor object
            formEditor.BindPdf(dataDir + "input_form.pdf");
           
            //copy a text field from one document to another one
            formEditor.CopyOuterField("textfieldform.pdf", "textfield", 1);
           
            //close and save the output document
            formEditor.Save(dataDir + "CopyOuterField_out.pdf");
            
            
        }
    }
}