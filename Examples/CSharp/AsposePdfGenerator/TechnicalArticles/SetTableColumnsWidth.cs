using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.TechnicalArticles
{
    public class SetTableColumnsWidth
    {
        public static void Run()
        {
            // ExStart:SetTableColumnsWidth
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_TechnicalArticles();

            // Create Pdf Instance
            Aspose.Pdf.Generator.Pdf pdf = new Aspose.Pdf.Generator.Pdf();
            // Create section object and add it to pdf object
            Aspose.Pdf.Generator.Section sec1 = pdf.Sections.Add();

            // Create a table instance
            Aspose.Pdf.Generator.Table mytable = new Aspose.Pdf.Generator.Table();
            // Specify the default border for table object and set its color as Navy
            mytable.DefaultCellBorder = new Aspose.Pdf.Generator.BorderInfo((int)Aspose.Pdf.Generator.BorderSide.All, 1f, new Aspose.Pdf.Generator.Color("Navy"));
            // Specify the border information for table object
            mytable.Border = new Aspose.Pdf.Generator.BorderInfo((int)Aspose.Pdf.Generator.BorderSide.All, 1f, new Aspose.Pdf.Generator.Color("Navy"));
            // Define initial width information for table cells
            mytable.ColumnWidths = "100 100";
            // Create a row object and add it to table 
             Aspose.Pdf.Generator.Row row1 = mytable.Rows.Add();
            // Create loop to add specify the number of columns to be added to table row
            for (int Column_Counter = 1; Column_Counter <= 7; Column_Counter++)
            {
                // Create a cell object and add it to table row
                 Aspose.Pdf.Generator.Cell Cell = row1.Cells.Add("Cell (1," + Column_Counter.ToString() + ")");
            }
            // Define the variable to keep record of number of columns in table
            int TableColumn = 0;
            // Traverse through each table cell in row object
            foreach (Aspose.Pdf.Generator.Cell InnerCell in row1.Cells)
            {
                // Specify the width information for each column based on section objects margin and width values
                // Set the width value as, get the total width of section and subtract left and right margin and divide
                // It with total number of cells in a particular table row
                mytable.SetColumnWidth(TableColumn, (sec1.PageInfo.PageWidth - sec1.PageInfo.Margin.Left - sec1.PageInfo.Margin.Right) / row1.Cells.Count);
                // Increase the value of variable holding the column count information
                TableColumn += 1;
            }

            // Add table to paragraphs collection of section
            sec1.Paragraphs.Add(mytable);
            // Save the resultant PDF document
            pdf.Save(dataDir + "SetTableColumnsWidth_out.pdf");
            // ExEnd:SetTableColumnsWidth           
        }
    }
}