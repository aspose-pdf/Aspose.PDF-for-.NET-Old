//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace CSharp.AsposePdfGenerator.Paragraphs
{
    public class AssignID
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Paragraphs();
            // Create directory if it is not already present.
            bool IsExists = System.IO.Directory.Exists(dataDir);
            if (!IsExists)
                System.IO.Directory.CreateDirectory(dataDir);

            //Instantiate Pdf object by calling its empty constructor
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf(); 

            //Add a new section to the Pdf object
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add(); 

            //Create a text paragraph with the reference of a section, sec1
            Aspose.Pdf.Generator.Text text3 = new Aspose.Pdf.Generator.Text(sec1, "product 1 info ...");

            //Add the text paragraph in the section
            sec1.Paragraphs.Add(text3);

            //Set the text paragraph to be the first paragraph among the other ones
            text3.IsFirstParagraph = true;

            //Assign and ID to the text paragraph
            text3.ID = "product1";

            // save the resultant PDF
            pdf1.Save(dataDir+ "ParaID.pdf");
            
        }
    }
}