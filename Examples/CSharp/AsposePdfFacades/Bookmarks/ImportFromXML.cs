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
    public class ImportFromXML
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Bookmarks();
            //create PdfBookmarkEditor class
            PdfBookmarkEditor bookmarkEditor = new PdfBookmarkEditor();
            //open PDF file
            bookmarkEditor.BindPdf(dataDir+ "ImportFromXML.pdf");
            //import bookmarks
            bookmarkEditor.ImportBookmarksWithXML(dataDir+ "bookmarks.xml");
            //save updated PDF file
            bookmarkEditor.Save(dataDir+ "ImportFromXML_out.pdf");
 
            
            
        }
    }
}