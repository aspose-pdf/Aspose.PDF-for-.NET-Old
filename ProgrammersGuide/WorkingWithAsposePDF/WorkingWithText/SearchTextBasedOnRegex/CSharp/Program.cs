//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;
using Aspose.Pdf.Text;
using Aspose.Pdf.Text.TextOptions;
using Aspose.Pdf.Facades;
using System;

namespace SearchTextBasedOnRegexExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");
            //create absorber object to find all instances of the input search phrase
            TextFragmentAbsorber absorber = new TextFragmentAbsorber("D[a-z]{7}:");
            //Enable regular expression search
            absorber.TextSearchOptions = new TextSearchOptions(true);
            //open document            
            PdfContentEditor editor = new PdfContentEditor();
            // bind source PDF file
            editor.BindPdf(dataDir+ "Input_new.pdf");
            //accept the absorber for the page
            editor.Document.Pages[1].Accept(absorber);

            int[] dashArray = { };
            String[] LEArray = { };
            System.Drawing.Color blue = System.Drawing.Color.Blue;

            //loop through the fragments
            foreach (TextFragment textFragment in absorber.TextFragments)
            {
                textFragment.TextState.ForegroundColor = Aspose.Pdf.Color.Blue;
                System.Drawing.Rectangle rect = new System.Drawing.Rectangle((int)textFragment.Rectangle.LLX,
                    (int)Math.Round(textFragment.Rectangle.LLY), (int)Math.Round(textFragment.Rectangle.Width + 2),
                    (int)Math.Round(textFragment.Rectangle.Height + 1));
                Enum[] actionName = new Enum[2] { Aspose.Pdf.InteractiveFeatures.PredefinedAction.Document_AttachFile, Aspose.Pdf.InteractiveFeatures.PredefinedAction.Document_ExtractPages };
                editor.CreateWebLink(rect, "http://www.aspose.com", 1, blue, actionName);
                editor.CreateLine(rect, "", (float)textFragment.Rectangle.LLX + 1, (float)textFragment.Rectangle.LLY - 1,
                    (float)textFragment.Rectangle.URX, (float)textFragment.Rectangle.LLY - 1, 1, 1, blue, "S", dashArray, LEArray);
            }
            //Save & Close the document
            editor.Save(dataDir+ "TextReplaced_with_Links.pdf");
            editor.Close();
 
            
            
        }
    }
}