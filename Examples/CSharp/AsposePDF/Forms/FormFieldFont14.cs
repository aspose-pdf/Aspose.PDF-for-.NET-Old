//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;
using Aspose.Pdf.Text;

namespace CSharp.AsposePdf.Forms
{
    public class FormFieldFont14
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Forms();

            // Open document
            Document pdfDocument = new Document(dataDir + "FormFieldFont14.pdf");

            // Get particular form field from document
            Aspose.Pdf.InteractiveFeatures.Forms.Field field = pdfDocument.Form["textbox1"] as Aspose.Pdf.InteractiveFeatures.Forms.Field;

            // Create font object
            Aspose.Pdf.Text.Font font = FontRepository.FindFont("ComicSansMS");

            // Set the font information for form field
            field.DefaultAppearance = new Aspose.Pdf.InteractiveFeatures.DefaultAppearance(font, 10, System.Drawing.Color.Black);

            // Save updated document
            pdfDocument.Save(dataDir + "FormFieldFont14_out.pdf");
        }
    }
}