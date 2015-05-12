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
using Aspose.Pdf.InteractiveFeatures;

namespace SetJavaScript
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            // load input PDF file
            Document doc = new Document(dataDir + "input.pdf");

            TextBoxField field = (TextBoxField)doc.Form["textbox1"];
          
            //2 digits after point
            //no separator
            //neg style = minus
            //no currency
            field.Actions.OnModifyCharacter = new JavascriptAction("AFNumber_Keystroke(2, 1, 1, 0, \"\", true)");
            field.Actions.OnFormat = new JavascriptAction("AFNumber_Format(2, 1, 1, 0, \"\", true)");

            // set initial field value
            field.Value = "123";

            // save resultant PDF
            doc.Save(dataDir + "Restricted_out.pdf");

        }
    }
}