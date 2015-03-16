//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace TableInHeaderFooter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //Instantiate PDF instance by calling empty constructor
            Aspose.Pdf.Generator.Pdf pdfConv = new Aspose.Pdf.Generator.Pdf();
            //Create a section in the pdf document
            Aspose.Pdf.Generator.Section sec1 = pdfConv.Sections.Add();

            // Create a Header Section of the PDF file
            Aspose.Pdf.Generator.HeaderFooter header = new Aspose.Pdf.Generator.HeaderFooter(sec1);
            // Set the Odd Header for the PDF file
            sec1.OddHeader = header;
            // set the top margin for the header section
            header.Margin.Top = 20;

            //Instantiate a table object
            Aspose.Pdf.Generator.Table tab1 = new Aspose.Pdf.Generator.Table();
            //Add the table in paragraphs collection of the desired section
            header.Paragraphs.Add(tab1);
            //Set default cell border using BorderInfo object
            tab1.DefaultCellBorder = new Aspose.Pdf.Generator.BorderInfo((int)Aspose.Pdf.Generator.BorderSide.All, 0.1F);
            //Set with column widths of the table
            tab1.ColumnWidths = "60 300";

            Aspose.Pdf.Generator.Image img = new Aspose.Pdf.Generator.Image();
            img.ImageInfo.File = dataDir + "asposelogo.png";
            img.ImageInfo.ImageFileType = Aspose.Pdf.Generator.ImageFileType.Png;

            //Create rows in the table and then cells in the rows
            Aspose.Pdf.Generator.Row row1 = tab1.Rows.Add();

            row1.Cells.Add("Table in Header Section");
            row1.BackgroundColor = new Aspose.Pdf.Generator.Color("#CCCCCC");
            row1.DefaultCellTextInfo.Color = new Aspose.Pdf.Generator.Color("#6699FF");
            // set the font face for the text in the row
            row1.DefaultCellTextInfo.FontName = "Helvetica";
            // set the row span value for first row as 2
            tab1.Rows[0].Cells[0].ColumnsSpan = 2;

            //Create rows in the table and then cells in the rows
            Aspose.Pdf.Generator.Row row2 = tab1.Rows.Add();
            // set the background color for Row2
            row2.BackgroundColor = new Aspose.Pdf.Generator.Color("#FFFFCC");
            // Add the cell which holds the image
            Aspose.Pdf.Generator.Cell cell2 = row2.Cells.Add();
            // set the image width to 60
            img.ImageInfo.FixWidth = 60;

            Aspose.Pdf.Generator.Text txt2 = new Aspose.Pdf.Generator.Text();
            // Add a text segment to hold image and text together
            Aspose.Pdf.Generator.Segment seg1 = new Aspose.Pdf.Generator.Segment();
            seg1.InlineParagraph = img;
            txt2.Segments.Add(seg1);

            //Add the image to the table cell
            cell2.Paragraphs.Add(txt2);
            row2.Cells.Add("Aspose Logo is looking very lovely !");
            row2.DefaultCellTextInfo.FontName = "Helvetica";
            // set the vertical allignment of the text as center alligned
            row2.Cells[1].VerticalAlignment = Aspose.Pdf.Generator.VerticalAlignmentType.Center;
            row2.Cells[1].Alignment = Aspose.Pdf.Generator.AlignmentType.Center;

            // save the Pdf file
            pdfConv.Save(dataDir + "Table_in_Header.pdf");
        }
    }
}