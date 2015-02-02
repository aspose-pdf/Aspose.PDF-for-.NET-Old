//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace DisableFilesCompressionExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            Document pdfDocument = new Document(dataDir+ "Input.pdf");
            //Setup new file to be added as attachment
            FileSpecification fileSpecification = new FileSpecification("test.txt", "Sample text file");
            //Specify Encoding proparty setting it to FileEncoding.None
            fileSpecification.Encoding = FileEncoding.None;
            //Add attachment to document's attachment collection
            pdfDocument.EmbeddedFiles.Add(fileSpecification);
            //Save new output
            pdfDocument.Save(dataDir+ "output.pdf");
 


            
            
        }
    }
}