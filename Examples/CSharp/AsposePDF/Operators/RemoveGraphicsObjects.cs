//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;
using System.Collections;

namespace CSharp.AsposePdf.Operators
{
    public class RemoveGraphicsObjects
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Operators();

            Document doc = new Document(dataDir+ "RemoveGraphicsObjects.pdf");
            Page page = doc.Pages[2];
            OperatorCollection oc = page.Contents;

            // used path-painting operators
            Operator[] operators = new Operator[] {
new Operator.Stroke(),
new Operator.ClosePathStroke(),
new Operator.Fill()
};

            ArrayList list = new ArrayList();
            foreach (Operator op in operators)
            {
                OperatorSelector os = new OperatorSelector(op);
                oc.Accept(os);
                list.AddRange(os.Selected);
            }

            oc.Delete(list);

            doc.Save(dataDir+ "No_Graphics.pdf");
            
            
        }
    }
}