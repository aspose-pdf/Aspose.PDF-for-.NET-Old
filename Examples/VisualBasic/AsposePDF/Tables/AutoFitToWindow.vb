Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Namespace AsposePDF.Tables
    Public Class AutoFitToWindow
        Public Shared Sub Run()
            ' ExStart:AutoFitToWindow
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Tables()

            ' Instntiate the Pdf object by calling its empty constructor
            Dim doc As New Document()
            ' Create the section in the Pdf object
            Dim sec1 As Page = doc.Pages.Add()

            ' Instantiate a table object
            Dim tab1 As New Table()
            ' Add the table in paragraphs collection of the desired section
            sec1.Paragraphs.Add(tab1)

            ' Set with column widths of the table
            tab1.ColumnWidths = "50 50 50"
            tab1.ColumnAdjustment = ColumnAdjustment.AutoFitToWindow

            ' Set default cell border using BorderInfo object
            tab1.DefaultCellBorder = New BorderInfo(BorderSide.All, 0.1F)

            ' Set table border using another customized BorderInfo object
            tab1.Border = New BorderInfo(BorderSide.All, 1.0F)
            ' Create MarginInfo object and set its left, bottom, right and top margins
            Dim margin As New MarginInfo()
            margin.Top = 5.0F
            margin.Left = 5.0F
            margin.Right = 5.0F
            margin.Bottom = 5.0F

            ' Set the default cell padding to the MarginInfo object
            tab1.DefaultCellPadding = margin

            ' Create rows in the table and then cells in the rows
            Dim row1 As Row = tab1.Rows.Add()
            row1.Cells.Add("col1")
            row1.Cells.Add("col2")
            row1.Cells.Add("col3")
            Dim row2 As Row = tab1.Rows.Add()
            row2.Cells.Add("item1")
            row2.Cells.Add("item2")
            row2.Cells.Add("item3")

            dataDir = dataDir & Convert.ToString("AutoFitToWindow_out_.pdf")
            ' Save updated document containing table object
            doc.Save(dataDir)
            ' ExEnd:AutoFitToWindow

        End Sub
    End Class
End Namespace