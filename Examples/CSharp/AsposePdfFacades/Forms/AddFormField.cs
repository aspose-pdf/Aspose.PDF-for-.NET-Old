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

namespace CSharp.AsposePDFFacades.Forms
{
    public class AddFormField
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Forms();

            //open document
            FormEditor formEditor = new FormEditor();
            //Open Document
            formEditor.BindPdf(dataDir+ "AddFormField.pdf");

            //add field
            formEditor.AddField(FieldType.Text, "textfield", 1, 100, 100, 200, 150);
            formEditor.AddField(FieldType.CheckBox, "checkboxfield", 1, 100, 200, 200, 250);
            formEditor.AddField(FieldType.ComboBox, "comboboxfield", 1, 100, 300, 200, 350);
            formEditor.AddField(FieldType.ListBox, "listboxfield", 1, 100, 400, 200, 450);
            formEditor.AddField(FieldType.MultiLineText, "multilinetextfield", 1, 100, 500, 200, 550);
            


            //save updated file
            formEditor.Save(dataDir+ "AddFormField_out.pdf");
        }
    }
}