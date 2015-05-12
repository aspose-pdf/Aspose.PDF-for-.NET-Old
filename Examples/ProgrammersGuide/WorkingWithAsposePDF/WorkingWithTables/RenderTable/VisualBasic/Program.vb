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
Imports Aspose.Pdf.Text

Namespace RenderTable
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' Create directory if it is not already present.
			Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
			If (Not IsExists) Then
				System.IO.Directory.CreateDirectory(dataDir)
			End If


			Dim doc As New Document()
			Dim pageInfo As PageInfo = doc.PageInfo
			Dim marginInfo As Aspose.Pdf.MarginInfo = pageInfo.Margin

			marginInfo.Left = 37
			marginInfo.Right = 37
			marginInfo.Top = 37
			marginInfo.Bottom = 37

			pageInfo.IsLandscape = True

			Dim table As New Aspose.Pdf.Table()
			table.ColumnWidths = "50 100"
			' Added page.
			Dim curPage As Page = doc.Pages.Add()
			For i As Integer = 1 To 120
				Dim row As Aspose.Pdf.Row = table.Rows.Add()
				row.FixedRowHeight = 15
				Dim cell1 As Aspose.Pdf.Cell = row.Cells.Add()
				cell1.Paragraphs.Add(New TextFragment("Content 1"))
				Dim cell2 As Aspose.Pdf.Cell = row.Cells.Add()
				cell2.Paragraphs.Add(New TextFragment("HHHHH"))
			Next i
			Dim paragraphs As Aspose.Pdf.Paragraphs = curPage.Paragraphs
			paragraphs.Add(table)
			'******************************************
			Dim table1 As New Aspose.Pdf.Table()
			table.ColumnWidths = "100 100"
			For i As Integer = 1 To 10
				Dim row As Aspose.Pdf.Row = table1.Rows.Add()
				Dim cell1 As Aspose.Pdf.Cell = row.Cells.Add()
				cell1.Paragraphs.Add(New TextFragment("LAAAAAAA"))
				Dim cell2 As Aspose.Pdf.Cell = row.Cells.Add()
				cell2.Paragraphs.Add(New TextFragment("LAAGGGGGG"))
			Next i
			table1.IsInNewPage = True
			' I want to keep table 1 to next page please...
			paragraphs.Add(table1)

			doc.Save(dataDir & "IsNewPageProperty_Test.pdf")


		End Sub
	End Class
End Namespace