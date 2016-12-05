using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.TechnicalArticles
{
    public class AddImageInTableCell
    {
        public static void Run()
        {           
            // ExStart:AddImageInTableCell
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_TechnicalArticles();

            // Instantiate a Pdf object
            Aspose.Pdf.Generator.Pdf pdfConv = new Aspose.Pdf.Generator.Pdf();
            // Create a section in the pdf document
            Aspose.Pdf.Generator.Section sec1 = pdfConv.Sections.Add();
            // Instantiate a table object
            Aspose.Pdf.Generator.Table tab1 = new Aspose.Pdf.Generator.Table();
            // Add the table in paragraphs collection of the desired section
            sec1.Paragraphs.Add(tab1);
            // Set default cell border using BorderInfo object
            tab1.DefaultCellBorder = new Aspose.Pdf.Generator.BorderInfo((int)Aspose.Pdf.Generator.BorderSide.All, 0.1F);
            // Set with column widths of the table
            tab1.ColumnWidths = "100 100 120";

            Aspose.Pdf.Generator.Image img = new Aspose.Pdf.Generator.Image();
            img.ImageInfo.File = dataDir + "aspose-logo.jpg";
            img.ImageInfo.ImageFileType = Aspose.Pdf.Generator.ImageFileType.Jpeg;

            // Create rows in the table and then cells in the rows
            Aspose.Pdf.Generator.Row row1 = tab1.Rows.Add();
            row1.Cells.Add("Sample text in cell");

            // Add the cell which holds the image
            Aspose.Pdf.Generator.Cell cell2 = row1.Cells.Add();
            // Add the image to the table cell
            cell2.Paragraphs.Add(img);

            row1.Cells.Add("Previous cell with image");
            row1.Cells[2].VerticalAlignment = Aspose.Pdf.Generator.VerticalAlignmentType.Center;

            // Save the Pdf file
            pdfConv.Save(dataDir + "AddImageInTableCell_out.pdf");
            // ExEnd:AddImageInTableCell           
        }
    }
}