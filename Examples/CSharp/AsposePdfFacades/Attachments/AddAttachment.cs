
using System.IO;

using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Attachments
{
    public class AddAttachment
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Attachments();
            //open document
            PdfContentEditor contentEditor = new PdfContentEditor();
            contentEditor.BindPdf(dataDir+ "AddAttachment.pdf");

            //add attachment
            contentEditor.AddDocumentAttachment(dataDir+ "test.txt", "Attachment Description");

            //save updated PDF
            contentEditor.Save(dataDir+ "AddAttachment_out.pdf");
            
        }
    }
}