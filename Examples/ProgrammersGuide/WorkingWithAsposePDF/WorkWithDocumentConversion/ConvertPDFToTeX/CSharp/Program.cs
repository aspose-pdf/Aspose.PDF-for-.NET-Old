//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace ConvertPDFToTeX
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            // create Document object
            Aspose.Pdf.Document doc = new Aspose.Pdf.Document(dataDir + "input.pdf");

            // instantiate LaTex save option            
            LaTeXSaveOptions saveOptions = new LaTeXSaveOptions();

            // specify the output directory 
            string pathToOutputDirectory = dataDir;

            // set the output directory path for save option object
            saveOptions.OutDirectoryPath = pathToOutputDirectory;

            // save PDF file into LaTex format            
            doc.Save(dataDir + "Output.tex", saveOptions);
        }
    }
}