//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace CSharp.AsposePdfGenerator.Text
{
    public class SetVerticalAlignment
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Text();

             // Create directory if it is not already present.
            bool IsExists = System.IO.Directory.Exists(dataDir);
            if (!IsExists)
                System.IO.Directory.CreateDirectory(dataDir);

            //Instantiate Pdf object by calling its empty constructor
Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

//Create a section in the Pdf object
Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

//Create a new text paragraph with an initial text segment "Aspose"
Aspose.Pdf.Generator.Text text1 = new Aspose.Pdf.Generator.Text(sec1,"Aspose");

//Add the text paragraph to the section
sec1.Paragraphs.Add(text1);

//Create a new text segment into the text paragraph
Aspose.Pdf.Generator.Segment seg2 = text1.Segments.Add("TM");

//Set the vertical alignment of text segment "seg2" to Topline by setting
//IsBaseline property  ot seg2.TextInfo to true
seg2.TextInfo.IsBaseline=false;
// set the font size information for the segment
seg2.TextInfo.FontSize = 5;


//Save the Pdf
pdf1.Save(dataDir+ "AsposeOutput.pdf");
            
            
        }
    }
}