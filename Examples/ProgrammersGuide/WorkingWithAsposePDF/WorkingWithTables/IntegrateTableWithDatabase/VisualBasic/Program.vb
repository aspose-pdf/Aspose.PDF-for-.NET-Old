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
Imports System.Data
Imports System

Namespace IntegrateTableWithDatabase
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

'             Create a DataTable object (Employee) and add columns to it (Employee_ID,
'  * Employee_Name, Gender).   
'  
			Dim dt As New DataTable("Employee")
			dt.Columns.Add("Employee_ID", GetType(Int32))
			dt.Columns.Add("Employee_Name", GetType(String))
			dt.Columns.Add("Gender", GetType(String))
			'Add 2 rows into the DataTable object programmatically
			Dim dr As DataRow = dt.NewRow()
			dr(0) = 1
			dr(1) = "John Smith"
			dr(2) = "Male"
			dt.Rows.Add(dr)
			dr = dt.NewRow()
			dr(0) = 2
			dr(1) = "Mary Miller"
			dr(2) = "Female"
			dt.Rows.Add(dr)
			' Create Document instance
			Dim doc As New Document()
			doc.Pages.Add()
			' Initializes a new instance of the Table
			Dim table As New Aspose.Pdf.Table()
			'Set column widths of the table
			table.ColumnWidths = "40 100 100 100"
			' Set the table border color as LightGray
			table.Border = New Aspose.Pdf.BorderInfo(Aspose.Pdf.BorderSide.All,.5f, Aspose.Pdf.Color.FromRgb(System.Drawing.Color.LightGray))
			' set the border for table cells
			table.DefaultCellBorder = New Aspose.Pdf.BorderInfo(Aspose.Pdf.BorderSide.All,.5f, Aspose.Pdf.Color.FromRgb(System.Drawing.Color.LightGray))
			table.ImportDataTable(dt, True, 0, 1, 3, 3)

			' Add table object to first page of input document
			doc.Pages(1).Paragraphs.Add(table)
			' Save updated document containing table object
			doc.Save(dataDir & "DataIntegrated.pdf")


		End Sub
	End Class
End Namespace