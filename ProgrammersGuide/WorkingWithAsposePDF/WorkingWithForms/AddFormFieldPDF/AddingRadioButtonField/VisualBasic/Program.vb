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

Namespace AddingRadioButtonField
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' Create directory if it is not already present.
			Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
			If (Not IsExists) Then
				System.IO.Directory.CreateDirectory(dataDir)
			End If

			' instantiate Document object
			Dim pdfDocument As New Document()

			' add a page to PDF file
			pdfDocument.Pages.Add()

			' instatiate RadioButtonField object with page number as argument
			Dim radio As New RadioButtonField(pdfDocument.Pages(1))

			' add first radio button option and also specify its origin using Rectangle object
			radio.AddOption("Test", New Aspose.Pdf.Rectangle(0, 0, 20, 20))

			' add second radio button option
			radio.AddOption("Test1", New Aspose.Pdf.Rectangle(20, 20, 40, 40))

			' add radio button to form object of Document object
			pdfDocument.Form.Add(radio)

			' save the PDF file
			pdfDocument.Save(dataDir & "output.pdf")

		End Sub
	End Class
End Namespace