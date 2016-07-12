using System;
using System.IO;
using Aspose.Pdf;
namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Tables
{
    public class RowAndColumnFormat
    {
        public static void Run()
        {
            // ExStart:RowAndColumnFormat
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Tables();

            // Instantiate Pdf document object 
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();
            // Create a section in the Pdf
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            // Create a table
            Aspose.Pdf.Generator.Table tab1 = new Aspose.Pdf.Generator.Table();

            // Add table in the paragraphs collection of the section
            sec1.Paragraphs.Add(tab1);

            // Set the column widths of the table
            tab1.ColumnWidths = "60 100 100";

            // Create a TextInfo instance
            Aspose.Pdf.Generator.TextInfo tinfo = new Aspose.Pdf.Generator.TextInfo();

            // Set the font name to "Courier" for the TextInfo object
            tinfo.FontName = "Courier";

            // Set default table border using the BorderInfo object
            tab1.DefaultCellBorder = new Aspose.Pdf.Generator.BorderInfo((int)Aspose.Pdf.Generator.BorderSide.All, 0.1F);

            // Apply the text format settings in TextInfo object to table cells
            tab1.DefaultCellTextInfo = tinfo;

            // Create an array of double values
            double[] darr = new Double[] { 1.5, 3.1415926, 100000, 20, 4000, 30.4512, 45.67, 890, 23.45 };

            // Import the values in array to table
            tab1.ImportArray(darr, 0, 0, false);

            // Set background color for the first row 
            Aspose.Pdf.Generator.TextInfo tinfo1 = tinfo.Clone() as Aspose.Pdf.Generator.TextInfo;
            tinfo1.BackgroundColor = new Aspose.Pdf.Generator.Color("#0000ff");
            tab1.Rows[0].DefaultCellTextInfo = tinfo1;

            // Align text in the last column to right hand side
            Aspose.Pdf.Generator.TextInfo tinfo2 = tinfo.Clone() as Aspose.Pdf.Generator.TextInfo;
            tinfo2.Alignment = Aspose.Pdf.Generator.AlignmentType.Right;
            tab1.SetColumnTextInfo(2, tinfo2);

            // We have to reset text format settings of the upper right cell 
            tinfo1.Alignment = Aspose.Pdf.Generator.AlignmentType.Right;
            tab1.Rows[0].Cells[2].DefaultCellTextInfo = tinfo1; 
            
            // Save the Pdf
            pdf1.Save(dataDir + "RowAndColumnFormat_out_.pdf");
            // ExEnd:RowAndColumnFormat   
                
        }
    }
}