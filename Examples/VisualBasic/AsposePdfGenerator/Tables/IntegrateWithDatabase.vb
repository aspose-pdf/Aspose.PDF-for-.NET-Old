Imports System.Data
Imports System
Imports Microsoft.VisualBasic
Imports System.IO
Imports Aspose.Pdf

Namespace AsposePdfGenerator.Tables
    Public Class IntegrateWithDatabase
        Public Shared Sub Run()
            ' ExStart:IntegrateWithDatabase
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Tables()

            Dim dt As New DataTable("Employee")
            dt.Columns.Add("Employee_ID", GetType(Int32))
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

            ' Instantiate a Pdf instance
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

            ' Create a section in the Pdf instance
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

            ' Create a Table object
            Dim tab1 As New Aspose.Pdf.Generator.Table()


            ' Add the Table object in the paragraphs collection of the section
            sec1.Paragraphs.Add(tab1)

            ' Set column widths of the table
            tab1.ColumnWidths = "40 100 100 100"

            ' Set default cell border of the table using BorderInfo object
            tab1.DefaultCellBorder = New Aspose.Pdf.Generator.BorderInfo(CInt(Aspose.Pdf.Generator.BorderSide.All), 0.1F)

            ' Import data into the Table object from the DataTable created above
            tab1.ImportDataTable(dt, True, 0, 1, 3, 3)

            ' Get 1st row from the table
            Dim row1 As Aspose.Pdf.Generator.Row = tab1.Rows(0)

            ' Iterate through all cells in the row and set their background color to blue
            For Each curCell As Aspose.Pdf.Generator.Cell In row1.Cells
                curCell.BackgroundColor = New Aspose.Pdf.Generator.Color("Blue")
            Next

            ' Save the Pdf
            pdf1.Save(dataDir & Convert.ToString("IntegrateWithDatabase_out_.pdf"))
            ' ExEnd:IntegrateWithDatabase   

        End Sub
    End Class
End Namespace