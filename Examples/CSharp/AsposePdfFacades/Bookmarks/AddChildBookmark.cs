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

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Bookmarks
{
    public class AddChildBookmark
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Bookmarks();
            //create bookmarks
            Aspose.Pdf.Facades.Bookmarks bookmarks = new Aspose.Pdf.Facades.Bookmarks();
            Bookmark childBookmark1 = new Bookmark();
            childBookmark1.PageNumber = 1;
            childBookmark1.Title = "First Child";
            Bookmark childBookmark2 = new Bookmark();
            childBookmark2.PageNumber = 2;
            childBookmark2.Title = "Second Child";

            bookmarks.Add(childBookmark1);
            bookmarks.Add(childBookmark2);

            Bookmark bookmark = new Bookmark();
            bookmark.Action = "GoTo";
            bookmark.PageNumber = 1;
            bookmark.Title = "Parent";

            bookmark.ChildItems = bookmarks;

            //create PdfBookmarkEditor class
            PdfBookmarkEditor bookmarkEditor = new PdfBookmarkEditor();
            //bind PDF document
            bookmarkEditor.BindPdf(dataDir+ "AddChildBookmark.pdf");
            //create bookmarks
            bookmarkEditor.CreateBookmarks(bookmark);
            //save updated document
            bookmarkEditor.Save(dataDir+ "AddChildBookmark_out.pdf");
            
        }
    }
}