using System;
using System.Data;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Tables
{
    public class IntegrateWithDatabase
    {
        public static void Run()
        {
            // ExStart:IntegrateWithDatabase
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Tables();

            DataTable dt = new DataTable("Employee"); 
            dt.Columns.Add("Employee_ID",typeof(Int32)); 
            dt.Columns.Add("Employee_Name",typeof(string)); 
            dt.Columns.Add("Gender",typeof(string)); 

            // Add 2 rows into the DataTable object programmatically

            DataRow dr = dt.NewRow(); 
            dr[0] = 1; 
            dr[1] = "John Smith"; 
            dr[2] = "Male"; 
            dt.Rows.Add(dr); 

            dr = dt.NewRow(); 
            dr[0] = 2; 
            dr[1] = "Mary Miller"; 
            dr[2] = "Female"; 
            dt.Rows.Add(dr); 

            // Instantiate a Pdf instance
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf(); 

            // Create a section in the Pdf instance
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add(); 

            // Create a Table object
            Aspose.Pdf.Generator.Table tab1 = new Aspose.Pdf.Generator.Table(); 


            // Add the Table object in the paragraphs collection of the section
            sec1.Paragraphs.Add(tab1); 

            // Set column widths of the table
            tab1.ColumnWidths = "40 100 100 100"; 

            // Set default cell border of the table using BorderInfo object
            tab1.DefaultCellBorder = new Aspose.Pdf.Generator.BorderInfo((int) Aspose.Pdf.Generator.BorderSide.All,0.1F); 

            // Import data into the Table object from the DataTable created above
            tab1.ImportDataTable(dt,true,0,1,3,3); 

            // Get 1st row from the table
            Aspose.Pdf.Generator.Row row1 = tab1.Rows[0]; 

            // Iterate through all cells in the row and set their background color to blue
            foreach(Aspose.Pdf.Generator.Cell curCell in row1.Cells) 
                curCell.BackgroundColor = new Aspose.Pdf.Generator.Color("Blue"); 

            // Save the Pdf
            pdf1.Save(dataDir + "IntegrateWithDatabase_out_.pdf"); 
            // ExEnd:IntegrateWithDatabase   
                
        }
    }
}