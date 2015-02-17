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

Namespace CopyInnerFieldExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")
			'create FormEditor object
			Dim formEditor As FormEditor = New FormEditor()
			'Open Document
			formEditor.BindPdf(dataDir & "input.pdf")
			'copy a field to another page
			formEditor.CopyInnerField("textfield", "newfieldname", 0)

			'close and save the output document
			formEditor.Save(dataDir & "output.pdf")


		End Sub
	End Class
End Namespace