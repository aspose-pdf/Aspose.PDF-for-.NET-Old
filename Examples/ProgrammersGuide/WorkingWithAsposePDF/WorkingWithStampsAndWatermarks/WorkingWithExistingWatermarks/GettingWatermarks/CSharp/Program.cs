//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;
using System;

namespace GettingWatermarks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //Open document
            Document pdfDocument = new Document(dataDir+ "input.pdf");
            // Iterate through and get tub-type, text and location of artifact
            foreach (Artifact artifact in pdfDocument.Pages[1].Artifacts)
            {
                Console.WriteLine(artifact.Subtype + " " + artifact.Text + " " + artifact.Rectangle);
            }
            
            
        }
    }
}