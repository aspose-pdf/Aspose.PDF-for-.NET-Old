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

namespace CSharp.AsposePdf.LinksActions
{
    public class SpecifyPageWhenViewing
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_LinksActions();

            // load the PDF file
            Document doc = new Document(dataDir+ "SpecifyPageWhenViewing.pdf");
            // get the instance of second page of document
            Page page2 = doc.Pages[2];
            // create the variable to set the zoom factor of target page
            double zoom = 1;
            // create GoToAction instance
            Aspose.Pdf.InteractiveFeatures.GoToAction action = new Aspose.Pdf.InteractiveFeatures.GoToAction();
            // Go to 2 page
            action.Destination = new XYZExplicitDestination(page2, 0, page2.Rect.Height, zoom);
            // set the document open action
            doc.OpenAction = action;
            // save updated document
            doc.Save(dataDir + "goto2page.pdf");
 
            
            
        }
    }
}