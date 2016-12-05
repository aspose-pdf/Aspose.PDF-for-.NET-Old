using System.IO;
using System;
using Aspose.Pdf;
using System.Text;
using System.Xml;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Text
{
    public class InlineRadioButton
    {
        public static void Run()
        {
            try
            {
                // ExStart:InlineRadioButton
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Text();

                // Create Pdf Instance
                Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

                // Add A Section
                Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

                // Add Text Paragraph
                Aspose.Pdf.Generator.Text text1 = new Aspose.Pdf.Generator.Text();
                // Add Text Paragraph to paragraphs collection of section
                sec1.Paragraphs.Add(text1);
                // Add a segment with sample text to segments collection of Text Paragraph
                text1.Segments.Add("This is a test for inline radiobutton:    ");

                // Specify Inline Radio button field name
                text1.InlineRadioButtonFieldName = "inlineradio";
                // Specify the checked index for inline radio button
                text1.InlineRadioButtonCheckedIndex = 1;

                // Add segments
                Aspose.Pdf.Generator.Segment seg1 = text1.Segments.Add();

                // 1st Radio Button and set the Inline Paragraph property of segment equal to radioButton  
                Aspose.Pdf.Generator.RadioButton radio1 = new Aspose.Pdf.Generator.RadioButton();
                seg1.InlineParagraph = radio1;

                Aspose.Pdf.Generator.Segment seg11 = text1.Segments.Add("radio1  ");
                Aspose.Pdf.Generator.Segment seg2 = text1.Segments.Add();

                Aspose.Pdf.Generator.RadioButton radio2 = new Aspose.Pdf.Generator.RadioButton();
                radio2.ID = "radio2";
                seg2.InlineParagraph = radio2;

                Aspose.Pdf.Generator.Segment seg22 = text1.Segments.Add("radio2  ");
                Aspose.Pdf.Generator.Segment seg3 = text1.Segments.Add();
                Aspose.Pdf.Generator.RadioButton radio3 = new Aspose.Pdf.Generator.RadioButton();
                seg3.InlineParagraph = radio3;

                Aspose.Pdf.Generator.Segment seg33 = text1.Segments.Add("radio3  ");
                
                // Save the document
                pdf1.Save(dataDir + "InlineRadioButton_out.pdf");
                // ExEnd:InlineRadioButton
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

