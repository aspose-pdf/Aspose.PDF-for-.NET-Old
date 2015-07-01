//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace CSharp.AsposePdf.Tables
{
    public class AddTable
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Tables();

            // Load source PDF document
            Aspose.Pdf.Document doc = new Aspose.Pdf.Document(dataDir+ "AddTable.pdf");
            // Initializes a new instance of the Table
            Aspose.Pdf.Table table = new Aspose.Pdf.Table();
            // Set the table border color as LightGray
            table.Border = new Aspose.Pdf.BorderInfo(Aspose.Pdf.BorderSide.All, .5f, Aspose.Pdf.Color.FromRgb(System.Drawing.Color.LightGray));
            // set the border for table cells
            table.DefaultCellBorder = new Aspose.Pdf.BorderInfo(Aspose.Pdf.BorderSide.All, .5f, Aspose.Pdf.Color.FromRgb(System.Drawing.Color.LightGray));
            // create a loop to add 10 rows
            for (int row_count = 1; row_count < 10; row_count++)
            {
                // add row to table
                Aspose.Pdf.Row row = table.Rows.Add();
                // add table cells
                row.Cells.Add("Column (" + row_count + ", 1)");
                row.Cells.Add("Column (" + row_count + ", 2)");
                row.Cells.Add("Column (" + row_count + ", 3)");
            }
            // Add table object to first page of input document
            doc.Pages[1].Paragraphs.Add(table);
            // Save updated document containing table object
            doc.Save(dataDir+ "document_with_table.pdf");
            
        }
    }
}