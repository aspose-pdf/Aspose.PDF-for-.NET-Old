Imports System.IO
Imports System
Imports Aspose.Pdf

Namespace AsposePdfGenerator.TechnicalArticles
    Public Class SetTableColumnsWidth
        Public Shared Sub Run()
            ' ExStart:SetTableColumnsWidth
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_TechnicalArticles()

            ' Create Pdf Instance
            Dim pdf As New Aspose.Pdf.Generator.Pdf()
            ' Create section object and add it to pdf object
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf.Sections.Add()

            ' Create a table instance
            Dim mytable As New Aspose.Pdf.Generator.Table()
            ' Specify the default border for table object and set its color as Navy
            mytable.DefaultCellBorder = New Aspose.Pdf.Generator.BorderInfo(CInt(Aspose.Pdf.Generator.BorderSide.All), 1.0F, New Aspose.Pdf.Generator.Color("Navy"))
            ' Specify the border information for table object
            mytable.Border = New Aspose.Pdf.Generator.BorderInfo(CInt(Aspose.Pdf.Generator.BorderSide.All), 1.0F, New Aspose.Pdf.Generator.Color("Navy"))
            ' Define initial width information for table cells
            mytable.ColumnWidths = "100 100"
            ' Create a row object and add it to table 
            Dim row1 As Aspose.Pdf.Generator.Row = mytable.Rows.Add()
            ' Create loop to add specify the number of columns to be added to table row
            For Column_Counter As Integer = 1 To 7
                ' Create a cell object and add it to table row
                Dim Cell As Aspose.Pdf.Generator.Cell = row1.Cells.Add("Cell (1," + Column_Counter.ToString() + ")")
            Next
            ' Define the variable to keep record of number of columns in table
            Dim TableColumn As Integer = 0
            ' Traverse through each table cell in row object
            For Each InnerCell As Aspose.Pdf.Generator.Cell In row1.Cells
                ' Specify the width information for each column based on section objects margin and width values
                ' Set the width value as, get the total width of section and subtract left and right margin and divide
                ' It with total number of cells in a particular table row
                mytable.SetColumnWidth(TableColumn, (sec1.PageInfo.PageWidth - sec1.PageInfo.Margin.Left - sec1.PageInfo.Margin.Right) / row1.Cells.Count)
                ' Increase the value of variable holding the column count information
                TableColumn += 1
            Next

            ' Add table to paragraphs collection of section
            sec1.Paragraphs.Add(mytable)
            ' Save the resultant PDF document
            pdf.Save(dataDir & Convert.ToString("SetTableColumnsWidth_out_.pdf"))
            ' ExEnd:SetTableColumnsWidth           
        End Sub
    End Class
End Namespace
