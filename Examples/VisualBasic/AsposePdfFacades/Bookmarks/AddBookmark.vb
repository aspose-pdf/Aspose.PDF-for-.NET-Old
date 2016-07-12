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

Namespace AsposePDFFacades.Bookmarks
    Public Class AddBookmark
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Bookmarks()
            'create bookmark
            Dim boomark As New Bookmark()
            boomark.PageNumber = 1
            boomark.Title = "New Bookmark"
            'create PdfBookmarkEditor class
            Dim bookmarkEditor As New PdfBookmarkEditor()
            'bind PDF document
            bookmarkEditor.BindPdf(dataDir & "AddBookmark.pdf")
            'create bookmarks
            bookmarkEditor.CreateBookmarks(boomark)
            'save updated document
            bookmarkEditor.Save(dataDir & "AddBookmark_out.pdf")



        End Sub
    End Class
End Namespace