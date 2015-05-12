//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;
using Aspose.Pdf.InteractiveFeatures.Annotations;
using System;

namespace GetAllAnnotationsFromPageOfPDFDocument
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //open document
            Document pdfDocument = new Document(dataDir + "input.pdf");

            //loop through all the annotations
            foreach (MarkupAnnotation annotation in pdfDocument.Pages[1].Annotations)
            {

                //get annotation properties
                Console.WriteLine("Title : {0} ", annotation.Title);
                Console.WriteLine("Subject : {0} ", annotation.Subject);
                Console.WriteLine("Contents : {0} ", annotation.Contents);
                
            }

        }
    }
}