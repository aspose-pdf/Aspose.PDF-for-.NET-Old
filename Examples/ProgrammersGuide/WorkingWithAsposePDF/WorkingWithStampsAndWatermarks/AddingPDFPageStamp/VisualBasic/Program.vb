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

Namespace AddingPDFPageStamp
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'open document
			Dim pdfDocument As New Document(dataDir & "input.pdf")

			'create page stamp
			Dim pageStamp As New PdfPageStamp(pdfDocument.Pages(1))
			pageStamp.Background = True
			pageStamp.XIndent = 100
			pageStamp.YIndent = 100
			pageStamp.Rotate = Rotation.on180


			'add stamp to particular page
			pdfDocument.Pages(1).AddStamp(pageStamp)

			'save output document
			pdfDocument.Save(dataDir & "output.pdf")

		End Sub
	End Class
End Namespace