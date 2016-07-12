using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Text;
using System;
namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class AddHTMLUsingDOM
    {
        public static void Run()
        {
            // ExStart:AddHTMLUsingDOM
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();

            // Instantiate Document object
            Document doc = new Document();
            // Add a page to pages collection of PDF file
            Page page = doc.Pages.Add();
            // Instantiate HtmlFragment with HTML contnets
            HtmlFragment titel = new HtmlFragment("<fontsize=10><b><i>Table</i></b></fontsize>");
            // Set bottom margin information
            titel.Margin.Bottom = 10;
            // Set top margin information
            titel.Margin.Top = 200;
            // Add HTML Fragment to paragraphs collection of page
            page.Paragraphs.Add(titel);

            dataDir = dataDir + "AddHTMLUsingDOM_out_.pdf";
            // Save PDF file
            doc.Save(dataDir);

            // ExEnd:AddHTMLUsingDOM            
            Console.WriteLine("\nHTML using DOM added successfully.\nFile saved at " + dataDir);
        }
    }
}