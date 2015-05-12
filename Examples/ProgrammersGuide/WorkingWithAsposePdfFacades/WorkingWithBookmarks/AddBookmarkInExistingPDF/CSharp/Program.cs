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

namespace AddBookmarkInExistingPDFExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");
            //create bookmark
            Bookmark boomark = new Bookmark();
            boomark.PageNumber = 1;
            boomark.Title = "New Bookmark";
            //create PdfBookmarkEditor class
            PdfBookmarkEditor bookmarkEditor = new PdfBookmarkEditor();
            //bind PDF document
            bookmarkEditor.BindPdf(dataDir+ "input.pdf");
            //create bookmarks
            bookmarkEditor.CreateBookmarks(boomark);
            //save updated document
            bookmarkEditor.Save(dataDir+ "output.pdf");
 
            
            
        }
    }
}