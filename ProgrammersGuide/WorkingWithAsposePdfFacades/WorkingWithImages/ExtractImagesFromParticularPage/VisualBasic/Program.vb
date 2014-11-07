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
Imports System

Namespace ExtractImagesFromParticularPageExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'open input PDF
			Dim pdfExtractor As New PdfExtractor()
			pdfExtractor.BindPdf(dataDir & "input.pdf")

			'set StartPage and EndPage properties to the page number to
			'you want to extract images from
			pdfExtractor.StartPage = 2
			pdfExtractor.EndPage = 2

			'extract images
			pdfExtractor.ExtractImage()
			'get extracted images
			Do While pdfExtractor.HasNextImage()
				'read image into memory stream
				Dim memoryStream As New MemoryStream()
				pdfExtractor.GetNextImage(memoryStream)

				'write to disk, if you like, or use it otherwise.
				Dim fileStream As New FileStream(DateTime.Now.Ticks.ToString() & ".jpg", FileMode.Create)
				memoryStream.WriteTo(fileStream)
				fileStream.Close()
			Loop


		End Sub
	End Class
End Namespace