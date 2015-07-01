//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace CSharp.AsposePdf.Forms
{
    public class FillXFAFields
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Forms();

            // load XFA form
            Document doc = new Document(dataDir + "FillXFAFields.pdf");

            // get names of XFA form fields
            string[] names = doc.Form.XFA.FieldNames;

            //set field values
            doc.Form.XFA[names[0]] = "Field 0";
            doc.Form.XFA[names[1]] = "Field 1";

            // save the updated document
            doc.Save(dataDir + "Filled_XFA.pdf");

        }
    }
}