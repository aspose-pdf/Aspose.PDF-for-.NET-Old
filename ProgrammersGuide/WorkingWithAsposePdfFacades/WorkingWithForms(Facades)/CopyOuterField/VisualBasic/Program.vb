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

Namespace CopyOuterFieldExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")
			'open the document and create a FormEditor object
			Dim formEditor As New FormEditor(dataDir & "input_form.pdf", dataDir & "output.pdf")
			'copy a text field from one document to another one
			formEditor.CopyOuterField("textfieldform.pdf", "textfield", 1)
			'close and save the output document
			formEditor.Save()


		End Sub
	End Class
End Namespace