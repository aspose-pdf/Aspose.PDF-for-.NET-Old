Imports System.IO
Imports System
Imports Aspose.Pdf

Namespace AsposePdfGenerator.TechnicalArticles
    Public Class PlacingTextAroundImage
        Public Shared Sub Run()
            ' ExStart:PlacingTextAroundImage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_TechnicalArticles()

            ' Instantiate Pdf document object 
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()
            ' Create a section in the Pdf 
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

            ' Instantiate a table object 
            Dim table1 As New Aspose.Pdf.Generator.Table()
            ' Add the table in paragraphs collection of the desired section 
            sec1.Paragraphs.Add(table1)
            ' Set with column widths of the table 
            table1.ColumnWidths = "120 270"

            ' Create MarginInfo object and set its left, bottom, right and top margins 
            Dim margin As New Aspose.Pdf.Generator.MarginInfo()
            margin.Top = 5.0F
            margin.Left = 5.0F
            margin.Right = 5.0F
            margin.Bottom = 5.0F
            ' Set the default cell padding to the MarginInfo object 
            table1.DefaultCellPadding = margin

            ' Create rows in the table and then cells in the rows 
            Dim row1 As Aspose.Pdf.Generator.Row = table1.Rows.Add()

            ' Create an image object
            Dim logo As New Aspose.Pdf.Generator.Image()
            ' Specify the image file path
            logo.ImageInfo.File = dataDir & Convert.ToString("aspose-logo.jpg")
            ' Specify the image Fixed Height
            logo.ImageInfo.FixHeight = 120
            ' Specify the image Fixed Width
            logo.ImageInfo.FixWidth = 110
            row1.Cells.Add()
            ' Add the image to paragraphs collection of the table cell
            row1.Cells(0).Paragraphs.Add(logo)

            ' Create string variables with text containing html tags 
            Dim TitleString As String = "<font face=""Arial"" size=6 color=""#101090""><b> Aspose.Pdf for .NET</b></font>"
            ' Create a text object to be added to the right of image
            Dim TitleText As New Aspose.Pdf.Generator.Text(TitleString)
            TitleText.IsHtmlTagSupported = True
            row1.Cells.Add()
            ' Add the text paragraphs containing HTML text to the table cell
            row1.Cells(1).Paragraphs.Add(TitleText)
            ' Set the vertical alignment of the row contents as Top
            row1.VerticalAlignment = Aspose.Pdf.Generator.VerticalAlignmentType.Top

            Dim BodyString1 As String = "<font face=""Arial"" size=2><br/>Aspose.Pdf for .NET is a non-graphical PDF® document reporting component that enables .NET applications to <b> create PDF documents from scratch </b> without utilizing Adobe Acrobat®. Aspose.Pdf for .NET is very affordably priced and offers a wealth of strong features including: compression, tables, graphs, images, hyperlinks, security and custom fonts. </font>"

            ' Add a text segment to segments collection of the text object
            TitleText.Segments.Add(BodyString1)

            ' Create rows in the table and then cells in the rows
            Dim SecondRow As Aspose.Pdf.Generator.Row = table1.Rows.Add()
            SecondRow.Cells.Add()
            ' Set the row span value for Second row as 2
            SecondRow.Cells(0).ColumnsSpan = 2
            ' Set the vertical alignment of the second row as Top
            SecondRow.VerticalAlignment = Aspose.Pdf.Generator.VerticalAlignmentType.Top

            Dim SecondRowString As String = "<font face=""Arial"" size=2>Aspose.Pdf for .NET supports the creation of PDF files through API and XML or XSL-FO templates. Aspose.Pdf for .NET is very easy to use and is provided with 14 fully featured demos written in both C# and Visual Basic.</font>"
            Dim SecondRowText As New Aspose.Pdf.Generator.Text(SecondRowString)
            SecondRowText.IsHtmlTagSupported = True
            ' Add the text paragraphs containing HTML text to the table cell
            SecondRow.Cells(0).Paragraphs.Add(SecondRowText)
            ' Save the Pdf file
            pdf1.Save(dataDir & Convert.ToString("PlacingTextAroundImage_out_.pdf"))
            ' ExEnd:PlacingTextAroundImage           
        End Sub
    End Class
End Namespace
