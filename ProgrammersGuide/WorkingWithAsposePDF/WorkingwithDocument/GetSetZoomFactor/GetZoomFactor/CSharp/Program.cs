//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;
using Aspose.Pdf.InteractiveFeatures;

namespace GetZoomFactor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            // instantiate new Document object
            Document doc = new Document(dataDir + "Zoomed_pdf.pdf");

            // create GoToAction object
            GoToAction action = doc.OpenAction as GoToAction;
            
            // get the Zoom factor of PDF file
            System.Console.WriteLine((action.Destination as XYZExplicitDestination).Zoom); // Document zoom value;
        }
    }
}