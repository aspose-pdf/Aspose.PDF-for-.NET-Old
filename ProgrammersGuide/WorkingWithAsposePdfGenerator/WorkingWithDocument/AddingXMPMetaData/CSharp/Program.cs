//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace AddingXMPMetaData
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


            //Instantiate a PDF Object 
            Aspose.Pdf.Generator.Pdf pdf = new Aspose.Pdf.Generator.Pdf();

            //Add a section into the pdf document
            Aspose.Pdf.Generator.Section section1 = pdf.Sections.Add();

            // create a sample text paragraph
            Aspose.Pdf.Generator.Text text1 = new Aspose.Pdf.Generator.Text("This is a test for XMP Metadata");
            // Add text paragraph to paragraphs collection of section object
            section1.Paragraphs.Add(text1);

            // create XmpMetaData object
            pdf.XmpMetadata = new Aspose.Pdf.Generator.XmpMetadata();

            //core properties
            pdf.XmpMetadata.AddCreationDate(System.DateTime.Now.ToString());

            //user properties
            pdf.XmpMetadata.AddUserProperty("xmlns:dc=\"http://purl.org/dc/elements/1.1/\"", "dc:contributor", "Aspose");

            //Save Pdf Document
            pdf.Save(dataDir+ "Aspose.pdf");
            
            
        }
    }
}