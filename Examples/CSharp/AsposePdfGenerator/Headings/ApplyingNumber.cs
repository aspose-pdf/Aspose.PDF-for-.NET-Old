using System;
using System.IO;
using Aspose.Pdf;
namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Headings
{
    public class ApplyingNumber
    {
        public static void Run()
        {
            // ExStart:ApplyingNumber
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Headings();
            // Instntiate the Pdf object by calling its empty constructor
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Create the section in the Pdf object
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            /*
            * Create 1st heading in the Pdf object's section with level=1. Then create
            * a text segment and add it in the heading. Set its numbering style to "Arab"
            * using HeadingType enumeration. And don't forget to set IsAutoSequence=true.
            * If IsAutoSeguence property is set to true then the heading's sequence is 
            * controlled automatically by Aspose.Pdf. After setting all properties, add 
            * heading into the paragraphs collection of the section
            */

            Aspose.Pdf.Generator.Heading heading1 = new Aspose.Pdf.Generator.Heading(pdf1, sec1, 1);
            Aspose.Pdf.Generator.Segment segment1 = new Aspose.Pdf.Generator.Segment(heading1);
            heading1.Segments.Add(segment1);
            segment1.Content = "Arab";
            heading1.HeadingType = Aspose.Pdf.Generator.HeadingType.Arab;
            heading1.IsAutoSequence = true;
            sec1.Paragraphs.Add(heading1);

            /*
            * Create 2nd heading in the Pdf object's section with level=1. Then create
            * a text segment and add it in the heading. Set its numbering style to "RomanUpper"
            * using HeadingType enumeration. And don't forget to set IsAutoSequence=true.
            * If IsAutoSeguence property is set to true then the heading's sequence is 
            * controlled automatically by Aspose.Pdf for .NET. After setting all properties, add 
            * heading into the paragraphs collection of the section
            */

            Aspose.Pdf.Generator.Heading heading2 = new Aspose.Pdf.Generator.Heading(pdf1, sec1, 1);
            Aspose.Pdf.Generator.Segment segment2 = new Aspose.Pdf.Generator.Segment(heading2);
            heading2.Segments.Add(segment2);
            segment2.Content = "RomanUpper";
            heading2.HeadingType = Aspose.Pdf.Generator.HeadingType.RomanUpper;
            heading2.IsAutoSequence = true;
            sec1.Paragraphs.Add(heading2);

            /*
            * Create 3rd heading in the Pdf object's section with level=1. Then create
            * a text segment and add it in the heading. Set its numbering style to "RomanLower"
            * using HeadingType enumeration. And don't forget to set IsAutoSequence=true.
            * If IsAutoSeguence property is set to true then the heading's sequence is 
            * controlled automatically by Aspose.Pdf for .NET. After setting all properties, add 
            * heading into the paragraphs collection of the section
            */

            Aspose.Pdf.Generator.Heading heading3 = new Aspose.Pdf.Generator.Heading(pdf1, sec1, 1);
            Aspose.Pdf.Generator.Segment segment3 = new Aspose.Pdf.Generator.Segment(heading3);
            heading3.Segments.Add(segment3);
            segment3.Content = "RomanLower";
            heading3.HeadingType = Aspose.Pdf.Generator.HeadingType.RomanLower;
            heading3.IsAutoSequence = true;
            sec1.Paragraphs.Add(heading3);

            /*
            * Create 4th heading in the Pdf object's section with level=1. Then create a
            * text segment and add it in the heading. Set its numbering style to "EnglishUpper"
            * using HeadingType enumeration. And don't forget to set IsAutoSequence=true.
            * If IsAutoSeguence property is set to true then the heading's sequence is 
            * controlled automatically by Aspose.Pdf for .NET. After setting all properties, add 
            * heading into the paragraphs collection of the section
            */

            Aspose.Pdf.Generator.Heading heading4 = new Aspose.Pdf.Generator.Heading(pdf1, sec1, 1);
            Aspose.Pdf.Generator.Segment segment4 = new Aspose.Pdf.Generator.Segment(heading4);
            heading4.Segments.Add(segment4);
            segment4.Content = "EnglishUpper";
            heading4.HeadingType = Aspose.Pdf.Generator.HeadingType.EnglishUpper;
            heading4.IsAutoSequence = true;
            sec1.Paragraphs.Add(heading4);

            /*
            * Create 5th heading in the Pdf object's section with level=1. Then create a
            * text segment and add it in the heading. Set its numbering style to "EnglishLower"
            * using HeadingType enumeration. And don't forget to set IsAutoSequence=true.
            * If IsAutoSeguence property is set to true then the heading's sequence is 
            * controlled automatically by Aspose.Pdf for .NET. After setting all properties, add 
            * heading into the paragraphs collection of the section
            */

            Aspose.Pdf.Generator.Heading heading5 = new Aspose.Pdf.Generator.Heading(pdf1, sec1, 1);
            Aspose.Pdf.Generator.Segment segment5 = new Aspose.Pdf.Generator.Segment(heading5);
            heading5.Segments.Add(segment5);
            segment5.Content = "EnglishLower";
            heading5.HeadingType = Aspose.Pdf.Generator.HeadingType.EnglishLower;
            heading5.IsAutoSequence = true;
            sec1.Paragraphs.Add(heading5);                       
            pdf1.Save( dataDir + "headings_out_.pdf");            
            // ExEnd:ApplyingNumber   
                
        }
    }
}