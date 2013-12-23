//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;
using Aspose.Pdf.InteractiveFeatures.Forms;
using Aspose.Pdf.InteractiveFeatures.Annotations;

namespace AddingTextBoxField
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //Open document
            Document pdfDocument = new Document(dataDir + "input.pdf");

            //Create a field
            TextBoxField textBoxField = new TextBoxField(pdfDocument.Pages[1], new Aspose.Pdf.Rectangle(100, 200, 300, 300));
            textBoxField.PartialName = "textbox1";
            textBoxField.Value = "Text Box";
            
            //textBoxField.Border = new Border(
            Border border = new Border(textBoxField);
            border.Width = 5;
            border.Dash = new Dash(1, 1);
            textBoxField.Border = border;

            textBoxField.Color = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Green);

            //Add field to the document
            pdfDocument.Form.Add(textBoxField, 1);

            //Save modified PDF
            pdfDocument.Save(dataDir + "output.pdf");

        }
    }
}