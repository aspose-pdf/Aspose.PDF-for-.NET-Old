using System.IO;
using Aspose.Pdf;
using System;
using System.Net;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion
{
    public class ProvideCredentialsDuringHTMLToPDF
    {
        public static void Run()
        {
            try
            {
                // ExStart:ProvideCredentialsDuringHTMLToPDF
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();

                // Create a request for the URL.
                WebRequest request = WebRequest.Create("http://my.signchart.com/Report/PrintBook.asp?ProjectGuid=6FB9DBB0-");
                // If required by the server, set the credentials.
                request.Credentials = CredentialCache.DefaultCredentials;
                // Get the response.
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                // Get the stream containing content returned by the server.
                Stream dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
                response.Close();

                MemoryStream stream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(responseFromServer));

                HtmlLoadOptions options = new HtmlLoadOptions("http://my.signchart.com/");
                options.ExternalResourcesCredentials = CredentialCache.DefaultCredentials;

                // load HTML file
                Document pdfDocument = new Document(stream, options);
                // save resultant file
                pdfDocument.Save("ProvideCredentialsDuringHTMLToPDF_out_.pdf");
                // ExEnd:ProvideCredentialsDuringHTMLToPDF
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }        
    }
}