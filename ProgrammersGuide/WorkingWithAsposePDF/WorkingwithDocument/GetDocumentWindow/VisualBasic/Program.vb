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
Imports System

Namespace GetDocumentWindow
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'open document
			Dim pdfDocument As New Document(dataDir & "input.pdf")

			'get different document properties
			'position of document's window - Default: false
			Console.WriteLine("CenterWindow : {0}", pdfDocument.CenterWindow)

			'predominant reading order; determins the position of page
			'when displayed side by side - Default: L2R
			Console.WriteLine("Direction : {0}", pdfDocument.Direction)

			'whether window's title bar should display document title
			'if false, title bar displays PDF file name - Default: false
			Console.WriteLine("DisplayDocTitle : {0}", pdfDocument.DisplayDocTitle)

			'whether to resize the document's window to fit the size of
			'first displayed page - Default: false
			Console.WriteLine("FitWindow : {0}", pdfDocument.FitWindow)

			'whether to hide menu bar of the viewer application - Default: false
			Console.WriteLine("HideMenuBar : {0}", pdfDocument.HideMenubar)

			'whether to hide tool bar of the viewer application - Default: false
			Console.WriteLine("HideToolBar : {0}", pdfDocument.HideToolBar)

			'whether to hide UI elements like scroll bars
			'and leaving only the page contents displayed - Default: false
			Console.WriteLine("HideWindowUI : {0}", pdfDocument.HideWindowUI)

			'document's page mode. How to display document on exiting full-screen mode.
			Console.WriteLine("NonFullScreenPageMode : {0}", pdfDocument.NonFullScreenPageMode)

			'the page layout i.e. single page, one column
			Console.WriteLine("PageLayout : {0}", pdfDocument.PageLayout)

			'how the document should display when opened
			'i.e. show thumbnails, full-screen, show attachment panel
			Console.WriteLine("pageMode : {0}", pdfDocument.PageMode)

		End Sub
	End Class
End Namespace