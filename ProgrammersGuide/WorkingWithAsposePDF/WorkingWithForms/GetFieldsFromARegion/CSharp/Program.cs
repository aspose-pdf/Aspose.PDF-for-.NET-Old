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
using System;

namespace GetFieldsFromARegion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //Open pdf file
            Aspose.Pdf.Document doc = new Aspose.Pdf.Document(dataDir + "input.pdf");

            //Create rectangle object to get fields in that area
            Aspose.Pdf.Rectangle rectangle = new Aspose.Pdf.Rectangle(35, 30, 500, 500);

            //Get the PDF form
            Aspose.Pdf.InteractiveFeatures.Forms.Form form = doc.Form;

            //get fields in the rectangular area
            Aspose.Pdf.InteractiveFeatures.Forms.Field[] fields = form.GetFieldsInRect(rectangle);

            //Display Field names and values
            foreach (Field field in fields)
            {

                //Display image placement properties for all placements
                Console.Out.WriteLine("Field Name: " + field.FullName + "-" + "Field Value: " + field.Value);
            }

        }
    }
}