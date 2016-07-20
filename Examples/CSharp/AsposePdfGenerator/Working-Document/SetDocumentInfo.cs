using System.IO;
using Aspose.Pdf;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.WorkingDocuments
{
    public class SetDocumentInfo
    {
        public static void Run()
        {
            // ExStart:SetDocumentInfo
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_WorkingDocuments();
                      
            // Instantiate Pdf instance by calling its empty constructor
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Set the properties of Pdf instance
            pdf1.Author = "Naeem Akram";
            pdf1.Creator = "Aspose.Pdf";
            pdf1.Keywords = "Hello World";
            pdf1.Subject = "Example";
            pdf1.Title = "Example";
            dataDir = dataDir + "DocInfo_out_.pdf";
            pdf1.Save(dataDir);
            // ExEnd:SetDocumentInfo 
            Console.WriteLine("\nDocument Info setup successfully.\nFile saved at " + dataDir);
        }
    }
}