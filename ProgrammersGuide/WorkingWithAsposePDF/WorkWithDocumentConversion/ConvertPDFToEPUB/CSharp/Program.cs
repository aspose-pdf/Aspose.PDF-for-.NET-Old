//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace ConvertPDFToEPUB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            // load PDF document
            Document pdfDocument = new Document(dataDir + "input.pdf");

            // instantiate Epub Save options
            EpubSaveOptions options = new EpubSaveOptions();
            
            // specify the layout for contents
            options.ContentRecognitionMode = EpubSaveOptions.RecognitionMode.Flow;
            
            // save the ePUB document
            pdfDocument.Save(dataDir + "Sample.epub", options);
        }
    }
}