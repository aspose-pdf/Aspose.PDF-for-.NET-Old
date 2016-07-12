using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Generator;
namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Conversion
{
    public class HTMLToPDFUsingStream
    {
        public static void Run()
        {
            // ExStart:HTMLToPDFUsingStream
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Conversion();
            // Instantiate Pdf object
            Aspose.Pdf.Generator.Pdf pdf = new Aspose.Pdf.Generator.Pdf();
            // Specify the Character encoding for HTML file
            pdf.HtmlInfo.CharSet = "UTF-8";
            pdf.HtmlInfo.CharsetApplyingLevelOfForce = HtmlInfo.CharsetApplyingForceLevel.UseWhenImpossibleDetectFromContent;
            // Load the HTML file to Stream object
            using (Stream htmlAsStream = System.IO.File.OpenRead(dataDir + "resultant.html"))
            {
                // Bind the source HTML
                pdf.BindHTML(htmlAsStream, "");
            }
            // Save the PDF file
            pdf.Save(dataDir + "HTMLToPDFUsingStream_out_.pdf");
            // ExEnd:HTMLToPDFUsingStream
        }
        public static void EnforceUseAlways()
        {
            // ExStart:EnforceUseAlways
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Conversion();
            // Instantiate Pdf object
            Aspose.Pdf.Generator.Pdf pdf = new Aspose.Pdf.Generator.Pdf();
            // Specify the Character encoding for HTML file
            pdf.HtmlInfo.CharSet = "UTF-8";
            pdf.HtmlInfo.CharsetApplyingLevelOfForce = HtmlInfo.CharsetApplyingForceLevel.EnforceUseAlways;
            // Load the HTML file to Stream object
            using (Stream htmlAsStream = System.IO.File.OpenRead(dataDir + "resultant.html"))
            {
                // Bind the source HTML
                pdf.BindHTML(htmlAsStream, "");
            }
            // Save the PDF file
            pdf.Save(dataDir + "EnforceUseAlways_out_.pdf");
            // ExEnd:EnforceUseAlways
        }
    }
}