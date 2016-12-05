Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePdfGenerator.Tables
    Public Class CellInformation
        Public Shared Sub Run()
            ' ExStart:CellInformation
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Tables()

            ' Instntiate the Pdf object by calling its empty constructor
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

            ' Create the section in the Pdf object
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

            ' Create Table instance
            Dim tab1 As New Aspose.Pdf.Generator.Table()

            ' Add the table object in the paragraphs collection of the section
            sec1.Paragraphs.Add(tab1)

            ' Set the column widths of the table
            tab1.ColumnWidths = "50 50 50"

            ' Set default text color for the text contents of each cell in the table to blue
            tab1.DefaultCellTextInfo.Color = New Aspose.Pdf.Generator.Color("Blue")

            ' Set default left side padding of the cell
            tab1.DefaultCellPadding.Left = 5

            ' Set default border of the cell using BorderInfo object
            tab1.DefaultCellBorder = New Aspose.Pdf.Generator.BorderInfo(CInt(Aspose.Pdf.Generator.BorderSide.All), 0.1F)

            ' After setting default cell format information for the table, you can add rows
            ' And columns in the table
            Dim row1 As Aspose.Pdf.Generator.Row = tab1.Rows.Add()
            row1.Cells.Add("col1")
            row1.Cells.Add("col2")
            row1.Cells.Add("col3")

            ' Save the Pdf
            pdf1.Save(dataDir & Convert.ToString("CellInformation_out_.pdf"))
            ' ExEnd:CellInformation  

        End Sub
    End Class
End Namespace