using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Tables
{
    public class CellInformation
    {
        public static void Run()
        {
            // ExStart:CellInformation
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Tables();

            // Instntiate the Pdf object by calling its empty constructor
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Create the section in the Pdf object
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            // Create Table instance
            Aspose.Pdf.Generator.Table tab1 = new Aspose.Pdf.Generator.Table();

            // Add the table object in the paragraphs collection of the section
            sec1.Paragraphs.Add(tab1);

            // Set the column widths of the table
            tab1.ColumnWidths = "50 50 50";

            // Set default text color for the text contents of each cell in the table to blue
            tab1.DefaultCellTextInfo.Color = new Aspose.Pdf.Generator.Color("Blue");

            // Set default left side padding of the cell
            tab1.DefaultCellPadding.Left = 5;

            // Set default border of the cell using BorderInfo object
            tab1.DefaultCellBorder = new Aspose.Pdf.Generator.BorderInfo((int)Aspose.Pdf.Generator.BorderSide.All, 0.1F);

            // After setting default cell format information for the table, you can add rows
            // and columns in the table
            Aspose.Pdf.Generator.Row row1 = tab1.Rows.Add();
            row1.Cells.Add("col1");
            row1.Cells.Add("col2");
            row1.Cells.Add("col3");
            
            // Save the Pdf
            pdf1.Save(dataDir + "CellInformation_out_.pdf");
            // ExEnd:CellInformation   
                
        }
    }
}