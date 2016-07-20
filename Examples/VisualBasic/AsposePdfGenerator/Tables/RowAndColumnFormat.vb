Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Namespace AsposePdfGenerator.Tables
    Public Class RowAndColumnFormat
        Public Shared Sub Run()
            ' ExStart:RowAndColumnFormat
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfGenerator_Tables()

            ' Instantiate Pdf document object 
            Dim pdf1 As New Aspose.Pdf.Generator.Pdf()
            ' Create a section in the Pdf
            Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

            ' Create a table
            Dim tab1 As New Aspose.Pdf.Generator.Table()

            ' Add table in the paragraphs collection of the section
            sec1.Paragraphs.Add(tab1)

            ' Set the column widths of the table
            tab1.ColumnWidths = "60 100 100"

            ' Create a TextInfo instance
            Dim tinfo As New Aspose.Pdf.Generator.TextInfo()

            ' Set the font name to "Courier" for the TextInfo object
            tinfo.FontName = "Courier"

            ' Set default table border using the BorderInfo object
            tab1.DefaultCellBorder = New Aspose.Pdf.Generator.BorderInfo(CInt(Aspose.Pdf.Generator.BorderSide.All), 0.1F)

            ' Apply the text format settings in TextInfo object to table cells
            tab1.DefaultCellTextInfo = tinfo

            ' Create an array of double values
            Dim darr As Double() = New [Double]() {1.5, 3.1415926, 100000, 20, 4000, 30.4512, _
                45.67, 890, 23.45}

            ' Import the values in array to table
            tab1.ImportArray(darr, 0, 0, False)

            ' Set background color for the first row 
            Dim tinfo1 As Aspose.Pdf.Generator.TextInfo = TryCast(tinfo.Clone(), Aspose.Pdf.Generator.TextInfo)
            tinfo1.BackgroundColor = New Aspose.Pdf.Generator.Color("#0000ff")
            tab1.Rows(0).DefaultCellTextInfo = tinfo1

            ' Align text in the last column to right hand side
            Dim tinfo2 As Aspose.Pdf.Generator.TextInfo = TryCast(tinfo.Clone(), Aspose.Pdf.Generator.TextInfo)
            tinfo2.Alignment = Aspose.Pdf.Generator.AlignmentType.Right
            tab1.SetColumnTextInfo(2, tinfo2)

            ' We have to reset text format settings of the upper right cell 
            tinfo1.Alignment = Aspose.Pdf.Generator.AlignmentType.Right
            tab1.Rows(0).Cells(2).DefaultCellTextInfo = tinfo1

            ' Save the Pdf
            pdf1.Save(dataDir & Convert.ToString("RowAndColumnFormat_out_.pdf"))
            ' ExEnd:RowAndColumnFormat   

        End Sub
    End Class
End Namespace