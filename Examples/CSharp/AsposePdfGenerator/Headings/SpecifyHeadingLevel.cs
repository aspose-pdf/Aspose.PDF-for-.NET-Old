using System;
using System.IO;
using Aspose.Pdf;
namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Headings
{
    public class SpecifyHeadingLevel
    {
        public static void Run()
        {
            // ExStart:SpecifyHeadingLevel
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Headings();
            // Instntiate the Pdf object by calling its empty constructor
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Create the section in the Pdf object
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            /*
             * Create 1st heading in the Pdf object's section with level=1. Then create
             * a text segment and add it in the heading. Set its StartNumber=6 to start 
             * the numbering from 6 and onwards. And don't forget to set IsAutoSequence=true.
             * If IsAutoSeguence property is set to true then the heading's sequence is 
             * controlled automatically by Aspose.Pdf for .NET. After setting all properties, add 
             * heading into the paragraphs collection of the section
             */

            Aspose.Pdf.Generator.Heading heading1 = new Aspose.Pdf.Generator.Heading(pdf1, sec1, 1);
            Aspose.Pdf.Generator.Segment segment1 = new Aspose.Pdf.Generator.Segment(heading1);
            heading1.Segments.Add(segment1);
            segment1.Content = "Level 1";
            heading1.IsAutoSequence = true;
            heading1.StartNumber = 6;
            sec1.Paragraphs.Add(heading1);

            /*
             * Create 2nd heading in the Pdf object's section with level=2. Then create
             * a text segment and add it in the heading. And don't forget to set 
             * IsAutoSequence=true.If IsAutoSeguence property is set to true then the 
             * heading's sequence is controlled automatically by Aspose.Pdf for .NET. After setting
             * all properties, add heading into the paragraphs collection of the section
             */

            Aspose.Pdf.Generator.Heading heading2 = new Aspose.Pdf.Generator.Heading(pdf1, sec1, 2);
            Aspose.Pdf.Generator.Segment segment2 = new Aspose.Pdf.Generator.Segment(heading2);
            heading2.Segments.Add(segment2);
            segment2.Content = "Level 2";
            heading2.IsAutoSequence = true;
            sec1.Paragraphs.Add(heading2);

            /*
             * Create 3rd heading in the Pdf object's section with level=3. Then create
             * a text segment and add it in the heading. And don't forget to set 
             * IsAutoSequence=true.If IsAutoSeguence property is set to true then the 
             * heading's sequence is controlled automatically by Aspose.Pdf for .NET. After setting
             * all properties, add heading into the paragraphs collection of the section
             */

            Aspose.Pdf.Generator.Heading heading3 = new Aspose.Pdf.Generator.Heading(pdf1, sec1, 3);
            Aspose.Pdf.Generator.Segment segment3 = new Aspose.Pdf.Generator.Segment(heading3);
            heading3.Segments.Add(segment3);
            segment3.Content = "Level 3";
            heading3.IsAutoSequence = true;
            sec1.Paragraphs.Add(heading3);

            pdf1.Save(dataDir + "SpecifyHeadingLevel_out_.pdf");
            // ExEnd:SpecifyHeadingLevel   
                
        }
    }
}