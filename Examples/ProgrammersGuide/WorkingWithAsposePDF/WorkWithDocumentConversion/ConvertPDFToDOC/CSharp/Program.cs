//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace ConvertPDFToDOC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //open the source PDF document
            Document pdfDocument = new Document(dataDir + "input.pdf");

            // 1.
            // saving using direct method
            // save the file into MS document format
            pdfDocument.Save(dataDir + "simpleOutput.doc", SaveFormat.Doc);

            // 2.
            // save using save options
            // create DocSaveOptions object
            DocSaveOptions saveOptions = new DocSaveOptions();

            // set the recognition mode as Flow
            saveOptions.Mode = DocSaveOptions.RecognitionMode.Flow;
            
            // set the Horizontal proximity as 2.5
            saveOptions.RelativeHorizontalProximity = 2.5f;
            
            // enable the value to recognize bullets during conversion process
            saveOptions.RecognizeBullets = true;
            
            // save the resultant DOC file
            pdfDocument.Save(dataDir + "saveOptionsOutput.doc", saveOptions);
        }
    }
}