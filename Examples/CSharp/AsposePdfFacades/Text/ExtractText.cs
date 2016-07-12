//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;
using Aspose.Pdf.Facades;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Text
{
    public class ExtractText
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Text();
            //open input PDF
            PdfExtractor pdfExtractor = new PdfExtractor();
            pdfExtractor.BindPdf(dataDir+ "ExtractText.pdf");

            //use parameterless ExtractText method
            pdfExtractor.ExtractText();

            MemoryStream tempMemoryStream = new MemoryStream();
            pdfExtractor.GetText(tempMemoryStream);

            string text = "";
            //specify Unicode encoding type in StreamReader constructor
            using (StreamReader streamReader = new StreamReader(tempMemoryStream, Encoding.Unicode))
            {
                streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                text = streamReader.ReadToEnd();
            }

            File.WriteAllText(dataDir+ "output.txt", text);
 
            
        }
    }
}