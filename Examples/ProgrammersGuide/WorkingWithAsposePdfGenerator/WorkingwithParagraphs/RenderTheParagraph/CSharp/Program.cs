//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace RenderTheParagraph
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

            //Create a section in the Pdf document
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            //Add a text paragraph in the section
            sec1.Paragraphs.Add(new Aspose.Pdf.Generator.Text("page 1"));

            //Create another text paragraph that has to be rendered
            Aspose.Pdf.Generator.Text t2 = new Aspose.Pdf.Generator.Text("page2");

            //Set the IsFirstParagraph property of the text paragraph to true
            //to render it to a new page
            t2.IsFirstParagraph = true;

            //Add the text paragraph to be rendered to the section
            sec1.Paragraphs.Add(t2);

            //Save the Pdf document
            pdf1.Save(dataDir+ "HelloWorld.pdf");
            
            
        }
    }
}