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

namespace AddSwfFileAsAnnotationToPDFDocument
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //Open the PDF document
            Document doc = new Document(dataDir + "input.pdf");
            
            // get reference of the page to which you need to add the annotation
            Page page = doc.Pages[1];
            
            // create ScreenAnnotation object with .swf multimedia file as an argument
            ScreenAnnotation annotation = new ScreenAnnotation(page, new Aspose.Pdf.Rectangle(0, 400, 600, 700), dataDir + "input.swf");
           
            // add the annotation to annotations collection of page
            page.Annotations.Add(annotation);
            
            // save the update PDF document with annotation
            doc.Save(dataDir + "output.pdf");

        }
    }
}