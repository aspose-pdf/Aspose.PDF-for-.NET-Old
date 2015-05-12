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

Namespace AddBookmarkInExistingPDFExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")
			'create bookmark
			Dim boomark As New Bookmark()
			boomark.PageNumber = 1
			boomark.Title = "New Bookmark"
			'create PdfBookmarkEditor class
			Dim bookmarkEditor As New PdfBookmarkEditor()
			'bind PDF document
			bookmarkEditor.BindPdf(dataDir & "input.pdf")
			'create bookmarks
			bookmarkEditor.CreateBookmarks(boomark)
			'save updated document
			bookmarkEditor.Save(dataDir & "output.pdf")



		End Sub
	End Class
End Namespace