//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;
using Aspose.Pdf.Text;

namespace ReplaceTextInSinglePageOfPDF
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //open document
            Document pdfDocument = new Document(dataDir + "input.pdf");
            
            //create TextAbsorber object to find all instances of the input search phrase
            TextFragmentAbsorber textFragmentAbsorber = new TextFragmentAbsorber("text");
            
            //accept the absorber for a particular page
            pdfDocument.Pages[2].Accept(textFragmentAbsorber);
            
            //get the extracted text fragments
            TextFragmentCollection textFragmentCollection = textFragmentAbsorber.TextFragments;
            
            //loop through the fragments
            foreach (TextFragment textFragment in textFragmentCollection)
            {
                //update text and other properties
                textFragment.Text = "New Phrase";
                textFragment.TextState.Font = FontRepository.FindFont("Verdana");
                textFragment.TextState.FontSize = 22;
                textFragment.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Blue);
                textFragment.TextState.BackgroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Green);
            }

            pdfDocument.Save(dataDir + "output.pdf");
        }
    }
}