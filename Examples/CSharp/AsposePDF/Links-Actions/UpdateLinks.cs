//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;
using Aspose.Pdf.InteractiveFeatures.Annotations;
using Aspose.Pdf.InteractiveFeatures;

namespace CSharp.AsposePdf.LinksActions
{
    public class UpdateLinks
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_LinksActions();

            // Load the PDF file
            Document doc = new Document(dataDir+ "UpdateLinks.pdf");
            // Get the first link annotation from first page of document
            LinkAnnotation linkAnnot = (LinkAnnotation)doc.Pages[1].Annotations[1];
            // Modification link: change link destination
            GoToAction goToAction = (GoToAction)linkAnnot.Action;
            // Specify the destination for link object
            // The first parameter is document object, second is destination page number.
            // The 5ht argument is zoom factor when displaying the respective page. When using 2, the page will be displayed in 200% zoom
            goToAction.Destination = new Aspose.Pdf.InteractiveFeatures.XYZExplicitDestination(doc, 1, 1, 2, 2);
            // Save the document with updated link
            doc.Save(dataDir + "PDFLINK_Modified_UpdateLinks_out.pdf");

            
            
        }
    }
}