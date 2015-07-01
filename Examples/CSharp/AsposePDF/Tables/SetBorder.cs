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
    public class SetBorder
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Tables();
            // Create directory if it is not already present.
            bool IsExists = System.IO.Directory.Exists(dataDir);
            if (!IsExists)
                System.IO.Directory.CreateDirectory(dataDir);


            // instantiate Document object
            Document doc = new Document();
            // add page to PDF document
            Page page = doc.Pages.Add();
            // create BorderInfo object
            Aspose.Pdf.BorderInfo border = new Aspose.Pdf.BorderInfo(Aspose.Pdf.BorderSide.All);
            // specify that Top border will be double
            border.Top.IsDoubled = true;
            // specify that bottom border will be double
            border.Bottom.IsDoubled = true;
            // instantiate Table object
            Aspose.Pdf.Table table = new Aspose.Pdf.Table();
            // specify Columns width information
            table.ColumnWidths = "100";
            // create Row object
            Aspose.Pdf.Row row = table.Rows.Add();
            // add a Table cell to cells collection of row
            Aspose.Pdf.Cell cell = row.Cells.Add("some text");
            // set the border for cell object (double border)
            cell.Border = border;
            // add table to paragraphs collection of Page
            page.Paragraphs.Add(table);
            // save the PDF document
            doc.Save(dataDir+ "TableBorderTest.pdf");
            
            
        }
    }
}