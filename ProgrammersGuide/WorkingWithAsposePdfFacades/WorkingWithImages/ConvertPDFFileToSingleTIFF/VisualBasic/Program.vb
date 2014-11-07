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

Namespace ConvertPDFFileToSingleTIFFExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")
			'create PdfConverter object
			Dim objConverter As New PdfConverter()

			'bind input pdf file
			objConverter.BindPdf(dataDir & "input.pdf")

			'initialize the converting process
			objConverter.DoConvert()

			'save pdf as tiff image
			objConverter.SaveAsTIFF(dataDir & "output.tif")

			'close the PdfConverter object
			objConverter.Close()


		End Sub
	End Class
End Namespace