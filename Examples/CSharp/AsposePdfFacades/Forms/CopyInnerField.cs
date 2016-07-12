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
    public class CopyInnerField
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Forms();
            //create FormEditor object
            FormEditor formEditor = new FormEditor();
            //Open Document
            formEditor.BindPdf(dataDir+ "CopyInnerField.pdf");
            //copy a field to another page
            formEditor.CopyInnerField("textfield", "newfieldname", 0);

            //close and save the output document
            formEditor.Save(dataDir+ "CopyInnerField_out.pdf");
            
            
        }
    }
}