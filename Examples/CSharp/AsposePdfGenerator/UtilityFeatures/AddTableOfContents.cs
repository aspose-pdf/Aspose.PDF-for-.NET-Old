using System;
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Generator;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.UtilityFeatures
{
    public class AddTableOfContents
    {
        public static void Run()
        {
            // ExStart:AddTableOfContents
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_UtilityFeatures();

            // Create a PDF instance
            Aspose.Pdf.Generator.Pdf pdf = new Aspose.Pdf.Generator.Pdf();
            // Create a list section 
            Aspose.Pdf.Generator.ListSection tocSection = new Aspose.Pdf.Generator.ListSection("Table Of Contents");
            // Set its list type as table of contents
            tocSection.ListType = ListType.TableOfContents;
            // Add the list section to the sections collection of the Pdf document
            pdf.Sections.Add(tocSection);

            // Define the format of the four levels list by setting the left margins and
            // Text format settings of each level
            tocSection.ListFormatArray.Length = 4;
            tocSection.ListFormatArray[0].LeftMargin = 0;
            tocSection.ListFormatArray[0].TextInfo.IsTrueTypeFontBold = true;
            tocSection.ListFormatArray[0].TextInfo.IsTrueTypeFontItalic = true;
            tocSection.ListFormatArray[1].LeftMargin = 10;
            tocSection.ListFormatArray[1].TextInfo.IsUnderline = true;
            tocSection.ListFormatArray[1].TextInfo.FontSize = 10;
            tocSection.ListFormatArray[2].LeftMargin = 20;
            tocSection.ListFormatArray[2].TextInfo.IsTrueTypeFontBold = true;
            tocSection.ListFormatArray[3].LeftMargin = 30;
            tocSection.ListFormatArray[3].TextInfo.IsTrueTypeFontBold = true;

            // Create a section in the Pdf document
            Aspose.Pdf.Generator.Section sec1 = pdf.Sections.Add();

            // Add four headings in the section
            for (int Level = 1; Level < 5; Level++)
            {
                Aspose.Pdf.Generator.Heading heading1 = new Aspose.Pdf.Generator.Heading(pdf, sec1, Level);
                Segment segment1 = new Segment(heading1);
                heading1.Segments.Add(segment1);
                heading1.IsAutoSequence = true;
                segment1.Content = "this is heading of level ";
                segment1.Content += Level.ToString();

                // Add the heading into Table Of Contents. 
                heading1.IsInList = true;
                // Heading2.TOC = tocSection;
                sec1.Paragraphs.Add(heading1);
            }

            // Create a list section 
            ListSection tocSection2 = new ListSection("Second Table Of Contents");
            // Set its list type as table of of contents
            tocSection2.ListType = ListType.TableOfContents;
            // Add the list section to the sections collection of the Pdf document
            pdf.Sections.Add(tocSection2);

            // Define the format of the four levels list by setting the left margins and
            // Text format settings of each level
            tocSection2.ListFormatArray.Length = 4;
            tocSection2.ListFormatArray[0].LeftMargin = 0;
            tocSection2.ListFormatArray[0].TextInfo.IsTrueTypeFontBold = true;
            tocSection2.ListFormatArray[0].TextInfo.IsTrueTypeFontItalic = true;
            tocSection2.ListFormatArray[1].LeftMargin = 10;
            tocSection2.ListFormatArray[1].TextInfo.IsUnderline = true;
            tocSection2.ListFormatArray[1].TextInfo.FontSize = 10;
            tocSection2.ListFormatArray[2].LeftMargin = 20;
            tocSection2.ListFormatArray[2].TextInfo.IsTrueTypeFontBold = true;
            tocSection2.ListFormatArray[3].LeftMargin = 30;
            tocSection2.ListFormatArray[3].TextInfo.IsTrueTypeFontBold = true;

            // Create a section in the Pdf document
            Aspose.Pdf.Generator.Section sec2 = pdf.Sections.Add();

            // Add four headings in the section
            for (int Level = 1; Level < 5; Level++)
            {
                Aspose.Pdf.Generator.Heading heading2 = new Aspose.Pdf.Generator.Heading(pdf, sec1, Level);
                Segment segment2 = new Segment(heading2);
                heading2.Segments.Add(segment2);
                heading2.IsAutoSequence = true;
                segment2.Content = "this is heading of level ";
                segment2.Content += Level.ToString();

                // Add the heading into Table Of Contents. 
                heading2.IsInList = true;
                // Add the heading elements to second ListSection
                heading2.TOC = tocSection2;
                // Add the heading obejct to paragraphs colelction of section2
                sec2.Paragraphs.Add(heading2);
            }     
           
            dataDir = dataDir + "Multiple_TOC_out.pdf";
            // Save the resultant PDF document
            pdf.Save(dataDir);
            // ExEnd:AddTableOfContents           
        }        
    }
}