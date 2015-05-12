//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace AddHyperlink
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");


            // Open document
            Document document = new Document(dataDir+ "input.pdf");
            // Create link
            Page page = document.Pages[1];
            // Create Link annotation object
            Aspose.Pdf.InteractiveFeatures.Annotations.LinkAnnotation link = new Aspose.Pdf.InteractiveFeatures.Annotations.LinkAnnotation(page, new Aspose.Pdf.Rectangle(100, 100, 300, 300));
            // Create border object for LinkAnnotation
            Aspose.Pdf.InteractiveFeatures.Annotations.Border border = new Aspose.Pdf.InteractiveFeatures.Annotations.Border(link);
            // Set the border width value as 0
            border.Width = 0;
            // Set the border for LinkAnnotation
            link.Border = border;
            // Specify the link type as remote URI
            link.Action = new Aspose.Pdf.InteractiveFeatures.GoToURIAction("www.aspose.com");
            // Add link annotation to annotations collection of first page of PDF file
            page.Annotations.Add(link);

            // Create Free Text annotation
            Aspose.Pdf.InteractiveFeatures.Annotations.FreeTextAnnotation textAnnotation = new Aspose.Pdf.InteractiveFeatures.Annotations.FreeTextAnnotation(document.Pages[1], new Aspose.Pdf.Rectangle(100, 100, 300, 300), new Aspose.Pdf.InteractiveFeatures.DefaultAppearance(Aspose.Pdf.Text.FontRepository.FindFont("TimesNewRoman"), 10, System.Drawing.Color.Blue));
            // String to be added as Free text
            textAnnotation.Contents = "Link to Aspose website";
            // Set the border for Free Text Annotation
            textAnnotation.Border = border;
            // Add FreeText annotation to annotations collection of first page of Document
            document.Pages[1].Annotations.Add(textAnnotation);
            // Save updated document
            document.Save(dataDir + "output.pdf");
            
        }
    }
}