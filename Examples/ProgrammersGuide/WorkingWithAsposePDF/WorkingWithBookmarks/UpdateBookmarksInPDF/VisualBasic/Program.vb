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

Namespace UpdateBookmarksInPDF
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'open document
			Dim pdfDocument As New Document(dataDir & "input.pdf")

			'get a bookmark object
			Dim pdfOutline As OutlineItemCollection = pdfDocument.Outlines(1)
			pdfOutline.Title = "Updated Outline"
			pdfOutline.Italic = True
			pdfOutline.Bold = True

			'save output
			pdfDocument.Save(dataDir & "output.pdf")

		End Sub
	End Class
End Namespace