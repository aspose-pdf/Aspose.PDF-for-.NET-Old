Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Namespace AsposePdfGenerator.Tables
    Public Class RoundedCornerTable
        Public Shared Sub Run()
            ' ExStart:RoundedCornerTable
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Tables()

            ' Instantiate Pdf object
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

            ' Create the section in the Pdf object
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

            ' Instantiate a table object
            Dim tab1 As New Aspose.Pdf.Generator.Table()

            ' Add the table in paragraphs collection of the desired section
            sec1.Paragraphs.Add(tab1)

            ' Set with column widths of the table
            tab1.ColumnWidths = "100"

            ' Set fixed table row height 
            tab1.FixedHeight = 30

            ' Create a blank BorderInfo object
            Dim bInfo As New Aspose.Pdf.Generator.BorderInfo()

            ' Create a GraphInfo object without any argument to its constructor
            Dim gInfo As New Aspose.Pdf.Generator.GraphInfo()

            ' Set the corner radius for GraphInfo
            gInfo.CornerRadius = 15.0F

            ' Specify the line color information 
            gInfo.Color = New Aspose.Pdf.Generator.Color("Red")

            ' Set the rounded corner table border
            bInfo.Round = gInfo

            ' Specify the Corner style for table border as Round
            tab1.CornerStyle = Aspose.Pdf.Generator.BorderCornerStyle.Round

            ' Set the table border information
            tab1.Border = bInfo

            ' Create rows in the table and then cells in the rows
            Dim row1 As Aspose.Pdf.Generator.Row = tab1.Rows.Add()

            ' Add sample string to paragraphs collection of table cell
            row1.Cells.Add("Hello World...")

            ' Set the vertical alignment of text as center aligned
            row1.Cells(0).DefaultCellTextInfo.Alignment = Aspose.Pdf.Generator.AlignmentType.Center

            ' Set the horizontal alignment of text as center aligned 
            row1.Cells(0).VerticalAlignment = Aspose.Pdf.Generator.VerticalAlignmentType.Center

            ' Save the Pdf
            pdf1.Save(dataDir & Convert.ToString("Rounded_Corner-Table_out_.pdf"))
            ' ExEnd:RoundedCornerTable   

        End Sub
        Private Shared Sub BorderInfo()
            ' ExStart:BorderInfo
            Dim binfo As New Aspose.Pdf.Generator.BorderInfo(CInt(BorderSide.All), 1.0F, New Aspose.Pdf.Generator.Color("Red"))
            ' ExEnd:BorderInfo
        End Sub
    End Class
End Namespace
