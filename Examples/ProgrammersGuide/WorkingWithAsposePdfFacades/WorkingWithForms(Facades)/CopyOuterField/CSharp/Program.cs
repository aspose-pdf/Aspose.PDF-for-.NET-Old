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

namespace CopyOuterFieldExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");
            //open the document and create a FormEditor object
            FormEditor formEditor = new FormEditor(dataDir+ "input_form.pdf", dataDir+ "output.pdf");
            //copy a text field from one document to another one
            formEditor.CopyOuterField("textfieldform.pdf", "textfield", 1);
            //close and save the output document
            formEditor.Save();
            
            
        }
    }
}