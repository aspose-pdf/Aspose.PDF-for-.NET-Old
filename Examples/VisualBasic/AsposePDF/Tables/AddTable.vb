Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports Aspose.Pdf
Namespace AsposePDF.Tables
    Public Class AddTable
        Public Shared Sub Run()
            ' ExStart:AddTable
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Tables()

            ' Load source PDF document
            Dim doc As New Document(dataDir & Convert.ToString("AddTable.pdf"))
            ' Initializes a new instance of the Table
            Dim table As New Table()
            ' Set the table border color as LightGray
            table.Border = New BorderInfo(BorderSide.All, 0.5F, Color.FromRgb(System.Drawing.Color.LightGray))
            ' Set the border for table cells
            table.DefaultCellBorder = New BorderInfo(BorderSide.All, 0.5F, Color.FromRgb(System.Drawing.Color.LightGray))
            ' Create a loop to add 10 rows
            For row_count As Integer = 1 To 9
                ' Add row to table
                Dim row As Row = table.Rows.Add()
                ' Add table cells
                row.Cells.Add("Column (" + row_count.ToString() + ", 1)")
                row.Cells.Add("Column (" + row_count.ToString() + ", 2)")
                row.Cells.Add("Column (" + row_count.ToString() + ", 3)")
            Next
            ' Add table object to first page of input document
            doc.Pages(1).Paragraphs.Add(table)
            dataDir = dataDir & Convert.ToString("document_with_table_out_.pdf")
            ' Save updated document containing table object
            doc.Save(dataDir)
            ' ExEnd:AddTable
            Console.WriteLine(Convert.ToString(vbLf & "Text added successfully to an existing pdf file." & vbLf & "File saved at ") & dataDir)
        End Sub
    End Class
End Namespace
