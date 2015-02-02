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

namespace DecorateAllFieldsOfParticularTypeExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");
            //create FormEditor object and open PDF file
            FormEditor form = new FormEditor(dataDir+ "input_form.pdf", dataDir+ "output.pdf");
            //create a new facade object
            FormFieldFacade facade = new FormFieldFacade();
            //assign the facade to form editor
            form.Facade = facade;
            //set the backgroud color as red
            facade.BackgroundColor = System.Drawing.Color.Red;
            //set the alignment as center
            facade.Alignment = FormFieldFacade.AlignCenter;
            //all text fields will be modified:
            form.DecorateField(FieldType.Text);
            //close and validate the modification like this:
            form.Save();
            
        }
    }
}