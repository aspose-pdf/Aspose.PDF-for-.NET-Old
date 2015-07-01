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

Namespace VisualBasic.AsposePDFFacades.Bookmarks
    Public Class DeleteABookmark
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Bookmarks()
            'open document
            Dim bookmarkEditor As New PdfBookmarkEditor()
            bookmarkEditor.BindPdf(dataDir & "DeleteABookmark.pdf")
            'delete bookmark
            bookmarkEditor.DeleteBookmarks("Page2")
            'save updated PDF file
            bookmarkEditor.Save(dataDir & "DeleteABookmark_out.pdf")


        End Sub
    End Class
End Namespace