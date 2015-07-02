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

namespace CSharp.AsposePDFFacades.WorkingDocument
{
    public class SetViewerPreference
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_WorkingDocuments();
            //open document
            PdfContentEditor contentEditor = new PdfContentEditor();
            contentEditor.BindPdf(dataDir+ "SetViewerPreference.pdf");

            //change Viewer Preferences
            contentEditor.ChangeViewerPreference(ViewerPreference.CenterWindow);
            contentEditor.ChangeViewerPreference(ViewerPreference.HideMenubar);
            contentEditor.ChangeViewerPreference(ViewerPreference.PageModeUseNone);

            //save output PDF file
            contentEditor.Save(dataDir+ "SetViewerPreference_out.pdf");
            
            
        }
    }
}