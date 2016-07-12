using System;
using System.IO;
using Aspose.Pdf;
namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Text
{
    public class RTLLanguages
    {
        public static void Run()
        {
            // ExStart:RTLLanguages
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Text();

            // Instantiate Pdf instance by calling it empty constructor
            Aspose.Pdf.Generator.Pdf pdf = new Aspose.Pdf.Generator.Pdf();
            // Create a section in the Pdf object
            pdf.Sections.Add();

            pdf.IsTruetypeFontMapCached = true;
            // Specify the location where to save TruetypeFontMap.xml
            pdf.TruetypeFontMapPath = dataDir+ "" ;

            // Create a text object and pass the string object carrying arabic text in it
            Aspose.Pdf.Generator.Text text1 = new Aspose.Pdf.Generator.Text();
            // Create a segment and add it to segments collection of text object
            Aspose.Pdf.Generator.Segment seg0 = text1.Segments.Add();
            // Specify contents for segment
            seg0.Content = "أسبوز هو بائع عنصر ال";
            Aspose.Pdf.Generator.Segment seg1 = text1.Segments.Add();
            seg1.Content = ".NET";
            Aspose.Pdf.Generator.Segment seg2 = text1.Segments.Add();
            seg2.Content = "البارز";

            // Enable text alignment from right to left
            seg0.TextInfo.IsRightToLeft = true;
            seg1.TextInfo.IsRightToLeft = false;         //default
            seg2.TextInfo.IsRightToLeft = true;

            // Enable unicode character set for the text segment
            seg0.TextInfo.IsUnicode = true;
            seg1.TextInfo.IsUnicode = true;
            seg2.TextInfo.IsUnicode = true;

            // Set Font Name
            seg0.TextInfo.FontName = "Times New Roman";
            seg1.TextInfo.FontName = "Times New Roman";
            seg2.TextInfo.FontName = "Times New Roman";
            // Set font size
            seg0.TextInfo.FontSize = 14;
            seg1.TextInfo.FontSize = 14;
            seg2.TextInfo.FontSize = 14;

            // Align text to right hand side using AlignmentType enumeration    
            // Make the text right aligned(The meaning of Alignment.Left and AlignmentType.Right are //exchanged when processing RTL language).
            text1.TextInfo.Alignment = Aspose.Pdf.Generator.AlignmentType.Left;

            pdf.Sections[0].Paragraphs.Add(text1);
            pdf.IsRtlInSegmentMode = true;         //default

            pdf.Save(dataDir + "RTLLanguages_out_.pdf");
            // ExEnd:RTLLanguages
            
            
        }
    }
}