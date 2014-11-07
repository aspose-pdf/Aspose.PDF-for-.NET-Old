//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace SetTextBackgroundColor
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

//Create a section in the Pdf object
Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

//Create a text paragraph
Aspose.Pdf.Generator.Text text1 = new Aspose.Pdf.Generator.Text(sec1,"Hello Aspose.Pdf");

//Set the BackgroundColor of the text paragraph to Red
text1.TextInfo.BackgroundColor=new Aspose.Pdf.Generator.Color("Red");

//Add the text paragraph to the section
sec1.Paragraphs.Add(text1);

//Save the Pdf
pdf1.Save(dataDir+ "AsposeOutput.pdf");
            
            
        }
    }
}