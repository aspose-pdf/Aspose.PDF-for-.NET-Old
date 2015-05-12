//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace DrawXFormOnPageUsageOperators
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");


            string imageFile = dataDir+ "aspose-logo.jpg";
            string inFile = dataDir + "input.pdf";
            string outFile = dataDir + "blank-sample2-out.pdf";

            using (Document doc = new Document(inFile))
            {
                OperatorCollection pageContents = doc.Pages[1].Contents;

                // the sample demonstrates 
                // GSave/GRestore operators usage
                // ContatenateMatrix operator usage to position xForm
                // Do operator usage to draw xForm on page

                // wrap existing contents with GSave/GRestore operators pair
                //        this is to get initial graphics state at the and of existing contents
                //        otherwise there might remain some undesirable transformations at the end of existing operators chain
                pageContents.Insert(1, new Operator.GSave());
                pageContents.Add(new Operator.GRestore());

                // add save graphics state operator to properly clear graphics state after new commands
                pageContents.Add(new Operator.GSave());

                #region create xForm

                // create xForm
                XForm form = XForm.CreateNewForm(doc.Pages[1], doc);
                doc.Pages[1].Resources.Forms.Add(form);
                form.Contents.Add(new Operator.GSave());
                // define image width and heigh
                form.Contents.Add(new Operator.ConcatenateMatrix(200, 0, 0, 200, 0, 0));
                // load image into stream
                Stream imageStream = new FileStream(imageFile, FileMode.Open);
                // add image to Images collection of the XForm Resources
                form.Resources.Images.Add(imageStream);
                XImage ximage = form.Resources.Images[form.Resources.Images.Count];
                // using Do operator: this operator draws image
                form.Contents.Add(new Operator.Do(ximage.Name));
                form.Contents.Add(new Operator.GRestore());

                #endregion


                pageContents.Add(new Operator.GSave());
                // place form to the x=100 y=500 coordinates
                pageContents.Add(new Operator.ConcatenateMatrix(1, 0, 0, 1, 100, 500));
                // draw form with Do operator
                pageContents.Add(new Operator.Do(form.Name));
                pageContents.Add(new Operator.GRestore());

                pageContents.Add(new Operator.GSave());
                // place form to the x=100 y=300 coordinates
                pageContents.Add(new Operator.ConcatenateMatrix(1, 0, 0, 1, 100, 300));
                // draw form with Do operator
                pageContents.Add(new Operator.Do(form.Name));
                pageContents.Add(new Operator.GRestore());

                // restore grahics state with GRestore after the GSave
                pageContents.Add(new Operator.GRestore());

                doc.Save(outFile);
            }
            
        }
    }
}