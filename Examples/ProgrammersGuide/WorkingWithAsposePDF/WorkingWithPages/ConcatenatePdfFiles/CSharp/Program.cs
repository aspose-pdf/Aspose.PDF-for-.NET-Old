//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace ConcatenatePdfFiles
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //open first document
            Document pdfDocument1 = new Document(dataDir + "input1.pdf");
            //open second document
            Document pdfDocument2 = new Document(dataDir + "input2.pdf");

            //add pages of second document to the first
            pdfDocument1.Pages.Add(pdfDocument2.Pages);

            //save concatenated output file
            pdfDocument1.Save(dataDir + "output.pdf");

            // Display result.
            System.Console.WriteLine("PDFs are concatenated successfully!");
        }
    }
}