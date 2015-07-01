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

namespace CSharp.AsposePdf.WorkingDocuments
{
    public class SetZoomFactor
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            // instantiate new Document object
            Document doc = new Document(dataDir + "SetZoomFactor.pdf");

            //Set Left Right and Z factors
            double[] parameters = {0,0,10};

            //Set Explicit Destination
            ExplicitDestination ED = ExplicitDestination.CreateDestination(1,ExplicitDestinationType.XYZ,parameters);

            //Set Action 
            GoToAction action = new GoToAction(ED);
            
            //Set Open action of document
            doc.OpenAction = action;

            //Save the document
            doc.Save(dataDir + "Zoomed_pdf.pdf");
        }
    }
}