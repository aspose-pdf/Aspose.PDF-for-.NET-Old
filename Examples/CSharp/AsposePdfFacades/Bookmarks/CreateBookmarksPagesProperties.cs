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

namespace CSharp.AsposePDFFacades.Bookmarks
{
    public class CreateBookmarksPagesProperties
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Bookmarks();
            //open document
            PdfBookmarkEditor bookmarkEditor = new PdfBookmarkEditor();
            bookmarkEditor.BindPdf(dataDir+ "CreateBookmarks-PagesProperties.pdf");
            //create bookmark of all pages
            bookmarkEditor.CreateBookmarks(System.Drawing.Color.Green, true, true);
            //save updated PDF file
            bookmarkEditor.Save(dataDir+ "CreateBookmarks-PagesProperties_out.pdf");
            
            
        }
    }
}