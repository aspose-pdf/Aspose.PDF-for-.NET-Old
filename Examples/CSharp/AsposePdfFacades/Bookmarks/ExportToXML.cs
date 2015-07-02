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
    public class ExportToXML
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Bookmarks();
            //Create PdfBookmarkEditor object
            PdfBookmarkEditor bookmarkEditor = new PdfBookmarkEditor();
            //Open PDF file
            bookmarkEditor.BindPdf(dataDir+ "ExportToXML.pdf");
            //Export bookmarks
            bookmarkEditor.ExportBookmarksToXML(dataDir+ "bookmarks.xml");
            //Save updated PDF
            bookmarkEditor.Save(dataDir+ "ExportToXML_out.pdf");
            
            
        }
    }
}