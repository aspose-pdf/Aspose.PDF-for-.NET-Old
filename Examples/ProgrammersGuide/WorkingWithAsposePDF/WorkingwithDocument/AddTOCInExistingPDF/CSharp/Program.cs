//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;
using Aspose.Pdf.Text;

namespace AddTOCInExistingPDF
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            // Load an existing PDF files
            Document doc = new Document(dataDir + "input.pdf");

            // Get access to first page of PDF file
            Page tocPage = doc.Pages.Insert(1);

            // Create object to represent TOC information
            TocInfo tocInfo = new TocInfo();
            TextFragment title = new TextFragment("Table Of Contents");
            title.TextState.FontSize = 20;
            title.TextState.FontStyle = FontStyles.Bold;

            // Set the title for TOC
            tocInfo.Title = title;
            tocPage.TocInfo = tocInfo;

            // Create string objects which will be used as TOC elements
            string[] titles = new string[4];
            titles[0] = "First page";
            titles[1] = "Second page";
            titles[2] = "Third page";
            titles[3] = "Fourth page";
            for (int i = 0; i < 2; i++)
            {
                // Create Heading object
                Aspose.Pdf.Heading heading2 = new Aspose.Pdf.Heading(1);
                TextSegment segment2 = new TextSegment();
                heading2.TocPage = tocPage;
                heading2.Segments.Add(segment2);

                // Specify the destination page for heading object
                heading2.DestinationPage = doc.Pages[i + 2];

                // Destination page
                heading2.Top = doc.Pages[i + 2].Rect.Height;

                // Destination coordinate
                segment2.Text = titles[i];

                // Add heading to page containing TOC
                tocPage.Paragraphs.Add(heading2);
            }
            // Save the updated document
            doc.Save(dataDir + "TOC_Output.pdf");

        }
    }
}