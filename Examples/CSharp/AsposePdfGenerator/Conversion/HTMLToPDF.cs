using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Generator;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Conversion
{
    public class HTMLToPDF
    {
        public static void Run()
        {
            // ExStart:HTMLToPDF
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Conversion();

            // Instantiate an object PDF class
            Aspose.Pdf.Generator.Pdf pdf = new Aspose.Pdf.Generator.Pdf();
            
            // Add the section to PDF document sections collection
            Aspose.Pdf.Generator.Section section = pdf.Sections.Add();

            // Read the contents of HTML file into StreamReader object
            StreamReader r = File.OpenText(dataDir + "resultant.html");
            
            // Create text paragraphs containing HTML text
            Aspose.Pdf.Generator.Text text2 = new Aspose.Pdf.Generator.Text(section, r.ReadToEnd());
            
            // Enable the property to display HTML contents within their own formatting
            text2.IsHtmlTagSupported = true;

            // ExStart:OverwriteFontNames
            text2.IfHtmlTagSupportedOverwriteHtmlFontNames = true;
            text2.IfHtmlTagSupportedOverwriteHtmlFontSizes = true;
            // ExEnd:OverwriteFontNames            

            // Add the text paragraphs containing HTML text to the section
            section.Paragraphs.Add(text2);
            
            // Specify the URL which serves as images database
            pdf.HtmlInfo.ImgUrl = dataDir;

            // ExStart:SpecialCharacters
            // Following properties are added from Aspose.Pdf for .NET 8.4.0
            pdf.HtmlInfo.BadHtmlHandlingStrategy = BadHtmlHandlingStrategy.TreatAsPlainText;
            pdf.HtmlInfo.ShowUnknownHtmlTagsAsText = true;
            // ExEnd:SpecialCharacters

            // Save the Pdf document
            pdf.Save(dataDir + "HTML2pdf_out_.pdf");
            // ExEnd:HTMLToPDF
        }
    }
}