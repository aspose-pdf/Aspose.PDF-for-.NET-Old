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
Imports System.Drawing.Imaging

Namespace ExtractImages
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'open document
			Dim pdfDocument As New Document(dataDir & "input.pdf")

			'extract a particular image
			Dim xImage As XImage = pdfDocument.Pages(1).Resources.Images(1)

			Dim outputImage As New FileStream(dataDir & "output.jpg", FileMode.Create)

			'save output image
			xImage.Save(outputImage, ImageFormat.Jpeg)
			outputImage.Close()

			'save updated PDF file
			pdfDocument.Save(dataDir & "output.pdf")

		End Sub
	End Class
End Namespace