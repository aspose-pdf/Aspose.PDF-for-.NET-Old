Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePdfGenerator.Tables
    Public Class NonEnglishText
        Public Shared Sub Run()
            ' ExStart:NonEnglishText
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Tables()

            ' Instantiate the Pdf object by calling its empty constructor
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

            ' Create the section in the Pdf object
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

            ' Instantiate a table object
            Dim tab1 As New Aspose.Pdf.Generator.Table()

            ' Add the table in paragraphs collection of the desired section
            sec1.Paragraphs.Add(tab1)

            ' Set with column widths of the table
            tab1.ColumnWidths = "110 120 50"

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
            row1.DefaultCellTextInfo.FontName = "Arial Unicode MS"
            row1.Cells.Add("Arabic Sample مَرْحَبا بكِ كُلَّ الْتَرْحيبْ")
            row1.Cells(0).DefaultCellTextInfo.IsRightToLeft = True

            ' Row1.Cells[0].DefaultCellTextInfo.FontName = "Arial Unicode MS";
            row1.Cells.Add("Persian alphabet الفبای فارسی")
            row1.Cells(1).DefaultCellTextInfo.IsRightToLeft = True

            ' Row1.Cells[1].DefaultCellTextInfo.FontName = "Arial Unicode MS";
            row1.Cells.Add("English Text")

            ' Include the subset of Font supporting Non-English text in PDF file
            pdf1.SetUnicode()

            ' Save the Pdf
            pdf1.Save(dataDir & Convert.ToString("Arabic_Farsi_Text_in_TableCell_out_.pdf"))
            ' ExEnd:NonEnglishText   

        End Sub
    End Class
End Namespace
