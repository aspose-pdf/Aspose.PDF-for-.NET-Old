//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace CSharp.AsposePdf.StampsWatermarks
{
    public class AddImageStamp
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_StampsWatermarks();

            //Open document
            Document pdfDocument = new Document(dataDir+ "AddImageStamp.pdf");

            //Create image stamp
            ImageStamp imageStamp = new ImageStamp(dataDir + "aspose-logo.jpg");
            imageStamp.Background = true;
            imageStamp.XIndent = 100;
            imageStamp.YIndent = 100;
            imageStamp.Height = 300;
            imageStamp.Width = 300;
            imageStamp.Rotate = Rotation.on270;
            imageStamp.Opacity = 0.5;
            //Add stamp to particular page
            pdfDocument.Pages[1].AddStamp(imageStamp);

            //Save output document
            pdfDocument.Save(dataDir + "AddImageStamp_out.pdf");
            
            
        }
    }
}