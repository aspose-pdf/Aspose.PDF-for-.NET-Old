using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.UtilityFeatures
{
    public class CustomizingWatermark
    {
        public static void Run()
        {
            // ExStart:CustomizingWatermark
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_UtilityFeatures();

            // Instantiate the Pdf object
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Add a section to the Pdf object
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            Aspose.Pdf.Generator.Text text1 = new Aspose.Pdf.Generator.Text(sec1, "This is text in section1.");
            text1.Left = 30;
            text1.Top = 100;
            sec1.Paragraphs.Add(text1);
            Aspose.Pdf.Generator.Section sec2 = pdf1.Sections.Add();
            Aspose.Pdf.Generator.Text text2 = new Aspose.Pdf.Generator.Text(sec2, "This is text in section2.");
            text2.Left = 30;
            text2.Top = 100;
            sec2.Paragraphs.Add(text2);


            // Setting image watermark
            Aspose.Pdf.Generator.Image image1 = new Aspose.Pdf.Generator.Image();
            image1.ImageInfo.File = dataDir + "aspose-logo.jpg";
            image1.ImageInfo.ImageFileType = Aspose.Pdf.Generator.ImageFileType.Jpeg;
            image1.ImageScale = 0.1f;
            Aspose.Pdf.Generator.FloatingBox watermark1 = new Aspose.Pdf.Generator.FloatingBox(108, 80);           
            watermark1.BoxHorizontalPositioning = Aspose.Pdf.Generator.BoxHorizontalPositioningType.Page;
            watermark1.BoxHorizontalAlignment = Aspose.Pdf.Generator.BoxHorizontalAlignmentType.Center;
            watermark1.BoxVerticalPositioning = Aspose.Pdf.Generator.BoxVerticalPositioningType.Page;
            watermark1.BoxVerticalAlignment = Aspose.Pdf.Generator.BoxVerticalAlignmentType.Center;
            watermark1.Paragraphs.Add(image1);


            // Graph watermark
            Aspose.Pdf.Generator.Graph graph1 = new Aspose.Pdf.Generator.Graph(100, 400);
            float[] posArr = new float[] { 0, 0, 200, 80, 300, 40, 350, 90 };
            Aspose.Pdf.Generator.Curve curve1 = new Aspose.Pdf.Generator.Curve(graph1, posArr);
            graph1.Shapes.Add(curve1);
            Aspose.Pdf.Generator.FloatingBox watermark2 = new Aspose.Pdf.Generator.FloatingBox(108, 80);
            watermark2.Paragraphs.Add(graph1);


            // Text watermark
            Aspose.Pdf.Generator.Text text3 = new Aspose.Pdf.Generator.Text("Text Watermark");
            Aspose.Pdf.Generator.FloatingBox watermark3 = new Aspose.Pdf.Generator.FloatingBox(108, 80);
            watermark3.Left = 50;
            watermark3.Top = 500;
            watermark3.Paragraphs.Add(text3);


            pdf1.Watermarks.Add(watermark1);
            pdf1.Watermarks.Add(watermark2);
            pdf1.Watermarks.Add(watermark3);

            dataDir = dataDir + "CustomizingWatermark_out.pdf";
            // Save the Pdf
            pdf1.Save(dataDir);
            // ExEnd:CustomizingWatermark           
        }
       
    }
}