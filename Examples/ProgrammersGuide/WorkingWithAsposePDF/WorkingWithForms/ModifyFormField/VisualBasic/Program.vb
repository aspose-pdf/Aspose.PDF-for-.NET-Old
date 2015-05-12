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
Imports Aspose.Pdf.InteractiveFeatures.Forms
Imports Aspose.Pdf.InteractiveFeatures.Annotations

Namespace ModifyFormField
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'open document
			Dim pdfDocument As New Document(dataDir & "input.pdf")

			'get a field
			Dim textBoxField As TextBoxField = TryCast(pdfDocument.Form("textbox1"), TextBoxField)

			'modify field value
			textBoxField.Value = "New Value"
			textBoxField.ReadOnly = True

			'save updated document
			pdfDocument.Save(dataDir & "output.pdf")

		End Sub
	End Class
End Namespace