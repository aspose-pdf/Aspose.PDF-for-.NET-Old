//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;
using Aspose.Pdf.Text;

namespace CSharp.AsposePdf.Text
{
    public class ExtractTextAll
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();

            //open document
            Document pdfDocument = new Document(dataDir + "ExtractTextAll.pdf");

            //create TextAbsorber object to extract text
            TextAbsorber textAbsorber = new TextAbsorber();

            //accept the absorber for all the pages
            pdfDocument.Pages.Accept(textAbsorber);

            //get the extracted text
            string extractedText = textAbsorber.Text;

            // create a writer and open the file
            TextWriter tw = new StreamWriter(dataDir + "extracted-text.txt");

            // write a line of text to the file
            tw.WriteLine(extractedText);

            // close the stream
            tw.Close();
            
            
        }
    }
}