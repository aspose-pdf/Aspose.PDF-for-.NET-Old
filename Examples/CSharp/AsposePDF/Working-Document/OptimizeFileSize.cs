using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments
{
    public class OptimizeFileSize
    {
        public static void Run()
        {
            // ExStart:OptimizeFileSize
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            // Open document
            Document pdfDocument = new Document(dataDir + "OptimizeDocument.pdf");

            // Optimzie the file size by removing unused objects
            pdfDocument.OptimizeResources(new Document.OptimizationOptions()
            {
                LinkDuplcateStreams = true,
                RemoveUnusedObjects = true,
                RemoveUnusedStreams = true,
                CompressImages = true,
                ImageQuality = 10
            });            
            dataDir = dataDir + "OptimizeFileSize_out_.pdf";
            // Save output document
            pdfDocument.Save(dataDir);
            // ExEnd:OptimizeFileSize
            Console.WriteLine("\nFile size optimized successfully.\nFile saved at " + dataDir);
        }
    }
}