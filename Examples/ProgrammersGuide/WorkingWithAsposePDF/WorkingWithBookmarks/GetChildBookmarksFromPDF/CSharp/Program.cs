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

namespace GetChildBookmarksFromPDF
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //open document
            Document pdfDocument = new Document(dataDir + "input.pdf");

            //loop through all the bookmarks
            foreach (OutlineItemCollection outlineItem in pdfDocument.Outlines)
            {
                Console.WriteLine(outlineItem.Title);
                Console.WriteLine(outlineItem.Italic);
                Console.WriteLine(outlineItem.Bold);
                Console.WriteLine(outlineItem.Color);

                if (outlineItem.Count > 0)
                {
                    Console.WriteLine("Child Bookmarks");
                    //there are child bookmarks then loop through that as well
                    foreach (OutlineItemCollection childOutline in outlineItem)
                    {
                        Console.WriteLine(childOutline.Title);
                        Console.WriteLine(childOutline.Italic);
                        Console.WriteLine(childOutline.Bold);
                        Console.WriteLine(childOutline.Color);
                    }
                }
            }

        }
    }
}