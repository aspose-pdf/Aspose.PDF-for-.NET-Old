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

Namespace ExtractImagesFromRangeOfPagesExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'open input PDF
			Dim pdfExtractor As New PdfExtractor()
			pdfExtractor.BindPdf(dataDir & "Input_new.pdf")

			'set StartPage and EndPage properties to specify range
			pdfExtractor.StartPage = 10
			pdfExtractor.EndPage = 20

			'extract images
			pdfExtractor.ExtractImage()
			'get all the extracted images
			Do While pdfExtractor.HasNextImage()
				'read image into memory stream
				Dim memoryStream As New MemoryStream()
				pdfExtractor.GetNextImage(memoryStream)

				'write to disk, if you like, or use it otherwise.
				Dim fileStream As New FileStream(dataDir & DateTime.Now.Ticks.ToString() & ".jpg", FileMode.Create)
				memoryStream.WriteTo(fileStream)
				fileStream.Close()
			Loop

		End Sub
	End Class
End Namespace