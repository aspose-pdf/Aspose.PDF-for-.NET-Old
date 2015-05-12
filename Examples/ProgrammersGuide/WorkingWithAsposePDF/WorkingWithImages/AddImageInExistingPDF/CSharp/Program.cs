//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace AddImageInExistingPDF
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //open document
            Document pdfDocument = new Document(dataDir+ "input.pdf");

            //set coordinates
            int lowerLeftX = 100;
            int lowerLeftY = 100;
            int upperRightX = 200;
            int upperRightY = 200;

            //get the page where image needs to be added
            Page page = pdfDocument.Pages[1];
            //load image into stream
            FileStream imageStream = new FileStream(dataDir + "aspose-logo.jpg", FileMode.Open);
            //add image to Images collection of Page Resources
            page.Resources.Images.Add(imageStream);
            //using GSave operator: this operator saves current graphics state
            page.Contents.Add(new Operator.GSave());
            //create Rectangle and Matrix objects
            Aspose.Pdf.Rectangle rectangle = new Aspose.Pdf.Rectangle(lowerLeftX, lowerLeftY, upperRightX, upperRightY);
            Aspose.Pdf.DOM.Matrix matrix = new Aspose.Pdf.DOM.Matrix(new double[] { rectangle.URX - rectangle.LLX, 0, 0, rectangle.URY - rectangle.LLY, rectangle.LLX, rectangle.LLY });
            //using ConcatenateMatrix (concatenate matrix) operator: defines how image must be placed
            page.Contents.Add(new Operator.ConcatenateMatrix(matrix));
            XImage ximage = page.Resources.Images[page.Resources.Images.Count];
            //using Do operator: this operator draws image
            page.Contents.Add(new Operator.Do(ximage.Name));
            //using GRestore operator: this operator restores graphics state
            page.Contents.Add(new Operator.GRestore());
            //save updated document
            pdfDocument.Save(dataDir + "output.pdf");
        }
    }
}