Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports System.Data

Namespace AsposePDF.Tables
    Public Class IntegrateWithDatabase
        Public Shared Sub Run()
            ' ExStart:IntegrateWithDatabase
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Tables()

            Dim dt As New DataTable("Employee")
            dt.Columns.Add("Employee_ID", GetType(Integer))
            dt.Columns.Add("Employee_Name", GetType(String))
            dt.Columns.Add("Gender", GetType(String))
            ' Add 2 rows into the DataTable object programmatically
            Dim dr As DataRow = dt.NewRow()
            dr(0) = 1
            dr(1) = "John Smith"
            dr(2) = "Male"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr(0) = 2
            dr(1) = "Mary Miller"
            dr(2) = "Female"
            dt.Rows.Add(dr)
            ' Create Document instance
            Dim doc As New Document()
            doc.Pages.Add()
            ' Initializes a new instance of the Table
            Dim table As New Table()
            ' Set column widths of the table
            table.ColumnWidths = "40 100 100 100"
            ' Set the table border color as LightGray
            table.Border = New BorderInfo(BorderSide.All, 0.5F, Color.FromRgb(System.Drawing.Color.LightGray))
            ' Set the border for table cells
            table.DefaultCellBorder = New BorderInfo(BorderSide.All, 0.5F, Color.FromRgb(System.Drawing.Color.LightGray))
            table.ImportDataTable(dt, True, 0, 1, 3, 3)

            ' Add table object to first page of input document
            doc.Pages(1).Paragraphs.Add(table)
            dataDir = dataDir & Convert.ToString("DataIntegrated_out_.pdf")
            ' Save updated document containing table object
            doc.Save(dataDir)
            ' ExEnd:IntegrateWithDatabase
            Console.WriteLine(Convert.ToString(vbLf & "Database integrated successfully." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
