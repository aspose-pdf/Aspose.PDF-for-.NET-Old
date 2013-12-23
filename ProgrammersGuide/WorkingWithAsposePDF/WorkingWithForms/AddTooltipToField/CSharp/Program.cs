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

namespace AddTooltipToField
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            // Load source PDF form
            Document doc = new Document(dataDir + "input.pdf");

            // Set the tooltip for textfield
            (doc.Form["textbox1"] as Field).AlternateName = "Text box tool tip";

            // Save the updated document
            doc.Save(dataDir + "output.pdf");

            
        }
    }
}