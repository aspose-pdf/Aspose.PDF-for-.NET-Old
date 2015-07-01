'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Pdf. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Pdf

Namespace VisualBasic.AsposePdf.Tables
    Public Class AddTable
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Tables()

            ' Load source PDF document
            Dim doc As New Aspose.Pdf.Document(dataDir & "AddTable.pdf")
            ' Initializes a new instance of the Table
            Dim table As New Aspose.Pdf.Table()
            ' Set the table border color as LightGray
            table.Border = New Aspose.Pdf.BorderInfo(Aspose.Pdf.BorderSide.All, 0.5F, Aspose.Pdf.Color.FromRgb(System.Drawing.Color.LightGray))
            ' set the border for table cells
            table.DefaultCellBorder = New Aspose.Pdf.BorderInfo(Aspose.Pdf.BorderSide.All, 0.5F, Aspose.Pdf.Color.FromRgb(System.Drawing.Color.LightGray))
            ' create a loop to add 10 rows
            For row_count As Integer = 1 To 9
                ' add row to table
                Dim row As Aspose.Pdf.Row = table.Rows.Add()
                ' add table cells
                row.Cells.Add("Column (" & row_count & ", 1)")
                row.Cells.Add("Column (" & row_count & ", 2)")
                row.Cells.Add("Column (" & row_count & ", 3)")
            Next row_count
            ' Add table object to first page of input document
            doc.Pages(1).Paragraphs.Add(table)
            ' Save updated document containing table object
            doc.Save(dataDir & "document_with_table.pdf")

        End Sub
    End Class
End Namespace