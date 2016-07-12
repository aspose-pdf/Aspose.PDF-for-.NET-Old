using System;
using System.IO;
using Aspose.Pdf;
using System.Web;
namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.AdvanceFeatures
{
    public class SendingPdfToBrowser
    {
        public static void Run()
        {
            // ExStart:SendingPdfToBrowser
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_AdvanceFeatures();

            // Instantiate Pdf instance by calling its empty constructor
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            MemoryStream stream = new MemoryStream();
            HttpResponse Response = new HttpResponse(null);
            pdf1.Save(stream);
            Response.Clear();
            Response.ClearHeaders();
            Response.ClearContent();
            Response.Charset = "UTF-8";
            Response.AddHeader("Content-Length", stream.Length.ToString());
            Response.AddHeader("content-disposition", String.Format("attachment;filename={0}", dataDir + "SendingPdfToBrowser.pdf"));
            Response.ContentType = "application/pdf";
            Response.BinaryWrite(stream.ToArray());
            Response.Flush();
            Response.End();
            // ExEnd:SendingPdfToBrowser           
        }
    }
}