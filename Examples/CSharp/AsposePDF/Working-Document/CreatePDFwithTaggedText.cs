using Aspose.Pdf.TaggedPdf;
using Aspose.Pdf.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Working_Document
{
    public class CreatePDFwithTaggedText
    {
        public static void Run()
        {
            // ExStart:CreatePDFwithTaggedText
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            Document doc = new Document();
            Aspose.Pdf.Page page1 = doc.Pages.Add();
            Aspose.Pdf.Page page2 = doc.Pages.Add();
            Aspose.Pdf.Page page3 = doc.Pages.Add();

            // Create TextState and configure it
            Aspose.Pdf.Text.TextState ts = new Aspose.Pdf.Text.TextState();
            ts.Font = FontRepository.FindFont("Arial");

            // Creating tagged text element i.e. Supported tags P, H,H1-H6
            TaggedPdfTextElement textElement1 = new TaggedPdfTextElement(doc, "P", "text", ts);
            TaggedPdfTextElement textElement2 = new TaggedPdfTextElement(doc, "P", "test1", ts);
            TaggedPdfTextElement textElement3 = new TaggedPdfTextElement(doc, "P", "test2", ts);
            TaggedPdfTextElement textElement4 = new TaggedPdfTextElement(doc, "P", "test3", ts);
            TaggedPdfTextElement textElement5 = new TaggedPdfTextElement(doc, "P", "test4", ts);
            TaggedPdfTextElement textElement6 = new TaggedPdfTextElement(doc, "P", "test5", ts);
            TaggedPdfTextElement textElement7 = new TaggedPdfTextElement(doc, "P", "test6", ts);
            TaggedPdfTextElement textElement8 = new TaggedPdfTextElement(doc, "P", "test7", ts);

            // Add tagged text element to content
            page1.TaggedPdfContent.Add(textElement1);
            page1.TaggedPdfContent.Add(textElement2);
            page1.TaggedPdfContent.Add(textElement3);
            page2.TaggedPdfContent.Add(textElement4);
            page2.TaggedPdfContent.Add(textElement5);
            page3.TaggedPdfContent.Add(textElement6);
            page3.TaggedPdfContent.Add(textElement7);
            page3.TaggedPdfContent.Add(textElement8);

            // Save PDF Document
            doc.Save( dataDir + "PDFwithTaggedText.pdf");
            // ExEnd:CreatePDFwithTaggedText
        }
    }
}
