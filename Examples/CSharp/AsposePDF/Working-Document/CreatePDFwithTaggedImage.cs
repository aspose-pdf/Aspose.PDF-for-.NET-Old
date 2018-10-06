using Aspose.Pdf.TaggedPdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Working_Document
{
    public class CreatePDFwithTaggedImage
    {
        public static void Run()
        {
            // ExStart:CreatePDFwithTaggedText
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            Document doc = new Document();
            Aspose.Pdf.Page page1 = doc.Pages.Add();
            // Create image
            Image image = new Image();
            //Assign image file 
            image.File = dataDir + @"aspose-logo.jpg";

            //Create BBox element
            Rectangle BBox = new Rectangle(30, 70, 300, 720);
            //Create tagged figure element
            TaggedPdfFigureElement figureElement = new TaggedPdfFigureElement(doc, image, BBox);
            Rectangle BBox1 = new Rectangle(550, 570, 300, 720);
            TaggedPdfFigureElement figureElement1 = new TaggedPdfFigureElement(doc, image, BBox1);
            //Add tagged figure element into content
            page1.TaggedPdfContent.Add(figureElement);
            page1.TaggedPdfContent.Add(figureElement1);

            // Save PDF Document
            doc.Save(dataDir + "PDFwithTaggedImage.pdf");
            // ExEnd:CreatePDFwithTaggedImage
        }
    }
}
