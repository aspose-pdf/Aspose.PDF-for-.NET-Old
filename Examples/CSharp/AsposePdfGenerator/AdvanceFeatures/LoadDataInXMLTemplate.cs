using System;
using System.IO;
using System.Data;
using Aspose.Pdf;
namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.AdvanceFeatures
{
    public class LoadDataInXMLTemplate
    {
        public static void Run()
        {
            // ExStart:LoadDataInXMLTemplate
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_AdvanceFeatures();

            // Creating a new Pdf object
            Aspose.Pdf.Generator.Pdf pdf = new Aspose.Pdf.Generator.Pdf();

            // Binding the content from the named XML file
            pdf.BindXML(dataDir + "Sample.xml", null);

            // In a real scenario, data is usually input from Database. So, we can get data
            // from a database. In this case, we are using a method that will provide us an
            // instance of DataTable. The implementation of this method is also given below.
            DataTable getDT = creatDataTable();

            // Accessing a table through its ID
            Aspose.Pdf.Generator.Table contenTable = (Aspose.Pdf.Generator.Table)pdf.GetObjectByID("Content");

            // Importing data from a DataTable and filling the table in PDF document
            contenTable.ImportDataTable(getDT, false, 1, 1, 5, 4);

            // Saving the results
            pdf.Save(dataDir + "Sample_out_.pdf");
            // ExEnd:LoadDataInXMLTemplate
        }
        // ExStart:creatDataTable
        // The implementation of createDataTable method that is being called in the program
        public static DataTable creatDataTable()
        {

            // Creating a DataTable object
            DataTable dt = new DataTable("Sample");

            // Adding columns to the DataTable
            dt.Columns.Add("Beginning of lease", typeof(Int32));
            dt.Columns.Add("End of lease", typeof(Int32));
            dt.Columns.Add("Landlord's end-of-lease assessment", typeof(string));
            dt.Columns.Add("Comments", typeof(string));

            // Adding rows to the DataTable
            DataRow dr = dt.NewRow();
            dr[0] = 12;
            dr[1] = 11;
            dr[2] = "$32.38";
            dr[3] = "M";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = 22;
            dr[1] = 22;
            dr[2] = "$148.45";
            dr[3] = "G";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = 41;
            dr[1] = 41;
            dr[2] = "$11.42";
            dr[3] = "S,R";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = 47;
            dr[1] = 40;
            dr[2] = "$48.52";
            dr[3] = "D";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = 28;
            dr[1] = 20;
            dr[2] = "$78.43";
            dr[3] = "R";
            dt.Rows.Add(dr);

            // Returning the instance of DataTable object
            return dt;
                     
        }
        // ExEnd:creatDataTable
    }
     
}