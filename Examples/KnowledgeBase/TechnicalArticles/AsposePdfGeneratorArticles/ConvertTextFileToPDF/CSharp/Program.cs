//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace ConvertTextFileToPDF
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //read the source text file
            System.IO.TextReader tr = new StreamReader(dataDir + "test.txt");

            //Instantiate Pdf pbject by calling its empty constructor
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            //Create a new section in the Pdf object
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            //Create a new text paragraph and pass the text to its constructor as argument
            Aspose.Pdf.Generator.Text t2 = new Aspose.Pdf.Generator.Text(tr.ReadToEnd());
            sec1.Paragraphs.Add(t2);

            pdf1.Save(dataDir + "output.pdf");
        }
    }
}