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

namespace SetFormattingOfFreeTextAnnotation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //open document
            Document pdfDocument = new Document(dataDir + "input.pdf");
            
            // instantiate DefaultAppearance object
            Aspose.Pdf.InteractiveFeatures.DefaultAppearance default_appearance = new DefaultAppearance("Arial", 28, System.Drawing.Color.Red);
            
            //create annotation
            FreeTextAnnotation freetext = new FreeTextAnnotation(pdfDocument.Pages[1], new Aspose.Pdf.Rectangle(200, 400, 400, 600), default_appearance);
            
            // specify the contents of annotation
            freetext.Contents = "Free Text";
            
            // add anootation to annotations collection of page
            pdfDocument.Pages[1].Annotations.Add(freetext);
            
            // save the updated document
            pdfDocument.Save(dataDir + "output.pdf");

            
        }
    }
}