//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;
using Aspose.Pdf.Text;

namespace MarginsOrPadding
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            // Create directory if it is not already present.
            bool IsExists = System.IO.Directory.Exists(dataDir);
            if (!IsExists)
                System.IO.Directory.CreateDirectory(dataDir);


            //Instntiate the Document object by calling its empty constructor
            Document doc = new Document();
            Page page = doc.Pages.Add();
            //Instantiate a table object
            Aspose.Pdf.Table tab1 = new Aspose.Pdf.Table();
            //Add the table in paragraphs collection of the desired section
            page.Paragraphs.Add(tab1);
            //Set with column widths of the table
            tab1.ColumnWidths = "50 50 50";
            //Set default cell border using BorderInfo object
            tab1.DefaultCellBorder = new Aspose.Pdf.BorderInfo(Aspose.Pdf.BorderSide.All, 0.1F);
            //Set table border using another customized BorderInfo object
            tab1.Border = new Aspose.Pdf.BorderInfo(Aspose.Pdf.BorderSide.All, 1F);
            //Create MarginInfo object and set its left, bottom, right and top margins
            Aspose.Pdf.MarginInfo margin = new Aspose.Pdf.MarginInfo();
            margin.Top = 5f;
            margin.Left = 5f;
            margin.Right = 5f;
            margin.Bottom = 5f;
            //Set the default cell padding to the MarginInfo object
            tab1.DefaultCellPadding = margin;
            //Create rows in the table and then cells in the rows
            Aspose.Pdf.Row row1 = tab1.Rows.Add();
            row1.Cells.Add("col1");
            row1.Cells.Add("col2");
            row1.Cells.Add();
            TextFragment mytext = new TextFragment("col3 with large text string");
            //row1.Cells.Add("col3 with large text string to be placed inside cell");
            row1.Cells[2].Paragraphs.Add(mytext);
            row1.Cells[2].IsWordWrapped = false;
            //row1.Cells[2].Paragraphs[0].FixedWidth= 80;
            Aspose.Pdf.Row row2 = tab1.Rows.Add();
            row2.Cells.Add("item1");
            row2.Cells.Add("item2");
            row2.Cells.Add("item3");
            //Save the Pdf
            doc.Save(dataDir+ "output.pdf");
            
            
        }
    }
}