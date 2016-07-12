using System.IO;
using System.Net;
using Aspose.Pdf;
using System.Text;
namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Conversion
{
    public class WebToPDF
    {
        public static void Run()
        {
            // ExStart:WebToPDF
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Conversion();

            // The address of the web URL which you need to convert into PDF format
            string WebUrl = "http://en.wikipedia.org/wiki/Main_Page";
            // Create a Web Request object to connect to remote URL
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(WebUrl);
            // Set the Web Request timeout
            request.Timeout = 10000;     // 10 secs

            // Retrieve request info headers
            HttpWebResponse localWebResponse = (HttpWebResponse)request.GetResponse();
            // Windows default Code Page  (Include System.Text namespace in project)
            Encoding encoding = Encoding.GetEncoding(1252);
            // Read the contents of into StreamReader object
            StreamReader localResponseStream = new StreamReader(localWebResponse.GetResponseStream(), encoding);

            // Instantiate an object PDF class
            Aspose.Pdf.Generator.Pdf pdf = new Aspose.Pdf.Generator.Pdf();

            // Add the section to PDF document sections collection
            Aspose.Pdf.Generator.Section section = pdf.Sections.Add();

            // Create text paragraphs containing HTML text
            Aspose.Pdf.Generator.Text text2 = new Aspose.Pdf.Generator.Text(section, localResponseStream.ReadToEnd());           

            // Enable the property to display HTML contents within their own formatting
            text2.IsHtmlTagSupported = true;

            // Add the text object containing HTML contents to PD Sections
            section.Paragraphs.Add(text2);

            // Specify the URL which serves as images database
            // pdf.HtmlInfo.ImgUrl = "http://en.wikipedia.org/";
            // Save the pdf document            
            pdf.Save(dataDir + "WebToPDF_out_.pdf");
            localWebResponse.Close();
            localResponseStream.Close();            
            // ExEnd:WebToPDF
        }
    }
}