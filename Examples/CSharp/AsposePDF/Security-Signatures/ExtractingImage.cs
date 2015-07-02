//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;
using Aspose.Pdf.InteractiveFeatures.Forms;
using System.Drawing;

namespace CSharp.AsposePdf.SecuritySignatures
{
    public class ExtractingImage
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_SecuritySignatures();

            string input = dataDir+ @"ExtractingImage.pdf";
            using (Document pdfDocument = new Document(input))
            {
                foreach (Field field in pdfDocument.Form)
                {
                    SignatureField sf = field as SignatureField;
                    if (sf != null)
                    {
                        string outFile = dataDir+ @"output.jpg";
                        using (Stream imageStream = sf.ExtractImage())
                        {
                            if (imageStream != null)
                            {
                                using (System.Drawing.Image image = Bitmap.FromStream(imageStream))
                                {
                                    image.Save(outFile, System.Drawing.Imaging.ImageFormat.Jpeg);
                                }
                            }
                        }
                    }
                }
            }
            
            
        }
    }
}