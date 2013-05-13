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
using System;

namespace SearchAndGetTextSegmentsFromAllPagesOfPDF
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
            
            //accept the absorber for all the pages
            pdfDocument.Pages.Accept(textFragmentAbsorber);
            
            //get the extracted text fragments
            TextFragmentCollection textFragmentCollection = textFragmentAbsorber.TextFragments;
            
            //loop through the fragments
            foreach (TextFragment textFragment in textFragmentCollection)
            {
                foreach (TextSegment textSegment in textFragment.Segments)
                {
                    Console.WriteLine("Text : {0} ", textSegment.Text);
                    Console.WriteLine("Position : {0} ", textSegment.Position);
                    Console.WriteLine("XIndent : {0} ", textSegment.Position.XIndent);
                    Console.WriteLine("YIndent : {0} ", textSegment.Position.YIndent);
                    Console.WriteLine("Font - Name : {0}", textSegment.TextState.Font.FontName);
                    Console.WriteLine("Font - IsAccessible : {0} ", textSegment.TextState.Font.IsAccessible);
                    Console.WriteLine("Font - IsEmbedded : {0} ", textSegment.TextState.Font.IsEmbedded);
                    Console.WriteLine("Font - IsSubset : {0} ", textSegment.TextState.Font.IsSubset);
                    Console.WriteLine("Font Size : {0} ", textSegment.TextState.FontSize);
                    Console.WriteLine("Foreground Color : {0} ", textSegment.TextState.ForegroundColor);
                }

            }
        }
    }
}