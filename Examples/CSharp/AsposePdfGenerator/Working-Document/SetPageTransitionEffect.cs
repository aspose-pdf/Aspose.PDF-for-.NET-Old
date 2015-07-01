//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace CSharp.AsposePdfGenerator.WorkingDocuments
{
    public class SetPageTransitionEffect
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_WorkingDocuments();

            // Create directory if it is not already present.
            bool IsExists = System.IO.Directory.Exists(dataDir);
            if (!IsExists)
                System.IO.Directory.CreateDirectory(dataDir);

            //Instantiate Pdf instance
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            //You may set OpenType poperty to full screen
            pdf1.OpenType = Aspose.Pdf.Generator.OpenType.FullScreen;

            //Set PageTransitionType poperty of Pdf instance to a pre-defined desired value
            pdf1.PageTransitionType = Aspose.Pdf.Generator.PageTransitionType.Dissolve; 
            pdf1.Save(dataDir + "PageTransition.pdf");
            
        }
    }
}