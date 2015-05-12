//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace AddTextExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");
            //create PdfFileMend object to add text
            PdfFileMend mender = new PdfFileMend(dataDir+ "input.pdf", dataDir+ "output.pdf");

            //create formatted text
            FormattedText text = new FormattedText("Aspose - Your File Format Experts!", System.Drawing.Color.AliceBlue, System.Drawing.Color.Gray, Aspose.Pdf.Facades.FontStyle.Courier, EncodingType.Winansi, true, 14);

            //set whether to use Word Wrap or not and using which mode
            mender.IsWordWrap = true;
            mender.WrapMode = WordWrapMode.Default;

            //add text in the PDF file
            mender.AddText(text, 1, 100, 200, 200, 400);

            //close PdfFileMend object
            mender.Close();
            
        }
    }
}