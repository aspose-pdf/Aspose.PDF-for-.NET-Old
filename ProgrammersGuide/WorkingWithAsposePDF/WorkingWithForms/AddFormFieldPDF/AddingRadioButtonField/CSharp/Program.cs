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

namespace AddingRadioButtonField
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            // Create directory if it is not already present.
            bool IsExists = System.IO.Directory.Exists(dataDir);
            if (!IsExists)
                System.IO.Directory.CreateDirectory(dataDir);

            // instantiate Document object
            Document pdfDocument = new Document();

            // add a page to PDF file
            pdfDocument.Pages.Add();

            // instatiate RadioButtonField object with page number as argument
            RadioButtonField radio = new RadioButtonField(pdfDocument.Pages[1]);

            // add first radio button option and also specify its origin using Rectangle object
            radio.AddOption("Test", new Aspose.Pdf.Rectangle(0, 0, 20, 20));

            // add second radio button option
            radio.AddOption("Test1", new Aspose.Pdf.Rectangle(20, 20, 40, 40));

            // add radio button to form object of Document object
            pdfDocument.Form.Add(radio);

            // save the PDF file
            pdfDocument.Save(dataDir + "output.pdf");

        }
    }
}