//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;
using System.Collections;

namespace AddLayersToPDFFileExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            Document doc = new Document();
            Page page = doc.Pages.Add();
            Layer layer = new Layer("oc1", "Red Line");
            layer.Contents.Add(new Operator.SetRGBColorStroke(1, 0, 0));
            layer.Contents.Add(new Operator.MoveTo(500, 700));
            layer.Contents.Add(new Operator.LineTo(400, 700));
            layer.Contents.Add(new Operator.Stroke());
            page.Layers = new ArrayList();
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
            doc.Save(dataDir+ "output.pdf");
        }
    }
}