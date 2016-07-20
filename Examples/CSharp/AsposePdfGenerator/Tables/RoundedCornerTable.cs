using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Tables
{
    public class RoundedCornerTable
    {
        public static void Run()
        {
            // ExStart:RoundedCornerTable
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Tables();

            // Instantiate Pdf object
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Create the section in the Pdf object
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            // Instantiate a table object
            Aspose.Pdf.Generator.Table tab1 = new Aspose.Pdf.Generator.Table();

            // Add the table in paragraphs collection of the desired section
            sec1.Paragraphs.Add(tab1);

            // Set with column widths of the table
            tab1.ColumnWidths = "100";

            // Set fixed table row height 
            tab1.FixedHeight = 30;

            // Create a blank BorderInfo object
            Aspose.Pdf.Generator.BorderInfo bInfo = new Aspose.Pdf.Generator.BorderInfo();

            // Create a GraphInfo object without any argument to its constructor
            Aspose.Pdf.Generator.GraphInfo gInfo = new Aspose.Pdf.Generator.GraphInfo();

            // Set the corner radius for GraphInfo
            gInfo.CornerRadius = 15F;

            // Specify the line color information 
            gInfo.Color = new Aspose.Pdf.Generator.Color("Red");

            // Set the rounded corner table border
            bInfo.Round = gInfo;

            // Specify the Corner style for table border as Round
            tab1.CornerStyle = Aspose.Pdf.Generator.BorderCornerStyle.Round;

            // Set the table border information
            tab1.Border = bInfo;

            // Create rows in the table and then cells in the rows
            Aspose.Pdf.Generator.Row row1 = tab1.Rows.Add();

            // Add sample string to paragraphs collection of table cell
            row1.Cells.Add("Hello World...");

            // Set the vertical alignment of text as center aligned
            row1.Cells[0].DefaultCellTextInfo.Alignment = Aspose.Pdf.Generator.AlignmentType.Center;

            // Set the horizontal alignment of text as center aligned 
            row1.Cells[0].VerticalAlignment = Aspose.Pdf.Generator.VerticalAlignmentType.Center;

            // Save the Pdf
            pdf1.Save(dataDir + "Rounded_Corner-Table_out_.pdf");
            // ExEnd:RoundedCornerTable   
                
        }
        private static void BorderInfo()
        {
            // ExStart:BorderInfo
            Aspose.Pdf.Generator.BorderInfo binfo = new Aspose.Pdf.Generator.BorderInfo((int)BorderSide.All, 1f, new Aspose.Pdf.Generator.Color("Red"));
            // ExEnd:BorderInfo
        }
    }
}