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

namespace AddListItemExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");
            //create instance of FormEditor
            FormEditor formEditor = new FormEditor();
            //Open Document
            formEditor.BindPdf(dataDir+ "input.pdf");
            //add list field in PDF file
            formEditor.AddField(FieldType.ListBox, "listbox", 1, 300, 200, 350, 225);
            //add list items
            formEditor.AddListItem("listbox", "Item 1");
            formEditor.AddListItem("listbox", "Item 2");
            //add multiple list items once
            string[] listItems = { "Item 3", "Item 4", "Item 5" };
            formEditor.AddListItem("listbox", listItems);
            //save updated file
            formEditor.Save(dataDir+ "output.pdf");
            
        }
    }
}