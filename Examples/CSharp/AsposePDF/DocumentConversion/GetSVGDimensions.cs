//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace CSharp.AsposePdf.DocumentConversion
{
    public class GetSVGDimensions
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();
            
            var loadopt = new SvgLoadOptions();
            loadopt.AdjustPageSize = true;
            var svgDoc = new Document(dataDir + "Example.svg", loadopt);
            svgDoc.Pages[1].PageInfo.Margin.Top = 0;
            svgDoc.Pages[1].PageInfo.Margin.Left = 0;
            svgDoc.Pages[1].PageInfo.Margin.Bottom = 0;
            svgDoc.Pages[1].PageInfo.Margin.Right = 0;
            svgDoc.Save(dataDir + "SVG_test.pdf");
        }
    }
}