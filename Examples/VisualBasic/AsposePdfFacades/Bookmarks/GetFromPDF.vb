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
Imports System

Namespace VisualBasic.AsposePDFFacades.Bookmarks
    Public Class GetFromPDF
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Bookmarks()
            'create PdfBookmarkEditor
            Dim bookmarkEditor As New PdfBookmarkEditor()
            'open PDF file
            bookmarkEditor.BindPdf(dataDir & "input.PDF")
            'extract bookmarks
            Dim bookmarks As Aspose.Pdf.Facades.Bookmarks = bookmarkEditor.ExtractBookmarks()
            For Each bookmark As Aspose.Pdf.Facades.Bookmark In bookmarks
                ' get the title information of bookmark item
                Console.WriteLine("Title: {0}", bookmark.Title)
                ' get the destination page for bookmark
                Console.WriteLine("Page Number: {0}", bookmark.PageNumber)
                ' get the information related to associated action with bookmark
                Console.WriteLine("Bookmark Action: " & bookmark.Action)
            Next bookmark



        End Sub
    End Class
End Namespace