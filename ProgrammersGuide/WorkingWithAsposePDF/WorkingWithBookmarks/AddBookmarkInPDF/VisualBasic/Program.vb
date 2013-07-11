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

Namespace AddBookmarkInPDF
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'open document
			Dim pdfDocument As New Document(dataDir & "input.pdf")

			'create a bookmark object
			Dim pdfOutline As New OutlineItemCollection(pdfDocument.Outlines)
			pdfOutline.Title = "Test Outline"
			pdfOutline.Italic = True
			pdfOutline.Bold = True

			'set the destination page number
			pdfOutline.Action = New Aspose.Pdf.InteractiveFeatures.GoToAction(pdfDocument.Pages(1))

			'add bookmark in the document's outline collection.
			pdfDocument.Outlines.Add(pdfOutline)

			'save output
			pdfDocument.Save(dataDir & "output.pdf")
		End Sub
	End Class
End Namespace