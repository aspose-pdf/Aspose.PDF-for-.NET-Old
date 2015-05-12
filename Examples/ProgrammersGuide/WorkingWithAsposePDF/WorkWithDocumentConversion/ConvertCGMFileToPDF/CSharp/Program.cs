//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace ConvertCGMFileToPDFExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            // Instantiate LoadOption object using CGMLoadOption
            Aspose.Pdf.CgmLoadOptions cgmload = new Aspose.Pdf.CgmLoadOptions();
            // instantiate Document object
            Document doc = new Document(dataDir+ "TECHDRAW.CGM", cgmload);
            // Save the resultant PDF document
            doc.Save(dataDir+ "TECHDRAW.pdf");
        }
    }
}