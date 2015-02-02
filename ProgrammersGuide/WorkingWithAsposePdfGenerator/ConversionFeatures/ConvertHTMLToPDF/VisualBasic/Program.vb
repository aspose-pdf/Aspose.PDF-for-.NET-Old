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

Namespace ConvertHTMLToPDF
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' Instantiate an object PDF class
			Dim pdf As New Aspose.Pdf.Generator.Pdf()

			' add the section to PDF document sections collection
			Dim section As Aspose.Pdf.Generator.Section = pdf.Sections.Add()

			' Read the contents of HTML file into StreamReader object
			Dim r As StreamReader = File.OpenText(dataDir & "Aspose.htm")

			'Create text paragraphs containing HTML text
			Dim text2 As New Aspose.Pdf.Generator.Text(section, r.ReadToEnd())

			' enable the property to display HTML contents within their own formatting
			text2.IsHtmlTagSupported = True

			'Add the text paragraphs containing HTML text to the section
			section.Paragraphs.Add(text2)

			' Specify the URL which serves as images database
			'pdf.HtmlInfo.ImgUrl = "D:/pdftest/MemoryStream/";

			'Save the pdf document
			pdf.Save(dataDir & "HTML2pdf.pdf")

		End Sub
	End Class
End Namespace