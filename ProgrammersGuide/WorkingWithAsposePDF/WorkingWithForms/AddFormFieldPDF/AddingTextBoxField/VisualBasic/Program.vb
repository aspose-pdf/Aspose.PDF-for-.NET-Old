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

Namespace AddingTextBoxField
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Open document
			Dim pdfDocument As New Document(dataDir & "input.pdf")

			'Create a field
			Dim textBoxField As New TextBoxField(pdfDocument.Pages(1), New Aspose.Pdf.Rectangle(100, 200, 300, 300))
			textBoxField.PartialName = "textbox1"
			textBoxField.Value = "Text Box"

			'textBoxField.Border = new Border(
			Dim border As New Border(textBoxField)
			border.Width = 5
			border.Dash = New Dash(1, 1)
			textBoxField.Border = border

			textBoxField.Color = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Green)

			'Add field to the document
			pdfDocument.Form.Add(textBoxField, 1)

			'Save modified PDF
			pdfDocument.Save(dataDir & "output.pdf")

		End Sub
	End Class
End Namespace