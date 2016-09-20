Imports System.IO
Imports System
Imports Aspose.Pdf

Namespace AsposePdfGenerator.TechnicalArticles
    Public Class TableInHeaderFooterSection
        Public Shared Sub Run()
            ' ExStart:TableInHeaderFooterSection
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_TechnicalArticles()

            ' Instantiate PDF instance by calling empty constructor
            Dim pdfConv As New Aspose.Pdf.Generator.Pdf()
            ' Create a section in the pdf document
            Dim sec1 As Aspose.Pdf.Generator.Section = pdfConv.Sections.Add()

            ' Create a Header Section of the PDF file
            Dim header As New Aspose.Pdf.Generator.HeaderFooter(sec1)
            ' Set the Odd Header for the PDF file
            sec1.OddHeader = header
            ' Set the top margin for the header section
            header.Margin.Top = 20

            ' Instantiate a table object
            Dim tab1 As New Aspose.Pdf.Generator.Table()
            ' Add the table in paragraphs collection of the desired section
            header.Paragraphs.Add(tab1)
            ' Set default cell border using BorderInfo object
            tab1.DefaultCellBorder = New Aspose.Pdf.Generator.BorderInfo(CInt(Aspose.Pdf.Generator.BorderSide.All), 0.1F)
            ' Set with column widths of the table
            tab1.ColumnWidths = "60 300"

            Dim img As New Aspose.Pdf.Generator.Image()
            img.ImageInfo.File = dataDir & Convert.ToString("aspose-logo.jpg")
            img.ImageInfo.ImageFileType = Aspose.Pdf.Generator.ImageFileType.Jpeg

            ' Create rows in the table and then cells in the rows
            Dim row1 As Aspose.Pdf.Generator.Row = tab1.Rows.Add()

            row1.Cells.Add("Table in Header Section")
            row1.BackgroundColor = New Aspose.Pdf.Generator.Color("#CCCCCC")
            row1.DefaultCellTextInfo.Color = New Aspose.Pdf.Generator.Color("#6699FF")
            ' Set the font face for the text in the row
            row1.DefaultCellTextInfo.FontName = "Helvetica"
            ' Set the row span value for first row as 2
            tab1.Rows(0).Cells(0).ColumnsSpan = 2

            ' Create rows in the table and then cells in the rows
            Dim row2 As Aspose.Pdf.Generator.Row = tab1.Rows.Add()
            ' Set the background color for Row2
            row2.BackgroundColor = New Aspose.Pdf.Generator.Color("#FFFFCC")
            ' Add the cell which holds the image
            Dim cell2 As Aspose.Pdf.Generator.Cell = row2.Cells.Add()
            ' Set the image width to 60
            img.ImageInfo.FixWidth = 60

            Dim txt2 As New Aspose.Pdf.Generator.Text()
            ' Add a text segment to hold image and text together
            Dim seg1 As New Aspose.Pdf.Generator.Segment()
            seg1.InlineParagraph = img
            txt2.Segments.Add(seg1)

            ' Add the image to the table cell
            cell2.Paragraphs.Add(txt2)
            row2.Cells.Add("Penguin is looking very lovely !")
            row2.DefaultCellTextInfo.FontName = "Helvetica"
            ' Set the vertical allignment of the text as center alligned
            row2.Cells(1).VerticalAlignment = Aspose.Pdf.Generator.VerticalAlignmentType.Center
            row2.Cells(1).Alignment = Aspose.Pdf.Generator.AlignmentType.Center

            ' Save the Pdf file
            pdfConv.Save(dataDir & Convert.ToString("TableInHeaderFooterSection_out_.pdf"))
            ' ExEnd:TableInHeaderFooterSection           
        End Sub
    End Class
End Namespace
