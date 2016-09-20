Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePdfGenerator.TechnicalArticles
    Public Class FigureOutTableBreak
        Public Shared Sub Run()
            ' ExStart:FigureOutTableBreak
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_TechnicalArticles()

            ' Instantiate an object PDF class
            Dim pdf As New Aspose.Pdf.Generator.Pdf()
            ' Add the section to PDF document sections collection
            Dim section As Aspose.Pdf.Generator.Section = pdf.Sections.Add()
            ' Instantiate a table object
            Dim table1 As New Aspose.Pdf.Generator.Table()
            table1.Margin.Top = 300
            ' Add the table in paragraphs collection of the desired section
            section.Paragraphs.Add(table1)
            ' Set with column widths of the table
            table1.ColumnWidths = "100 100 100"
            ' Set default cell border using BorderInfo object
            table1.DefaultCellBorder = New Aspose.Pdf.Generator.BorderInfo(CInt(Aspose.Pdf.Generator.BorderSide.All), 0.1F)
            ' Set table border using another customized BorderInfo object
            table1.Border = New Aspose.Pdf.Generator.BorderInfo(CInt(Aspose.Pdf.Generator.BorderSide.All), 1.0F)
            ' Create MarginInfo object and set its left, bottom, right and top margins
            Dim margin As New Aspose.Pdf.Generator.MarginInfo()
            margin.Top = 5.0F
            margin.Left = 5.0F
            margin.Right = 5.0F
            margin.Bottom = 5.0F
            ' Set the default cell padding to the MarginInfo object
            table1.DefaultCellPadding = margin
            ' If you increase the counter to 17, table will break 
            ' Because it cannot be accommodated any more over this page
            For RowCounter As Integer = 0 To 16
                ' Create rows in the table and then cells in the rows
                Dim row1 As Aspose.Pdf.Generator.Row = table1.Rows.Add()
                row1.Cells.Add("col " + RowCounter.ToString() + ", 1")
                row1.Cells.Add("col " + RowCounter.ToString() + ", 2")
                row1.Cells.Add("col " + RowCounter.ToString() + ", 3")
            Next
            ' Get the Page Height information
            Dim PageHeight As Single = pdf.PageSetup.PageHeight
            ' Get the total height information of Page Top & Bottom margin, table Top margin and table height.
            Dim TotalObjectsHeight As Single = section.PageInfo.Margin.Top + section.PageInfo.Margin.Bottom + table1.Margin.Top + table1.GetHeight(pdf)

            ' Display Page Height, Table Height, table Top margin and Page Top and Bottom margin information
            Console.WriteLine("PDF document Height = " + pdf.PageSetup.PageHeight.ToString() + vbLf & "Top Margin Info = " + section.PageInfo.Margin.Top.ToString() + vbLf & "Bottom Margin Info = " + section.PageInfo.Margin.Bottom.ToString() + vbLf & vbLf & "Table-Top Margin Info = " + table1.Margin.Top.ToString() + vbLf & "Average Row Height = " + table1.Rows(0).GetHeight(pdf).ToString() + " " & vbLf & "Table height " + table1.GetHeight(pdf).ToString() + vbLf & " ----------------------------------------" + vbLf & "Total Page Height =" + PageHeight.ToString() + vbLf & "Cummulative height including Table =" + TotalObjectsHeight.ToString())

            ' Check if we deduct the sume of Page top margin + Page Bottom margin + Table Top margin and table height from Page height and its less
            ' than 10 (an average row can be greater than 10)
            If (PageHeight - TotalObjectsHeight) <= 10 Then
                ' If the value is less than 10, then display the message. 
                ' Which shows that another row can not be placed and if we add new 
                ' row, table will break. It depends upon the row height value.
                Console.WriteLine("Page Height - Objects Height < 10, so table will break")
            End If
            ' Save the pdf document
            pdf.Save(dataDir & Convert.ToString("FigureOutTableBreak_out_.pdf"))
            ' ExEnd:FigureOutTableBreak           
        End Sub
    End Class
End Namespace
