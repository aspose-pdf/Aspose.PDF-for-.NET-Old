using System;
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Text;
using Aspose.Pdf.Facades;
using Aspose.Pdf.Text.TextOptions;
namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class SpecifyCharacterSpacing
    {
        public static void Run()
        {
            UsingTextBuilderAndFragment();
            UsingTextBuilderAndParagraph();
            UsingTextStamp();
            UsingAsposePdfGenerator();
           
        }
        public static void UsingTextBuilderAndFragment()
        {
            // ExStart:UsingTextBuilderAndFragment
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();

            // Create Document instance
            Document pdfDocument = new Document();
            // Add page to pages collection of Document
            Page page = pdfDocument.Pages.Add();
            // Create TextBuilder instance
            TextBuilder builder = new TextBuilder(pdfDocument.Pages[1]);
            // Create text fragment instance with sample contents
            TextFragment wideFragment = new TextFragment("Text with increased character spacing");
            wideFragment.TextState.ApplyChangesFrom(new TextState("Arial", 12));
            // Specify character spacing for TextFragment
            wideFragment.TextState.CharacterSpacing = 2.0f;
            // Specify the position of TextFragment
            wideFragment.Position = new Position(100, 650);
            // Append TextFragment to TextBuilder instance
            builder.AppendText(wideFragment);
            dataDir = dataDir + "CharacterSpacingUsingTextBuilderAndFragment_out_.pdf";
            // Save resulting PDF document.
            pdfDocument.Save(dataDir);
            // ExEnd:UsingTextBuilderAndFragment
            Console.WriteLine("\nCharacter spacing specified successfully using Text builder and fragment.\nFile saved at " + dataDir); 
        }
        public static void UsingTextBuilderAndParagraph()
        {
            // ExStart:UsingTextBuilderAndParagraph
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();

            // Create Document instance
            Document pdfDocument = new Document();
            // Add page to pages collection of Document
            Page page = pdfDocument.Pages.Add();
            // Create TextBuilder instance
            TextBuilder builder = new TextBuilder(pdfDocument.Pages[1]);
            // Instantiate TextParagraph instance
            TextParagraph paragraph = new TextParagraph();
            // Create TextState instance to specify font name and size
            TextState state = new TextState("Arial", 12);
            // Specify the character spacing
            state.CharacterSpacing = 1.5f;
            // Append text to TextParagraph object
            paragraph.AppendLine("This is paragraph with character spacing", state);
            // Specify the position for TextParagraph
            paragraph.Position = new Position(100, 550);
            // Append TextParagraph to TextBuilder instance
            builder.AppendParagraph(paragraph);

            dataDir = dataDir + "CharacterSpacingUsingTextBuilderAndParagraph_out_.pdf";
            // Save resulting PDF document.
            pdfDocument.Save(dataDir);
            // ExEnd:UsingTextBuilderAndParagraph
            Console.WriteLine("\nCharacter spacing specified successfully using Text builder and paragraph.\nFile saved at " + dataDir);
        }
        public static void UsingTextStamp()
        {
            // ExStart:UsingTextStamp
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();

            // Create Document instance
            Document pdfDocument = new Document();
            // Add page to pages collection of Document
            Page page = pdfDocument.Pages.Add();
            // Instantiate TextStamp instance with sample text
            TextStamp stamp = new TextStamp("This is text stamp with character spacing");
            // Specify font name for Stamp object
            stamp.TextState.Font = FontRepository.FindFont("Arial");
            // Specify Font size for TextStamp
            stamp.TextState.FontSize = 12;
            // Specify character specing as 1f
            stamp.TextState.CharacterSpacing = 1f;
            // Set the XIndent for Stamp
            stamp.XIndent = 100;
            // Set the YIndent for Stamp
            stamp.YIndent = 500;
            // Add textual stamp to page instance
            stamp.Put(page);
            dataDir = dataDir + "CharacterSpacingUsingTextStamp_out_.pdf";
            // Save resulting PDF document.
            pdfDocument.Save(dataDir);
            // ExEnd:UsingTextStamp
            Console.WriteLine("\nCharacter spacing specified successfully using text stamp.\nFile saved at " + dataDir);
        }
        public static void UsingAsposePdfGenerator()
        {
            // ExStart:UsingAsposePdfGenerator
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();

            // Instantiate Pdf instance
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Create a new section in the Pdf object
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            // Add 1st paragraph (inheriting the text format settings from the section)
            // to the section 
            sec1.Paragraphs.Add(new Aspose.Pdf.Generator.Text(sec1, "This is generator text paragraph with default character spacing"));

            Aspose.Pdf.Generator.Section sec2 = pdf1.Sections.Add();

            // Create 2nd paragraph (inheriting the text format settings from the section) 
            Aspose.Pdf.Generator.Text t2 = new Aspose.Pdf.Generator.Text(sec1);

            // Create a segment "seg1" in the paragraph "t2"
            Aspose.Pdf.Generator.Segment seg1 = new Aspose.Pdf.Generator.Segment(t2);
            // Assign some content to the segment
            seg1.Content = "This is generator text paragraph with increased character spacing";
            // Set character spacing of the segment to 2.0
            seg1.TextInfo.CharSpace = 2.0f;

            // Add segment (with character spacing) to the paragraph
            t2.Segments.Add(seg1);
            // Add 2nd text paragraph to the section with overridden text format settings
            sec1.Paragraphs.Add(t2); ;
            dataDir = dataDir + "UsingAsposePdfGenerator_out_.pdf";
            // Save resulting PDF document.
            pdf1.Save(dataDir);
            // ExEnd:UsingAsposePdfGenerator
            Console.WriteLine("\nCharacter spacing specified successfully using Aspose Pdf Generator.\nFile saved at " + dataDir);
        }
        
    }
}