Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Imports Aspose.Pdf.Text

Namespace AsposePDF.Tables
    Public Class RenderTable
        Public Shared Sub Run()
            ' ExStart:RenderTable
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Tables()

            Dim doc As New Document()
            Dim pageInfo As PageInfo = doc.PageInfo
            Dim marginInfo As MarginInfo = pageInfo.Margin

            marginInfo.Left = 37
            marginInfo.Right = 37
            marginInfo.Top = 37
            marginInfo.Bottom = 37

            pageInfo.IsLandscape = True

            Dim table As New Table()
            table.ColumnWidths = "50 100"
            ' Added page.
            Dim curPage As Page = doc.Pages.Add()
            For i As Integer = 1 To 120
                Dim row As Row = table.Rows.Add()
                row.FixedRowHeight = 15
                Dim cell1 As Cell = row.Cells.Add()
                cell1.Paragraphs.Add(New TextFragment("Content 1"))
                Dim cell2 As Cell = row.Cells.Add()
                cell2.Paragraphs.Add(New TextFragment("HHHHH"))
            Next
            Dim paragraphs As Paragraphs = curPage.Paragraphs
            paragraphs.Add(table)
            '******************************************

            Dim table1 As New Table()
            table.ColumnWidths = "100 100"
            For i As Integer = 1 To 10
                Dim row As Row = table1.Rows.Add()
                Dim cell1 As Cell = row.Cells.Add()
                cell1.Paragraphs.Add(New TextFragment("LAAAAAAA"))
                Dim cell2 As Cell = row.Cells.Add()
                cell2.Paragraphs.Add(New TextFragment("LAAGGGGGG"))
            Next
            table1.IsInNewPage = True
            ' I want to keep table 1 to next page please...
            paragraphs.Add(table1)
            dataDir = dataDir & Convert.ToString("IsNewPageProperty_Test_out_.pdf")
            doc.Save(dataDir)
            ' ExEnd:RenderTable
            Console.WriteLine(Convert.ToString(vbLf & "Table render successfully on a page." & vbLf & "File saved at ") & dataDir)


        End Sub
    End Class
End Namespace