//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace ChangeTextFormat
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            // Create directory if it is not already present.
            bool IsExists = System.IO.Directory.Exists(dataDir);
            if (!IsExists)
                System.IO.Directory.CreateDirectory(dataDir);

            //Instantiate Pdf instance by calling its empty constructor
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            //Create a new section in the Pdf object
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            //Set text color to blue in the whole section 
            sec1.TextInfo.Color = new Aspose.Pdf.Generator.Color("Blue");

            //Add 1st paragraph (inheriting the text format settings from the section)
            //to the section 
            sec1.Paragraphs.Add(new Aspose.Pdf.Generator.Text(sec1, "paragraph 1 "));

            //Add 2nd paragraph (inheriting the text format settings from the section)
            //to the section
            sec1.Paragraphs.Add(new Aspose.Pdf.Generator.Text(sec1, "paragraph 2"));

            //Create 3rd paragraph (inheriting the text format settings from the section) 
            Aspose.Pdf.Generator.Text t3 = new Aspose.Pdf.Generator.Text(sec1);

            //Create a segment "seg1" in the paragraph "t3"
            Aspose.Pdf.Generator.Segment seg1 = new Aspose.Pdf.Generator.Segment(t3);

            //Assign some content to the segment
            seg1.Content = "paragraph 3 segment 1";

            //Set the color of the segment to red
            seg1.TextInfo.Color = new Aspose.Pdf.Generator.Color("Red");

            //Add segment (with red text color) to the paragraph
            t3.Segments.Add(seg1);

            //Create a new segment "seg2" in the paragraph "t3"
            Aspose.Pdf.Generator.Segment seg2 = new Aspose.Pdf.Generator.Segment(t3);

            //Assign some content to the segment
            seg2.Content = "paragraph 3 segment 2";

            //Set the color of the segment to green
            seg2.TextInfo.Color = new Aspose.Pdf.Generator.Color("Green");

            //Add segment (with green text color) to the paragraph
            t3.Segments.Add(seg2);

            //Add 3rd text paragraph to the section with overridden text format settings
            sec1.Paragraphs.Add(t3);

            //Add 4th paragraph (inheriting the text format settings from the section)
            //to the section
            sec1.Paragraphs.Add(new Aspose.Pdf.Generator.Text(sec1, "paragraph 4"));

            Aspose.Pdf.Generator.TextInfo info1 = t3.TextInfo.Clone() as Aspose.Pdf.Generator.TextInfo;

            //Modify the font side to 16 pt
            info1.FontSize = 16;

            //Set TextInfo property of the text paragraph to newly cloned instance "info1"
            t3.TextInfo = info1;

            //save the document
            pdf1.Save(dataDir + "output.pdf"); 
            
        }
    }
}