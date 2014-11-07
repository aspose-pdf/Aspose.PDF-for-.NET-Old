//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace ImagePageNumberInHeaderFooter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //Instantiate a Pdf object by calling its empty constructor
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();
            //Create a section in the Pdf object
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            //=====================================================//
            //	Header to show an Image
            //=====================================================//

            // Create Header Section of the document
            Aspose.Pdf.Generator.HeaderFooter header = new Aspose.Pdf.Generator.HeaderFooter(sec1);
            // set the Odd header for the PDF file
            sec1.OddHeader = header;
            // Set the Even Header for the PDF file
            sec1.EvenHeader = header;
            //Create an image object in the section
            Aspose.Pdf.Generator.Image image1 = new Aspose.Pdf.Generator.Image(sec1);
            //Set the path of image file
            image1.ImageInfo.File = dataDir + "aspose.jpg";
            //Set the type of image using ImageFileType enumeration
            image1.ImageInfo.ImageFileType = Aspose.Pdf.Generator.ImageFileType.Jpeg;
            //Add image to Header section of the Pdf file
            header.Paragraphs.Add(image1);

            //=====================================================//
            //	Footer to show Page Number
            //=====================================================//

            // Create a Footer Section of the document
            Aspose.Pdf.Generator.HeaderFooter footer = new Aspose.Pdf.Generator.HeaderFooter(sec1);
            // set the Odd footer of the PDF file
            sec1.OddFooter = footer;
            // set the Even footer of the PDF file
            sec1.EvenFooter = footer;
            // Create a Text object
            Aspose.Pdf.Generator.Text txt = new Aspose.Pdf.Generator.Text("Page: ($p of $P ) ");
            // Add text to Header section of the Pdf file
            footer.Paragraphs.Add(txt);

            //Save the Pdf
            pdf1.Save(dataDir + "pdfWithHeaderAndPageNos.pdf");
        }
    }
}