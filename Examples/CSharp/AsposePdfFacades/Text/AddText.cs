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

namespace CSharp.AsposePDFFacades.Text
{
    public class AddText
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Text();

            //open document
            PdfFileMend mender = new PdfFileMend();

            //create PdfFileMend object to add text
            mender.BindPdf(dataDir + "AddText.pdf");

            //create formatted text
            FormattedText text = new FormattedText("Aspose - Your File Format Experts!", System.Drawing.Color.AliceBlue, System.Drawing.Color.Gray, Aspose.Pdf.Facades.FontStyle.Courier, EncodingType.Winansi, true, 14);

            //set whether to use Word Wrap or not and using which mode
            mender.IsWordWrap = true;
            mender.WrapMode = WordWrapMode.Default;

            //add text in the PDF file
            mender.AddText(text, 1, 100, 200, 200, 400);

            //save changes
            mender.Save(dataDir + "AddText_out.pdf");

            //close PdfFileMend object
            mender.Close();
            
        }
    }
}