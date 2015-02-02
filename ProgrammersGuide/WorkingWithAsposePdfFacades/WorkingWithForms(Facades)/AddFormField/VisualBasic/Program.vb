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

Namespace AddFormFieldExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'open document
			Dim formEditor As New FormEditor()
			'Open Document
			formEditor.BindPdf(dataDir & "input.pdf")

			'add field
			formEditor.AddField(FieldType.Text, "textfield", 1, 100, 100, 200, 150)
			formEditor.AddField(FieldType.CheckBox, "checkboxfield", 1, 100, 200, 200, 250)
			formEditor.AddField(FieldType.ComboBox, "comboboxfield", 1, 100, 300, 200, 350)
			formEditor.AddField(FieldType.ListBox, "listboxfield", 1, 100, 400, 200, 450)
			formEditor.AddField(FieldType.MultiLineText, "multilinetextfield", 1, 100, 500, 200, 550)



			'save updated file
			formEditor.Save(dataDir & "output.pdf")
		End Sub
	End Class
End Namespace