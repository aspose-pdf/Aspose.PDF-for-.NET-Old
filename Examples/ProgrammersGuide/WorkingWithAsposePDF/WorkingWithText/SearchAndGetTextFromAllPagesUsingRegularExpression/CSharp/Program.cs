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
using Aspose.Pdf.Text.TextOptions;
using System;

namespace SearchAndGetTextFromAllPagesUsingRegularExpression
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //open document
            Document pdfDocument = new Document(dataDir + "input.pdf");
            
            //create TextAbsorber object to find all the phrases matching the regular expression
            TextFragmentAbsorber textFragmentAbsorber = new TextFragmentAbsorber("\\d{4}-\\d{4}"); //like 1999-2000
            
            //set text search option to specify regular expression usage
            TextSearchOptions textSearchOptions = new TextSearchOptions(true);
            
            textFragmentAbsorber.TextSearchOptions = textSearchOptions;
            
            //accept the absorber for all the pages
            pdfDocument.Pages.Accept(textFragmentAbsorber);
            
            //get the extracted text fragments
            TextFragmentCollection textFragmentCollection = textFragmentAbsorber.TextFragments;
            
            //loop through the fragments
            foreach (TextFragment textFragment in textFragmentCollection)
            {
                Console.WriteLine("Text : {0} ", textFragment.Text);
                Console.WriteLine("Position : {0} ", textFragment.Position);
                Console.WriteLine("XIndent : {0} ", textFragment.Position.XIndent);
                Console.WriteLine("YIndent : {0} ", textFragment.Position.YIndent);
                Console.WriteLine("Font - Name : {0}", textFragment.TextState.Font.FontName);
                Console.WriteLine("Font - IsAccessible : {0} ", textFragment.TextState.Font.IsAccessible);
                Console.WriteLine("Font - IsEmbedded : {0} ", textFragment.TextState.Font.IsEmbedded);
                Console.WriteLine("Font - IsSubset : {0} ", textFragment.TextState.Font.IsSubset);
                Console.WriteLine("Font Size : {0} ", textFragment.TextState.FontSize);
                Console.WriteLine("Foreground Color : {0} ", textFragment.TextState.ForegroundColor);
            } 
        }
    }
}