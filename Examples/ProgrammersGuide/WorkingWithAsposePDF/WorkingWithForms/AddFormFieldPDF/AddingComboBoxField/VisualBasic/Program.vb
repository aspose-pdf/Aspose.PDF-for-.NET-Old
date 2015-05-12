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

Namespace AddingComboBoxField
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' create Document object
			Dim doc As New Document()

			' add page to document object
			doc.Pages.Add()

			' instantiate ComboBox Field object
			Dim combo As New ComboBoxField(doc.Pages(1), New Aspose.Pdf.Rectangle(100, 600, 150, 616))

			' add option to ComboBox
			combo.AddOption("Red")
			combo.AddOption("Yellow")
			combo.AddOption("Green")
			combo.AddOption("Blue")

			' add combo box object to form fields collection of document object
			doc.Form.Add(combo)

			' save the PDF document
			doc.Save(dataDir & "output.pdf")

		End Sub
	End Class
End Namespace