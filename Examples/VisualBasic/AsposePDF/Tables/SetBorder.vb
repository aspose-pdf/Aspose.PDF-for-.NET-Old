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
    Public Class SetBorder
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Tables()
            ' Create directory if it is not already present.
            Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
            If (Not IsExists) Then
                System.IO.Directory.CreateDirectory(dataDir)
            End If


            ' instantiate Document object
            Dim doc As New Document()
            ' add page to PDF document
            Dim page As Page = doc.Pages.Add()
            ' create BorderInfo object
            Dim border As New Aspose.Pdf.BorderInfo(Aspose.Pdf.BorderSide.All)
            ' specify that Top border will be double
            border.Top.IsDoubled = True
            ' specify that bottom border will be double
            border.Bottom.IsDoubled = True
            ' instantiate Table object
            Dim table As New Aspose.Pdf.Table()
            ' specify Columns width information
            table.ColumnWidths = "100"
            ' create Row object
            Dim row As Aspose.Pdf.Row = table.Rows.Add()
            ' add a Table cell to cells collection of row
            Dim cell As Aspose.Pdf.Cell = row.Cells.Add("some text")
            ' set the border for cell object (double border)
            cell.Border = border
            ' add table to paragraphs collection of Page
            page.Paragraphs.Add(table)
            ' save the PDF document
            doc.Save(dataDir & "TableBorderTest.pdf")


        End Sub
    End Class
End Namespace