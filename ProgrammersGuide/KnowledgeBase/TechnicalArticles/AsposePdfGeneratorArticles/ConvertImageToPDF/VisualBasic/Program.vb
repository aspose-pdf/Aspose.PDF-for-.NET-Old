'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Pdf. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////
Imports System.IO

Imports Aspose.Pdf

Namespace ConvertImageToPDF
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' 1.
			'Instantiate a Pdf object by calling its empty constructor
			Dim pdf1 As New Aspose.Pdf.Generator.Pdf()

			'Create a section in the Pdf object
			Dim sec1 As Aspose.Pdf.Generator.Section = pdf1.Sections.Add()

			'Create an image object in the section
			Dim image1 As New Aspose.Pdf.Generator.Image(sec1)

			'Add image object into the Paragraphs collection of the section
			sec1.Paragraphs.Add(image1)

			'Set the path of image file
			image1.ImageInfo.File = dataDir & "aspose.jpg"

			'Set the type of image using ImageFileType enumeration
			image1.ImageInfo.ImageFileType = Aspose.Pdf.Generator.ImageFileType.Jpeg

			'Set image title
			image1.ImageInfo.Title = "JPEG image"

			'Save the Pdf
			pdf1.Save(dataDir & "jpegOutput.pdf")


			' 2.
			' create a PDF object
			Dim pdf As New Aspose.Pdf.Generator.Pdf()

			' create a section and add it to pdf document
			Dim MainSection As Aspose.Pdf.Generator.Section = pdf.Sections.Add()

			'Add the radio form field to the paragraphs collection of the section
			' create an image object
			Dim sample_image As New Aspose.Pdf.Generator.Image()

			' specify the image file path information
			sample_image.ImageInfo.File = dataDir & "aspose.bmp"

			' specify the image file type
			sample_image.ImageInfo.ImageFileType = Aspose.Pdf.Generator.ImageFileType.Bmp

			' specify the image width information equal to page width 
			sample_image.ImageInfo.FixWidth = MainSection.PageInfo.PageWidth - MainSection.PageInfo.Margin.Left - MainSection.PageInfo.Margin.Right

			' specify the image Height information equal to page Height
			sample_image.ImageInfo.FixWidth = MainSection.PageInfo.PageHeight - MainSection.PageInfo.Margin.Top - MainSection.PageInfo.Margin.Bottom

			' create bitmap image object to load image information
			Dim myimage As New Bitmap(dataDir & "aspose.bmp")

			' check if the width of the image file is greater than Page width or not
			If myimage.Width > MainSection.PageInfo.PageWidth Then
				' if the Image width is greater than page width, then set the page orientation to Landscape
				MainSection.IsLandscape = True
			Else
				' if the Image width is less than page width, then set the page orientation to Portrait
				MainSection.IsLandscape = False
			End If

			' add image to paragraphs collection of section
			MainSection.Paragraphs.Add(sample_image)

			' save the resultant PDF
			pdf.Save(dataDir & "resizedBmpOutput.pdf")
		End Sub
	End Class
End Namespace