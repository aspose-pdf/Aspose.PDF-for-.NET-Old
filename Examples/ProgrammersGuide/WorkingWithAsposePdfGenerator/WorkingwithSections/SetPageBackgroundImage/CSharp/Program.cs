//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace SetPageBackgroundImage
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

            //Assign the image file path to BackgroundImageFile property of section
            section1.BackgroundImageFile = dataDir+ "aspose-logo.jpg";

            //Set the image type using ImageFileType enumeration
            section1.BackgroundImageType = Aspose.Pdf.Generator.ImageFileType.Jpeg;
            //Save Pdf Document

            pdf.Save(dataDir+ "Aspose.pdf");
        }
    }
}