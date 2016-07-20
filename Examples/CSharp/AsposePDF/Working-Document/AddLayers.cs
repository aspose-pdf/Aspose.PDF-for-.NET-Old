using System.IO;
using Aspose.Pdf;
using System.Collections;
using System.Collections.Generic;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments
{
    public class AddLayers
    {
        public static void Run()
        {
            // ExStart:AddLayers
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            Document doc = new Document();
            Page page = doc.Pages.Add();
            Layer layer = new Layer("oc1", "Red Line");
            layer.Contents.Add(new Operator.SetRGBColorStroke(1, 0, 0));
            layer.Contents.Add(new Operator.MoveTo(500, 700));
            layer.Contents.Add(new Operator.LineTo(400, 700));
            layer.Contents.Add(new Operator.Stroke());
            page.Layers = new  List<Layer>();
            page.Layers.Add(layer);
            layer = new Layer("oc2", "Green Line");
            layer.Contents.Add(new Operator.SetRGBColorStroke(0, 1, 0));
            layer.Contents.Add(new Operator.MoveTo(500, 750));
            layer.Contents.Add(new Operator.LineTo(400, 750));
            layer.Contents.Add(new Operator.Stroke());
            page.Layers.Add(layer);
            layer = new Layer("oc3", "Blue Line");
            layer.Contents.Add(new Operator.SetRGBColorStroke(0, 0, 1));
            layer.Contents.Add(new Operator.MoveTo(500, 800));
            layer.Contents.Add(new Operator.LineTo(400, 800));
            layer.Contents.Add(new Operator.Stroke());
            page.Layers.Add(layer);
            dataDir = dataDir + "AddLayers_out_.pdf";
            doc.Save(dataDir);
            // ExEnd:AddLayers
            Console.WriteLine("\nLayers added successfully to PDF file.\nFile saved at " + dataDir);
        }
    }
}