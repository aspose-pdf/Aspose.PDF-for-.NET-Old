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

namespace AddingComboBoxField
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            // create Document object
            Document doc = new Document();

            // add page to document object
            doc.Pages.Add();

            // instantiate ComboBox Field object
            ComboBoxField combo = new ComboBoxField(doc.Pages[1], new Aspose.Pdf.Rectangle(100, 600, 150, 616));

            // add option to ComboBox
            combo.AddOption("Red");
            combo.AddOption("Yellow");
            combo.AddOption("Green");
            combo.AddOption("Blue");

            // add combo box object to form fields collection of document object
            doc.Form.Add(combo);

            // save the PDF document
            doc.Save(dataDir + "output.pdf");

        }
    }
}