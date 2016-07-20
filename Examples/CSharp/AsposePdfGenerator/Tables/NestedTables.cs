using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Tables
{
    public class NestedTables
    {
        public static void Run()
        {
            // ExStart:NestedTables
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Tables();

            // Instantiate Pdf document object 
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf(); 
            // Create a section in the Pdf
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add(); 

            // Create a table
            Aspose.Pdf.Generator.Table tab1 = new Aspose.Pdf.Generator.Table(); 

            // Add the table into the paragraphs collection of section
            sec1.Paragraphs.Add(tab1); 

            // Set the column widths of the table
            tab1.ColumnWidths = "100 200"; 

            // Set the default cell border using BorderInfo instance
            tab1.DefaultCellBorder = new Aspose.Pdf.Generator.BorderInfo((int) Aspose.Pdf.Generator.BorderSide.All); 

            // Add a row into the table
            Aspose.Pdf.Generator.Row row1 = tab1.Rows.Add(); 

            // Add 1st cell in the row
            row1.Cells.Add("left cell"); 

            // Add 2nd cell in the row
            Aspose.Pdf.Generator.Cell cell2 = row1.Cells.Add(); 

            // Create a table to be nested with the reference of 2nd cell in the row
            Aspose.Pdf.Generator.Table tab2 = new Aspose.Pdf.Generator.Table(cell2); 

            // Add the nested table into the paragraphs collection of the 2nd cell
            cell2.Paragraphs.Add(tab2); 

            // Set the column widths of the nested table
            tab2.ColumnWidths = "100 100"; 

            // Create 1st row in the nested table
            Aspose.Pdf.Generator.Row row21 = tab2.Rows.Add(); 

            // Create 1st cell in the 1st row of the nested table
            Aspose.Pdf.Generator.Cell cell21 = row21.Cells.Add("top cell"); 

            // Set the column span of the 1st cell (in the 1st row of the nested table) to 2
            cell21.ColumnsSpan = 2; 

            // Create 2nd row in the nested table
            Aspose.Pdf.Generator.Row row22 = tab2.Rows.Add(); 

            // Create 1st cell in the 2nd row of the nested table
            row22.Cells.Add("left bottom cell"); 

            // Create 2nd cell in the 2nd row of the nested table
            row22.Cells.Add("right bottom cell"); 
            
            // Save the Pdf
            pdf1.Save(dataDir + "NestedTables_out_.pdf");
            // ExEnd:NestedTables   
                
        }
    }
}