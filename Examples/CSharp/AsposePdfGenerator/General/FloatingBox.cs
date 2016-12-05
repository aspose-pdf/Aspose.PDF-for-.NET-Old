using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.General
{
    public class FloatingBoxLook
    {
        public static void Run()
        {
            try
            {
                // ExStart:FloatingBoxLook
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_General();
                               
                // Instantiate Pdf instance by calling its empty constructor
                Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();
                // Create section object and add it to sections collection of PDF
                Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

                // Create FloatingBox with 108 as width and 80 as height
                Aspose.Pdf.Generator.FloatingBox box1 = new Aspose.Pdf.Generator.FloatingBox(108, 80);
                // Add FloatingBox to paragraphs collection of section object
                sec1.Paragraphs.Add(box1);
                // ExStart:FloatingBoxPositionEnum 
                box1.BoxHorizontalPositioning = Aspose.Pdf.Generator.BoxHorizontalPositioningType.Margin;
                box1.BoxHorizontalAlignment = Aspose.Pdf.Generator.BoxHorizontalAlignmentType.Right;
                box1.BoxVerticalPositioning = Aspose.Pdf.Generator.BoxVerticalPositioningType.Page;
                box1.BoxVerticalAlignment = Aspose.Pdf.Generator.BoxVerticalAlignmentType.Center;
                // ExEnd:FloatingBoxPositionEnum
                // Add sample text string to paragraphs collection of FloatingBox object
                box1.Paragraphs.Add(new Aspose.Pdf.Generator.Text("Hello."));

                dataDir = dataDir + "FloatingBox_out.pdf";
                // Save the resultant PDF
                pdf1.Save(dataDir);
                // ExEnd:FloatingBoxLook
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");
            }
            
        }
    }
}