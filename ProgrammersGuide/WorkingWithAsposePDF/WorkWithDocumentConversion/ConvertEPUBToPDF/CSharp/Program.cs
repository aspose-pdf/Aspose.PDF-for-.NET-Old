//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace ConvertEPUBToPDF
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            // Instantiate LoadOption object using EPUB load option
            EpubLoadOptions epubload = new EpubLoadOptions();

            // Create Document object
            Aspose.Pdf.Document pdf = new Aspose.Pdf.Document(dataDir + "Sample.epub", epubload);
            
            // Save the resultant PDF document
            pdf.Save(dataDir + "output.pdf");
        }
    }
}