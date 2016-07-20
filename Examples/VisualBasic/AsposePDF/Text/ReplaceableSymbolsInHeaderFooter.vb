Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Text

Namespace AsposePDF.Text
    Public Class ReplaceableSymbolsInHeaderFooter
        Public Shared Sub Run()
            ' ExStart:ReplaceableSymbolsInHeaderFooter
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Text()

            Dim doc As New Document()
            Dim page As Page = doc.Pages.Add()

            Dim marginInfo As New MarginInfo()
            marginInfo.Top = 90
            marginInfo.Bottom = 50
            marginInfo.Left = 50
            marginInfo.Right = 50
            ' Assign the marginInfo instance to Margin property of sec1.PageInfo
            page.PageInfo.Margin = marginInfo

            Dim hfFirst As New HeaderFooter()
            page.Header = hfFirst
            hfFirst.Margin.Left = 50
            hfFirst.Margin.Right = 50

            ' Instantiate a Text paragraph that will store the content to show as header
            Dim t1 As New TextFragment("report title")
            t1.TextState.Font = FontRepository.FindFont("Arial")
            t1.TextState.FontSize = 16
            t1.TextState.ForegroundColor = Color.Black
            t1.TextState.FontStyle = FontStyles.Bold
            t1.TextState.HorizontalAlignment = HorizontalAlignment.Center
            t1.TextState.LineSpacing = 5.0F
            hfFirst.Paragraphs.Add(t1)

            Dim t2 As New TextFragment("Report_Name")
            t2.TextState.Font = FontRepository.FindFont("Arial")
            t2.TextState.ForegroundColor = Color.Black
            t2.TextState.HorizontalAlignment = HorizontalAlignment.Center
            t2.TextState.LineSpacing = 5.0F
            t2.TextState.FontSize = 12
            hfFirst.Paragraphs.Add(t2)

            ' Create a HeaderFooter object for the section
            Dim hfFoot As New HeaderFooter()
            ' Set the HeaderFooter object to odd & even footer
            page.Footer = hfFoot
            hfFoot.Margin.Left = 50
            hfFoot.Margin.Right = 50

            ' Add a text paragraph containing current page number of total number of pages
            Dim t3 As New TextFragment("Generated on test date")
            Dim t4 As New TextFragment("report name ")
            Dim t5 As New TextFragment("Page $p of $P")

            ' Instantiate a table object
            Dim tab2 As New Table()

            ' Add the table in paragraphs collection of the desired section
            hfFoot.Paragraphs.Add(tab2)

            ' Set with column widths of the table
            tab2.ColumnWidths = "165 172 165"

            ' Create rows in the table and then cells in the rows
            Dim row3 As Row = tab2.Rows.Add()

            row3.Cells.Add()
            row3.Cells.Add()
            row3.Cells.Add()

            ' Set the vertical allignment of the text as center alligned
            row3.Cells(0).Alignment = HorizontalAlignment.Left
            row3.Cells(1).Alignment = HorizontalAlignment.Center
            row3.Cells(2).Alignment = HorizontalAlignment.Right

            row3.Cells(0).Paragraphs.Add(t3)
            row3.Cells(1).Paragraphs.Add(t4)
            row3.Cells(2).Paragraphs.Add(t5)

            ' Sec1.Paragraphs.Add(New Text("Aspose.Total for Java is a compilation of every Java component offered by Aspose. It is compiled on a#$NL" + "daily basis to ensure it contains the most up to date versions of each of our Java components. #$NL " + "Using Aspose.Total for Java developers can create a wide range of applications. #$NL #$NL #$NP" + "Aspose.Total for Java is a compilation of every Java component offered by Aspose. It is compiled on a#$NL" + "daily basis to ensure it contains the most up to date versions of each of our Java components. #$NL " + "Using Aspose.Total for Java developers can create a wide range of applications. #$NL #$NL #$NP" + "Aspose.Total for Java is a compilation of every Java component offered by Aspose. It is compiled on a#$NL" + "daily basis to ensure it contains the most up to date versions of each of our Java components. #$NL " + "Using Aspose.Total for Java developers can create a wide range of applications. #$NL #$NL"))
            Dim table As New Table()

            table.ColumnWidths = "33% 33% 34%"
            table.DefaultCellPadding = New MarginInfo()
            table.DefaultCellPadding.Top = 10
            table.DefaultCellPadding.Bottom = 10

            ' Add the table in paragraphs collection of the desired section
            page.Paragraphs.Add(table)

            ' Set default cell border using BorderInfo object
            table.DefaultCellBorder = New BorderInfo(BorderSide.All, 0.1F)

            ' Set table border using another customized BorderInfo object
            table.Border = New BorderInfo(BorderSide.All, 1.0F)

            table.RepeatingRowsCount = 1

            ' Create rows in the table and then cells in the rows
            Dim row1 As Row = table.Rows.Add()

            row1.Cells.Add("col1")
            row1.Cells.Add("col2")
            row1.Cells.Add("col3")
            Const CRLF As String = vbCr & vbLf
            For i As Integer = 0 To 10
                Dim row As Row = table.Rows.Add()
                row.IsRowBroken = True
                For c As Integer = 0 To 2
                    Dim c1 As Cell
                    If c = 2 Then
                        c1 = row.Cells.Add((Convert.ToString((Convert.ToString((Convert.ToString("Aspose.Total for Java is a compilation of every Java component offered by Aspose. It is compiled on a") & CRLF) + "daily basis to ensure it contains the most up to date versions of each of our Java components. ") & CRLF) + "daily basis to ensure it contains the most up to date versions of each of our Java components. ") & CRLF) + "Using Aspose.Total for Java developers can create a wide range of applications.")
                    Else
                        c1 = row.Cells.Add("item1" + c.ToString())
                    End If
                    c1.Margin = New MarginInfo()
                    c1.Margin.Left = 30
                    c1.Margin.Top = 10
                    c1.Margin.Bottom = 10
                Next
            Next

            dataDir = dataDir & Convert.ToString("ReplaceableSymbolsInHeaderFooter_out_.pdf")
            doc.Save(dataDir)
            ' ExEnd:ReplaceableSymbolsInHeaderFooter            
            Console.WriteLine(Convert.ToString(vbLf & "Symbols replaced successfully in header and footer." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
