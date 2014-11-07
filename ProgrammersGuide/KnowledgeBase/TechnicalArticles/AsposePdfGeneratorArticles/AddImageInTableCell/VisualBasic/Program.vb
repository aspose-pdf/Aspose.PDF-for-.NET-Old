'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Pdf. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////
Imports System.IO

Imports Aspose.Pdf

Namespace AddImageInTableCell
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Create a section in the pdf document
			Dim pdfConv As New Aspose.Pdf.Generator.Pdf()
			'Create a section in the pdf document
			Dim sec1 As Aspose.Pdf.Generator.Section = pdfConv.Sections.Add()
			'Instantiate a table object
			Dim tab1 As New Aspose.Pdf.Generator.Table()
			'Add the table in paragraphs collection of the desired section
			sec1.Paragraphs.Add(tab1)
			'Set default cell border using BorderInfo object
			tab1.DefaultCellBorder = New Aspose.Pdf.Generator.BorderInfo(CInt(Aspose.Pdf.Generator.BorderSide.All), 0.1F)
			'Set with column widths of the table
			tab1.ColumnWidths = "100 100 120"

			Dim img As New Aspose.Pdf.Generator.Image()
			img.ImageInfo.File = dataDir & "aspose.jpg"
			img.ImageInfo.ImageFileType = Aspose.Pdf.Generator.ImageFileType.Jpeg

			'Create rows in the table and then cells in the rows
			Dim row1 As Aspose.Pdf.Generator.Row = tab1.Rows.Add()
			row1.Cells.Add("Sample text in cell")

			' Add the cell which holds the image
			Dim cell2 As Aspose.Pdf.Generator.Cell = row1.Cells.Add()
			'Add the image to the table cell
			cell2.Paragraphs.Add(img)

			row1.Cells.Add("Previous cell with image")
			row1.Cells(2).VerticalAlignment = Aspose.Pdf.Generator.VerticalAlignmentType.Center

			' save the Pdf file
			pdfConv.Save(dataDir & "Image_in_Cell.pdf")
		End Sub
	End Class
End Namespace