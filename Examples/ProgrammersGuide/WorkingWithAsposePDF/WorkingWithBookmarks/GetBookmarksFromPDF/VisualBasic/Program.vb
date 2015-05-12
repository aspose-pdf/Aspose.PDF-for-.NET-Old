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

Namespace GetBookmarksFromPDF
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'open document
			Dim pdfDocument As New Document(dataDir & "input.pdf")

			'loop through all the bookmarks
			For Each outlineItem As OutlineItemCollection In pdfDocument.Outlines
				Console.WriteLine(outlineItem.Title)
				Console.WriteLine(outlineItem.Italic)
				Console.WriteLine(outlineItem.Bold)
				Console.WriteLine(outlineItem.Color)
			Next outlineItem

		End Sub
	End Class
End Namespace