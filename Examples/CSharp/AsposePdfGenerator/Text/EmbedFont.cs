using System;
using System.IO;
using Aspose.Pdf;
namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Text
{
    public class EmbedFont
    {
        public static void Run()
        {
            
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Text();

            // Instantiate Pdf instance by calling it empty constructor
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Create a section in the Pdf object
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();
            // ExStart:EmbedFont
            // Create a text object in a section
            Aspose.Pdf.Generator.Text t1 = new Aspose.Pdf.Generator.Text(sec1, "Arial Bold MT");

            // Set the font name of a segment in the text object
            t1.Segments[0].TextInfo.FontName = "Arial-BoldMT";

            // Set the PFM file for the text segment
            t1.Segments[0].TextInfo.FontPfmFile = "_AB_____.PFM";

            // Set the font encoding file for the text segment
            t1.Segments[0].TextInfo.FontEncodingFile = "CP1250.txt";

            // Set the font encoding name of the text segment
            t1.Segments[0].TextInfo.FontEncoding = "cp1250";

            // Set the font outline file for the text segment
            t1.Segments[0].TextInfo.FontOutlineFile = "_AB_____.PFB";

            // Set IsFontEmbedded to true
            t1.Segments[0].TextInfo.IsFontEmbedded = true;
            // ExEnd:EmbedFont
            dataDir = dataDir + "EmbedFont_out_.pdf";
            // Create the result PDF Document
            pdf1.Save(dataDir);
            
        }
        public static void TrueTypeBoldFont()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Text();

            // Instantiate Pdf instance by calling it empty constructor
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Create a section in the Pdf object
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();
            // ExStart:TrueTypeBoldFont
            // Create a text object in the section
            Aspose.Pdf.Generator.Text t1 = new Aspose.Pdf.Generator.Text(sec1, "Courier New Bold font");

            // Set font name of a specific text segment to courier new
            t1.Segments[0].TextInfo.FontName = "Courier New";

            // Set the font to bold
            t1.Segments[0].TextInfo.IsTrueTypeFontBold = true;
            // ExEnd:TrueTypeBoldFont
            dataDir = dataDir + "TrueTypeBoldFont_out_.pdf";
            // Create the result PDF Document
            pdf1.Save(dataDir);
        }
        public static void TrueTypeFont()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Text();

            // Instantiate Pdf instance by calling it empty constructor
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Create a section in the Pdf object
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();
            // ExStart:TrueTypeFont
            // Create a text object in the section
            Aspose.Pdf.Generator.Text t1 = new Aspose.Pdf.Generator.Text(sec1, "Courier New Bold font");

            // Set font name of a specific text segment to courier new
            t1.Segments[0].TextInfo.FontName = "Courier New";

            // ExEnd:TrueTypeFont
            dataDir = dataDir + "TrueTypeFont_out_.pdf";
            // Create the result PDF Document
            pdf1.Save(dataDir);
        }
        public static void Unicode()
        {
            // ExStart:Unicode
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Text();

            // Instantiate Pdf instance by calling it empty constructor
            Aspose.Pdf.Generator.Pdf pdf = new Aspose.Pdf.Generator.Pdf();
            // Set the property to make your application run faster. It will help load the Truetype font faster
            pdf.IsTruetypeFontMapCached = true;
            // Create a section in the Pdf object
            Aspose.Pdf.Generator.Section sec1 = pdf.Sections.Add();

            // To assign a unicode character by it's coding
            Aspose.Pdf.Generator.Text t1 = new Aspose.Pdf.Generator.Text(((char)0x25a0).ToString());
            // Specify the font face name for first segment in text object
            t1.Segments[0].TextInfo.FontName = "Times New Roman";
            // Specify that first segment in text is UniCode
            t1.Segments[0].TextInfo.IsUnicode = true;
            // Add text to paragraphs collection of section object
            sec1.Paragraphs.Add(t1);
            // Save the PDF document
            pdf.Save(dataDir + "Unicode_out_.pdf");
            // ExEnd:Unicode
        }
    }
}