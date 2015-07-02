//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace CSharp.AsposePdf.Bookmarks
{
    public class UpdateChildBookmarks
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Bookmarks();

            //open document
            Document pdfDocument = new Document(dataDir + "UpdateChildBookmarks.pdf");

            //get a bookmark object
            OutlineItemCollection pdfOutline = pdfDocument.Outlines[1];
            
            //get child bookmark object
            OutlineItemCollection childOutline = pdfOutline[1];
            childOutline.Title = "Updated Outline";
            childOutline.Italic = true;
            childOutline.Bold = true;
                        
            //save output
            pdfDocument.Save(dataDir + "UpdateChildBookmarks_out.pdf");

        }
    }
}