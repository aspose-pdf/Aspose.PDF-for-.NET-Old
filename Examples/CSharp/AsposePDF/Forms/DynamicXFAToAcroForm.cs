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

namespace CSharp.AsposePdf.Forms
{
    public class DynamicXFAToAcroForm
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Forms();

            // load dynamic XFA form
            Document document = new Document(dataDir + "Dynamic_XFA.pdf");

            // set the form fields type as standard AcroForm
            document.Form.Type = FormType.Standard;

            // save the resultant PDF
            document.Save(dataDir + "Standard_AcroForm.pdf");

        }
    }
}