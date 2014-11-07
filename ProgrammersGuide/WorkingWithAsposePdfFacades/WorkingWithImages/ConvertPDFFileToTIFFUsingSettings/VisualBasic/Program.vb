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
Imports Aspose.Pdf.Devices

Namespace ConvertPDFFileToTIFFUsingSettingsExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")
			'create PdfConverter object and bind input PDF file
			Dim pdfConverter As New PdfConverter()
			' create Resolution object with 300 as an argument
			Dim resolution As New Aspose.Pdf.Devices.Resolution(300)
			' specify the resolution value for PdfConverter object
			pdfConverter.Resolution = resolution
			' bind the source PDF file
			pdfConverter.BindPdf(dataDir & "input.pdf")
			' start the conversion process
			pdfConverter.DoConvert()
			'create TiffSettings object and set ColorDepth
			Dim tiffSettings As New TiffSettings()
			tiffSettings.Depth = Aspose.Pdf.Devices.ColorDepth.Format1bpp
			'convert to TIFF image
			pdfConverter.SaveAsTIFF(dataDir & "output.tif", 300, 300, tiffSettings)
			' close Converter object
			pdfConverter.Close()

		End Sub
	End Class
End Namespace