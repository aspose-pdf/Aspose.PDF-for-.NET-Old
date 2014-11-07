//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace AddImageInTableCell
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //Create a section in the pdf document
            Aspose.Pdf.Generator.Pdf pdfConv = new Aspose.Pdf.Generator.Pdf();
            //Create a section in the pdf document
            Aspose.Pdf.Generator.Section sec1 = pdfConv.Sections.Add();
            //Instantiate a table object
            Aspose.Pdf.Generator.Table tab1 = new Aspose.Pdf.Generator.Table();
            //Add the table in paragraphs collection of the desired section
            sec1.Paragraphs.Add(tab1);
            //Set default cell border using BorderInfo object
            tab1.DefaultCellBorder = new Aspose.Pdf.Generator.BorderInfo((int)Aspose.Pdf.Generator.BorderSide.All, 0.1F);
            //Set with column widths of the table
            tab1.ColumnWidths = "100 100 120";

            Aspose.Pdf.Generator.Image img = new Aspose.Pdf.Generator.Image();
            img.ImageInfo.File = dataDir + "aspose.jpg";
            img.ImageInfo.ImageFileType = Aspose.Pdf.Generator.ImageFileType.Jpeg;

            //Create rows in the table and then cells in the rows
            Aspose.Pdf.Generator.Row row1 = tab1.Rows.Add();
            row1.Cells.Add("Sample text in cell");

            // Add the cell which holds the image
            Aspose.Pdf.Generator.Cell cell2 = row1.Cells.Add();
            //Add the image to the table cell
            cell2.Paragraphs.Add(img);

            row1.Cells.Add("Previous cell with image");
            row1.Cells[2].VerticalAlignment = Aspose.Pdf.Generator.VerticalAlignmentType.Center;

            // save the Pdf file
            pdfConv.Save(dataDir + "Image_in_Cell.pdf");
        }
    }
}