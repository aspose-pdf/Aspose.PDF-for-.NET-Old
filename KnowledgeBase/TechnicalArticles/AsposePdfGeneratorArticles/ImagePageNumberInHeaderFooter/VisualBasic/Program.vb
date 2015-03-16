'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Pdf. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////
Imports System.IO

Imports Aspose.Pdf

Namespace ImagePageNumberInHeaderFooter
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Instantiate a Pdf object by calling its empty constructor
			Dim pdf1 As New Aspose.Pdf.Generator.Pdf()
			'Create a section in the Pdf object
			Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

			'=====================================================//
			'	Header to show an Image
			'=====================================================//

			' Create Header Section of the document
			Dim header As New Aspose.Pdf.Generator.HeaderFooter(sec1)
			' set the Odd header for the PDF file
			sec1.OddHeader = header
			' Set the Even Header for the PDF file
			sec1.EvenHeader = header
			'Create an image object in the section
			Dim image1 As New Aspose.Pdf.Generator.Image(sec1)
			'Set the path of image file
			image1.ImageInfo.File = dataDir & "aspose.jpg"
			'Set the type of image using ImageFileType enumeration
			image1.ImageInfo.ImageFileType = Aspose.Pdf.Generator.ImageFileType.Jpeg
			'Add image to Header section of the Pdf file
			header.Paragraphs.Add(image1)

			'=====================================================//
			'	Footer to show Page Number
			'=====================================================//

			' Create a Footer Section of the document
			Dim footer As New Aspose.Pdf.Generator.HeaderFooter(sec1)
			' set the Odd footer of the PDF file
			sec1.OddFooter = footer
			' set the Even footer of the PDF file
			sec1.EvenFooter = footer
			' Create a Text object
			Dim txt As New Aspose.Pdf.Generator.Text("Page: ($p of $P ) ")
			' Add text to Header section of the Pdf file
			footer.Paragraphs.Add(txt)

			'Save the Pdf
			pdf1.Save(dataDir & "pdfWithHeaderAndPageNos.pdf")
		End Sub
	End Class
End Namespace