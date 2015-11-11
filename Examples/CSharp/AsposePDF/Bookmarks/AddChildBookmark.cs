//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;
using Aspose.Pdf.InteractiveFeatures;

namespace CSharp.AsposePdf.Bookmarks
{
    public class AddChildBookmark
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Bookmarks();

            //open document
            Document pdfDocument = new Document(dataDir + "AddChildBookmark.pdf");
            
            //create a parent bookmark object
            OutlineItemCollection pdfOutline = new OutlineItemCollection(pdfDocument.Outlines);
            pdfOutline.Title = "Parent Outline";
            pdfOutline.Italic = true;
            pdfOutline.Bold = true;
            
            //set the destination page number
            pdfOutline.Destination = new GoToAction(pdfDocument.Pages[2]);

            //create a child bookmark object
            OutlineItemCollection pdfChildOutline = new OutlineItemCollection(pdfDocument.Outlines);
            pdfChildOutline.Title = "Child Outline";
            pdfChildOutline.Italic = true;
            pdfChildOutline.Bold = true;
            
            //set the destination page number for child outline
            pdfChildOutline.Destination = new GoToAction(pdfDocument.Pages[1]);
            
            //add child bookmark in parent bookmark's collection
            pdfOutline.Add(pdfChildOutline);
            
            //add parent bookmark in the document's outline collection.
            pdfDocument.Outlines.Add(pdfOutline);
            
            //save output
            pdfDocument.Save(dataDir + "AddChildBookmark_out.pdf");	

        }
    }
}