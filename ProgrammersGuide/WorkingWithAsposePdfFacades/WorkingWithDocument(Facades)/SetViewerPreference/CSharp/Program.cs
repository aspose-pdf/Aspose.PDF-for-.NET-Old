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

namespace SetViewerPreferenceExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");
            //open document
            PdfContentEditor contentEditor = new PdfContentEditor();
            contentEditor.BindPdf(dataDir+ "input.pdf");

            //change Viewer Preferences
            contentEditor.ChangeViewerPreference(ViewerPreference.CenterWindow);
            contentEditor.ChangeViewerPreference(ViewerPreference.HideMenubar);
            contentEditor.ChangeViewerPreference(ViewerPreference.PageModeUseNone);

            //save output PDF file
            contentEditor.Save(dataDir+ "output.pdf");
            
            
        }
    }
}