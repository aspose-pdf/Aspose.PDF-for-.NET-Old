using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.AdvanceFeatures
{
    public class TableMinimumColumnWidth
    {
        public static void Run()
        {
            // ExStart:TableMinimumColumnWidth
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_AdvanceFeatures();

            // Instantiate Pdf instance by calling its empty constructor
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Add a section in the Pdf
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            // Create a table object and add it to the paragraphs collection of the section        
            Aspose.Pdf.Generator.Table tab1 = new Aspose.Pdf.Generator.Table();
            sec1.Paragraphs.Add(tab1);

            // Set the column widths and default cell border of the table
            tab1.ColumnWidths = "60 100 100";
            tab1.DefaultCellBorder = new Aspose.Pdf.Generator.BorderInfo((int)Aspose.Pdf.Generator.BorderSide.All, 1F);

            // Prepare an array of string values to be added to table
            string[] darr = new string[]
        {"Owner/Marketing Assistant","dhasf hh ddt", "dhaosdha djsd dsads",
                "dsd dajd", "hdsah jj jj jdj", "ddfa jjj jhdusa"};

            // Import the contents of the array created in above step
            tab1.ImportArray(darr, 0, 0, true);

            // Call GetMinColumnWidth and pass the column number whose minimum width is needed
            float width = tab1.GetMinColumnWidth(pdf1, 0);

            // Call SetColumnWidth and pass the column number with minimum width
            tab1.SetColumnWidth(0, width);                                

            dataDir = dataDir + "TableMinimumColumnWidth_out_.pdf";
            // Save the Pdf
            pdf1.Save(dataDir);
            // ExEnd:TableMinimumColumnWidth           
        }
    }
}