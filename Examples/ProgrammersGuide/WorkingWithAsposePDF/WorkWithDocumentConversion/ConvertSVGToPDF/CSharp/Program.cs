//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace ConvertSVGToPDF
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            // Instantiate LoadOption object using SVG load option
            Aspose.Pdf.LoadOptions loadopt = new Aspose.Pdf.SvgLoadOptions();

            // Create Document object
            Aspose.Pdf.Document doc = new Aspose.Pdf.Document(dataDir + "example.svg", loadopt);

            // Save the resultant PDF document
            doc.Save(dataDir + "converted.pdf");
        }
    }
}