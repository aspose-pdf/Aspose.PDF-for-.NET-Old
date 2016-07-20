using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Tables
{
    public class CompleteClone
    {
        public static void Run()
        {
            // ExStart:CompleteClone
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Tables();

            // Instantiate a Pdf object by calling its empty constructor
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Call BindXML method to read information from RepeatExample.xml document. Second
            // parameter is for Xsl file. In our case, we don't need it so leave it as null.
            pdf1.BindXML( dataDir + "RepeatExample.xml", null);

            // Obtain the first section from the Pdf
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections[0];

            // Obtain a table named "table1" from the Pdf
            Aspose.Pdf.Generator.Table table1 = sec1.Paragraphs["table1"] as Aspose.Pdf.Generator.Table;

            // Declare a table instance
            Aspose.Pdf.Generator.Table curTable;

            // Create an array of string containing three values, "item1", "item2" and "item3"
            string[] items = new string[] { "item1", "item2", "item3" };

            // Run a for loop for 5 times
            for (int i = 0; i < 5; i++)
            {
                // Copy the table structure of "table1" by calling its Clone method
                curTable = table1.Clone() as Aspose.Pdf.Generator.Table;

                // Set the top margin of the cloned table to 10
                curTable.Margin.Top = 10;

                // Copy a row (with structure and data) of "table1" by calling its
                // CompleteClone method. And then add that row to the cloned table
                curTable.Rows.Add(table1.Rows[0].CompleteClone() as Aspose.Pdf.Generator.Row);

                // Import an array of string "items" into the table
                curTable.ImportArray(items, 1, 0, false);

                // Add the cloned table to the paragraphs collection of the section
                sec1.Paragraphs.Add(curTable);
            }
            
            // Save the Pdf
            pdf1.Save(dataDir + "CompleteClone_out_.pdf");
            // ExEnd:CompleteClone   
                
        }
    }
}