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

namespace CSharp.AsposePdf.Bookmarks
{
    public class GetBookmarks
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Bookmarks();

            //open document
            Document pdfDocument = new Document(dataDir + "GetBookmarks.pdf");

            //loop through all the bookmarks
            foreach (OutlineItemCollection outlineItem in pdfDocument.Outlines)
            {
                Console.WriteLine(outlineItem.Title);
                Console.WriteLine(outlineItem.Italic);
                Console.WriteLine(outlineItem.Bold);
                Console.WriteLine(outlineItem.Color);
            }

        }
    }
}