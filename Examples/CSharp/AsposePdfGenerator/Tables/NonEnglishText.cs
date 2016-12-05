using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Tables
{
    public class NonEnglishText
    {
        public static void Run()
        {
            // ExStart:NonEnglishText
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Tables();

            // Instantiate the Pdf object by calling its empty constructor
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Create the section in the Pdf object
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            // Instantiate a table object
            Aspose.Pdf.Generator.Table tab1 = new Aspose.Pdf.Generator.Table();

            // Add the table in paragraphs collection of the desired section
            sec1.Paragraphs.Add(tab1);

            // Set with column widths of the table
            tab1.ColumnWidths = "110 120 50";

            // Set default cell border using BorderInfo object
            tab1.DefaultCellBorder = new Aspose.Pdf.Generator.BorderInfo((int)Aspose.Pdf.Generator.BorderSide.All, 0.1F);

            // Set table border using another customized BorderInfo object
            tab1.Border = new Aspose.Pdf.Generator.BorderInfo((int)Aspose.Pdf.Generator.BorderSide.All, 1F);

            // Create MarginInfo object and set its left, bottom, right and top margins
            Aspose.Pdf.Generator.MarginInfo margin = new Aspose.Pdf.Generator.MarginInfo();
            margin.Top = 5f;
            margin.Left = 5f;
            margin.Right = 5f;
            margin.Bottom = 5f;

            // Set the default cell padding to the MarginInfo object
            tab1.DefaultCellPadding = margin;

            // Create rows in the table and then cells in the rows
            Aspose.Pdf.Generator.Row row1 = tab1.Rows.Add();
            row1.DefaultCellTextInfo.FontName = "Arial Unicode MS";
            row1.Cells.Add("Arabic Sample مَرْحَبا بكِ كُلَّ الْتَرْحيبْ");
            row1.Cells[0].DefaultCellTextInfo.IsRightToLeft = true;

            // Row1.Cells[0].DefaultCellTextInfo.FontName = "Arial Unicode MS";
            row1.Cells.Add("Persian alphabet الفبای فارسی");
            row1.Cells[1].DefaultCellTextInfo.IsRightToLeft = true;

            // Row1.Cells[1].DefaultCellTextInfo.FontName = "Arial Unicode MS";
            row1.Cells.Add("English Text");

            // Include the subset of Font supporting Non-English text in PDF file
            pdf1.SetUnicode();           

            // Save the Pdf
            pdf1.Save(dataDir + "Arabic_Farsi_Text_in_TableCell_out.pdf");
            // ExEnd:NonEnglishText   
                
        }
    }
}