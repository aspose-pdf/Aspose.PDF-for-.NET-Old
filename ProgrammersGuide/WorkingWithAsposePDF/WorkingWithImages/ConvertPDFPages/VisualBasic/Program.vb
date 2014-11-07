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
Imports Aspose.Pdf.Devices

Namespace ConvertPDFPages
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'open document
			Dim pdfDocument As New Document(dataDir & "input.pdf")

			For pageCount As Integer = 1 To pdfDocument.Pages.Count
				Using imageStream As New FileStream(dataDir & "image" & pageCount & ".jpg", FileMode.Create)
					'create Resolution object
					Dim resolution As New Resolution(300)
					'create JPEG device with specified attributes (Width, Height, Resolution, Quality)
					' where Quality [0-100], 100 is Maximum
					Dim jpegDevice As New JpegDevice(resolution, 100)

					'convert a particular page and save the image to stream
					jpegDevice.Process(pdfDocument.Pages(pageCount), imageStream)
					'close stream
					imageStream.Close()
				End Using
			Next pageCount




		End Sub
	End Class
End Namespace