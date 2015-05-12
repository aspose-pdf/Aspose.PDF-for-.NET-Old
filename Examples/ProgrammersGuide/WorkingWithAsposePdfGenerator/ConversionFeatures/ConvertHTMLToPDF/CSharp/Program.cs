//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace ConvertHTMLToPDF
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            // Instantiate an object PDF class
            Aspose.Pdf.Generator.Pdf pdf = new Aspose.Pdf.Generator.Pdf();
            
            // add the section to PDF document sections collection
            Aspose.Pdf.Generator.Section section = pdf.Sections.Add();

            // Read the contents of HTML file into StreamReader object
            StreamReader r = File.OpenText(dataDir + "Aspose.htm");
            
            //Create text paragraphs containing HTML text
            Aspose.Pdf.Generator.Text text2 = new Aspose.Pdf.Generator.Text(section, r.ReadToEnd());
            
            // enable the property to display HTML contents within their own formatting
            text2.IsHtmlTagSupported = true;
            
            //Add the text paragraphs containing HTML text to the section
            section.Paragraphs.Add(text2);
            
            // Specify the URL which serves as images database
            //pdf.HtmlInfo.ImgUrl = "D:/pdftest/MemoryStream/";

            //Save the pdf document
            pdf.Save(dataDir + "HTML2pdf.pdf");

        }
    }
}