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
Imports Aspose.Pdf.DOM

Namespace SetDocumentWindow
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'open document
			Dim pdfDocument As New Document(dataDir & "input.pdf")

			'set different document properties
			'sepcify to position document's window - Default: false
			pdfDocument.CenterWindow = True

			'predominant reading order; determins the position of page
			'when displayed side by side - Default: L2R
			pdfDocument.Direction = Direction.R2L

			'specify whether window's title bar should display document title
			'if false, title bar displays PDF file name - Default: false
			pdfDocument.DisplayDocTitle = True

			'specify whether to resize the document's window to fit the size of
			'first displayed page - Default: false
			pdfDocument.FitWindow = True

			'specify whether to hide menu bar of the viewer application - Default: false
			pdfDocument.HideMenubar = True

			'specify whether to hide tool bar of the viewer application - Default: false
			pdfDocument.HideToolBar = True

			'specify whether to hide UI elements like scroll bars
			'and leaving only the page contents displayed - Default: false
			pdfDocument.HideWindowUI = True

			'document's page mode. specify how to display document on exiting full-screen mode.
			pdfDocument.NonFullScreenPageMode = PageMode.UseOC

			'specify the page layout i.e. single page, one column
			pdfDocument.PageLayout = PageLayout.TwoColumnLeft

			'specify how the document should display when opened
			'i.e. show thumbnails, full-screen, show attachment panel
			pdfDocument.PageMode = PageMode.UseThumbs

			'save updated PDF file
			pdfDocument.Save(dataDir & "output.pdf")

		End Sub
	End Class
End Namespace