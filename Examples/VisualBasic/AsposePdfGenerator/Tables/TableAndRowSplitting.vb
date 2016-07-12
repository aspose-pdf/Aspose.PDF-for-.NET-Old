Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Namespace AsposePdfGenerator.Tables
    Public Class TableAndRowSplitting
        Public Shared Sub Run()

            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Tables()

            ' Instntiate the Pdf object by calling its empty constructor
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

            ' Create the section in the Pdf object
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

            ' Instantiate a table object
            Dim tab1 As New Aspose.Pdf.Generator.Table()

            ' Add the table in paragraphs collection of the desired section
            sec1.Paragraphs.Add(tab1)

            'ExStart:TableRowRepeat
            tab1.IsFirstRowRepeated = True
            'ExEnd:TableRowRepeat

            'ExStart:TableIsBroken
            tab1.IsBroken = False
            'ExEnd:TableIsBroken

            ' Set with column widths of the table
            tab1.ColumnWidths = "50 50 50"

            ' Set default cell border using BorderInfo object
            tab1.DefaultCellBorder = New Aspose.Pdf.Generator.BorderInfo(CInt(Aspose.Pdf.Generator.BorderSide.All), 0.1F)

            ' Set table border using another customized BorderInfo object
            tab1.Border = New Aspose.Pdf.Generator.BorderInfo(CInt(Aspose.Pdf.Generator.BorderSide.All), 1.0F)
            ' Create MarginInfo object and set its left, bottom, right and top margins
            Dim margin As New Aspose.Pdf.Generator.MarginInfo()
            margin.Top = 5.0F
            margin.Left = 5.0F
            margin.Right = 5.0F
            margin.Bottom = 5.0F

            ' Set the default cell padding to the MarginInfo object
            tab1.DefaultCellPadding = margin

            ' Create rows in the table and then cells in the rows
            Dim row1 As Aspose.Pdf.Generator.Row = tab1.Rows.Add()
            row1.Cells.Add("col1")
            row1.Cells.Add("col2")
            row1.Cells.Add("col3")
            Dim row2 As Aspose.Pdf.Generator.Row = tab1.Rows.Add()
            row2.Cells.Add("item1")
            row2.Cells.Add("item2")
            row2.Cells.Add("item3")

            ' Save the Pdf
            pdf1.Save(dataDir & Convert.ToString("TableAndRowSplitting_out_.pdf"))

        End Sub
    End Class
End Namespace