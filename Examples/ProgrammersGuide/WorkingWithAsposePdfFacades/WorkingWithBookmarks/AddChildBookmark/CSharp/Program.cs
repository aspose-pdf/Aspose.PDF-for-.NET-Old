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

namespace AddChildBookmarkExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");
            //create bookmarks
            Bookmarks bookmarks = new Bookmarks();
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
            bookmarkEditor.BindPdf(dataDir+ "input.pdf");
            //create bookmarks
            bookmarkEditor.CreateBookmarks(bookmark);
            //save updated document
            bookmarkEditor.Save(dataDir+ "output.pdf");
            
        }
    }
}