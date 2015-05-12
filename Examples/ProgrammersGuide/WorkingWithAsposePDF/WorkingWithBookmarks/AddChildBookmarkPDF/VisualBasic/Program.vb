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
Imports Aspose.Pdf.InteractiveFeatures

Namespace AddChildBookmarkPDF
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'open document
			Dim pdfDocument As New Document(dataDir & "input.pdf")

			'create a parent bookmark object
			Dim pdfOutline As New OutlineItemCollection(pdfDocument.Outlines)
			pdfOutline.Title = "Parent Outline"
			pdfOutline.Italic = True
			pdfOutline.Bold = True

			'set the destination page number
			pdfOutline.Destination = New GoToAction(2)

			'create a child bookmark object
			Dim pdfChildOutline As New OutlineItemCollection(pdfDocument.Outlines)
			pdfChildOutline.Title = "Child Outline"
			pdfChildOutline.Italic = True
			pdfChildOutline.Bold = True

			'set the destination page number for child outline
			pdfChildOutline.Destination = New GoToAction(1)

			'add child bookmark in parent bookmark's collection
			pdfOutline.Add(pdfChildOutline)

			'add parent bookmark in the document's outline collection.
			pdfDocument.Outlines.Add(pdfOutline)

			'save output
			pdfDocument.Save(dataDir & "output.pdf")

		End Sub
	End Class
End Namespace