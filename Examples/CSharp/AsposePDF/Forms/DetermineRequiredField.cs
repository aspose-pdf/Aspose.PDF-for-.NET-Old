//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;
using System;

namespace CSharp.AsposePdf.Forms
{
    public class DetermineRequiredField
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Forms();

            // Load source PDF file
            Document pdf = new Document(dataDir + "DetermineRequiredField.pdf");

            // Instantiate Form object
            Aspose.Pdf.Facades.Form pdfForm = new Aspose.Pdf.Facades.Form(pdf);

            // Iterate through each field inside PDF form
            foreach (Aspose.Pdf.InteractiveFeatures.Forms.Field field in pdf.Form.Fields)
            {
                // Determine if the field is marked as required or not
                bool isRequired = pdfForm.IsRequiredField(field.FullName);
                if (isRequired)

                {
                    // Print either the field is marked as required or not
                    Console.WriteLine("The field named " + field.FullName + " is required");
                }
            }

        }
    }
}