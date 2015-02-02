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

Namespace AddChildBookmarkExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")
			'create bookmarks
			Dim bookmarks As New Bookmarks()
			Dim childBookmark1 As New Bookmark()
			childBookmark1.PageNumber = 1
			childBookmark1.Title = "First Child"
			Dim childBookmark2 As New Bookmark()
			childBookmark2.PageNumber = 2
			childBookmark2.Title = "Second Child"

			bookmarks.Add(childBookmark1)
			bookmarks.Add(childBookmark2)

			Dim bookmark As New Bookmark()
			bookmark.Action = "GoTo"
			bookmark.PageNumber = 1
			bookmark.Title = "Parent"

			bookmark.ChildItems = bookmarks

			'create PdfBookmarkEditor class
			Dim bookmarkEditor As New PdfBookmarkEditor()
			'bind PDF document
			bookmarkEditor.BindPdf(dataDir & "input.pdf")
			'create bookmarks
			bookmarkEditor.CreateBookmarks(bookmark)
			'save updated document
			bookmarkEditor.Save(dataDir & "output.pdf")

		End Sub
	End Class
End Namespace