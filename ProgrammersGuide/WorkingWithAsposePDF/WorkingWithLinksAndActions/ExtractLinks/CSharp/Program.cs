//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;
using Aspose.Pdf.InteractiveFeatures.Annotations;
using System.Collections;

namespace ExtractLinks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");


            //Open document
            Document document = new Document(dataDir+ "input.pdf");

            //Extract actions
            Page page = document.Pages[1];
            AnnotationSelector selector = new AnnotationSelector(new LinkAnnotation(page, Aspose.Pdf.Rectangle.Trivial));
            page.Accept(selector);
            IList list = selector.Selected;

            Annotation annotation = (Annotation)list[0];

            //Save updated document
            document.Save(dataDir + "output.pdf");
            
        }
    }
}