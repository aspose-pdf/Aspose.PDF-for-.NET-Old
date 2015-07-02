//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace CSharp.AsposePdf.Pages
{
    public class ImageAsBackground
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Pages();

            // create a new Document object
            Document doc = new Document();

            // add a new page to document object
            Page page = doc.Pages.Add();

            // create BackgroundArtifact object
            BackgroundArtifact background = new BackgroundArtifact();

            // specify the image for backgroundartifact object
            background.BackgroundImage = File.OpenRead(dataDir + "aspose-total-for-net.jpg");

            // add backgroundartifact to artifacts collection of page
            page.Artifacts.Add(background);

            // save the document
            doc.Save(dataDir + "ImageAsBackground_out.pdf");

        }
    }
}