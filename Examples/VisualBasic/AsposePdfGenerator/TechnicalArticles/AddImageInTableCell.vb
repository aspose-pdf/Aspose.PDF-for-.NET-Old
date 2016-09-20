Imports System.IO
Imports System
Imports Aspose.Pdf

Namespace AsposePdfGenerator.TechnicalArticles
    Public Class AddImageInTableCell
        Public Shared Sub Run()
            ' ExStart:AddImageInTableCell
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_TechnicalArticles()

            ' Instantiate a Pdf object
            Dim pdfConv As New Aspose.Pdf.Generator.Pdf()
            ' Create a section in the pdf document
            Dim sec1 As Aspose.Pdf.Generator.Section = pdfConv.Sections.Add()
            ' Instantiate a table object
            Dim tab1 As New Aspose.Pdf.Generator.Table()
            ' Add the table in paragraphs collection of the desired section
            sec1.Paragraphs.Add(tab1)
            ' Set default cell border using BorderInfo object
            tab1.DefaultCellBorder = New Aspose.Pdf.Generator.BorderInfo(CInt(Aspose.Pdf.Generator.BorderSide.All), 0.1F)
            ' Set with column widths of the table
            tab1.ColumnWidths = "100 100 120"

            Dim img As New Aspose.Pdf.Generator.Image()
            img.ImageInfo.File = dataDir & Convert.ToString("aspose-logo.jpg")
            img.ImageInfo.ImageFileType = Aspose.Pdf.Generator.ImageFileType.Jpeg

            ' Create rows in the table and then cells in the rows
            Dim row1 As Aspose.Pdf.Generator.Row = tab1.Rows.Add()
            row1.Cells.Add("Sample text in cell")

            ' Add the cell which holds the image
            Dim cell2 As Aspose.Pdf.Generator.Cell = row1.Cells.Add()
            ' Add the image to the table cell
            cell2.Paragraphs.Add(img)

            row1.Cells.Add("Previous cell with image")
            row1.Cells(2).VerticalAlignment = Aspose.Pdf.Generator.VerticalAlignmentType.Center

            ' Save the Pdf file
            pdfConv.Save(dataDir & Convert.ToString("AddImageInTableCell_out_.pdf"))
            ' ExEnd:AddImageInTableCell           
        End Sub
    End Class
End Namespace

