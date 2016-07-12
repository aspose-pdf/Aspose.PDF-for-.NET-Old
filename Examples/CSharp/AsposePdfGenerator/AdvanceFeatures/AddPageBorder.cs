using System;
using System.IO;
using Aspose.Pdf;
namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.AdvanceFeatures
{
    public class AddPageBorder
    {
        public static void Run()
        {
            // ExStart:AddPageBorder
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_AdvanceFeatures();

            // Instantiate Pdf instance by calling its empty constructor
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Add a section in the Pdf
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            // Set the page border of the section using BorderInfo object 
            sec1.PageInfo.PageBorder = new Aspose.Pdf.Generator.BorderInfo((int)Aspose.Pdf.Generator.BorderSide.All, 0.2F);

            // Set the left margin of page border of the section
            sec1.PageInfo.PageBorderMargin.Left = 20;

            // Add a text paragraph to the paragraphs collection of the section
            sec1.Paragraphs.Add(new Aspose.Pdf.Generator.Text("Hello World"));

            dataDir = dataDir + "AddPageBorder_out_.pdf";
            // Save the Pdf
            pdf1.Save(dataDir);
            // ExEnd:AddPageBorder           
        }
    }
}