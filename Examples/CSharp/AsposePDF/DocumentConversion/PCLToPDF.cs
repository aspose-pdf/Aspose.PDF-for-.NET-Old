//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace CSharp.AsposePdf.DocumentConversion
{
    public class PCLToPDF
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();

            // instantiate LoadOption object using PCL load option
            Aspose.Pdf.LoadOptions loadopt = new Aspose.Pdf.PclLoadOptions();
            
            // create Document object
            Aspose.Pdf.Document doc = new Aspose.Pdf.Document(dataDir + "test.pcl", loadopt);
            
            // save the resultant PDF document
            doc.Save(dataDir + "test-converted.pdf");
        }
    }
}