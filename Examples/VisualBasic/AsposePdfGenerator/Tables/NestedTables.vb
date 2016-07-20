Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePdfGenerator.Tables
    Public Class NestedTables
        Public Shared Sub Run()
            ' ExStart:NestedTables
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Tables()

            ' Instantiate Pdf document object 
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()
            ' Create a section in the Pdf
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

            ' Create a table
            Dim tab1 As New Aspose.Pdf.Generator.Table()

            ' Add the table into the paragraphs collection of section
            sec1.Paragraphs.Add(tab1)

            ' Set the column widths of the table
            tab1.ColumnWidths = "100 200"

            ' Set the default cell border using BorderInfo instance
            tab1.DefaultCellBorder = New Aspose.Pdf.Generator.BorderInfo(CInt(Aspose.Pdf.Generator.BorderSide.All))

            ' Add a row into the table
            Dim row1 As Aspose.Pdf.Generator.Row = tab1.Rows.Add()

            ' Add 1st cell in the row
            row1.Cells.Add("left cell")

            ' Add 2nd cell in the row
            Dim cell2 As Aspose.Pdf.Generator.Cell = row1.Cells.Add()

            ' Create a table to be nested with the reference of 2nd cell in the row
            Dim tab2 As New Aspose.Pdf.Generator.Table(cell2)

            ' Add the nested table into the paragraphs collection of the 2nd cell
            cell2.Paragraphs.Add(tab2)

            ' Set the column widths of the nested table
            tab2.ColumnWidths = "100 100"

            ' Create 1st row in the nested table
            Dim row21 As Aspose.Pdf.Generator.Row = tab2.Rows.Add()

            ' Create 1st cell in the 1st row of the nested table
            Dim cell21 As Aspose.Pdf.Generator.Cell = row21.Cells.Add("top cell")

            ' Set the column span of the 1st cell (in the 1st row of the nested table) to 2
            cell21.ColumnsSpan = 2

            ' Create 2nd row in the nested table
            Dim row22 As Aspose.Pdf.Generator.Row = tab2.Rows.Add()

            ' Create 1st cell in the 2nd row of the nested table
            row22.Cells.Add("left bottom cell")

            ' Create 2nd cell in the 2nd row of the nested table
            row22.Cells.Add("right bottom cell")

            ' Save the Pdf
            pdf1.Save(dataDir & Convert.ToString("NestedTables_out_.pdf"))
            ' ExEnd:NestedTables   

        End Sub
    End Class
End Namespace