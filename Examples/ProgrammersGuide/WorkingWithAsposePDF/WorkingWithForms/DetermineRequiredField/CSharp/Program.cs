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

namespace DetermineRequiredField
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            // Load source PDF file
            Document pdf = new Document(dataDir + "input.pdf");

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