'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Pdf. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace AddListItemExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")
			'create instance of FormEditor
			Dim formEditor As New FormEditor()
			'Open Document
			formEditor.BindPdf(dataDir & "input.pdf")
			'add list field in PDF file
			formEditor.AddField(FieldType.ListBox, "listbox", 1, 300, 200, 350, 225)
			'add list items
			formEditor.AddListItem("listbox", "Item 1")
			formEditor.AddListItem("listbox", "Item 2")
			'add multiple list items once
			Dim listItems() As String = { "Item 3", "Item 4", "Item 5" }
			formEditor.AddListItem("listbox", listItems)
			'save updated file
			formEditor.Save(dataDir & "output.pdf")

		End Sub
	End Class
End Namespace