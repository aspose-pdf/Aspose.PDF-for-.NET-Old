using System;
using System.IO;
using Aspose.Pdf;
namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.WorkingDocuments
{
    public class AddJavaScript
    {
        public static void Run()
        {
            // ExStart:AddJavaScript
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_WorkingDocuments();
            
            // Instantiate a PDF Object 
            Aspose.Pdf.Generator.Pdf pdf = new Aspose.Pdf.Generator.Pdf();

            // Instantiate a Aspose PDF JavaScript Object
            pdf.JavaScripts = new Aspose.Pdf.Generator.JavaScripts();

            // Call the Add method and pass JavaScript statement as an argument, to show Print Dialog
            pdf.JavaScripts.Add("this.print(true);");

            // Call the Add method and JavaScript statement as an argument, to show alert
            pdf.JavaScripts.Add("app.alert(\"hello world\");");
            dataDir = dataDir + "AddJavaScript_out_.pdf";
            // Save Pdf Document
            pdf.Save(dataDir);
            // ExEnd:AddJavaScript
            Console.WriteLine("\nJavascript added successfully.\nFile saved at " + dataDir);
            
        }
    }
}