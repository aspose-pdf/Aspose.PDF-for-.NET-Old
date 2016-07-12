using System.IO;
using System;
using Aspose.Pdf;
using System.Collections;
namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Operators
{
    public class RemoveGraphicsObjects
    {
        public static void Run()
        {
            // ExStart:RemoveGraphicsObjects
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Operators();

            Document doc = new Document(dataDir+ "RemoveGraphicsObjects.pdf");
            Page page = doc.Pages[2];
            OperatorCollection oc = page.Contents;

            // Used path-painting operators
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
            doc.Save(dataDir+ "No_Graphics_out_.pdf");
            // ExEnd:RemoveGraphicsObjects
        }
    }
}