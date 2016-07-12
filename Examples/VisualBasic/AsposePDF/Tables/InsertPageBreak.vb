Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf

Imports Aspose.Pdf.Text
Namespace AsposePDF.Tables
    Public Class InsertPageBreak
        Public Shared Sub Run()
            ' ExStart:InsertPageBreak
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Tables()

            ' Instantiate Document instance
            Dim doc As New Document()
            ' Add page to pages collection of PDF file
            doc.Pages.Add()
            ' Create table instance
            Dim tab As New Table()
            ' Set border style for table
            tab.Border = New BorderInfo(BorderSide.All, Color.Red)
            ' Set default border style for table with border color as Red
            tab.DefaultCellBorder = New BorderInfo(BorderSide.All, Color.Red)
            ' Specify table columsn widht
            tab.ColumnWidths = "100 100"
            ' Create a loop to add 200 rows for table
            For counter As Integer = 0 To 200
                Dim row As New Row()
                tab.Rows.Add(row)
                Dim cell1 As New Cell()
                cell1.Paragraphs.Add(New TextFragment("Cell " + counter.ToString() + ", 0"))
                row.Cells.Add(cell1)
                Dim cell2 As New Cell()
                cell2.Paragraphs.Add(New TextFragment("Cell " + counter.ToString() + ", 1"))
                row.Cells.Add(cell2)
                ' When 10 rows are added, render new row in new page
                If counter Mod 10 = 0 AndAlso counter <> 0 Then
                    row.IsInNewPage = True
                End If
            Next
            ' Add table to paragraphs collection of PDF file
            doc.Pages(1).Paragraphs.Add(tab)

            dataDir = dataDir & Convert.ToString("InsertPageBreak_out_.pdf")
            ' Save the PDF document
            doc.Save(dataDir)
            ' ExEnd:InsertPageBreak
            Console.WriteLine(Convert.ToString(vbLf & "Page break inserted successfully." & vbLf & "File saved at ") & dataDir)

        End Sub
    End Class
End Namespace