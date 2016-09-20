using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.TechnicalArticles
{
    public class FontsEmbedding 
    {
        public static void Run()
        {
            // ExStart:FontsEmbedding 
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_TechnicalArticles();

            // Instantiate Pdf instance by calling it empty constructor
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Create a section in the Pdf object                       
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            // Create a text paragraph inheriting text format settings from the section
            Aspose.Pdf.Generator.Text text1 = new Aspose.Pdf.Generator.Text(sec1);

            // Add the text paragraph to the section
            sec1.Paragraphs.Add(text1);

            // Create a text segment
            Aspose.Pdf.Generator.Segment s1 = new Aspose.Pdf.Generator.Segment(" This is a sample text using Custom font");

            // Set the font name to the TextInfo.FontName property of segment, where ‘Almonto Snow’ is custom font name
            s1.TextInfo.FontName = "Almonte Snow";

            // Set the value for property to include the font description into Pdf file
            s1.TextInfo.IsFontEmbedded = true;

            // ExStart:IsUnicode
            // Set the value for property to include a subset of font into Pdf file
            s1.TextInfo.IsUnicode = true;
            // ExEnd:IsUnicode

            // Add the text segment to the text paragraph
            text1.Segments.Add(s1);

            // Save the Pdf
            pdf1.Save(dataDir + @"FontsEmbedding_out_.pdf");
            // ExEnd:FontsEmbedding            
        }
        public static void FontsEmbeddingUsingHTML()
        {
            // ExStart:FontsEmbeddingUsingHTML 
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_TechnicalArticles();

            // Instantiate a pdf document
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Create a section in the pdf document
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            // Create string variables with text containing html tags
            string s = "<html><body><font isUnicode='true' face='Bete Noir NF' size=18><i>Sample text </i>with Custome font Embedded </font><br><font isUnicode='true' face='Courier New' size=10><s>Sample Text </s>in <u>Courier New</u> font</font></body></html>";

            // Create text paragraphs containing HTML text
            Aspose.Pdf.Generator.Text t1 = new Aspose.Pdf.Generator.Text(s);

            // Enable the HTML tag support property
            t1.IsHtmlTagSupported = true;

            // Add the text paragraphs containing HTML text to the section
            sec1.Paragraphs.Add(t1);

            // Save the pdf document
            pdf1.Save( dataDir + "inLineFormated_HtmlSuported_out_.pdf");
            // ExEnd:FontsEmbeddingUsingHTML 
        }
    }
}