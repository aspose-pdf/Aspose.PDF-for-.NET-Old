//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;
using System.Text;
using System.Xml;

namespace CSharp.AsposePdfGenerator.Text
{
    public class InlineHTMLFromXML
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Text();

            //Create pdf document
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            //Bind XML into the document
            pdf1.BindXML(dataDir + "TEST.xml", null);

            //Save the document
            pdf1.Save(dataDir + "test.pdf");
        }
    }
}

