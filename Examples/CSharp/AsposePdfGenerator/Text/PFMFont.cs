using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Text
{
    public class PFMFont
    {
        public static void Run()
        {
            
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Text();

            // Instantiate Pdf instance by calling it empty constructor
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Create a section in the Pdf object
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();
            // ExStart:PFMFont
            // Create a text object in a section
            Aspose.Pdf.Generator.Text t1 = new Aspose.Pdf.Generator.Text(sec1, "Arial Bold MT");

            // Set the font name of a segment in the text object
            t1.Segments[0].TextInfo.FontName = "Arial-BoldMT";

            // Set the PFM file for the text segment 
            t1.Segments[0].TextInfo.FontPfmFile = "_AB_____.PFM";

            // Set the font encoding file for the text segment
            t1.Segments[0].TextInfo.FontEncodingFile = @"CP1250.txt";

            // Set the font encoding name of the text segment
            t1.Segments[0].TextInfo.FontEncoding = "cp1250";
            // ExEnd:PFMFont
            dataDir = dataDir + "PFMFont_out_.pdf";
            // Create the result PDF Document
            pdf1.Save(dataDir);
            
        }
    }
}