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

namespace AddAnnotationInExistingPDFFile
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //open document
            Document pdfDocument = new Document(dataDir + "input.pdf");

            //create annotation
            TextAnnotation textAnnotation = new TextAnnotation(pdfDocument.Pages[1], new Aspose.Pdf.Rectangle(200, 400, 400, 600));
            textAnnotation.Title = "Sample Annotation Title";
            textAnnotation.Subject = "Sample Subject";
            textAnnotation.State = AnnotationState.Accepted;
            textAnnotation.Contents = "Sample contents for the annotation";
            textAnnotation.Open = true;
            textAnnotation.Icon = TextIcon.Key;
           
            Border border = new Border(textAnnotation);
            border.Width = 5;
            border.Dash = new Dash(1, 1);
            textAnnotation.Border = border;
            textAnnotation.Rect = new Aspose.Pdf.Rectangle(200, 400, 400, 600);
           
            //add annotation in the annotations collection of the page
            pdfDocument.Pages[1].Annotations.Add(textAnnotation);
            
            ////save output file
            pdfDocument.Save(dataDir + "output.pdf");

        }
    }
}