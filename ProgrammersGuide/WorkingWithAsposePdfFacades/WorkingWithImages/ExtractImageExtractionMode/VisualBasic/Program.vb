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
Imports System.Drawing
Imports System.Drawing.Imaging

Namespace ExtractImageExtractionModeExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")
			'open input PDF
			Dim extractor As New PdfExtractor()
			extractor.BindPdf(dataDir & "input.pdf")

			'Specify Image Extraction Mode
			extractor.ExtractImageMode = ExtractImageMode.DefinedInResources

			'Extract Images based on Image Extraction Mode
			extractor.ExtractImage()

			'Get all the extracted images
			Do While extractor.HasNextImage()
				extractor.GetNextImage(dataDir & DateTime.Now.Ticks.ToString() & ".png", System.Drawing.Imaging.ImageFormat.Png)
			Loop



		End Sub
	End Class
End Namespace